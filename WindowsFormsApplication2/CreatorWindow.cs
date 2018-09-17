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
using System.Threading;
//5.15 8.9 7.57 90 100 90

namespace WindowsFormsApplication2
{

    /// <summary>
    /// Graphic representation of program
    /// </summary>
    public partial class CreatorWindow : Form
    {
        //bool to know whitch parameters are we counting in
        public bool areParametersPhysical;

        //original size of glControl - to easier resing
        private int glControlOrigSizeX;
        private int glControlOrigSizeY;

        public CreatorWindow()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComponent();
            this.glControlPlot.MouseWheel += glControl_MouseWheel;
            InitializeComboBoxForm();
            InitializeComboBoxParams();
            areParametersPhysical = true;
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            buttonLoadView.Visible = false;
        }

        /// <summary>
        /// On click calls function that generates structure, if there are valid parametres and then draw structure in glControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            ClearAllGLControl();
            VerifyInputParametresAndCreateStructure();
            listOfPointsOfStructure = CreateListWithPointsForDrawing();
            PrepareDataBuffer();
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// takes the coordinates of all atoms and recount them that they fit info cube of sie 1,1,1 because we have camera set on this view
        /// reduction coefficient is the coefficient how much we reduced the structure
        /// </summary>
        /// <returns>list of recounted coordinates of atoms</returns>
        public List<CartesianCoordinates> CreateListWithPointsForDrawing()
        {
            List<CartesianCoordinates> drawPoints = new List<CartesianCoordinates>();

            reductionCoefficient = FindMaxForDivision();
            foreach (CartesianCoordinates point in CreatedStructure.Instance)
            {
                float x = (float)(point.x / reductionCoefficient);
                float y = (float)(point.y/ reductionCoefficient);
                float z = (float)(point.z / reductionCoefficient);
                drawPoints.Add(new CartesianCoordinates(point.element, x, y, z));
            }
            return drawPoints;
        }


        /// <summary>
        /// Changes the type of structure that should be generated (pipe or spiral)
        /// </summary>
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void comboBoxForm_SelectedValueChanged(object sender, EventArgs e)
        {
            SetView();
        }

        /// <summary>
        /// Changes the type of parameters that we are using (mathematical of physical)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxParams_SelectedValueChanged(object sender, EventArgs e)
        {
            SetView();
        }

        /// <summary>
        /// On click clears all user settings in page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAllText();
            ClearAllGLControl();
            listOfPointsOfStructure = new List<CartesianCoordinates>();
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// Loads other file from user's disk with input crystal coordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            LoadInputFromFile();
        }

        /// <summary>
        /// Loads and shows input crystal parameters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadCrystal_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            DeleteCrystalParamsTextBoxesContent();
            LoadCrystal();
        }

        /// <summary>
        /// Detele content of all text boxes with input crystal parameters
        /// </summary>
        private void DeleteCrystalParamsTextBoxesContent()
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
            textBoxAlpha.Text = "";
            textBoxBeta.Text = "";
            textBoxGamma.Text = "";
        }

        /// <summary>
        /// Save crystal parametres into file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveCrystalParams_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            LoaderAndSaver.SaveCrystalToFile(textBoxA.Text, textBoxB.Text, textBoxC.Text, textBoxAlpha.Text, textBoxBeta.Text, textBoxGamma.Text);
        }

        /// <summary>
        /// Choose nits which we are counting in (Angstroms of multiples of original cell)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMult_CheckedChanged(object sender, EventArgs e)
        {
            ChooseUnits();
        }

        /// <summary>
        /// Choose nits which we are counting in (Angstroms of multiples of original cell)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAngstroms_CheckedChanged(object sender, EventArgs e)
        {
            ChooseUnits();
        }

        /// <summary>
        /// On mouse hover make picture with structure parameters bigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></parasm>
        private void pictureBoxStructure_MouseHover(object sender, EventArgs e)
        {
            pictureBoxStructure.Height = 214;
            pictureBoxStructure.Width = 360;
            pictureBoxStructure.BringToFront();
        }


        /// <summary>
        /// On mouse hover make picture with structure parameters smaller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxStructure_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxStructure.Height = 30;
            pictureBoxStructure.Width = 45;
        }

        /// <summary>
        /// On mouse wheel zoom in or out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                float change = -e.Delta / 120.0f;
                actualZoom = (float)(actualZoom * (Math.Pow(1.04, change)));
                glControlPlot.Invalidate();
            }
        }

        private void glControl_Resize(object sender, EventArgs e)
        {
            if (!isGlControlLoaded) return;

            setViewAndProjectionMatrix();
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// start rotating of the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl_MouseDown(object sender, MouseEventArgs e)
        {
            draggingFromX = e.X;
            draggingFromY = e.Y;
            dragging = true;
        }

        /// <summary>
        /// end rotating of the camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        /// <summary>
        /// count new camera position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging) return;

            if (e.X != draggingFromX)
            {
                int delta = e.X - draggingFromX;
                draggingFromX = e.X;
                xAngle -= (float)(delta * (4.0 / glControlPlot.Width));
            }

            if (e.Y != draggingFromY)
            {
                int delta = e.Y - draggingFromY;
                draggingFromY = e.Y;
                yAngle += (float)(delta * (3.0 / glControlPlot.Height)); 
            }

            glControlPlot.Invalidate();
        }

        /// <summary>
        /// on glControlLoad set amera position and initialize all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl_Load(object sender, EventArgs e)
        {
            OpenGLInit();
            setViewAndProjectionMatrix();
            isGlControlLoaded = true;
            glControlOrigSizeX = glControlPlot.Width;
            glControlOrigSizeY = glControlPlot.Height;
        }

        private void glControl_Paint(object sender, PaintEventArgs e)
        {
            if (isGlControlLoaded) RenderScene();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            ResetView();
        }

        /// <summary>
        /// choose axis and direction to create structure around
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxAxes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAxes.Checked)
            {
                drawAxes = true;
                glControlPlot.Invalidate();

            }
            else
            {
                drawAxes = false;
                glControlPlot.Invalidate();
            }
        }

        /// <summary>
        /// saves createed structure into file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveStructure_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            if (CreatedStructure.Instance.Count == 0)
            {
                ShowError("Structure must be created before exporting into file.");
                return;
            }
            try
            {
                LoaderAndSaver.SaveToFile();
                ActionWasSuccessfull("Structure was saved into file.");
            }
            catch (IOException)
            {
                ShowError("Mistake while saving created structure into file.");
            }
        }

        /// <summary>
        /// handle selected keypressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControlPlot_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
 
            switch (e.KeyCode)
            {
                case Keys.A:
                    MoveCamera(Vector2.UnitX);
                    break;
                case Keys.S:
                    MoveCamera(Vector2.UnitY);
                    break;
                case Keys.W:
                    MoveCamera(-Vector2.UnitY);
                    break;
                case Keys.D:
                    MoveCamera(-Vector2.UnitX);
                    break;
                case Keys.Escape:
                    CancellFullSizeMode();
                    break;
                case Keys.R:
                    atom1 = null;
                    atom2 = null;
                    textBoxInfo.Text = "";
                    break;
                default:
                    break;          
            }
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// reduce glPlot to only a part of the screen
        /// </summary>
        private void CancellFullSizeMode()
        {
            checkBoxFullSize.Checked = false;
        }

        /// <summary>
        /// make glPlot as big as screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxFullSize_CheckedChanged(object sender, EventArgs e)
        {
            glControlPlot.BringToFront();

            if(checkBoxFullSize.Checked){
                FullSize();
                HidePanels();
            }
            else
            {
                if (!checkBoxViewMode.Checked)
                {
                    ShowPanels();
                }
                glControlPlot.Location= new Point(panelControlTools.Location.X, panelStructur.Location.Y);
                glControlPlot.Width = glControlOrigSizeX;
                glControlPlot.Height = glControlOrigSizeY;
            }
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// disable writing into status line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxInfo_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void textBoxInfo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void trackBarPointSize_Scroll(object sender, EventArgs e)
        {
            pointSize = trackBarPointSize.Value;
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// make picture with crystal parameters bigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCrystal_MouseHover(object sender, EventArgs e)
        {
            pictureBoxCrystal.Height = 170;
            pictureBoxCrystal.Width = 170;
            pictureBoxCrystal.BringToFront();
        }

        /// <summary>
        /// meka picture of crystal parameters smaller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxCrystal_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCrystal.Height = 34;
            pictureBoxCrystal.Width = 34;
        }

        /// <summary>
        /// if checkd then draw origin in [0,0,0]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxOrigin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOrigin.Checked)
            {
                origin = true;
            }
            else
            {
                origin = false;
            }
            glControlPlot.Invalidate();
        }

        /// <summary>
        /// chooose the nearest point from the place of click and write its coordinates
        /// if second point selected then write both coordinates and alsou count the distance between points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControlPlot_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            fromPoint = screenToWorld(e.X, e.Y, 0.0f);
            toPoint = screenToWorld(e.X, e.Y, 1.0f);
            Line line = CreateLineFromPoints(fromPoint, toPoint);
            SetChosenPointsAndCountDistance(line);
            glControlPlot.Invalidate();

        }
     
        /// <summary>
        /// only for displaying already created structures
        /// if view mode then display fullsize glControl and show only button for loading and displaying file with created structure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxViewMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewMode.Checked)
            {
                HidePanels();
                checkBoxFullSize.Checked = true;
                buttonLoadView.Visible = true;
            }
            else
            {
                ShowPanels();
                buttonLoadView.Visible = false;
                checkBoxFullSize.Checked = false;
            }

        }

        /// <summary>
        /// Select file with coordinates and displays it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadView_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            ClearAllGLControl();
            ResetView();
            try
            {
                LoadAndShowCrystal();
            }
            catch (Exception)
            {
                return;
            }

            listOfPointsOfStructure = CreateListWithPointsForDrawing();
            PrepareDataBuffer();
            glControlPlot.Invalidate();
        }

        private void CreatorWindow_Load(object sender, EventArgs e)
        {

        }
    }
}