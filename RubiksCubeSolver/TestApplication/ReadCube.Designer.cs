namespace TestApplication
{
    partial class ReadCube
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadCube));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSelectCamera = new System.Windows.Forms.Button();
            this.SP = new System.IO.Ports.SerialPort(this.components);
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdInit = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.rtc = new System.Windows.Forms.RichTextBox();
            this.ULU = new System.Windows.Forms.Panel();
            this.UU = new System.Windows.Forms.Panel();
            this.URU = new System.Windows.Forms.Panel();
            this.UL = new System.Windows.Forms.Panel();
            this.UC = new System.Windows.Forms.Panel();
            this.UR = new System.Windows.Forms.Panel();
            this.ULD = new System.Windows.Forms.Panel();
            this.UD = new System.Windows.Forms.Panel();
            this.URD = new System.Windows.Forms.Panel();
            this.FRD = new System.Windows.Forms.Panel();
            this.FD = new System.Windows.Forms.Panel();
            this.FLD = new System.Windows.Forms.Panel();
            this.FR = new System.Windows.Forms.Panel();
            this.FC = new System.Windows.Forms.Panel();
            this.FL = new System.Windows.Forms.Panel();
            this.FRU = new System.Windows.Forms.Panel();
            this.FU = new System.Windows.Forms.Panel();
            this.FLU = new System.Windows.Forms.Panel();
            this.RRD = new System.Windows.Forms.Panel();
            this.RD = new System.Windows.Forms.Panel();
            this.RLD = new System.Windows.Forms.Panel();
            this.RR = new System.Windows.Forms.Panel();
            this.RC = new System.Windows.Forms.Panel();
            this.RL = new System.Windows.Forms.Panel();
            this.RRU = new System.Windows.Forms.Panel();
            this.RU = new System.Windows.Forms.Panel();
            this.RLU = new System.Windows.Forms.Panel();
            this.BRD = new System.Windows.Forms.Panel();
            this.BD = new System.Windows.Forms.Panel();
            this.BLD = new System.Windows.Forms.Panel();
            this.BR = new System.Windows.Forms.Panel();
            this.BC = new System.Windows.Forms.Panel();
            this.BL = new System.Windows.Forms.Panel();
            this.BRU = new System.Windows.Forms.Panel();
            this.BU = new System.Windows.Forms.Panel();
            this.BLU = new System.Windows.Forms.Panel();
            this.LRD = new System.Windows.Forms.Panel();
            this.LD = new System.Windows.Forms.Panel();
            this.LLD = new System.Windows.Forms.Panel();
            this.LR = new System.Windows.Forms.Panel();
            this.LC = new System.Windows.Forms.Panel();
            this.LL = new System.Windows.Forms.Panel();
            this.LRU = new System.Windows.Forms.Panel();
            this.LU = new System.Windows.Forms.Panel();
            this.LLU = new System.Windows.Forms.Panel();
            this.DRD = new System.Windows.Forms.Panel();
            this.DD = new System.Windows.Forms.Panel();
            this.DLD = new System.Windows.Forms.Panel();
            this.DR = new System.Windows.Forms.Panel();
            this.DC = new System.Windows.Forms.Panel();
            this.DL = new System.Windows.Forms.Panel();
            this.DRU = new System.Windows.Forms.Panel();
            this.DU = new System.Windows.Forms.Panel();
            this.DLU = new System.Windows.Forms.Panel();
            this.cmdRead = new System.Windows.Forms.Button();
            this.cmdAutoinit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdSolve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtreadPattern = new System.Windows.Forms.TextBox();
            this.txtSolvedPattern = new System.Windows.Forms.TextBox();
            this.txtarstring = new System.Windows.Forms.TextBox();
            this.cmdsend = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.cmdl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage.BackgroundImage")));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(12, 274);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(258, 231);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cemara";
            // 
            // cmdSelectCamera
            // 
            this.cmdSelectCamera.Location = new System.Drawing.Point(26, 50);
            this.cmdSelectCamera.Name = "cmdSelectCamera";
            this.cmdSelectCamera.Size = new System.Drawing.Size(117, 34);
            this.cmdSelectCamera.TabIndex = 3;
            this.cmdSelectCamera.Text = "Select Camera";
            this.cmdSelectCamera.UseVisualStyleBackColor = true;
            this.cmdSelectCamera.Click += new System.EventHandler(this.cmdSelectCamera_Click);
            // 
            // SP
            // 
            this.SP.PortName = "COM10";
            this.SP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SP_DataReceived);
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(149, 50);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(121, 34);
            this.cmdConnect.TabIndex = 4;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdInit
            // 
            this.cmdInit.Enabled = false;
            this.cmdInit.Location = new System.Drawing.Point(26, 90);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(117, 34);
            this.cmdInit.TabIndex = 5;
            this.cmdInit.Text = "Initialize";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Enabled = false;
            this.cmdOK.Location = new System.Drawing.Point(149, 90);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(121, 34);
            this.cmdOK.TabIndex = 6;
            this.cmdOK.Text = "Done";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // rtc
            // 
            this.rtc.Location = new System.Drawing.Point(11, 19);
            this.rtc.Name = "rtc";
            this.rtc.Size = new System.Drawing.Size(345, 122);
            this.rtc.TabIndex = 7;
            this.rtc.Text = "";
            // 
            // ULU
            // 
            this.ULU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ULU.Location = new System.Drawing.Point(463, 259);
            this.ULU.Name = "ULU";
            this.ULU.Size = new System.Drawing.Size(22, 22);
            this.ULU.TabIndex = 8;
            // 
            // UU
            // 
            this.UU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UU.Location = new System.Drawing.Point(491, 259);
            this.UU.Name = "UU";
            this.UU.Size = new System.Drawing.Size(22, 22);
            this.UU.TabIndex = 9;
            // 
            // URU
            // 
            this.URU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URU.Location = new System.Drawing.Point(519, 259);
            this.URU.Name = "URU";
            this.URU.Size = new System.Drawing.Size(22, 22);
            this.URU.TabIndex = 9;
            // 
            // UL
            // 
            this.UL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UL.Location = new System.Drawing.Point(463, 287);
            this.UL.Name = "UL";
            this.UL.Size = new System.Drawing.Size(22, 22);
            this.UL.TabIndex = 9;
            // 
            // UC
            // 
            this.UC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UC.Location = new System.Drawing.Point(491, 287);
            this.UC.Name = "UC";
            this.UC.Size = new System.Drawing.Size(22, 22);
            this.UC.TabIndex = 9;
            // 
            // UR
            // 
            this.UR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UR.Location = new System.Drawing.Point(519, 287);
            this.UR.Name = "UR";
            this.UR.Size = new System.Drawing.Size(22, 22);
            this.UR.TabIndex = 9;
            // 
            // ULD
            // 
            this.ULD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ULD.Location = new System.Drawing.Point(463, 315);
            this.ULD.Name = "ULD";
            this.ULD.Size = new System.Drawing.Size(22, 22);
            this.ULD.TabIndex = 10;
            // 
            // UD
            // 
            this.UD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UD.Location = new System.Drawing.Point(491, 315);
            this.UD.Name = "UD";
            this.UD.Size = new System.Drawing.Size(22, 22);
            this.UD.TabIndex = 9;
            // 
            // URD
            // 
            this.URD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URD.Location = new System.Drawing.Point(519, 315);
            this.URD.Name = "URD";
            this.URD.Size = new System.Drawing.Size(22, 22);
            this.URD.TabIndex = 9;
            // 
            // FRD
            // 
            this.FRD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRD.Location = new System.Drawing.Point(519, 405);
            this.FRD.Name = "FRD";
            this.FRD.Size = new System.Drawing.Size(22, 22);
            this.FRD.TabIndex = 12;
            // 
            // FD
            // 
            this.FD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FD.Location = new System.Drawing.Point(491, 405);
            this.FD.Name = "FD";
            this.FD.Size = new System.Drawing.Size(22, 22);
            this.FD.TabIndex = 13;
            // 
            // FLD
            // 
            this.FLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLD.Location = new System.Drawing.Point(463, 405);
            this.FLD.Name = "FLD";
            this.FLD.Size = new System.Drawing.Size(22, 22);
            this.FLD.TabIndex = 19;
            // 
            // FR
            // 
            this.FR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FR.Location = new System.Drawing.Point(519, 377);
            this.FR.Name = "FR";
            this.FR.Size = new System.Drawing.Size(22, 22);
            this.FR.TabIndex = 14;
            // 
            // FC
            // 
            this.FC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FC.Location = new System.Drawing.Point(491, 377);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(22, 22);
            this.FC.TabIndex = 15;
            // 
            // FL
            // 
            this.FL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FL.Location = new System.Drawing.Point(463, 377);
            this.FL.Name = "FL";
            this.FL.Size = new System.Drawing.Size(22, 22);
            this.FL.TabIndex = 16;
            // 
            // FRU
            // 
            this.FRU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FRU.Location = new System.Drawing.Point(519, 349);
            this.FRU.Name = "FRU";
            this.FRU.Size = new System.Drawing.Size(22, 22);
            this.FRU.TabIndex = 17;
            // 
            // FU
            // 
            this.FU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FU.Location = new System.Drawing.Point(491, 349);
            this.FU.Name = "FU";
            this.FU.Size = new System.Drawing.Size(22, 22);
            this.FU.TabIndex = 18;
            // 
            // FLU
            // 
            this.FLU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLU.Location = new System.Drawing.Point(463, 349);
            this.FLU.Name = "FLU";
            this.FLU.Size = new System.Drawing.Size(22, 22);
            this.FLU.TabIndex = 11;
            // 
            // RRD
            // 
            this.RRD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RRD.Location = new System.Drawing.Point(616, 405);
            this.RRD.Name = "RRD";
            this.RRD.Size = new System.Drawing.Size(22, 22);
            this.RRD.TabIndex = 12;
            // 
            // RD
            // 
            this.RD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RD.Location = new System.Drawing.Point(588, 405);
            this.RD.Name = "RD";
            this.RD.Size = new System.Drawing.Size(22, 22);
            this.RD.TabIndex = 13;
            // 
            // RLD
            // 
            this.RLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RLD.Location = new System.Drawing.Point(560, 405);
            this.RLD.Name = "RLD";
            this.RLD.Size = new System.Drawing.Size(22, 22);
            this.RLD.TabIndex = 19;
            // 
            // RR
            // 
            this.RR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RR.Location = new System.Drawing.Point(616, 377);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(22, 22);
            this.RR.TabIndex = 14;
            // 
            // RC
            // 
            this.RC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RC.Location = new System.Drawing.Point(588, 377);
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(22, 22);
            this.RC.TabIndex = 15;
            // 
            // RL
            // 
            this.RL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RL.Location = new System.Drawing.Point(560, 377);
            this.RL.Name = "RL";
            this.RL.Size = new System.Drawing.Size(22, 22);
            this.RL.TabIndex = 16;
            // 
            // RRU
            // 
            this.RRU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RRU.Location = new System.Drawing.Point(616, 349);
            this.RRU.Name = "RRU";
            this.RRU.Size = new System.Drawing.Size(22, 22);
            this.RRU.TabIndex = 17;
            // 
            // RU
            // 
            this.RU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RU.Location = new System.Drawing.Point(588, 349);
            this.RU.Name = "RU";
            this.RU.Size = new System.Drawing.Size(22, 22);
            this.RU.TabIndex = 18;
            // 
            // RLU
            // 
            this.RLU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RLU.Location = new System.Drawing.Point(560, 349);
            this.RLU.Name = "RLU";
            this.RLU.Size = new System.Drawing.Size(22, 22);
            this.RLU.TabIndex = 11;
            // 
            // BRD
            // 
            this.BRD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BRD.Location = new System.Drawing.Point(710, 405);
            this.BRD.Name = "BRD";
            this.BRD.Size = new System.Drawing.Size(22, 22);
            this.BRD.TabIndex = 12;
            // 
            // BD
            // 
            this.BD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BD.Location = new System.Drawing.Point(682, 405);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(22, 22);
            this.BD.TabIndex = 13;
            // 
            // BLD
            // 
            this.BLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BLD.Location = new System.Drawing.Point(654, 405);
            this.BLD.Name = "BLD";
            this.BLD.Size = new System.Drawing.Size(22, 22);
            this.BLD.TabIndex = 19;
            // 
            // BR
            // 
            this.BR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BR.Location = new System.Drawing.Point(710, 377);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(22, 22);
            this.BR.TabIndex = 14;
            // 
            // BC
            // 
            this.BC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BC.Location = new System.Drawing.Point(682, 377);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(22, 22);
            this.BC.TabIndex = 15;
            // 
            // BL
            // 
            this.BL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BL.Location = new System.Drawing.Point(654, 377);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(22, 22);
            this.BL.TabIndex = 16;
            // 
            // BRU
            // 
            this.BRU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BRU.Location = new System.Drawing.Point(710, 349);
            this.BRU.Name = "BRU";
            this.BRU.Size = new System.Drawing.Size(22, 22);
            this.BRU.TabIndex = 17;
            // 
            // BU
            // 
            this.BU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BU.Location = new System.Drawing.Point(682, 349);
            this.BU.Name = "BU";
            this.BU.Size = new System.Drawing.Size(22, 22);
            this.BU.TabIndex = 18;
            // 
            // BLU
            // 
            this.BLU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BLU.Location = new System.Drawing.Point(654, 349);
            this.BLU.Name = "BLU";
            this.BLU.Size = new System.Drawing.Size(22, 22);
            this.BLU.TabIndex = 11;
            // 
            // LRD
            // 
            this.LRD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LRD.Location = new System.Drawing.Point(425, 405);
            this.LRD.Name = "LRD";
            this.LRD.Size = new System.Drawing.Size(22, 22);
            this.LRD.TabIndex = 12;
            // 
            // LD
            // 
            this.LD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LD.Location = new System.Drawing.Point(397, 405);
            this.LD.Name = "LD";
            this.LD.Size = new System.Drawing.Size(22, 22);
            this.LD.TabIndex = 13;
            // 
            // LLD
            // 
            this.LLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LLD.Location = new System.Drawing.Point(369, 405);
            this.LLD.Name = "LLD";
            this.LLD.Size = new System.Drawing.Size(22, 22);
            this.LLD.TabIndex = 19;
            // 
            // LR
            // 
            this.LR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LR.Location = new System.Drawing.Point(425, 377);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(22, 22);
            this.LR.TabIndex = 14;
            // 
            // LC
            // 
            this.LC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LC.Location = new System.Drawing.Point(397, 377);
            this.LC.Name = "LC";
            this.LC.Size = new System.Drawing.Size(22, 22);
            this.LC.TabIndex = 15;
            // 
            // LL
            // 
            this.LL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LL.Location = new System.Drawing.Point(369, 377);
            this.LL.Name = "LL";
            this.LL.Size = new System.Drawing.Size(22, 22);
            this.LL.TabIndex = 16;
            // 
            // LRU
            // 
            this.LRU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LRU.Location = new System.Drawing.Point(425, 349);
            this.LRU.Name = "LRU";
            this.LRU.Size = new System.Drawing.Size(22, 22);
            this.LRU.TabIndex = 17;
            // 
            // LU
            // 
            this.LU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LU.Location = new System.Drawing.Point(397, 349);
            this.LU.Name = "LU";
            this.LU.Size = new System.Drawing.Size(22, 22);
            this.LU.TabIndex = 18;
            // 
            // LLU
            // 
            this.LLU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LLU.Location = new System.Drawing.Point(369, 349);
            this.LLU.Name = "LLU";
            this.LLU.Size = new System.Drawing.Size(22, 22);
            this.LLU.TabIndex = 11;
            // 
            // DRD
            // 
            this.DRD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DRD.Location = new System.Drawing.Point(519, 500);
            this.DRD.Name = "DRD";
            this.DRD.Size = new System.Drawing.Size(22, 22);
            this.DRD.TabIndex = 12;
            // 
            // DD
            // 
            this.DD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DD.Location = new System.Drawing.Point(491, 500);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(22, 22);
            this.DD.TabIndex = 13;
            // 
            // DLD
            // 
            this.DLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DLD.Location = new System.Drawing.Point(463, 500);
            this.DLD.Name = "DLD";
            this.DLD.Size = new System.Drawing.Size(22, 22);
            this.DLD.TabIndex = 19;
            // 
            // DR
            // 
            this.DR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DR.Location = new System.Drawing.Point(519, 472);
            this.DR.Name = "DR";
            this.DR.Size = new System.Drawing.Size(22, 22);
            this.DR.TabIndex = 14;
            // 
            // DC
            // 
            this.DC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DC.Location = new System.Drawing.Point(491, 472);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(22, 22);
            this.DC.TabIndex = 15;
            // 
            // DL
            // 
            this.DL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DL.Location = new System.Drawing.Point(463, 472);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(22, 22);
            this.DL.TabIndex = 16;
            // 
            // DRU
            // 
            this.DRU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DRU.Location = new System.Drawing.Point(519, 444);
            this.DRU.Name = "DRU";
            this.DRU.Size = new System.Drawing.Size(22, 22);
            this.DRU.TabIndex = 17;
            // 
            // DU
            // 
            this.DU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DU.Location = new System.Drawing.Point(491, 444);
            this.DU.Name = "DU";
            this.DU.Size = new System.Drawing.Size(22, 22);
            this.DU.TabIndex = 18;
            // 
            // DLU
            // 
            this.DLU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DLU.Location = new System.Drawing.Point(463, 444);
            this.DLU.Name = "DLU";
            this.DLU.Size = new System.Drawing.Size(22, 22);
            this.DLU.TabIndex = 11;
            // 
            // cmdRead
            // 
            this.cmdRead.Enabled = false;
            this.cmdRead.Location = new System.Drawing.Point(149, 130);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(121, 34);
            this.cmdRead.TabIndex = 20;
            this.cmdRead.Text = "Read";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // cmdAutoinit
            // 
            this.cmdAutoinit.Enabled = false;
            this.cmdAutoinit.Location = new System.Drawing.Point(26, 130);
            this.cmdAutoinit.Name = "cmdAutoinit";
            this.cmdAutoinit.Size = new System.Drawing.Size(117, 34);
            this.cmdAutoinit.TabIndex = 21;
            this.cmdAutoinit.Text = "Auto init";
            this.cmdAutoinit.UseVisualStyleBackColor = true;
            this.cmdAutoinit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtc);
            this.groupBox1.Location = new System.Drawing.Point(276, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 149);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Read";
            // 
            // cmdSolve
            // 
            this.cmdSolve.Location = new System.Drawing.Point(26, 170);
            this.cmdSolve.Name = "cmdSolve";
            this.cmdSolve.Size = new System.Drawing.Size(117, 34);
            this.cmdSolve.TabIndex = 23;
            this.cmdSolve.Text = "Solve";
            this.cmdSolve.UseVisualStyleBackColor = true;
            this.cmdSolve.Click += new System.EventHandler(this.cmdSolve_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "RandPattern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtreadPattern
            // 
            this.txtreadPattern.Location = new System.Drawing.Point(286, 12);
            this.txtreadPattern.Name = "txtreadPattern";
            this.txtreadPattern.Size = new System.Drawing.Size(588, 20);
            this.txtreadPattern.TabIndex = 25;
            // 
            // txtSolvedPattern
            // 
            this.txtSolvedPattern.Location = new System.Drawing.Point(287, 38);
            this.txtSolvedPattern.Name = "txtSolvedPattern";
            this.txtSolvedPattern.Size = new System.Drawing.Size(588, 20);
            this.txtSolvedPattern.TabIndex = 26;
            // 
            // txtarstring
            // 
            this.txtarstring.Location = new System.Drawing.Point(287, 64);
            this.txtarstring.Name = "txtarstring";
            this.txtarstring.Size = new System.Drawing.Size(588, 20);
            this.txtarstring.TabIndex = 27;
            // 
            // cmdsend
            // 
            this.cmdsend.Location = new System.Drawing.Point(149, 170);
            this.cmdsend.Name = "cmdsend";
            this.cmdsend.Size = new System.Drawing.Size(121, 34);
            this.cmdsend.TabIndex = 28;
            this.cmdsend.Text = "Tell Bot";
            this.cmdsend.UseVisualStyleBackColor = true;
            this.cmdsend.Click += new System.EventHandler(this.cmdsend_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "Tell Bot I to I";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdl
            // 
            this.cmdl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.cmdl.Name = "cmdl";
            this.cmdl.Size = new System.Drawing.Size(153, 158);
            this.cmdl.Text = "Select Color";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Red";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem2.Text = "Blue";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem3.Text = "Green";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem4.Text = "Orange";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem5.Text = "Yellow";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem6.Text = "White";
            // 
            // ReadCube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdsend);
            this.Controls.Add(this.txtarstring);
            this.Controls.Add(this.txtSolvedPattern);
            this.Controls.Add(this.txtreadPattern);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdSolve);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAutoinit);
            this.Controls.Add(this.cmdRead);
            this.Controls.Add(this.DRD);
            this.Controls.Add(this.LRD);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.BRD);
            this.Controls.Add(this.DLD);
            this.Controls.Add(this.LD);
            this.Controls.Add(this.DR);
            this.Controls.Add(this.RRD);
            this.Controls.Add(this.DC);
            this.Controls.Add(this.LLD);
            this.Controls.Add(this.DL);
            this.Controls.Add(this.BD);
            this.Controls.Add(this.DRU);
            this.Controls.Add(this.LR);
            this.Controls.Add(this.DU);
            this.Controls.Add(this.FRD);
            this.Controls.Add(this.DLU);
            this.Controls.Add(this.LC);
            this.Controls.Add(this.BLD);
            this.Controls.Add(this.LL);
            this.Controls.Add(this.RD);
            this.Controls.Add(this.LRU);
            this.Controls.Add(this.BR);
            this.Controls.Add(this.LU);
            this.Controls.Add(this.URD);
            this.Controls.Add(this.LLU);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.RLD);
            this.Controls.Add(this.BL);
            this.Controls.Add(this.FD);
            this.Controls.Add(this.BRU);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.BU);
            this.Controls.Add(this.UD);
            this.Controls.Add(this.BLU);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.FLD);
            this.Controls.Add(this.RL);
            this.Controls.Add(this.ULD);
            this.Controls.Add(this.RRU);
            this.Controls.Add(this.FR);
            this.Controls.Add(this.RU);
            this.Controls.Add(this.UR);
            this.Controls.Add(this.RLU);
            this.Controls.Add(this.FC);
            this.Controls.Add(this.UC);
            this.Controls.Add(this.FL);
            this.Controls.Add(this.UL);
            this.Controls.Add(this.FRU);
            this.Controls.Add(this.URU);
            this.Controls.Add(this.FU);
            this.Controls.Add(this.UU);
            this.Controls.Add(this.FLU);
            this.Controls.Add(this.ULU);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.cmdSelectCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pbImage);
            this.Name = "ReadCube";
            this.Text = "ReadCube";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.cmdl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSelectCamera;
        private System.IO.Ports.SerialPort SP;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdInit;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.RichTextBox rtc;
        private System.Windows.Forms.Panel ULU;
        private System.Windows.Forms.Panel UU;
        private System.Windows.Forms.Panel URU;
        private System.Windows.Forms.Panel UL;
        private System.Windows.Forms.Panel UC;
        private System.Windows.Forms.Panel UR;
        private System.Windows.Forms.Panel ULD;
        private System.Windows.Forms.Panel UD;
        private System.Windows.Forms.Panel URD;
        private System.Windows.Forms.Panel FRD;
        private System.Windows.Forms.Panel FD;
        private System.Windows.Forms.Panel FLD;
        private System.Windows.Forms.Panel FR;
        private System.Windows.Forms.Panel FC;
        private System.Windows.Forms.Panel FL;
        private System.Windows.Forms.Panel FRU;
        private System.Windows.Forms.Panel FU;
        private System.Windows.Forms.Panel FLU;
        private System.Windows.Forms.Panel RRD;
        private System.Windows.Forms.Panel RD;
        private System.Windows.Forms.Panel RLD;
        private System.Windows.Forms.Panel RR;
        private System.Windows.Forms.Panel RC;
        private System.Windows.Forms.Panel RL;
        private System.Windows.Forms.Panel RRU;
        private System.Windows.Forms.Panel RU;
        private System.Windows.Forms.Panel RLU;
        private System.Windows.Forms.Panel BRD;
        private System.Windows.Forms.Panel BD;
        private System.Windows.Forms.Panel BLD;
        private System.Windows.Forms.Panel BR;
        private System.Windows.Forms.Panel BC;
        private System.Windows.Forms.Panel BL;
        private System.Windows.Forms.Panel BRU;
        private System.Windows.Forms.Panel BU;
        private System.Windows.Forms.Panel BLU;
        private System.Windows.Forms.Panel LRD;
        private System.Windows.Forms.Panel LD;
        private System.Windows.Forms.Panel LLD;
        private System.Windows.Forms.Panel LR;
        private System.Windows.Forms.Panel LC;
        private System.Windows.Forms.Panel LL;
        private System.Windows.Forms.Panel LRU;
        private System.Windows.Forms.Panel LU;
        private System.Windows.Forms.Panel LLU;
        private System.Windows.Forms.Panel DRD;
        private System.Windows.Forms.Panel DD;
        private System.Windows.Forms.Panel DLD;
        private System.Windows.Forms.Panel DR;
        private System.Windows.Forms.Panel DC;
        private System.Windows.Forms.Panel DL;
        private System.Windows.Forms.Panel DRU;
        private System.Windows.Forms.Panel DU;
        private System.Windows.Forms.Panel DLU;
        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.Button cmdAutoinit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSolve;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtreadPattern;
        private System.Windows.Forms.TextBox txtSolvedPattern;
        private System.Windows.Forms.TextBox txtarstring;
        private System.Windows.Forms.Button cmdsend;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip cmdl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}