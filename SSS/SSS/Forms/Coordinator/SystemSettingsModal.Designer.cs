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
            // SystemSettingsModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 501);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemSettingsModal";
            this.Text = "SystemSettingsModal";
            this.ResumeLayout(false);

        }

        #endregion

        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ATTENDANCETableAdapter attendanceTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENT_ACTIVITYTableAdapter studenT_ACTIVITYTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter tutorTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.USERPROFILETableAdapter userprofileTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.SSS_COORDINATORTableAdapter ssS_COORDINATORTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMESTableAdapter tutoR_AVAILABLE_TIMESTableAdapter1;
    }
}