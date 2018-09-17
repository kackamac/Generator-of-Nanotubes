namespace WindowsFormsApplication2
{
    partial class CreatorWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.glControlPlot = new OpenTK.GLControl();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelCrystalParametres = new System.Windows.Forms.Label();
            this.labelInnerDiameter = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelGamma = new System.Windows.Forms.Label();
            this.textBoxInnerDiameter = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.comboBoxParams = new System.Windows.Forms.ComboBox();
            this.labelForm = new System.Windows.Forms.Label();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.labelWidthWall = new System.Windows.Forms.Label();
            this.labelWidthSpace = new System.Windows.Forms.Label();
            this.textBoxWidthWall = new System.Windows.Forms.TextBox();
            this.textBoxWidthStructure = new System.Windows.Forms.TextBox();
            this.labelFormParams = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.labelBetta = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxBeta = new System.Windows.Forms.TextBox();
            this.labelHeading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelOuterDiameter = new System.Windows.Forms.Label();
            this.textBoxOuterDiameter = new System.Windows.Forms.TextBox();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonLoadCrystal = new System.Windows.Forms.Button();
            this.buttonSaveCrystalParams = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonXUp = new System.Windows.Forms.RadioButton();
            this.radioButtonYUp = new System.Windows.Forms.RadioButton();
            this.radioButtonZUp = new System.Windows.Forms.RadioButton();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.radioButtonMult = new System.Windows.Forms.RadioButton();
            this.radioButtonAngstroms = new System.Windows.Forms.RadioButton();
            this.panelUnits = new System.Windows.Forms.Panel();
            this.panelAxes = new System.Windows.Forms.Panel();
            this.radioButtonZDown = new System.Windows.Forms.RadioButton();
            this.radioButtonYDown = new System.Windows.Forms.RadioButton();
            this.radioButtonXDown = new System.Windows.Forms.RadioButton();
            this.panelCrystal = new System.Windows.Forms.Panel();
            this.pictureBoxCrystal = new System.Windows.Forms.PictureBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelStructur = new System.Windows.Forms.Panel();
            this.buttonSaveStructure = new System.Windows.Forms.Button();
            this.pictureBoxStructure = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxAxes = new System.Windows.Forms.CheckBox();
            this.checkBoxFullSize = new System.Windows.Forms.CheckBox();
            this.trackBarPointSize = new System.Windows.Forms.TrackBar();
            this.labelPointSize = new System.Windows.Forms.Label();
            this.checkBoxOrigin = new System.Windows.Forms.CheckBox();
            this.panelControlTools = new System.Windows.Forms.Panel();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.checkBoxViewMode = new System.Windows.Forms.CheckBox();
            this.buttonLoadView = new System.Windows.Forms.Button();
            this.radioButtonXFront = new System.Windows.Forms.RadioButton();
            this.radioButtonXBack = new System.Windows.Forms.RadioButton();
            this.radioButtonYFront = new System.Windows.Forms.RadioButton();
            this.radioButtonYBack = new System.Windows.Forms.RadioButton();
            this.radioButtonZFront = new System.Windows.Forms.RadioButton();
            this.radioButtonZBack = new System.Windows.Forms.RadioButton();
            this.panelUnits.SuspendLayout();
            this.panelAxes.SuspendLayout();
            this.panelCrystal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrystal)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelStructur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointSize)).BeginInit();
            this.panelControlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // glControlPlot
            // 
            this.glControlPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControlPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.glControlPlot.BackColor = System.Drawing.Color.Black;
            this.glControlPlot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.glControlPlot.Location = new System.Drawing.Point(454, 276);
            this.glControlPlot.Margin = new System.Windows.Forms.Padding(53, 52, 53, 52);
            this.glControlPlot.Name = "glControlPlot";
            this.glControlPlot.Size = new System.Drawing.Size(600, 325);
            this.glControlPlot.TabIndex = 17;
            this.glControlPlot.VSync = false;
            this.glControlPlot.Load += new System.EventHandler(this.glControl_Load);
            this.glControlPlot.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControlPlot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControlPlot_KeyDown);
            this.glControlPlot.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.glControlPlot_MouseDoubleClick);
            this.glControlPlot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
            this.glControlPlot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
            this.glControlPlot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseUp);
            this.glControlPlot.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCreate.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(157, 332);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(6);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 32);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelCrystalParametres
            // 
            this.labelCrystalParametres.AutoSize = true;
            this.labelCrystalParametres.BackColor = System.Drawing.Color.Transparent;
            this.labelCrystalParametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrystalParametres.Location = new System.Drawing.Point(48, 3);
            this.labelCrystalParametres.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCrystalParametres.Name = "labelCrystalParametres";
            this.labelCrystalParametres.Size = new System.Drawing.Size(249, 30);
            this.labelCrystalParametres.TabIndex = 2;
            this.labelCrystalParametres.Text = "Crystal parametres";
            // 
            // labelInnerDiameter
            // 
            this.labelInnerDiameter.AutoSize = true;
            this.labelInnerDiameter.BackColor = System.Drawing.Color.Transparent;
            this.labelInnerDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInnerDiameter.Location = new System.Drawing.Point(6, 36);
            this.labelInnerDiameter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInnerDiameter.Name = "labelInnerDiameter";
            this.labelInnerDiameter.Size = new System.Drawing.Size(142, 25);
            this.labelInnerDiameter.TabIndex = 3;
            this.labelInnerDiameter.Text = "Inner diameter:";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.BackColor = System.Drawing.Color.Transparent;
            this.labelLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLength.Location = new System.Drawing.Point(6, 101);
            this.labelLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(155, 25);
            this.labelLength.TabIndex = 5;
            this.labelLength.Text = "Structure length:";
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.BackColor = System.Drawing.Color.Transparent;
            this.labelGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamma.Location = new System.Drawing.Point(210, 111);
            this.labelGamma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(87, 25);
            this.labelGamma.TabIndex = 6;
            this.labelGamma.Text = "Gamma:";
            // 
            // textBoxInnerDiameter
            // 
            this.textBoxInnerDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInnerDiameter.Location = new System.Drawing.Point(212, 33);
            this.textBoxInnerDiameter.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxInnerDiameter.Name = "textBoxInnerDiameter";
            this.textBoxInnerDiameter.Size = new System.Drawing.Size(98, 30);
            this.textBoxInnerDiameter.TabIndex = 7;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLength.Location = new System.Drawing.Point(212, 101);
            this.textBoxLength.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(98, 30);
            this.textBoxLength.TabIndex = 9;
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGamma.Location = new System.Drawing.Point(297, 111);
            this.textBoxGamma.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(78, 30);
            this.textBoxGamma.TabIndex = 10;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.BackColor = System.Drawing.Color.Transparent;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(0, 75);
            this.labelFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(163, 25);
            this.labelFile.TabIndex = 11;
            this.labelFile.Text = "Choose input file:";
            // 
            // comboBoxParams
            // 
            this.comboBoxParams.DropDownHeight = 100;
            this.comboBoxParams.DropDownWidth = 170;
            this.comboBoxParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParams.FormattingEnabled = true;
            this.comboBoxParams.IntegralHeight = false;
            this.comboBoxParams.Location = new System.Drawing.Point(270, 38);
            this.comboBoxParams.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxParams.Name = "comboBoxParams";
            this.comboBoxParams.Size = new System.Drawing.Size(237, 33);
            this.comboBoxParams.TabIndex = 12;
            this.comboBoxParams.SelectedValueChanged += new System.EventHandler(this.comboBoxParams_SelectedValueChanged);
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.BackColor = System.Drawing.Color.Transparent;
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.Location = new System.Drawing.Point(0, 3);
            this.labelForm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(270, 25);
            this.labelForm.TabIndex = 14;
            this.labelForm.Text = "Choose structure to generate:";
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.DropDownHeight = 100;
            this.comboBoxForm.DropDownWidth = 170;
            this.comboBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.IntegralHeight = false;
            this.comboBoxForm.ItemHeight = 25;
            this.comboBoxForm.Location = new System.Drawing.Point(270, 3);
            this.comboBoxForm.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(237, 33);
            this.comboBoxForm.TabIndex = 15;
            this.comboBoxForm.SelectedValueChanged += new System.EventHandler(this.comboBoxForm_SelectedValueChanged);
            // 
            // labelWidthWall
            // 
            this.labelWidthWall.AutoSize = true;
            this.labelWidthWall.BackColor = System.Drawing.Color.Transparent;
            this.labelWidthWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidthWall.Location = new System.Drawing.Point(6, 135);
            this.labelWidthWall.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWidthWall.Name = "labelWidthWall";
            this.labelWidthWall.Size = new System.Drawing.Size(160, 25);
            this.labelWidthWall.TabIndex = 16;
            this.labelWidthWall.Text = "Width of the wall:";
            // 
            // labelWidthSpace
            // 
            this.labelWidthSpace.AutoSize = true;
            this.labelWidthSpace.BackColor = System.Drawing.Color.Transparent;
            this.labelWidthSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidthSpace.Location = new System.Drawing.Point(6, 169);
            this.labelWidthSpace.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWidthSpace.Name = "labelWidthSpace";
            this.labelWidthSpace.Size = new System.Drawing.Size(147, 25);
            this.labelWidthSpace.TabIndex = 17;
            this.labelWidthSpace.Text = "Structure width:";
            // 
            // textBoxWidthWall
            // 
            this.textBoxWidthWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidthWall.Location = new System.Drawing.Point(212, 135);
            this.textBoxWidthWall.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWidthWall.Name = "textBoxWidthWall";
            this.textBoxWidthWall.Size = new System.Drawing.Size(98, 30);
            this.textBoxWidthWall.TabIndex = 18;
            // 
            // textBoxWidthStructure
            // 
            this.textBoxWidthStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWidthStructure.Location = new System.Drawing.Point(212, 169);
            this.textBoxWidthStructure.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxWidthStructure.Name = "textBoxWidthStructure";
            this.textBoxWidthStructure.Size = new System.Drawing.Size(98, 30);
            this.textBoxWidthStructure.TabIndex = 19;
            // 
            // labelFormParams
            // 
            this.labelFormParams.AutoSize = true;
            this.labelFormParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormParams.Location = new System.Drawing.Point(49, 0);
            this.labelFormParams.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelFormParams.Name = "labelFormParams";
            this.labelFormParams.Size = new System.Drawing.Size(241, 30);
            this.labelFormParams.TabIndex = 20;
            this.labelFormParams.Text = "Spiral parametres:";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClear.Location = new System.Drawing.Point(188, 655);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 32);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(407, 139);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(100, 32);
            this.buttonBrowse.TabIndex = 28;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Transparent;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(2, 76);
            this.labelA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(74, 25);
            this.labelA.TabIndex = 32;
            this.labelA.Text = "Side b:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.BackColor = System.Drawing.Color.Transparent;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(2, 44);
            this.labelB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(74, 25);
            this.labelB.TabIndex = 33;
            this.labelB.Text = "Side a:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.Transparent;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelC.Location = new System.Drawing.Point(3, 111);
            this.labelC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(73, 25);
            this.labelC.TabIndex = 34;
            this.labelC.Text = "Side c:";
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.BackColor = System.Drawing.Color.Transparent;
            this.labelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlpha.Location = new System.Drawing.Point(210, 44);
            this.labelAlpha.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(69, 25);
            this.labelAlpha.TabIndex = 35;
            this.labelAlpha.Text = "Alpha:";
            // 
            // labelBetta
            // 
            this.labelBetta.AutoSize = true;
            this.labelBetta.BackColor = System.Drawing.Color.Transparent;
            this.labelBetta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetta.Location = new System.Drawing.Point(210, 77);
            this.labelBetta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBetta.Name = "labelBetta";
            this.labelBetta.Size = new System.Drawing.Size(63, 25);
            this.labelBetta.TabIndex = 36;
            this.labelBetta.Text = "Betta:";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxA.Location = new System.Drawing.Point(88, 41);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(78, 30);
            this.textBoxA.TabIndex = 37;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxB.Location = new System.Drawing.Point(88, 75);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(78, 30);
            this.textBoxB.TabIndex = 38;
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC.Location = new System.Drawing.Point(88, 111);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(78, 30);
            this.textBoxC.TabIndex = 39;
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAlpha.Location = new System.Drawing.Point(297, 42);
            this.textBoxAlpha.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(78, 30);
            this.textBoxAlpha.TabIndex = 40;
            // 
            // textBoxBeta
            // 
            this.textBoxBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeta.Location = new System.Drawing.Point(297, 76);
            this.textBoxBeta.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxBeta.Name = "textBoxBeta";
            this.textBoxBeta.Size = new System.Drawing.Size(78, 30);
            this.textBoxBeta.TabIndex = 41;
            // 
            // labelHeading
            // 
            this.labelHeading.BackColor = System.Drawing.Color.ForestGreen;
            this.labelHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHeading.Location = new System.Drawing.Point(0, 0);
            this.labelHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(1110, 55);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Nanotube creator";
            this.labelHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Å";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Å";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Å";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Å";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Å";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Å";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(317, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Å";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(317, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 59;
            this.label11.Text = "Å";
            // 
            // labelOuterDiameter
            // 
            this.labelOuterDiameter.AutoSize = true;
            this.labelOuterDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOuterDiameter.Location = new System.Drawing.Point(6, 67);
            this.labelOuterDiameter.Name = "labelOuterDiameter";
            this.labelOuterDiameter.Size = new System.Drawing.Size(147, 25);
            this.labelOuterDiameter.TabIndex = 60;
            this.labelOuterDiameter.Text = "Outer diameter:";
            // 
            // textBoxOuterDiameter
            // 
            this.textBoxOuterDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOuterDiameter.Location = new System.Drawing.Point(212, 67);
            this.textBoxOuterDiameter.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxOuterDiameter.Name = "textBoxOuterDiameter";
            this.textBoxOuterDiameter.Size = new System.Drawing.Size(98, 30);
            this.textBoxOuterDiameter.TabIndex = 62;
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputFile.Location = new System.Drawing.Point(175, 73);
            this.textBoxInputFile.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxInputFile.Multiline = true;
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputFile.Size = new System.Drawing.Size(332, 57);
            this.textBoxInputFile.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(237, 25);
            this.label12.TabIndex = 65;
            this.label12.Text = "Choose input parameters:";
            // 
            // buttonLoadCrystal
            // 
            this.buttonLoadCrystal.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonLoadCrystal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadCrystal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoadCrystal.Location = new System.Drawing.Point(275, 150);
            this.buttonLoadCrystal.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonLoadCrystal.Name = "buttonLoadCrystal";
            this.buttonLoadCrystal.Size = new System.Drawing.Size(100, 32);
            this.buttonLoadCrystal.TabIndex = 66;
            this.buttonLoadCrystal.Text = "Load";
            this.buttonLoadCrystal.UseVisualStyleBackColor = false;
            this.buttonLoadCrystal.Click += new System.EventHandler(this.buttonLoadCrystal_Click);
            // 
            // buttonSaveCrystalParams
            // 
            this.buttonSaveCrystalParams.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSaveCrystalParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveCrystalParams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSaveCrystalParams.Location = new System.Drawing.Point(173, 150);
            this.buttonSaveCrystalParams.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonSaveCrystalParams.Name = "buttonSaveCrystalParams";
            this.buttonSaveCrystalParams.Size = new System.Drawing.Size(100, 32);
            this.buttonSaveCrystalParams.TabIndex = 67;
            this.buttonSaveCrystalParams.Text = "Save";
            this.buttonSaveCrystalParams.UseVisualStyleBackColor = false;
            this.buttonSaveCrystalParams.Click += new System.EventHandler(this.buttonSaveCrystalParams_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(-3, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 17);
            this.label13.TabIndex = 68;
            this.label13.Text = "Choose axis to build on:";
            // 
            // radioButtonXUp
            // 
            this.radioButtonXUp.AutoSize = true;
            this.radioButtonXUp.Checked = true;
            this.radioButtonXUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXUp.Location = new System.Drawing.Point(9, 20);
            this.radioButtonXUp.Name = "radioButtonXUp";
            this.radioButtonXUp.Size = new System.Drawing.Size(59, 21);
            this.radioButtonXUp.TabIndex = 70;
            this.radioButtonXUp.TabStop = true;
            this.radioButtonXUp.Text = "x up";
            this.radioButtonXUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonYUp
            // 
            this.radioButtonYUp.AutoSize = true;
            this.radioButtonYUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYUp.Location = new System.Drawing.Point(9, 47);
            this.radioButtonYUp.Name = "radioButtonYUp";
            this.radioButtonYUp.Size = new System.Drawing.Size(60, 21);
            this.radioButtonYUp.TabIndex = 71;
            this.radioButtonYUp.Text = "y up";
            this.radioButtonYUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonZUp
            // 
            this.radioButtonZUp.AutoSize = true;
            this.radioButtonZUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonZUp.Location = new System.Drawing.Point(9, 74);
            this.radioButtonZUp.Name = "radioButtonZUp";
            this.radioButtonZUp.Size = new System.Drawing.Size(60, 21);
            this.radioButtonZUp.TabIndex = 72;
            this.radioButtonZUp.Text = "z up";
            this.radioButtonZUp.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMult.Location = new System.Drawing.Point(15, 25);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(88, 21);
            this.radioButtonMult.TabIndex = 75;
            this.radioButtonMult.Text = "Multiples";
            this.radioButtonMult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMult.UseVisualStyleBackColor = true;
            this.radioButtonMult.CheckedChanged += new System.EventHandler(this.radioButtonMult_CheckedChanged);
            // 
            // radioButtonAngstroms
            // 
            this.radioButtonAngstroms.AutoSize = true;
            this.radioButtonAngstroms.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonAngstroms.Checked = true;
            this.radioButtonAngstroms.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAngstroms.Location = new System.Drawing.Point(3, 3);
            this.radioButtonAngstroms.Name = "radioButtonAngstroms";
            this.radioButtonAngstroms.Size = new System.Drawing.Size(100, 21);
            this.radioButtonAngstroms.TabIndex = 74;
            this.radioButtonAngstroms.TabStop = true;
            this.radioButtonAngstroms.Text = "Angstroms";
            this.radioButtonAngstroms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAngstroms.UseVisualStyleBackColor = true;
            this.radioButtonAngstroms.CheckedChanged += new System.EventHandler(this.radioButtonAngstroms_CheckedChanged);
            // 
            // panelUnits
            // 
            this.panelUnits.Controls.Add(this.radioButtonMult);
            this.panelUnits.Controls.Add(this.radioButtonAngstroms);
            this.panelUnits.Location = new System.Drawing.Point(11, 315);
            this.panelUnits.Name = "panelUnits";
            this.panelUnits.Size = new System.Drawing.Size(137, 49);
            this.panelUnits.TabIndex = 77;
            // 
            // panelAxes
            // 
            this.panelAxes.Controls.Add(this.radioButtonZBack);
            this.panelAxes.Controls.Add(this.radioButtonZFront);
            this.panelAxes.Controls.Add(this.radioButtonYBack);
            this.panelAxes.Controls.Add(this.radioButtonYFront);
            this.panelAxes.Controls.Add(this.radioButtonXBack);
            this.panelAxes.Controls.Add(this.radioButtonXFront);
            this.panelAxes.Controls.Add(this.radioButtonZDown);
            this.panelAxes.Controls.Add(this.radioButtonYDown);
            this.panelAxes.Controls.Add(this.radioButtonXDown);
            this.panelAxes.Controls.Add(this.radioButtonYUp);
            this.panelAxes.Controls.Add(this.label13);
            this.panelAxes.Controls.Add(this.radioButtonXUp);
            this.panelAxes.Controls.Add(this.radioButtonZUp);
            this.panelAxes.Location = new System.Drawing.Point(11, 208);
            this.panelAxes.Name = "panelAxes";
            this.panelAxes.Size = new System.Drawing.Size(347, 104);
            this.panelAxes.TabIndex = 78;
            // 
            // radioButtonZDown
            // 
            this.radioButtonZDown.AutoSize = true;
            this.radioButtonZDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonZDown.Location = new System.Drawing.Point(78, 74);
            this.radioButtonZDown.Name = "radioButtonZDown";
            this.radioButtonZDown.Size = new System.Drawing.Size(77, 21);
            this.radioButtonZDown.TabIndex = 75;
            this.radioButtonZDown.Text = "z down";
            this.radioButtonZDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonYDown
            // 
            this.radioButtonYDown.AutoSize = true;
            this.radioButtonYDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYDown.Location = new System.Drawing.Point(78, 47);
            this.radioButtonYDown.Name = "radioButtonYDown";
            this.radioButtonYDown.Size = new System.Drawing.Size(77, 21);
            this.radioButtonYDown.TabIndex = 74;
            this.radioButtonYDown.Text = "y down";
            this.radioButtonYDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonXDown
            // 
            this.radioButtonXDown.AutoSize = true;
            this.radioButtonXDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXDown.Location = new System.Drawing.Point(78, 20);
            this.radioButtonXDown.Name = "radioButtonXDown";
            this.radioButtonXDown.Size = new System.Drawing.Size(76, 21);
            this.radioButtonXDown.TabIndex = 73;
            this.radioButtonXDown.Text = "x down";
            this.radioButtonXDown.UseVisualStyleBackColor = true;
            // 
            // panelCrystal
            // 
            this.panelCrystal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCrystal.Controls.Add(this.labelCrystalParametres);
            this.panelCrystal.Controls.Add(this.labelGamma);
            this.panelCrystal.Controls.Add(this.textBoxGamma);
            this.panelCrystal.Controls.Add(this.labelA);
            this.panelCrystal.Controls.Add(this.labelB);
            this.panelCrystal.Controls.Add(this.buttonSaveCrystalParams);
            this.panelCrystal.Controls.Add(this.labelC);
            this.panelCrystal.Controls.Add(this.buttonLoadCrystal);
            this.panelCrystal.Controls.Add(this.labelAlpha);
            this.panelCrystal.Controls.Add(this.textBoxA);
            this.panelCrystal.Controls.Add(this.labelBetta);
            this.panelCrystal.Controls.Add(this.textBoxB);
            this.panelCrystal.Controls.Add(this.textBoxC);
            this.panelCrystal.Controls.Add(this.textBoxAlpha);
            this.panelCrystal.Controls.Add(this.textBoxBeta);
            this.panelCrystal.Controls.Add(this.pictureBoxCrystal);
            this.panelCrystal.Controls.Add(this.label9);
            this.panelCrystal.Controls.Add(this.label1);
            this.panelCrystal.Controls.Add(this.label8);
            this.panelCrystal.Controls.Add(this.label2);
            this.panelCrystal.Controls.Add(this.label7);
            this.panelCrystal.Controls.Add(this.label3);
            this.panelCrystal.Location = new System.Drawing.Point(626, 70);
            this.panelCrystal.MaximumSize = new System.Drawing.Size(1010, 382);
            this.panelCrystal.Name = "panelCrystal";
            this.panelCrystal.Size = new System.Drawing.Size(428, 191);
            this.panelCrystal.TabIndex = 79;
            // 
            // pictureBoxCrystal
            // 
            this.pictureBoxCrystal.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCrystal.Image = global::WindowsFormsApplication2.Properties.Resources.crystal;
            this.pictureBoxCrystal.Location = new System.Drawing.Point(0, 3);
            this.pictureBoxCrystal.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxCrystal.Name = "pictureBoxCrystal";
            this.pictureBoxCrystal.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxCrystal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCrystal.TabIndex = 46;
            this.pictureBoxCrystal.TabStop = false;
            this.pictureBoxCrystal.MouseLeave += new System.EventHandler(this.pictureBoxCrystal_MouseLeave);
            this.pictureBoxCrystal.MouseHover += new System.EventHandler(this.pictureBoxCrystal_MouseHover);
            // 
            // panelInput
            // 
            this.panelInput.AutoSize = true;
            this.panelInput.Controls.Add(this.labelForm);
            this.panelInput.Controls.Add(this.labelFile);
            this.panelInput.Controls.Add(this.comboBoxParams);
            this.panelInput.Controls.Add(this.label12);
            this.panelInput.Controls.Add(this.comboBoxForm);
            this.panelInput.Controls.Add(this.textBoxInputFile);
            this.panelInput.Controls.Add(this.buttonBrowse);
            this.panelInput.Location = new System.Drawing.Point(40, 73);
            this.panelInput.MaximumSize = new System.Drawing.Size(1200, 300);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(525, 180);
            this.panelInput.TabIndex = 68;
            // 
            // panelStructur
            // 
            this.panelStructur.AutoSize = true;
            this.panelStructur.Controls.Add(this.buttonSaveStructure);
            this.panelStructur.Controls.Add(this.pictureBoxStructure);
            this.panelStructur.Controls.Add(this.panelUnits);
            this.panelStructur.Controls.Add(this.panelAxes);
            this.panelStructur.Controls.Add(this.labelInnerDiameter);
            this.panelStructur.Controls.Add(this.textBoxWidthStructure);
            this.panelStructur.Controls.Add(this.labelLength);
            this.panelStructur.Controls.Add(this.buttonCreate);
            this.panelStructur.Controls.Add(this.textBoxWidthWall);
            this.panelStructur.Controls.Add(this.labelWidthSpace);
            this.panelStructur.Controls.Add(this.textBoxInnerDiameter);
            this.panelStructur.Controls.Add(this.labelWidthWall);
            this.panelStructur.Controls.Add(this.textBoxLength);
            this.panelStructur.Controls.Add(this.label10);
            this.panelStructur.Controls.Add(this.labelFormParams);
            this.panelStructur.Controls.Add(this.label4);
            this.panelStructur.Controls.Add(this.textBoxOuterDiameter);
            this.panelStructur.Controls.Add(this.label11);
            this.panelStructur.Controls.Add(this.label5);
            this.panelStructur.Controls.Add(this.labelOuterDiameter);
            this.panelStructur.Controls.Add(this.label6);
            this.panelStructur.Location = new System.Drawing.Point(31, 259);
            this.panelStructur.Name = "panelStructur";
            this.panelStructur.Size = new System.Drawing.Size(386, 379);
            this.panelStructur.TabIndex = 81;
            // 
            // buttonSaveStructure
            // 
            this.buttonSaveStructure.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSaveStructure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveStructure.Location = new System.Drawing.Point(262, 332);
            this.buttonSaveStructure.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonSaveStructure.Name = "buttonSaveStructure";
            this.buttonSaveStructure.Size = new System.Drawing.Size(100, 32);
            this.buttonSaveStructure.TabIndex = 79;
            this.buttonSaveStructure.Text = "Export";
            this.buttonSaveStructure.UseVisualStyleBackColor = false;
            this.buttonSaveStructure.Click += new System.EventHandler(this.buttonSaveStructure_Click);
            // 
            // pictureBoxStructure
            // 
            this.pictureBoxStructure.Image = global::WindowsFormsApplication2.Properties.Resources.spiral;
            this.pictureBoxStructure.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxStructure.Name = "pictureBoxStructure";
            this.pictureBoxStructure.Size = new System.Drawing.Size(45, 30);
            this.pictureBoxStructure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStructure.TabIndex = 63;
            this.pictureBoxStructure.TabStop = false;
            this.pictureBoxStructure.MouseLeave += new System.EventHandler(this.pictureBoxStructure_MouseLeave);
            this.pictureBoxStructure.MouseHover += new System.EventHandler(this.pictureBoxStructure_MouseHover);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(500, 3);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 32);
            this.buttonReset.TabIndex = 79;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBoxAxes
            // 
            this.checkBoxAxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAxes.AutoSize = true;
            this.checkBoxAxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAxes.Location = new System.Drawing.Point(205, 7);
            this.checkBoxAxes.Name = "checkBoxAxes";
            this.checkBoxAxes.Size = new System.Drawing.Size(70, 24);
            this.checkBoxAxes.TabIndex = 82;
            this.checkBoxAxes.Text = "Axes";
            this.checkBoxAxes.UseVisualStyleBackColor = true;
            this.checkBoxAxes.CheckedChanged += new System.EventHandler(this.checkBoxAxes_CheckedChanged);
            // 
            // checkBoxFullSize
            // 
            this.checkBoxFullSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFullSize.AutoSize = true;
            this.checkBoxFullSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFullSize.Location = new System.Drawing.Point(363, 8);
            this.checkBoxFullSize.Name = "checkBoxFullSize";
            this.checkBoxFullSize.Size = new System.Drawing.Size(92, 24);
            this.checkBoxFullSize.TabIndex = 83;
            this.checkBoxFullSize.Text = "Full size";
            this.checkBoxFullSize.UseVisualStyleBackColor = true;
            this.checkBoxFullSize.CheckedChanged += new System.EventHandler(this.checkBoxFullSize_CheckedChanged);
            // 
            // trackBarPointSize
            // 
            this.trackBarPointSize.AutoSize = false;
            this.trackBarPointSize.Location = new System.Drawing.Point(80, 3);
            this.trackBarPointSize.Name = "trackBarPointSize";
            this.trackBarPointSize.Size = new System.Drawing.Size(119, 69);
            this.trackBarPointSize.TabIndex = 84;
            this.trackBarPointSize.Scroll += new System.EventHandler(this.trackBarPointSize_Scroll);
            // 
            // labelPointSize
            // 
            this.labelPointSize.AutoSize = true;
            this.labelPointSize.BackColor = System.Drawing.Color.Transparent;
            this.labelPointSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPointSize.Location = new System.Drawing.Point(6, 8);
            this.labelPointSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPointSize.Name = "labelPointSize";
            this.labelPointSize.Size = new System.Drawing.Size(81, 20);
            this.labelPointSize.TabIndex = 66;
            this.labelPointSize.Text = "Point size:";
            // 
            // checkBoxOrigin
            // 
            this.checkBoxOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOrigin.AutoSize = true;
            this.checkBoxOrigin.Checked = true;
            this.checkBoxOrigin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrigin.Location = new System.Drawing.Point(281, 7);
            this.checkBoxOrigin.Name = "checkBoxOrigin";
            this.checkBoxOrigin.Size = new System.Drawing.Size(76, 24);
            this.checkBoxOrigin.TabIndex = 85;
            this.checkBoxOrigin.Text = "Origin";
            this.checkBoxOrigin.UseVisualStyleBackColor = true;
            this.checkBoxOrigin.CheckedChanged += new System.EventHandler(this.checkBoxOrigin_CheckedChanged);
            // 
            // panelControlTools
            // 
            this.panelControlTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlTools.Controls.Add(this.textBoxInfo);
            this.panelControlTools.Controls.Add(this.buttonReset);
            this.panelControlTools.Controls.Add(this.checkBoxOrigin);
            this.panelControlTools.Controls.Add(this.checkBoxAxes);
            this.panelControlTools.Controls.Add(this.checkBoxFullSize);
            this.panelControlTools.Controls.Add(this.labelPointSize);
            this.panelControlTools.Controls.Add(this.trackBarPointSize);
            this.panelControlTools.Location = new System.Drawing.Point(454, 620);
            this.panelControlTools.Name = "panelControlTools";
            this.panelControlTools.Size = new System.Drawing.Size(600, 76);
            this.panelControlTools.TabIndex = 86;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfo.Location = new System.Drawing.Point(0, 36);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(600, 41);
            this.textBoxInfo.TabIndex = 86;
            this.textBoxInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInfo_KeyDown);
            this.textBoxInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInfo_KeyPress);
            // 
            // checkBoxViewMode
            // 
            this.checkBoxViewMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxViewMode.AutoSize = true;
            this.checkBoxViewMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxViewMode.Location = new System.Drawing.Point(20, 663);
            this.checkBoxViewMode.Name = "checkBoxViewMode";
            this.checkBoxViewMode.Size = new System.Drawing.Size(113, 24);
            this.checkBoxViewMode.TabIndex = 90;
            this.checkBoxViewMode.Text = "View mode";
            this.checkBoxViewMode.UseVisualStyleBackColor = true;
            this.checkBoxViewMode.CheckedChanged += new System.EventHandler(this.checkBoxViewMode_CheckedChanged);
            // 
            // buttonLoadView
            // 
            this.buttonLoadView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoadView.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonLoadView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoadView.Location = new System.Drawing.Point(296, 655);
            this.buttonLoadView.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.buttonLoadView.Name = "buttonLoadView";
            this.buttonLoadView.Size = new System.Drawing.Size(100, 32);
            this.buttonLoadView.TabIndex = 91;
            this.buttonLoadView.Text = "Load";
            this.buttonLoadView.UseVisualStyleBackColor = false;
            this.buttonLoadView.Click += new System.EventHandler(this.buttonLoadView_Click);
            // 
            // radioButtonXFront
            // 
            this.radioButtonXFront.AutoSize = true;
            this.radioButtonXFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXFront.Location = new System.Drawing.Point(164, 20);
            this.radioButtonXFront.Name = "radioButtonXFront";
            this.radioButtonXFront.Size = new System.Drawing.Size(72, 21);
            this.radioButtonXFront.TabIndex = 92;
            this.radioButtonXFront.TabStop = true;
            this.radioButtonXFront.Text = "x front";
            this.radioButtonXFront.UseVisualStyleBackColor = true;
            // 
            // radioButtonXBack
            // 
            this.radioButtonXBack.AutoSize = true;
            this.radioButtonXBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXBack.Location = new System.Drawing.Point(254, 20);
            this.radioButtonXBack.Name = "radioButtonXBack";
            this.radioButtonXBack.Size = new System.Drawing.Size(73, 21);
            this.radioButtonXBack.TabIndex = 93;
            this.radioButtonXBack.TabStop = true;
            this.radioButtonXBack.Text = "x back";
            this.radioButtonXBack.UseVisualStyleBackColor = true;
            // 
            // radioButtonYFront
            // 
            this.radioButtonYFront.AutoSize = true;
            this.radioButtonYFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYFront.Location = new System.Drawing.Point(163, 47);
            this.radioButtonYFront.Name = "radioButtonYFront";
            this.radioButtonYFront.Size = new System.Drawing.Size(73, 21);
            this.radioButtonYFront.TabIndex = 94;
            this.radioButtonYFront.TabStop = true;
            this.radioButtonYFront.Text = "y front";
            this.radioButtonYFront.UseVisualStyleBackColor = true;
            // 
            // radioButtonYBack
            // 
            this.radioButtonYBack.AutoSize = true;
            this.radioButtonYBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYBack.Location = new System.Drawing.Point(254, 47);
            this.radioButtonYBack.Name = "radioButtonYBack";
            this.radioButtonYBack.Size = new System.Drawing.Size(74, 21);
            this.radioButtonYBack.TabIndex = 95;
            this.radioButtonYBack.TabStop = true;
            this.radioButtonYBack.Text = "y back";
            this.radioButtonYBack.UseVisualStyleBackColor = true;
            // 
            // radioButtonZFront
            // 
            this.radioButtonZFront.AutoSize = true;
            this.radioButtonZFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonZFront.Location = new System.Drawing.Point(163, 74);
            this.radioButtonZFront.Name = "radioButtonZFront";
            this.radioButtonZFront.Size = new System.Drawing.Size(73, 21);
            this.radioButtonZFront.TabIndex = 96;
            this.radioButtonZFront.TabStop = true;
            this.radioButtonZFront.Text = "z front";
            this.radioButtonZFront.UseVisualStyleBackColor = true;
            // 
            // radioButtonZBack
            // 
            this.radioButtonZBack.AutoSize = true;
            this.radioButtonZBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonZBack.Location = new System.Drawing.Point(254, 74);
            this.radioButtonZBack.Name = "radioButtonZBack";
            this.radioButtonZBack.Size = new System.Drawing.Size(74, 21);
            this.radioButtonZBack.TabIndex = 97;
            this.radioButtonZBack.TabStop = true;
            this.radioButtonZBack.Text = "z back";
            this.radioButtonZBack.UseVisualStyleBackColor = true;
            // 
            // CreatorWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1110, 699);
            this.Controls.Add(this.checkBoxViewMode);
            this.Controls.Add(this.buttonLoadView);
            this.Controls.Add(this.panelControlTools);
            this.Controls.Add(this.panelCrystal);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.panelStructur);
            this.Controls.Add(this.glControlPlot);
            this.Controls.Add(this.panelInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CreatorWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nanotube creator";
            this.Load += new System.EventHandler(this.CreatorWindow_Load);
            this.panelUnits.ResumeLayout(false);
            this.panelUnits.PerformLayout();
            this.panelAxes.ResumeLayout(false);
            this.panelAxes.PerformLayout();
            this.panelCrystal.ResumeLayout(false);
            this.panelCrystal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrystal)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelStructur.ResumeLayout(false);
            this.panelStructur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPointSize)).EndInit();
            this.panelControlTools.ResumeLayout(false);
            this.panelControlTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControlPlot;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelCrystalParametres;
        private System.Windows.Forms.Label labelInnerDiameter;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.TextBox textBoxInnerDiameter;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.ComboBox comboBoxParams;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.Label labelWidthWall;
        private System.Windows.Forms.Label labelWidthSpace;
        private System.Windows.Forms.TextBox textBoxWidthWall;
        private System.Windows.Forms.TextBox textBoxWidthStructure;
        private System.Windows.Forms.Label labelFormParams;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.Label labelBetta;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxAlpha;
        private System.Windows.Forms.TextBox textBoxBeta;
        private System.Windows.Forms.PictureBox pictureBoxCrystal;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelOuterDiameter;
        private System.Windows.Forms.TextBox textBoxOuterDiameter;
        private System.Windows.Forms.PictureBox pictureBoxStructure;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonLoadCrystal;
        private System.Windows.Forms.Button buttonSaveCrystalParams;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonXUp;
        private System.Windows.Forms.RadioButton radioButtonYUp;
        private System.Windows.Forms.RadioButton radioButtonZUp;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RadioButton radioButtonMult;
        private System.Windows.Forms.RadioButton radioButtonAngstroms;
        private System.Windows.Forms.Panel panelUnits;
        private System.Windows.Forms.Panel panelAxes;
        private System.Windows.Forms.Panel panelCrystal;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelStructur;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxAxes;
        private System.Windows.Forms.CheckBox checkBoxFullSize;
        private System.Windows.Forms.Button buttonSaveStructure;
        private System.Windows.Forms.TrackBar trackBarPointSize;
        private System.Windows.Forms.Label labelPointSize;
        private System.Windows.Forms.CheckBox checkBoxOrigin;
        private System.Windows.Forms.Panel panelControlTools;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonZDown;
        private System.Windows.Forms.RadioButton radioButtonYDown;
        private System.Windows.Forms.RadioButton radioButtonXDown;
        private System.Windows.Forms.CheckBox checkBoxViewMode;
        private System.Windows.Forms.Button buttonLoadView;
        private System.Windows.Forms.RadioButton radioButtonYBack;
        private System.Windows.Forms.RadioButton radioButtonYFront;
        private System.Windows.Forms.RadioButton radioButtonXBack;
        private System.Windows.Forms.RadioButton radioButtonXFront;
        private System.Windows.Forms.RadioButton radioButtonZBack;
        private System.Windows.Forms.RadioButton radioButtonZFront;
    }
}