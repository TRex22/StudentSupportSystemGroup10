namespace SSS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlLoginTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.medPassword = new System.Windows.Forms.MaskedTextBox();
            this.medUsername = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.userprofileTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter();
            this.tutorTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter();
            this.studentTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter();
            this.ssS_COORDINATORTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter();
            this.studenT_ACTIVITYTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter();
            this.attendanceTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter();
            this.pnlLoginTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginTitle
            // 
            this.pnlLoginTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginTitle.Controls.Add(this.lblTitle);
            this.pnlLoginTitle.Location = new System.Drawing.Point(12, 12);
            this.pnlLoginTitle.Name = "pnlLoginTitle";
            this.pnlLoginTitle.Size = new System.Drawing.Size(464, 63);
            this.pnlLoginTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(79, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(291, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Student Support System";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 171);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Location = new System.Drawing.Point(3, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 37);
            this.panel3.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(291, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(93, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.medPassword);
            this.panel2.Controls.Add(this.medUsername);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 124);
            this.panel2.TabIndex = 0;
            // 
            // medPassword
            // 
            this.medPassword.Location = new System.Drawing.Point(123, 81);
            this.medPassword.Name = "medPassword";
            this.medPassword.PasswordChar = '*';
            this.medPassword.Size = new System.Drawing.Size(280, 20);
            this.medPassword.TabIndex = 3;
            // 
            // medUsername
            // 
            this.medUsername.Location = new System.Drawing.Point(123, 37);
            this.medUsername.Name = "medUsername";
            this.medUsername.Size = new System.Drawing.Size(280, 20);
            this.medUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(24, 82);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(24, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(79, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // userprofileTableAdapter1
            // 
            this.userprofileTableAdapter1.ClearBeforeFill = true;
            // 
            // tutorTableAdapter1
            // 
            this.tutorTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // ssS_COORDINATORTableAdapter1
            // 
            this.ssS_COORDINATORTableAdapter1.ClearBeforeFill = true;
            // 
            // studenT_ACTIVITYTableAdapter1
            // 
            this.studenT_ACTIVITYTableAdapter1.ClearBeforeFill = true;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(486, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLoginTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.pnlLoginTitle.ResumeLayout(false);
            this.pnlLoginTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox medPassword;
        private System.Windows.Forms.MaskedTextBox medUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter userprofileTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter tutorTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter ssS_COORDINATORTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter studenT_ACTIVITYTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter attendanceTableAdapter1;
    }
}