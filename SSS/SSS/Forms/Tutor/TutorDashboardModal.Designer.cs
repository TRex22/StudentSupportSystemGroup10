namespace SSS_Windows_Forms.Forms.Tutor
{
    partial class TutorDashboardModal
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IS2G10_DBSSSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IS2G10_DBSSSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS_Windows_Forms.Reports.Tutor.TutorDashboardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(753, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // IS2G10_DBSSSDataSetBindingSource
            // 
            this.IS2G10_DBSSSDataSetBindingSource.DataMember = "AVERAGE_RATINGS";
            // 
            // TutorDashboardModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 539);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TutorDashboardModal";
            this.Text = "TutorDashboardModal";
            this.Load += new System.EventHandler(this.TutorDashboardModal_Load);
            this.VisibleChanged += new System.EventHandler(this.TutorDashboardModal_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.IS2G10_DBSSSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IS2G10_DBSSSDataSetBindingSource;
    }
}