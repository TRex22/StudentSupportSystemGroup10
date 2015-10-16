namespace SSS_Windows_Forms.Forms.Student
{
    partial class CreateConsultationModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateConsultationModal));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tutorComboBox = new System.Windows.Forms.ComboBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.BookButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tutorTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter();
            this.consultationTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.CONSULTATIONTableAdapter();
            this.tutoR_AVAILABLE_TIMESTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMESTableAdapter();
            this.tutoR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Book a Consultation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Please Select a Tutor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "Day";
            // 
            // tutorComboBox
            // 
            this.tutorComboBox.FormattingEnabled = true;
            this.tutorComboBox.Location = new System.Drawing.Point(143, 131);
            this.tutorComboBox.Name = "tutorComboBox";
            this.tutorComboBox.Size = new System.Drawing.Size(140, 21);
            this.tutorComboBox.TabIndex = 84;
            this.tutorComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(143, 289);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(358, 125);
            this.detailsTextBox.TabIndex = 85;
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(143, 177);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(140, 21);
            this.dateComboBox.TabIndex = 86;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // timeComboBox
            // 
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(143, 226);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(140, 21);
            this.timeComboBox.TabIndex = 87;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.timeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 88;
            this.label4.Text = "Consultation Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(289, 125);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(29, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 90;
            this.pictureBox8.TabStop = false;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(530, 442);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(110, 23);
            this.BookButton.TabIndex = 91;
            this.BookButton.Text = "Book Consultation";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(289, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // tutorTableAdapter1
            // 
            this.tutorTableAdapter1.ClearBeforeFill = true;
            // 
            // consultationTableAdapter1
            // 
            this.consultationTableAdapter1.ClearBeforeFill = true;
            // 
            // tutoR_AVAILABLE_TIMESTableAdapter1
            // 
            this.tutoR_AVAILABLE_TIMESTableAdapter1.ClearBeforeFill = true;
            // 
            // tutoR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter1
            // 
            this.tutoR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter1.ClearBeforeFill = true;
            // 
            // CreateConsultationModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 501);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.tutorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateConsultationModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CreateConsultationModal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tutorComboBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTORTableAdapter tutorTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.CONSULTATIONTableAdapter consultationTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMESTableAdapter tutoR_AVAILABLE_TIMESTableAdapter1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.TUTOR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter tutoR_AVAILABLE_TIMES_SEARCH_BY_TUTORTableAdapter1;
    }
}