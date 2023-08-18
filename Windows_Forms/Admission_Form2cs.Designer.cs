namespace Windows_Form_Project
{
    partial class Admission_Form2cs
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
            tbName = new TextBox();
            lbl_title = new Label();
            lbl_Name = new Label();
            lblFees = new Label();
            tbFee = new TextBox();
            gbCourses = new GroupBox();
            cbAI = new CheckBox();
            cbGG = new CheckBox();
            cbGCS = new CheckBox();
            cbAWS = new CheckBox();
            CbPHP = new CheckBox();
            CbMySQL = new CheckBox();
            CbDjango = new CheckBox();
            cbPython = new CheckBox();
            CbOracle = new CheckBox();
            CbJee = new CheckBox();
            cbAdvJava = new CheckBox();
            cbCoreJava = new CheckBox();
            CbSQLServer = new CheckBox();
            CbMVC = new CheckBox();
            CbAsp = new CheckBox();
            CbCSharp = new CheckBox();
            CbLinux = new CheckBox();
            CbUnix = new CheckBox();
            Cbcpp = new CheckBox();
            cbC = new CheckBox();
            gbTrack = new GroupBox();
            rbSuperFast = new RadioButton();
            rbFast = new RadioButton();
            rbNormal = new RadioButton();
            btnReset = new Button();
            btnSave = new Button();
            gbCourses.SuspendLayout();
            gbTrack.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(95, 63);
            tbName.Name = "tbName";
            tbName.Size = new Size(192, 23);
            tbName.TabIndex = 0;
            // 
            // lbl_title
            // 
            lbl_title.BackColor = Color.Salmon;
            lbl_title.Font = new Font("Algerian", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbl_title.Location = new Point(166, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(470, 46);
            lbl_title.TabIndex = 1;
            lbl_title.Text = "Naresh IT Technology";
            // 
            // lbl_Name
            // 
            lbl_Name.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Name.Location = new Point(29, 61);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(60, 24);
            lbl_Name.TabIndex = 2;
            lbl_Name.Text = "Name:";
            // 
            // lblFees
            // 
            lblFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFees.Location = new Point(448, 63);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(90, 24);
            lblFees.TabIndex = 3;
            lblFees.Text = "Total Fees:";
            // 
            // tbFee
            // 
            tbFee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbFee.Location = new Point(544, 60);
            tbFee.Name = "tbFee";
            tbFee.ReadOnly = true;
            tbFee.Size = new Size(126, 29);
            tbFee.TabIndex = 4;
            tbFee.Text = "0";
            tbFee.TextAlign = HorizontalAlignment.Right;
            // 
            // gbCourses
            // 
            gbCourses.BackColor = Color.IndianRed;
            gbCourses.Controls.Add(cbAI);
            gbCourses.Controls.Add(cbGG);
            gbCourses.Controls.Add(cbGCS);
            gbCourses.Controls.Add(cbAWS);
            gbCourses.Controls.Add(CbPHP);
            gbCourses.Controls.Add(CbMySQL);
            gbCourses.Controls.Add(CbDjango);
            gbCourses.Controls.Add(cbPython);
            gbCourses.Controls.Add(CbOracle);
            gbCourses.Controls.Add(CbJee);
            gbCourses.Controls.Add(cbAdvJava);
            gbCourses.Controls.Add(cbCoreJava);
            gbCourses.Controls.Add(CbSQLServer);
            gbCourses.Controls.Add(CbMVC);
            gbCourses.Controls.Add(CbAsp);
            gbCourses.Controls.Add(CbCSharp);
            gbCourses.Controls.Add(CbLinux);
            gbCourses.Controls.Add(CbUnix);
            gbCourses.Controls.Add(Cbcpp);
            gbCourses.Controls.Add(cbC);
            gbCourses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbCourses.Location = new Point(0, 92);
            gbCourses.Name = "gbCourses";
            gbCourses.Size = new Size(746, 195);
            gbCourses.TabIndex = 5;
            gbCourses.TabStop = false;
            gbCourses.Text = "Courses Offered";
            // 
            // cbAI
            // 
            cbAI.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbAI.Location = new Point(545, 170);
            cbAI.Name = "cbAI";
            cbAI.Size = new Size(153, 24);
            cbAI.TabIndex = 24;
            cbAI.Tag = "7000";
            cbAI.Text = "AI(7000)";
            cbAI.UseVisualStyleBackColor = true;
            cbAI.CheckedChanged += cbC_CheckedChanged;
            // 
            // cbGG
            // 
            cbGG.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbGG.Location = new Point(364, 170);
            cbGG.Name = "cbGG";
            cbGG.Size = new Size(162, 24);
            cbGG.TabIndex = 23;
            cbGG.Tag = "3000";
            cbGG.Text = "Git & GitHub(3000)";
            cbGG.UseVisualStyleBackColor = true;
            cbGG.CheckedChanged += cbC_CheckedChanged;
            // 
            // cbGCS
            // 
            cbGCS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbGCS.Location = new Point(171, 170);
            cbGCS.Name = "cbGCS";
            cbGCS.Size = new Size(153, 24);
            cbGCS.TabIndex = 22;
            cbGCS.Tag = "4000";
            cbGCS.Text = "GCS(4000)";
            cbGCS.UseVisualStyleBackColor = true;
            cbGCS.CheckedChanged += cbC_CheckedChanged;
            // 
            // cbAWS
            // 
            cbAWS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbAWS.Location = new Point(20, 170);
            cbAWS.Name = "cbAWS";
            cbAWS.Size = new Size(153, 24);
            cbAWS.TabIndex = 21;
            cbAWS.Tag = "3000";
            cbAWS.Text = "AWS(3000)";
            cbAWS.UseVisualStyleBackColor = true;
            cbAWS.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbPHP
            // 
            CbPHP.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbPHP.Location = new Point(539, 131);
            CbPHP.Name = "CbPHP";
            CbPHP.Size = new Size(138, 24);
            CbPHP.TabIndex = 15;
            CbPHP.Tag = "3000";
            CbPHP.Text = "PHP(3000)";
            CbPHP.UseVisualStyleBackColor = true;
            CbPHP.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbMySQL
            // 
            CbMySQL.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbMySQL.Location = new Point(539, 95);
            CbMySQL.Name = "CbMySQL";
            CbMySQL.Size = new Size(138, 24);
            CbMySQL.TabIndex = 14;
            CbMySQL.Tag = "2000";
            CbMySQL.Text = "MySQL(2000)";
            CbMySQL.UseVisualStyleBackColor = true;
            CbMySQL.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbDjango
            // 
            CbDjango.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbDjango.Location = new Point(539, 59);
            CbDjango.Name = "CbDjango";
            CbDjango.Size = new Size(138, 24);
            CbDjango.TabIndex = 13;
            CbDjango.Tag = "3000";
            CbDjango.Text = "Django(3000)";
            CbDjango.UseVisualStyleBackColor = true;
            CbDjango.CheckedChanged += cbC_CheckedChanged;
            CbDjango.DpiChangedAfterParent += cbC_CheckedChanged;
            // 
            // cbPython
            // 
            cbPython.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbPython.Location = new Point(539, 29);
            cbPython.Name = "cbPython";
            cbPython.Size = new Size(159, 24);
            cbPython.TabIndex = 12;
            cbPython.Tag = "3000";
            cbPython.Text = "Python(3000)";
            cbPython.UseVisualStyleBackColor = true;
            cbPython.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbOracle
            // 
            CbOracle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbOracle.Location = new Point(364, 131);
            CbOracle.Name = "CbOracle";
            CbOracle.Size = new Size(126, 24);
            CbOracle.TabIndex = 11;
            CbOracle.Tag = "2000";
            CbOracle.Text = "Oracle(2000)";
            CbOracle.UseVisualStyleBackColor = true;
            CbOracle.CheckedChanged += cbC_CheckedChanged;
            CbOracle.DpiChangedAfterParent += cbC_CheckedChanged;
            // 
            // CbJee
            // 
            CbJee.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbJee.Location = new Point(364, 95);
            CbJee.Name = "CbJee";
            CbJee.Size = new Size(104, 24);
            CbJee.TabIndex = 10;
            CbJee.Tag = "3000";
            CbJee.Text = "JEE(3000)";
            CbJee.UseVisualStyleBackColor = true;
            CbJee.CheckedChanged += cbC_CheckedChanged;
            CbJee.DpiChangedAfterParent += cbC_CheckedChanged;
            // 
            // cbAdvJava
            // 
            cbAdvJava.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbAdvJava.Location = new Point(362, 59);
            cbAdvJava.Name = "cbAdvJava";
            cbAdvJava.Size = new Size(144, 24);
            cbAdvJava.TabIndex = 9;
            cbAdvJava.Tag = "3000";
            cbAdvJava.Text = "Adv. Java(3000)";
            cbAdvJava.UseVisualStyleBackColor = true;
            cbAdvJava.CheckedChanged += cbC_CheckedChanged;
            cbAdvJava.DpiChangedAfterParent += cbC_CheckedChanged;
            // 
            // cbCoreJava
            // 
            cbCoreJava.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbCoreJava.Location = new Point(362, 28);
            cbCoreJava.Name = "cbCoreJava";
            cbCoreJava.Size = new Size(144, 24);
            cbCoreJava.TabIndex = 8;
            cbCoreJava.Tag = "4000";
            cbCoreJava.Text = "Core Java(4000)";
            cbCoreJava.UseVisualStyleBackColor = true;
            cbCoreJava.CheckedChanged += cbC_CheckedChanged;
            cbCoreJava.DpiChangedAfterParent += cbC_CheckedChanged;
            // 
            // CbSQLServer
            // 
            CbSQLServer.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbSQLServer.Location = new Point(171, 131);
            CbSQLServer.Name = "CbSQLServer";
            CbSQLServer.Size = new Size(153, 24);
            CbSQLServer.TabIndex = 7;
            CbSQLServer.Tag = "2000";
            CbSQLServer.Text = "SQL Server(2000)";
            CbSQLServer.UseVisualStyleBackColor = true;
            CbSQLServer.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbMVC
            // 
            CbMVC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbMVC.Location = new Point(171, 95);
            CbMVC.Name = "CbMVC";
            CbMVC.Size = new Size(114, 24);
            CbMVC.TabIndex = 6;
            CbMVC.Tag = "4500";
            CbMVC.Text = "MVC(4500)";
            CbMVC.UseVisualStyleBackColor = true;
            CbMVC.CheckedChanged += cbC_CheckedChanged;
            CbMVC.DpiChangedAfterParent += cbC_CheckedChanged;
            // 
            // CbAsp
            // 
            CbAsp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbAsp.Location = new Point(171, 59);
            CbAsp.Name = "CbAsp";
            CbAsp.Size = new Size(136, 24);
            CbAsp.TabIndex = 5;
            CbAsp.Tag = "4000";
            CbAsp.Text = "Asp.Net(4000)";
            CbAsp.UseVisualStyleBackColor = true;
            CbAsp.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbCSharp
            // 
            CbCSharp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbCSharp.Location = new Point(171, 29);
            CbCSharp.Name = "CbCSharp";
            CbCSharp.Size = new Size(104, 24);
            CbCSharp.TabIndex = 4;
            CbCSharp.Tag = "3500";
            CbCSharp.Text = "C#(3500)";
            CbCSharp.UseVisualStyleBackColor = true;
            CbCSharp.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbLinux
            // 
            CbLinux.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbLinux.Location = new Point(20, 131);
            CbLinux.Name = "CbLinux";
            CbLinux.Size = new Size(116, 24);
            CbLinux.TabIndex = 3;
            CbLinux.Tag = "3000";
            CbLinux.Text = "Linux(3000)";
            CbLinux.UseVisualStyleBackColor = true;
            CbLinux.CheckedChanged += cbC_CheckedChanged;
            // 
            // CbUnix
            // 
            CbUnix.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CbUnix.Location = new Point(20, 95);
            CbUnix.Name = "CbUnix";
            CbUnix.Size = new Size(116, 24);
            CbUnix.TabIndex = 2;
            CbUnix.Tag = "3000";
            CbUnix.Text = "Unix(3000)";
            CbUnix.UseVisualStyleBackColor = true;
            CbUnix.CheckedChanged += cbC_CheckedChanged;
            // 
            // Cbcpp
            // 
            Cbcpp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cbcpp.Location = new Point(20, 59);
            Cbcpp.Name = "Cbcpp";
            Cbcpp.Size = new Size(116, 24);
            Cbcpp.TabIndex = 1;
            Cbcpp.Tag = "3500";
            Cbcpp.Text = "Cpp (3500)";
            Cbcpp.UseVisualStyleBackColor = true;
            Cbcpp.CheckedChanged += cbC_CheckedChanged;
            // 
            // cbC
            // 
            cbC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbC.Location = new Point(20, 29);
            cbC.Name = "cbC";
            cbC.Size = new Size(104, 24);
            cbC.TabIndex = 0;
            cbC.Tag = "3000";
            cbC.Text = "C (3000)";
            cbC.UseVisualStyleBackColor = true;
            cbC.CheckedChanged += cbC_CheckedChanged;
            // 
            // gbTrack
            // 
            gbTrack.BackColor = Color.IndianRed;
            gbTrack.Controls.Add(rbSuperFast);
            gbTrack.Controls.Add(rbFast);
            gbTrack.Controls.Add(rbNormal);
            gbTrack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbTrack.Location = new Point(0, 293);
            gbTrack.Name = "gbTrack";
            gbTrack.Size = new Size(738, 58);
            gbTrack.TabIndex = 6;
            gbTrack.TabStop = false;
            gbTrack.Text = "Tract";
            // 
            // rbSuperFast
            // 
            rbSuperFast.AutoSize = true;
            rbSuperFast.Location = new Point(539, 27);
            rbSuperFast.Name = "rbSuperFast";
            rbSuperFast.Size = new Size(146, 25);
            rbSuperFast.TabIndex = 2;
            rbSuperFast.Tag = "200";
            rbSuperFast.Text = "Super-Fast(200)";
            rbSuperFast.UseVisualStyleBackColor = true;
            rbSuperFast.CheckedChanged += rbNormal_CheckedChanged;
            // 
            // rbFast
            // 
            rbFast.AutoSize = true;
            rbFast.Location = new Point(274, 27);
            rbFast.Name = "rbFast";
            rbFast.Size = new Size(97, 25);
            rbFast.TabIndex = 1;
            rbFast.Tag = "100";
            rbFast.Text = "Fast(100)";
            rbFast.UseVisualStyleBackColor = true;
            rbFast.CheckedChanged += rbNormal_CheckedChanged;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(17, 27);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(86, 25);
            rbNormal.TabIndex = 0;
            rbNormal.Tag = "0";
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += rbNormal_CheckedChanged;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LawnGreen;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(225, 357);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(121, 42);
            btnReset.TabIndex = 7;
            btnReset.Text = "ResetForm";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LawnGreen;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(385, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(121, 42);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Admission_Form2cs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(734, 411);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(gbTrack);
            Controls.Add(gbCourses);
            Controls.Add(tbFee);
            Controls.Add(lblFees);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_title);
            Controls.Add(tbName);
            Name = "Admission_Form2cs";
            Text = "Admission_Form2cs";
            Load += Admission_Form2cs_Load;
            gbCourses.ResumeLayout(false);
            gbTrack.ResumeLayout(false);
            gbTrack.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label lbl_title;
        private Label lbl_Name;
        private Label lblFees;
        private TextBox tbFee;
        private GroupBox gbCourses;
        private CheckBox CbPHP;
        private CheckBox CbMySQL;
        private CheckBox CbDjango;
        private CheckBox cbPython;
        private CheckBox CbOracle;
        private CheckBox CbJee;
        private CheckBox cbAdvJava;
        private CheckBox cbCoreJava;
        private CheckBox CbSQLServer;
        private CheckBox CbMVC;
        private CheckBox CbAsp;
        private CheckBox CbCSharp;
        private CheckBox CbLinux;
        private CheckBox CbUnix;
        private CheckBox Cbcpp;
        private CheckBox cbC;
        private CheckBox cbAI;
        private CheckBox cbGG;
        private CheckBox cbGCS;
        private CheckBox cbAWS;
        private GroupBox gbTrack;
        private RadioButton rbSuperFast;
        private RadioButton rbFast;
        private RadioButton rbNormal;
        private Button btnReset;
        private Button btnSave;
    }
}