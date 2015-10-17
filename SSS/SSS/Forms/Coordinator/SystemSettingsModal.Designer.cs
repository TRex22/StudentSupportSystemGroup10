namespace SSS_Windows_Forms.Forms.Coordinator
{
    partial class SystemSettingsModal
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
            this.attendanceTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter();
            this.studenT_ACTIVITYTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter();
            this.tutorTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter();
            this.userprofileTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter();
            this.studentTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter();
            this.ssS_COORDINATORTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter();
            this.tutoR_AVAILABLE_TIMESTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMESTableAdapter();
            this.doDbOpButton = new System.Windows.Forms.Button();
            this.dBOpsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cleanDatabaseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // studenT_ACTIVITYTableAdapter1
            // 
            this.studenT_ACTIVITYTableAdapter1.ClearBeforeFill = true;
            // 
            // tutorTableAdapter1
            // 
            this.tutorTableAdapter1.ClearBeforeFill = true;
            // 
            // userprofileTableAdapter1
            // 
            this.userprofileTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // ssS_COORDINATORTableAdapter1
            // 
            this.ssS_COORDINATORTableAdapter1.ClearBeforeFill = true;
            // 
            // tutoR_AVAILABLE_TIMESTableAdapter1
            // 
            this.tutoR_AVAILABLE_TIMESTableAdapter1.ClearBeforeFill = true;
            // 
            // doDbOpButton
            // 
            this.doDbOpButton.Location = new System.Drawing.Point(79, 131);
            this.doDbOpButton.Name = "doDbOpButton";
            this.doDbOpButton.Size = new System.Drawing.Size(75, 23);
            this.doDbOpButton.TabIndex = 0;
            this.doDbOpButton.Text = "Do Op";
            this.doDbOpButton.UseVisualStyleBackColor = true;
            this.doDbOpButton.Click += new System.EventHandler(this.doDbOpButton_Click);
            // 
            // dBOpsComboBox
            // 
            this.dBOpsComboBox.FormattingEnabled = true;
            this.dBOpsComboBox.Location = new System.Drawing.Point(33, 104);
            this.dBOpsComboBox.Name = "dBOpsComboBox";
            this.dBOpsComboBox.Size = new System.Drawing.Size(121, 21);
            this.dBOpsComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "System Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Database Operations";
            // 
            // cleanDatabaseButton
            // 
            this.cleanDatabaseButton.Location = new System.Drawing.Point(33, 34);
            this.cleanDatabaseButton.Name = "cleanDatabaseButton";
            this.cleanDatabaseButton.Size = new System.Drawing.Size(98, 23);
            this.cleanDatabaseButton.TabIndex = 20;
            this.cleanDatabaseButton.Text = "Clean Database";
            this.cleanDatabaseButton.UseVisualStyleBackColor = true;
            this.cleanDatabaseButton.Click += new System.EventHandler(this.cleanDatabaseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cleanDatabaseButton);
            this.groupBox1.Controls.Add(this.doDbOpButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dBOpsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(89, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 196);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // SystemSettingsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 501);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemSettingsModal";
            this.Text = "SystemSettingsModal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter attendanceTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter studenT_ACTIVITYTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter tutorTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter userprofileTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter ssS_COORDINATORTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMESTableAdapter tutoR_AVAILABLE_TIMESTableAdapter1;
        private System.Windows.Forms.Button doDbOpButton;
        private System.Windows.Forms.ComboBox dBOpsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cleanDatabaseButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}