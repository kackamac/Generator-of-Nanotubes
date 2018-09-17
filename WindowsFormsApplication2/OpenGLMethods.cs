using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenGL;
using System.Globalization;

using OpenTK.Graphics.OpenGL;

namespace WindowsFormsApplication2
{
    public partial class CreatorWindow : Form
    {
        //list for transformed points to be drawn
        private List<CartesianCoordinates> listOfPointsOfStructure = new List<CartesianCoordinates>();
        

        //elements and colors
        private Dictionary<string, Color> elementColors = new Dictionary<string, Color>();
        
        //Id of vertex and index in buffers
        private uint[] bufferId = new uint[1];

        //values of diffuse and spectacular (20%)
        //default values of diffuse and specular are 1/1/1
        private readonly float[] lightColor = { 0.2f, 0.2f, 0.2f };
        //in the future I will need to set ligth position
        //private readonly Vector4 lightPosition = new Vector4(1.5f, 2.0f, 1.5f, 1.0f);

        //whether draw axes or not
        private bool drawAxes = false;
        private double reductionCoefficient = 1;

        //angles of rotation of camera (in rad)
        private const float cameraVerticalViewAngle = 1.0f;
        private const float cameraNearestViewPoint = 0.1f;
        private const float cameraFarthestViewPoint = 100.0f;

        private readonly Vector3 pointOfView = new Vector3(0.0f, 0.0f, 0.0f);
        private const float minZoom = 0.1f;
        private const float maxZoom = 2.0f;

        private const float originalZoom = 2.0f;
        private const float originalAngleX = 0.0f;
        private const float originalAngleY = 0.0f;
        private float xAngle = 0.0f;
        private float yAngle = 0.0f;
        private float actualZoom = originalZoom;

        //whether is GLControl ready
        private bool isGlControlLoaded = false;

        //position of dragging
        private bool dragging = false;
        private int draggingFromX;
        private int draggingFromY;

        //position of moving
        private static Vector2 originalVector = Vector2.Zero;
        private Vector2 cameraShift = originalVector;
        private float speedCam = 0.01f;


        private bool origin = true;

        //size of points
        private int pointSize = 1;


        //points to count distance between
        CartesianCoordinates atom1;
        CartesianCoordinates atom2;
        //if we are choosing first or second point
        bool wasSetFirstPoint;
        //to draw a line on the place where was clicked and count nearest point
        Vector3 fromPoint;
        Vector3 toPoint;

        //consts for sending points to buffer and draw from it
        private const int floatsPerVertex = 6;
        private const int arrayBufferPointSize = floatsPerVertex * sizeof(float);
        private const int bufferVertexOffset = 0;
        private const int bufferColorOffset = 3 * sizeof(float);

        /// <summary>
        /// Initializes basic OpenGL properties 
        /// </summary>
        private void OpenGLInit()
        {
            GL.ClearColor(Color.Black);   
            GL.Enable(EnableCap.DepthTest); //Discard non visible fragments
            GL.GenBuffers(1, bufferId); //Generate buffers
            
            //just some check according to documentation 
            if (GL.GetError() != ErrorCode.NoError) throw new Exception("Creation of VBO failed");

            //ligth position
            GL.Light(LightName.Light0, LightParameter.Ambient, lightColor);
        }

        /// <summary>
        /// Set view and matrix projection of OpenGL
        /// </summary>
        private void setViewAndProjectionMatrix()
        {
            GL.Viewport(0, 0, glControlPlot.Width, glControlPlot.Height); //set view
            
            //Set new projection matrix (based on new size of window)
            Matrix4 projectionMatrix = Matrix4.CreatePerspectiveFieldOfView(cameraVerticalViewAngle, glControlPlot.AspectRatio, cameraNearestViewPoint, cameraFarthestViewPoint);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref projectionMatrix);
        }

        /// <summary>
        /// Sets position of the camera
        /// </summary>
        private void SetCameraPosition()
        {
            Vector3 cameraPosition = new Vector3(0.0f, 0.0f, actualZoom);

            Matrix4 rotationX = Matrix4.CreateRotationX(-yAngle);
            Matrix4 rotationY = Matrix4.CreateRotationY(xAngle);

            cameraPosition = Vector3.TransformPosition(cameraPosition, rotationX);
            cameraPosition = Vector3.TransformPosition(cameraPosition, rotationY);

            GL.MatrixMode(MatrixMode.Modelview);

            Matrix4 lookAt = Matrix4.LookAt(cameraPosition, Vector3.Zero, Vector3.UnitY);
            lookAt *= Matrix4.CreateTranslation(new Vector3(-cameraShift.X, -cameraShift.Y,0));
            GL.LoadMatrix(ref lookAt);
        }

        /// <summary>
        /// Move camera position
        /// </summary>
        /// <param name="direction">direction of move</param>
        private void MoveCamera(Vector2 direction)
        {
            cameraShift += direction * speedCam;
        }

        /// <summary>
        /// give all atom coordinates and their color into buffer 
        /// </summary>
        /// <returns>float[] of vertices and colors</returns>
        private float[] getVertexBufferFromList()
        {
            //Get vertex buffer
            float[] vertexBuffer = new float[floatsPerVertex * listOfPointsOfStructure.Count];

            //Load vertex buffer
            for (int i = 0; i < listOfPointsOfStructure.Count; ++i)
            {
                CartesianCoordinates cc = listOfPointsOfStructure[i];
                int index = i * floatsPerVertex;

                //Vertex
                vertexBuffer[index] = (float)cc.x;
                vertexBuffer[++index] = (float)cc.y;
                vertexBuffer[++index] = (float)cc.z;

                //Color
                Color atomColor = SetColorToElement(cc.element);
                vertexBuffer[++index] = (float)atomColor.R/255;
                vertexBuffer[++index] = (float)atomColor.G/255;
                vertexBuffer[++index] = (float)atomColor.B/255;
            }
            return vertexBuffer;
        }

        /// <summary>
        /// Load float[] of vertices and color into drawing buffer
        /// </summary>
        private void PrepareDataBuffer()
        {
            GL.EnableClientState(ArrayCap.VertexArray);
            GL.EnableClientState(ArrayCap.ColorArray);

            GL.BindBuffer(BufferTarget.ArrayBuffer, bufferId[0]);

            //Get vertex buffer
            float[] vertexBuffer = getVertexBufferFromList();

            //Send to openGL
            unsafe
            {
                fixed (float* vertexBufferPointer = vertexBuffer)
                {
                    GL.BufferData(BufferTarget.ArrayBuffer, vertexBuffer.Length * sizeof(float), (IntPtr)vertexBufferPointer, BufferUsageHint.StaticDraw);
                }
            }          
        }

        /// <summary>
        /// OpenGL rendering of points from list with points
        /// </summary>
        private void RenderScene()
        {
            GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);
            SetCameraPosition();
            GL.PointSize(pointSize);
            
            //ORIGINAL VERSION WHITH DRAWING EXACTLY FROM LIST
            //GL.Color3(Color.Red);
            //GL.Begin(PrimitiveType.Points);
            //foreach (CartesianCoordinates point in listOfPointsOfStructure)
            //{
            //    GL.Color3(SetColorToElement(point.element));
            //    GL.Vertex3(point.x, point.y, point.z);
            //}


            //faster version with drawing from buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, bufferId[0]);
            GL.VertexPointer(3, VertexPointerType.Float, arrayBufferPointSize, bufferVertexOffset);
            GL.ColorPointer(3, ColorPointerType.Float, arrayBufferPointSize, bufferColorOffset);
            GL.DrawArrays(PrimitiveType.Points, 0, listOfPointsOfStructure.Count);
            GL.End();

            if (drawAxes)
            {
                DrawAxes();
            }
            if (origin)
            {
                DrawOrigin();
            }
            if (!Equals(atom1, null) && !Equals(atom2, null))
            {
                DrawLineBetweenPoints();
            }
            glControlPlot.SwapBuffers();
        }

        /// <summary>
        /// If selected 2 points connect them by a line
        /// </summary>
        private void DrawLineBetweenPoints()
        {
            GL.Color3(Color.White);
            GL.LineWidth(1);

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(atom1.x / reductionCoefficient, atom1.y / reductionCoefficient, atom1.z / reductionCoefficient);
            GL.Vertex3(atom2.x / reductionCoefficient, atom2.y / reductionCoefficient, atom2.z / reductionCoefficient);
            GL.End();

        }

        /// <summary>
        /// Draw point [0,0,0]
        /// </summary>
        private void DrawOrigin()
        {
            GL.Color3(Color.White);
            GL.LineWidth(1);

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(-0.025f, 0.0f, 0.0f);
            GL.Vertex3(0.025f, 0.0f, 0.0f);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.0f, -0.025f, 0.0f);
            GL.Vertex3(0.0f, 0.025f, 0.0f);
            GL.End();

            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.0f, 0.0f, -0.025f);
            GL.Vertex3(0.0f, 0.0f, 0.025f);
            GL.End();
        }

        /// <summary>
        /// set color to certain atom
        /// </summary>
        /// <param name="element">element to set a color</param>
        /// <returns>color of the element</returns>
        private Color SetColorToElement(string element)
        {
            switch (element)
            {
                case "H":
                    return Color.White;
                case "O":
                    return Color.Red;
                case "C":
                    return Color.Gray;
                case "Si":
                    return Color.Orange;
                case "Al":
                    return Color.Pink;
                case "Mg":
                    return Color.Green;
                case "Cl":
                    return Color.LightGreen;
                case "F":
                    return Color.Turquoise;
                case "Zn":
                    return Color.Purple;
                default:
                    return Color.Yellow;
            }
        }

        /// <summary>
        /// Draw letter X
        /// </summary>
        private void DrawX()
        {
            GL.LineWidth(4);
            GL.Color3(Color.Blue);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.35f, 0.05f, 0.0f);
            GL.Vertex3(0.37f, 0.07f, 0.0f);
            GL.Vertex3(0.35f, 0.07f, 0.0f);
            GL.Vertex3(0.37f, 0.05f, 0.0f);
            GL.End();
        }

        /// <summary>
        /// Draw letter Y
        /// </summary>
        private void DrawY()
        {
            GL.LineWidth(4);
            GL.Color3(Color.Green);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.05f, 0.35f, 0.0f);
            GL.Vertex3(0.07f, 0.37f, 0.0f);
            GL.Vertex3(0.05f, 0.37f, 0.0f);
            GL.Vertex3(0.06f, 0.36f, 0.0f);
            GL.End();
        }

        /// <summary>
        /// Draw letter Z
        /// </summary>
        private void DrawZ()
        {
            GL.LineWidth(4);
            GL.Color3(Color.Yellow);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(0.0f, 0.07f, 0.35f);
            GL.Vertex3(0.0f, 0.07f, 0.37f);
            GL.Vertex3(0.0f, 0.05f, 0.37f);
            GL.Vertex3(0.0f, 0.07f, 0.35f);
            GL.Vertex3(0.0f, 0.05f, 0.35f);
            GL.Vertex3(0.0f, 0.05f, 0.37f);
            GL.End();
        }

        /// <summary>
        /// Draw axes x y z
        /// </summary>
        private void DrawAxes()
        {
            Vector3 center = new Vector3(0, 0, 0);
            GL.LineWidth(2);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Blue);
            GL.Vertex3(center);
            GL.Vertex3(center + new Vector3(0.5f, 0.0f, 0.0f));
            GL.End();
          
            DrawX();

            GL.Color3(Color.Green);
            GL.LineWidth(2);
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex3(center);
            GL.Vertex3(center + new Vector3(0.0f, 0.5f, 0.0f));
            GL.End();

            DrawY();

            GL.LineWidth(2);
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Yellow);
            GL.Vertex3(center);
            GL.Vertex3(center + new Vector3(0.0f, 0.0f, 0.5f));
            GL.End();

            DrawZ();
        }
    }
}
