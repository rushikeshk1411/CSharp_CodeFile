namespace Windows_Form_Project
{
    partial class Registration_Form
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
            lblTitle = new Label();
            lblUName = new Label();
            lblPass = new Label();
            lblCPass = new Label();
            lblDOB = new Label();
            lblMob = new Label();
            lblEmail = new Label();
            lblAdd = new Label();
            tbUName = new TextBox();
            tbCPass = new TextBox();
            tbPass = new TextBox();
            tbMobile = new TextBox();
            tbEmail = new TextBox();
            tbAdd = new TextBox();
            btnReset = new Button();
            button2 = new Button();
            btnSave = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Stencil", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(24, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(333, 38);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "Registration Form";
            // 
            // lblUName
            // 
            lblUName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUName.Location = new Point(24, 73);
            lblUName.Name = "lblUName";
            lblUName.Size = new Size(100, 23);
            lblUName.TabIndex = 8;
            lblUName.Text = "User Name:";
            // 
            // lblPass
            // 
            lblPass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(24, 111);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(100, 23);
            lblPass.TabIndex = 9;
            lblPass.Text = "Password:";
            // 
            // lblCPass
            // 
            lblCPass.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCPass.Location = new Point(24, 153);
            lblCPass.Name = "lblCPass";
            lblCPass.Size = new Size(160, 23);
            lblCPass.TabIndex = 10;
            lblCPass.Text = "Confirm Pass: ";
            // 
            // lblDOB
            // 
            lblDOB.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDOB.Location = new Point(24, 194);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(122, 23);
            lblDOB.TabIndex = 11;
            lblDOB.Text = "Date Of Birth: ";
            // 
            // lblMob
            // 
            lblMob.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMob.Location = new Point(24, 236);
            lblMob.Name = "lblMob";
            lblMob.Size = new Size(100, 23);
            lblMob.TabIndex = 12;
            lblMob.Text = "Mobile:";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(24, 279);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // lblAdd
            // 
            lblAdd.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdd.Location = new Point(24, 328);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(100, 23);
            lblAdd.TabIndex = 14;
            lblAdd.Text = "Address:";
            // 
            // tbUName
            // 
            tbUName.Location = new Point(173, 73);
            tbUName.Name = "tbUName";
            tbUName.Size = new Size(184, 23);
            tbUName.TabIndex = 0;
            // 
            // tbCPass
            // 
            tbCPass.Location = new Point(173, 153);
            tbCPass.Name = "tbCPass";
            tbCPass.Size = new Size(184, 23);
            tbCPass.TabIndex = 2;
            tbCPass.UseSystemPasswordChar = true;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(173, 111);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(184, 23);
            tbPass.TabIndex = 1;
            tbPass.UseSystemPasswordChar = true;
            // 
            // tbMobile
            // 
            tbMobile.Location = new Point(173, 236);
            tbMobile.Name = "tbMobile";
            tbMobile.Size = new Size(184, 23);
            tbMobile.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(173, 279);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(184, 23);
            tbEmail.TabIndex = 5;
            // 
            // tbAdd
            // 
            tbAdd.Location = new Point(173, 328);
            tbAdd.Multiline = true;
            tbAdd.Name = "tbAdd";
            tbAdd.ScrollBars = ScrollBars.Both;
            tbAdd.Size = new Size(184, 68);
            tbAdd.TabIndex = 6;
            tbAdd.WordWrap = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.Location = new Point(21, 416);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 40);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(246, 416);
            button2.Name = "button2";
            button2.Size = new Size(111, 40);
            button2.TabIndex = 19;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(139, 416);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 40);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnReset_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(173, 194);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(184, 23);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 468);
            Controls.Add(maskedTextBox1);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(btnReset);
            Controls.Add(tbAdd);
            Controls.Add(tbEmail);
            Controls.Add(tbMobile);
            Controls.Add(tbPass);
            Controls.Add(tbCPass);
            Controls.Add(tbUName);
            Controls.Add(lblAdd);
            Controls.Add(lblEmail);
            Controls.Add(lblMob);
            Controls.Add(lblDOB);
            Controls.Add(lblCPass);
            Controls.Add(lblPass);
            Controls.Add(lblUName);
            Controls.Add(lblTitle);
            Name = "Registration_Form";
            Text = "Registration_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUName;
        private Label lblPass;
        private Label lblCPass;
        private Label lblDOB;
        private Label lblMob;
        private Label lblEmail;
        private Label lblAdd;
        private TextBox tbUName;
        private TextBox tbCPass;
        private TextBox tbPass;
        private TextBox tbMobile;
        private TextBox tbEmail;
        private TextBox tbAdd;
        private Button button1;
        private Button btnReset;
        private Button button2;
        private Button btnSave;
        private MaskedTextBox maskedTextBox1;
    }
}