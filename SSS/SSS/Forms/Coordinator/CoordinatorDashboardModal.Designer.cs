﻿namespace SSS_Windows_Forms.Forms.Coordinator
{
    partial class CoordinatorDashboardModal
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SSS_Windows_Forms.Reports.Coordinator.CoordinatorDashboardReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(762, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // CoordinatorDashboardModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 539);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoordinatorDashboardModal";
            this.Text = "CoordinatorDashboardModal";
            this.Load += new System.EventHandler(this.CoordinatorDashboardModal_Load);
            this.VisibleChanged += new System.EventHandler(this.CoordinatorDashboardModal_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}