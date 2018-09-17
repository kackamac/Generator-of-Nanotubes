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
        private const string ANGSTROMS = "Å";
        private const string MULTIPLES = "x crystal";
        private const string DEGREES = "°";

        private const string PHYSICAL_PARAMS = "Physical";
        private const string MATHEMATICAL_PARAMS = "Mathematical";
        private const string PIPE_PARAMS = "Pipe parameters";
        private const string PLANE_PARAMS = "Plane parameters";
        private const string SPIRAL_PARAMS = "Spiral parameters";

        private const string PIPE = "Pipe";
        private const string PLANE = "Plane";
        private const string SPIRAL = "Spiral";

        private const string WIDTH = "Width:";
        private const string HEIGHT = "Height:";
        private const string LENGTH = "Length:";
        private const string STRUCTURE_LENGTH = "Structure length:";
        private const string WALL_WIDTH = "Wall width:";
        private const string CIRCUMFERENCE = "Circumference:";
        private const string MOVE = "Move from the middle:";
        private const string CLIMB = "Climb of the spiral:";
        private const string INNER_DIAMETER = "Inner diameter:";
        private const string OUTER_DIAMETER = "Outer diameter:";
        private const string STRUCTURE_WIDTH = "Structure width:";

        enum Axes { xUp, xDown, xFront, xBack, yUp, yDown, yFront, yBack, zUp, zDown, zFront, zBack }

        public void InitializeComboBoxParams()
        {
            comboBoxParams.DropDownStyle = ComboBoxStyle.DropDownList;
            List<String> parametres = new List<String>();
            parametres.Add(PHYSICAL_PARAMS);
            parametres.Add(MATHEMATICAL_PARAMS);
            comboBoxParams.DataSource = parametres;
        }

        /// <summary>
        /// Add to combo box options to choice the structure which should be generated
        /// </summary>
        public void InitializeComboBoxForm()
        {
            comboBoxForm.DropDownStyle = ComboBoxStyle.DropDownList;
            List<String> forms = new List<String>();
            forms.Add(SPIRAL);
            forms.Add(PIPE);
            forms.Add(PLANE);
            comboBoxForm.DataSource = forms;
        }

        /// <summary>
        /// Load crystal parameters from input textboxes and verify they are correct
        /// </summary>
        /// <returns>crystal parameters<</returns>
        public CrystalParameters GetCrystalParametres()
        {
            double a = Convert.ToDouble(textBoxA.Text, CultureInfo.InvariantCulture);
            double b = Convert.ToDouble(textBoxB.Text, CultureInfo.InvariantCulture);
            double c = Convert.ToDouble(textBoxC.Text, CultureInfo.InvariantCulture);
            double alpha = Convert.ToDouble(textBoxAlpha.Text, CultureInfo.InvariantCulture);
            double beta = Convert.ToDouble(textBoxBeta.Text, CultureInfo.InvariantCulture);
            double gamma = Convert.ToDouble(textBoxGamma.Text, CultureInfo.InvariantCulture);
            CrystalParameters cp = new CrystalParameters(a, b, c, alpha, beta, gamma);
            if (!Validator.ValidCrystal(cp))
            {
                return null;
            }
            return cp;
        }

        /// <summary>
        /// Load spiral parameters from input textboxes and verify they are correct
        /// </summary>
        /// <returns>spiral parameters<</returns>
        public SpiralParameters GetSpiralParametres()
        {
            if (areParametersPhysical)
            {
                double wallWidth = Convert.ToDouble(textBoxWidthWall.Text, CultureInfo.InvariantCulture);
                double structureWidth = Convert.ToDouble(textBoxWidthStructure.Text, CultureInfo.InvariantCulture);
                double depth = Convert.ToDouble(textBoxLength.Text, CultureInfo.InvariantCulture);
                double innerSize = Convert.ToDouble(textBoxInnerDiameter.Text, CultureInfo.InvariantCulture);
                double outerSize = Convert.ToDouble(textBoxOuterDiameter.Text, CultureInfo.InvariantCulture);             
                if (!(Validator.ValidNumber(wallWidth) && Validator.ValidNumber(structureWidth) && Validator.ValidNumber(depth) && Validator.ValidNumber(innerSize) && Validator.ValidNumber(outerSize)))
                {
                    return null;
                }
                double climb = ConvertorOfParametres.CountClimb(innerSize, outerSize, structureWidth, wallWidth);
                double move = ConvertorOfParametres.CountMove(innerSize, wallWidth, climb);
                double turns = ConvertorOfParametres.CountTurns(climb, structureWidth, wallWidth);
                double circ = ConvertorOfParametres.CountCircumference(move, climb, turns);
                return new SpiralParameters(move, climb, depth, circ, wallWidth);
            }
            double move1 = Convert.ToDouble(textBoxWidthWall.Text, CultureInfo.InvariantCulture);
            double climb1 = Convert.ToDouble(textBoxWidthStructure.Text, CultureInfo.InvariantCulture);
            double depth1 = Convert.ToDouble(textBoxLength.Text, CultureInfo.InvariantCulture);
            double circumference = Convert.ToDouble(textBoxInnerDiameter.Text, CultureInfo.InvariantCulture);
            double wallWidth1 = Convert.ToDouble(textBoxOuterDiameter.Text, CultureInfo.InvariantCulture);
            SpiralParameters sp = new SpiralParameters(move1, climb1, depth1, circumference, wallWidth1);
            if (!Validator.ValidSpiral(sp))
            {
                return null;
            }
            return sp;
        }

        /// <summary>
        /// Load pipe parameters from input textboxes and verify they are correct
        /// </summary>
        /// <returns>pipe parameters</returns>
        public CylinderParameters GetPipeParametres()
        {
            double depth = Convert.ToDouble(textBoxLength.Text);
            if (areParametersPhysical)
            {
                double innerSize = Convert.ToDouble(textBoxInnerDiameter.Text, CultureInfo.InvariantCulture);
                double outerSize = Convert.ToDouble(textBoxOuterDiameter.Text, CultureInfo.InvariantCulture);
                double circ = ConvertorOfParametres.CircumferenceOfTheCircle(innerSize, outerSize); //count circumference of a circle
                double height = (outerSize / 2 - innerSize / 2) / 2;
                return new CylinderParameters(depth, circ, height);
            }
            double circumference = Convert.ToDouble(textBoxInnerDiameter.Text, CultureInfo.InvariantCulture);
            double wallWidth1 = Convert.ToDouble(textBoxOuterDiameter.Text, CultureInfo.InvariantCulture);
            CylinderParameters pp =  new CylinderParameters(depth, circumference, wallWidth1);
            if (!Validator.ValidPipe(pp))
            {
                return null;
            }
            return pp;
        }

        /// <summary>
        /// Load plane parameters from input textboxes and verify they are correct
        /// </summary>
        /// <returns>pipe parameters</returns>
        public PlanarParameters GetPlaneParametres()
        {
            double depth = Convert.ToDouble(textBoxLength.Text);
            double width = Convert.ToDouble(textBoxInnerDiameter.Text, CultureInfo.InvariantCulture);
            double height = Convert.ToDouble(textBoxOuterDiameter.Text, CultureInfo.InvariantCulture);
            PlanarParameters pp = new PlanarParameters(width, height, depth);
            if (!Validator.ValidPlane(pp))
            {
                return null;
            }
            return pp;
        }

        /// <summary>
        /// choose axes and direction we want structure to build on
        /// </summary>
        /// <returns></returns>
        public string ChooseAxisOfRotation()
        {
            if (radioButtonXDown.Checked)
            {
                return Axes.xDown.ToString();
            }
            else if (radioButtonXFront.Checked)
            {
                return Axes.xFront.ToString();
            }
            else if (radioButtonXBack.Checked)
            {
                return Axes.xBack.ToString();
            }
            else if (radioButtonYUp.Checked)
            {
                return Axes.yUp.ToString();
            }
            else if (radioButtonYDown.Checked)
            {
                return Axes.yDown.ToString();
            }
            else if (radioButtonYFront.Checked)
            {
                return Axes.yFront.ToString();
            }
            else if (radioButtonYBack.Checked)
            {
                return Axes.yBack.ToString();
            }
            else if (radioButtonZUp.Checked)
            {
                return Axes.zUp.ToString();
            }
            else if (radioButtonZDown.Checked)
            {
                return Axes.zDown.ToString();
            }
            else if (radioButtonZFront.Checked)
            {
                return Axes.zFront.ToString();
            }
            else if (radioButtonZBack.Checked)
            {
                return Axes.zBack.ToString();
            }
            return Axes.xUp.ToString();           
        }

        /// <summary>
        /// select units which it is counted in
        /// </summary>
        /// <returns></returns>
        public bool IsCountedInAngstroms()
        {
            return radioButtonAngstroms.Checked;
        }

        /// <summary>
        /// Verifies whether input parametres are valid and than creates chosen structure
        /// </summary>
        public void VerifyInputParametresAndCreateStructure()
        {
            try
            {
                //load crystal
                CrystalParameters crystParams = GetCrystalParametres();
                if (Equals(crystParams, null))
                {
                    ShowError("Invalid values of crystal cell parametres.");
                    return;
                }
                string axis = ChooseAxisOfRotation();

                //load files
                string inputFile = textBoxInputFile.Text;

                if (inputFile == "")
                {
                    ShowError("Missing input file with crystal atom's coordinates.");
                    return;
                }
                CreatorOfSurface.angstroms = IsCountedInAngstroms();
                //load spiral
                if (comboBoxForm.Text == SPIRAL)
                {
                    CreateSpiral(crystParams, inputFile, axis);
                }
                //load pipe
                else if(comboBoxForm.Text == PIPE)
                {
                     CreatePipe(crystParams, inputFile, axis);
                }
                else
                {           
                     CreatePlane(crystParams, inputFile, axis);
                }
            }
            catch
            {
                ShowError("Missing some input parameters. Check whether everything is filled.");
            }
        }

        /// <summary>
        /// create spiral
        /// </summary>
        /// <param name="crystParams">parameters of the crystal</param>
        /// <param name="inputFile">name of file with input crystal</param>
        /// <param name="axis">axis and direction of rotation</param>
        public void CreateSpiral(CrystalParameters crystParams, string inputFile, string axis)
        {
            SpiralParameters spiralParams = GetSpiralParametres();
            if (Equals(spiralParams, null))
            {
                ShowError("Invalid values of spiral parametres.");
                return;
            }
            try
            {
                Program.CreateSpiral(crystParams, spiralParams, inputFile, axis);
                ActionWasSuccessfull("Spiral was created.");
            }
            catch
            {
                ShowError("Mistake while creating spiral. Check your structure parameters or input file.");
            }
        }

        /// <summary>
        /// create pipe
        /// </summary>
        /// <param name="crystParams">parameters of the crystal</param>
        /// <param name="inputFile">name of file with input crystal</param>
        /// <param name="axis">axis and direction of rotation</param>
        public void CreatePipe(CrystalParameters crystParams, string inputFile, string axis)
        {
            CylinderParameters pipeParams = GetPipeParametres();
            if (Equals(pipeParams, null))
            {
                ShowError("Invalid values of pipe parametres.");
                return;
            }
            try
            {
                Program.CreatePipe(crystParams, pipeParams, inputFile, axis);
                ActionWasSuccessfull( "Pipe was created.");

            }
            catch
            {
                ShowError("Invalid input file with crystal atom's coordinates.");
            }
        }

        /// <summary>
        /// create plane
        /// </summary>
        /// <param name="crystParams">parameters of the crystal</param>
        /// <param name="inputFile">name of file with input crystal</param>
        /// <param name="axis">axis and direction of rotation</param>
        public void CreatePlane(CrystalParameters crystParams, string inputFile, string axis)
        {
            PlanarParameters plane = GetPlaneParametres();
            if (Equals(plane, null))
            {
                ShowError("Invalid values of plane parametres.");
                return;
            }
            try
            {
                Program.CreatePlane(crystParams, plane, inputFile, axis);
                ActionWasSuccessfull("Plane was created.");
            }
            catch
            {
                ShowError("Invalid input file with crystal atom's coordinates.");
            }
        }

        /// <summary>
        /// erase all textboxes content
        /// </summary>
        public void ClearAllText()
        {
            textBoxWidthStructure.Text = "";
            textBoxWidthWall.Text = "";
            textBoxGamma.Text = "";
            textBoxLength.Text = "";
            textBoxOuterDiameter.Text = "";
            textBoxWidthWall.Text = "";
            textBoxWidthStructure.Text = "";
            textBoxInnerDiameter.Text = "";
            textBoxGamma.Text = "";
            textBoxAlpha.Text = "";
            textBoxBeta.Text = "";
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxInputFile.Text = "";
            textBoxInfo.Text = "";
            textBoxInfo.BackColor = Color.White;
        }

        /// <summary>
        /// set correct boxes for input parameters according to the structure
        /// </summary>
        public void SetView()
        {
            if (comboBoxForm.Text == SPIRAL)
            {

                if (comboBoxParams.Text == PHYSICAL_PARAMS)
                {
                    pictureBoxStructure.Image = Properties.Resources.spiral;
                    pictureBoxStructure.Refresh();
                    ChoosePhysicalParams();
                }
                else //parametres2
                {
                    pictureBoxStructure.Image = Properties.Resources.spiral2;
                    pictureBoxStructure.Refresh();
                    ChooseMathematicalParams();
                }
                pictureBoxStructure.Refresh();
                SpiralView();
            }
            else if (comboBoxForm.Text == PIPE)
            {
                if (comboBoxParams.Text == PHYSICAL_PARAMS)
                {
                    pictureBoxStructure.Image = Properties.Resources.pipe;
                    pictureBoxStructure.Refresh();
                    ChoosePhysicalParams();
                }
                else //parametres2
                {
                    pictureBoxStructure.Image = Properties.Resources.pipe2;
                    pictureBoxStructure.Refresh();
                    pictureBoxStructure.Refresh();
                    ChooseMathematicalParams();
                }
                PipeView();
            }
            else
            {
                pictureBoxStructure.Image = Properties.Resources.plane;
                pictureBoxStructure.Refresh();
                pictureBoxStructure.Refresh();
                ChooseMathematicalParams();
                PlaneView();
            }
        }

        /// <summary>
        /// show correct descriptions to the texboxes for physical parameters
        /// </summary>
        public void ChoosePhysicalParams()
        {
            labelInnerDiameter.Text = INNER_DIAMETER;
            labelOuterDiameter.Text = OUTER_DIAMETER;
            labelLength.Text = STRUCTURE_LENGTH;
            labelWidthWall.Text = WALL_WIDTH;
            labelWidthSpace.Text = STRUCTURE_WIDTH;
            if (radioButtonMult.Checked)
            {
                label11.Text = MULTIPLES;
            }
            else {
                label11.Text =ANGSTROMS;
            }
            areParametersPhysical = true;
        }

        /// <summary>
        /// show correct descriptions to the texboxes for mathematical parameters
        /// </summary>
        public void ChooseMathematicalParams()
        {
            labelInnerDiameter.Text = CIRCUMFERENCE;
            labelOuterDiameter.Text = WALL_WIDTH;
            labelLength.Text = STRUCTURE_LENGTH;
            labelWidthWall.Text = MOVE;
            labelWidthSpace.Text = CLIMB;
            areParametersPhysical = false;
            label11.Text = DEGREES;
        }

        /// <summary>
        /// set corresponding textboxes for creating spiral
        /// </summary>
        public void SpiralView()
        {
            textBoxWidthStructure.Visible = true;
            textBoxWidthWall.Visible = true;
            textBoxGamma.Visible = true;
            labelWidthWall.Visible = true;
            labelWidthSpace.Visible = true;
            labelGamma.Visible = true;
            labelFormParams.Text = SPIRAL_PARAMS;
            label10.Visible = true;
            label11.Visible = true;
        }

        /// <summary>
        /// set corresponding textboxes for creating pipe
        /// </summary>
        public void PipeView()
        {
            textBoxWidthStructure.Visible = false;
            textBoxGamma.Visible = true;
            labelGamma.Visible = true;
            textBoxWidthWall.Visible = false;
            labelWidthWall.Visible = false;
            labelWidthSpace.Visible = false;
            labelFormParams.Text = PIPE_PARAMS;
            label10.Visible = false;
            label11.Visible = false;
        }

        /// <summary>
        /// set corresponding textboxes for creating plane
        /// </summary>
        public void PlaneView()
        {
            textBoxWidthStructure.Visible = false;
            textBoxGamma.Visible = true;
            labelGamma.Visible = true;
            textBoxWidthWall.Visible = false;
            labelWidthWall.Visible = false;
            labelWidthSpace.Visible = false;
            labelFormParams.Text = PLANE_PARAMS;
            label10.Visible = false;
            label11.Visible = false;
            labelInnerDiameter.Text = WIDTH;
            labelOuterDiameter.Text = HEIGHT;
            labelLength.Text = LENGTH;
        }

        /// <summary>
        /// choose units whitch it is counted in (Angstroms or multiples of the crystal)
        /// </summary>
        public void ChooseUnits()
        {
            if (radioButtonAngstroms.Checked)
            {
                label4.Text = ANGSTROMS;
                label5.Text = ANGSTROMS;
                label6.Text = ANGSTROMS;
                label10.Text = ANGSTROMS;
                if (comboBoxParams.Text == PHYSICAL_PARAMS)
                {
                    label11.Text = ANGSTROMS;
                }
                else
                {
                    label11.Text = DEGREES;
                }

            }
            else
            {
                 label4.Text = MULTIPLES;
                 label5.Text = MULTIPLES;
                 label6.Text = MULTIPLES;
                 label10.Text = MULTIPLES;
                if (comboBoxParams.Text == PHYSICAL_PARAMS)
                {
                    label11.Text = MULTIPLES;
                }
            }
        }

        /// <summary>
        /// show error message into status line
        /// </summary>
        /// <param name="errMessage">error message what was wrong</param>
        public void ShowError(string errMessage)
        {
            textBoxInfo.ForeColor = Color.Red;
            textBoxInfo.Text = errMessage;
        }

        /// <summary>
        /// set message that operation was successfull into status line
        /// </summary>
        /// <param name="succMessage">message what passed successfully</param>
        public void ActionWasSuccessfull(string succMessage)
        {
            textBoxInfo.ForeColor = Color.Green;
            textBoxInfo.Text = succMessage;
        }

        /// <summary>
        /// Load crystal parameters from file and display values in textboxes
        /// </summary>
        public void LoadCrystal()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string[] elements = LoaderAndSaver.LoadFileParams(file);
                if (elements == null)
                {
                    ShowError( "Invalid format of input file with crystal parameters.");
                    return;
                }
                textBoxA.Text = elements[0];
                textBoxB.Text = elements[1];
                textBoxC.Text = elements[2];
                textBoxAlpha.Text = elements[3];
                textBoxBeta.Text = elements[4];
                textBoxGamma.Text = elements[5];
            }
        }

        /// <summary>
        /// load input file with crytal coordinates
        /// </summary>
        public void LoadInputFromFile()
        {
            string text = textBoxInputFile.Text;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                textBoxInputFile.Text = file;
            }
        }

        /// <summary>
        /// Load file with created structure
        /// </summary>
        /// <returns></returns>
        public void LoadAndShowCrystal()
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
      
                try
                {
                    LoaderAndSaver.LoadFile(file);
                }
                catch (IOException)
                {
                    ShowError("Invalid input file.");
                    return;
                }
            }
        }

        /// <summary>
        /// reset camera view to the original one
        /// </summary>
        public void ResetView()
        {
            actualZoom = originalZoom;
            xAngle = originalAngleX;
            yAngle = originalAngleY;
            cameraShift = originalVector;
            SetCameraPosition();
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// convert screen coordinates to world ones to find the nearest atom coordinates
        /// </summary>
        /// <param name="x">x to convert</param>
        /// <param name="y">y to convert</param>
        /// <param name="z">z to convert</param>
        /// <returns>vector with real coordinates</returns>
        Vector3 screenToWorld(int x, int y, float z = 0.0f)
        {
            Matrix4 modelViewMatrix, projectionMatrix;
            GL.GetFloat(GetPName.ModelviewMatrix, out modelViewMatrix);
            GL.GetFloat(GetPName.ProjectionMatrix, out projectionMatrix);

            return UnProject(ref projectionMatrix, ref modelViewMatrix, glControlPlot.Width, glControlPlot.Height, x, glControlPlot.Height - y, z);
        }

        /// <summary>
        /// converts screen coordinates into world ones
        /// </summary>
        /// <param name="projection">projection matrix</param>
        /// <param name="view">view matrix</param>
        /// <param name="width">width of the glControl</param>
        /// <param name="height">height of the glControl</param>
        /// <param name="x">x to convert</param>
        /// <param name="y">y to convert</param>
        /// <param name="z">z to convert</param>
        /// <returns>converted coordinates</returns>
        public static Vector3 UnProject(ref Matrix4 projection, ref Matrix4 view, int width, int height, float x, float y, float z = 0.0f)
        {
            Vector4 vec;
            vec.X = 2.0f * x / (float)width - 1;
            vec.Y = 2.0f * y / (float)height - 1;
            vec.Z = z;
            vec.W = 1.0f;

            Matrix4 viewInv = Matrix4.Invert(view);
            Matrix4 projInv = Matrix4.Invert(projection);

            Vector4.Transform(ref vec, ref projInv, out vec);
            Vector4.Transform(ref vec, ref viewInv, out vec);

            if (vec.W > float.Epsilon ||
                 vec.W < float.Epsilon)
            {
                vec.X /= vec.W;
                vec.Y /= vec.W;
                vec.Z /= vec.W;
                vec.W = 1.0f;
            }

            return new Vector3(vec);
        }

        /// <summary>
        /// display glControl on while screen
        /// </summary>
        private void FullSize()
        {
            glControlPlot.Location = labelHeading.Location;
            glControlPlot.BringToFront();
            glControlPlot.Width = this.Width;
            glControlPlot.Height = buttonReset.PointToScreen(Point.Empty).Y - buttonReset.Height;
        }

        /// <summary>
        /// show panels with crystal structure, intpufile and structure pamareters
        /// </summary>
        private void ShowPanels()
        {
            panelCrystal.Visible = true;
            panelInput.Visible = true;
            panelStructur.Visible = true;
        }

        /// <summary>
        /// hide panels with crystal structure, intpufile and structure pamareters
        /// </summary>
        private void HidePanels()
        {
            panelCrystal.Visible = false;
            panelInput.Visible = false;
            panelStructur.Visible = false;
        }

        /// <summary>
        /// class for saving the line parameters
        /// point[x,y,z] and vector(x,y,z)
        /// </summary>
        public class Line
        {
            public Vector3 direction;
            public Vector3 point;
            public Line(Vector3 direction, Vector3 point)
            {
                this.direction = direction;
                this.point = point;
            }
        }

        /// <summary>
        /// find line parameters
        /// </summary>
        /// <param name="point1">1st point on the line</param>
        /// <param name="point2">2nd point on the line</param>
        /// <returns></returns>
        private Line CreateLineFromPoints(Vector3 point1, Vector3 point2)
        {
            return new Line(new Vector3(point2.X - point1.X, point2.Y - point1.Y, point2.Z - point1.Z), point1);
        }

        /// <summary>
        /// find nearest atom from the line  - foreach point count its distance and select the lowest
        /// </summary>
        /// <param name="line">line parameters</param>
        /// <returns>nearest point</returns>
        private CartesianCoordinates FindNearestPoint(Line line)
        {
            double minDistance = double.MaxValue;
            CartesianCoordinates nearestPoint = null;
            if (listOfPointsOfStructure.Count==0)
            {
                return null;
            }
            foreach (CartesianCoordinates cc in listOfPointsOfStructure)
            {
                double distance = CountDistance(cc, line);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestPoint = cc;
                }
            }
            return RecountToOriginalCoordinates(nearestPoint);
        }

        /// <summary>
        /// count point distance from line
        /// </summary>
        /// <param name="point">point coordinates</param>
        /// <param name="line">line parameters</param>
        /// <returns>distance</returns>
        public double CountDistance(CartesianCoordinates point, Line line)
        {
            double parameter = (line.direction.X * (point.x - line.point.X) + line.direction.Y * (point.y - line.point.Y) + line.direction.Z * (point.z - line.point.Z)) / (Math.Pow(line.direction.X, 2) + Math.Pow(line.direction.Y, 2) + Math.Pow(line.direction.Z, 2));
            double xNew = line.point.X + line.direction.X * parameter;
            double yNew = line.point.Y + line.direction.Y * parameter;
            double zNew = line.point.Z + line.direction.Z * parameter;
            return Math.Sqrt(Math.Pow(xNew - point.x, 2) + Math.Pow(yNew - point.y, 2) + Math.Pow(zNew - point.z, 2));
        }

        /// <summary>
        /// recount display coordinates to real (original) ones
        /// </summary>
        /// <param name="cc">display coordinates</param>
        /// <returns>oiginal (real) coordinates</returns>
        private CartesianCoordinates RecountToOriginalCoordinates(CartesianCoordinates cc)
        {
            return new CartesianCoordinates(cc.element, cc.x * reductionCoefficient, cc.y * reductionCoefficient, cc.z * reductionCoefficient);
        }

        /// <summary>
        /// find nearest point and count distance from previous if possible
        /// </summary>
        /// <param name="line">line parameters</param>
        private void SetChosenPointsAndCountDistance(Line line)
        {
            if (wasSetFirstPoint)
            {
                atom2 = FindNearestPoint(line);
                wasSetFirstPoint = false;
            }
            else
            {
                atom1 = FindNearestPoint(line);
                if (Equals(atom1, null))
                {
                    return;
                }
                wasSetFirstPoint = true;
            }
            WritePointsCoordinates();
        }

        /// <summary>
        /// write coordinates of selected atom(s) and distance
        /// </summary>
        private void WritePointsCoordinates()
        {
            int places = 4;
            textBoxInfo.ForeColor = Color.Black;
            if (atom2 != null)
            {
                double distance = Math.Sqrt(Math.Pow(atom2.x - atom1.x, 2) + Math.Pow(atom2.y - atom1.y, 2) + Math.Pow(atom2.z - atom1.z, 2));
                textBoxInfo.Text = String.Format("{0}: {1}  {2} {3} | {4}: {5} {6} {7} | distance: {8}",atom1.element, Math.Round(atom1.x, places), Math.Round(atom1.y, places), Math.Round(atom1.z, places), atom2.element, Math.Round(atom2.x, places), Math.Round(atom2.y, places), Math.Round(atom2.z, places), Math.Round(distance, places));

            }
            else
            {
                textBoxInfo.Text = String.Format( "{0}: {1} {2} {3}" , atom1.element, Math.Round(atom1.x, places), Math.Round(atom1.y, places),Math.Round(atom1.z, places));
            }
        }

        /// <summary>
        /// clear all settings in glControl
        /// </summary>
        public void ClearAllGLControl()
        {
            ResetView();
            GL.Clear(ClearBufferMask.DepthBufferBit | ClearBufferMask.ColorBufferBit);
            atom1 = null;
            atom2 = null;
            listOfPointsOfStructure = new List<CartesianCoordinates>();
            OriginalCrystal.Instance.Clear();
            CreatedStructure.Instance.Clear();
        }

        /// <summary>
        /// Find the maximum of all coordinates to get reduction coefficient to fit whole structure into 1,1,1 cube
        /// </summary>
        /// <returns></returns>
        public double FindMaxForDivision()
        {
            OneCrystalSize maxPoint = CreatedStructure.Instance.FindMaxDistanceAmongAtoms();
            OneCrystalSize minPoint = CreatedStructure.Instance.FindMinDistanceAmongAtoms();
            if (Math.Abs(maxPoint.x) < Math.Abs(minPoint.x))
            {
                maxPoint.x = Math.Abs(minPoint.x);
            }
            if (Math.Abs(maxPoint.y) < Math.Abs(minPoint.y))
            {
                maxPoint.y = Math.Abs(minPoint.y);
            }
            if (Math.Abs(maxPoint.z) < Math.Abs(minPoint.z))
            {
                maxPoint.z = Math.Abs(minPoint.z);
            }
            double max = maxPoint.x;

            if (max < maxPoint.y)
            {
                max = maxPoint.y;
            }
            if (max < maxPoint.z)
            {
                max = maxPoint.z;
            }
            if (max < 1)
            {
                max = 1;
            }
            return max;
        }
    }
}
