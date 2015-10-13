namespace SSS.Forms.Coordinator
{
    partial class SystemControl
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
            this.studentTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter();
            this.tutorTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter();
            this.studenT_ACTIVITYTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter();
            this.userprofileTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter();
            this.attendanceTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter();
            this.ssS_COORDINATORTableAdapter1 = new SSS.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter();
            this.SuspendLayout();
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // tutorTableAdapter1
            // 
            this.tutorTableAdapter1.ClearBeforeFill = true;
            // 
            // studenT_ACTIVITYTableAdapter1
            // 
            this.studenT_ACTIVITYTableAdapter1.ClearBeforeFill = true;
            // 
            // userprofileTableAdapter1
            // 
            this.userprofileTableAdapter1.ClearBeforeFill = true;
            // 
            // attendanceTableAdapter1
            // 
            this.attendanceTableAdapter1.ClearBeforeFill = true;
            // 
            // ssS_COORDINATORTableAdapter1
            // 
            this.ssS_COORDINATORTableAdapter1.ClearBeforeFill = true;
            // 
            // SystemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "SystemControl";
            this.Text = "SystemControl";
            this.ResumeLayout(false);

        }

        #endregion

        private IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter tutorTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter studenT_ACTIVITYTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter userprofileTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter attendanceTableAdapter1;
        private IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter ssS_COORDINATORTableAdapter1;
    }
}