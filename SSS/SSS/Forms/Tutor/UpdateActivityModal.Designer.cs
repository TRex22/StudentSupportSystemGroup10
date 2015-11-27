namespace SSS_Windows_Forms.Forms.Tutor
{
    partial class UpdateActivityModal
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aCTIVITYFULLDATARowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitY_FULL_DATATableAdapter1 = new SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ACTIVITY_FULL_DATATableAdapter();
            this.studentactivityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivitynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentarrivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.studentactivitypointvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivityweekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivitydescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivitytutorratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentactivityratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentemailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentmobilenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatorfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatorlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatoridpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatoremailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinatorcellnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutoridpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutoremailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorcellnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYFULLDATARowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Activity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Display Activity Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentactivityidDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.studentfirstnameDataGridViewTextBoxColumn,
            this.studentlastnameDataGridViewTextBoxColumn,
            this.studentactivitynameDataGridViewTextBoxColumn,
            this.studentarrivedDataGridViewCheckBoxColumn,
            this.studentactivitypointvalueDataGridViewTextBoxColumn,
            this.studentactivityweekDataGridViewTextBoxColumn,
            this.studentactivitydescriptionDataGridViewTextBoxColumn,
            this.studentactivitytutorratingDataGridViewTextBoxColumn,
            this.studentactivityratingDataGridViewTextBoxColumn,
            this.studentemailaddressDataGridViewTextBoxColumn,
            this.studentmobilenumberDataGridViewTextBoxColumn,
            this.coordinatoridDataGridViewTextBoxColumn,
            this.coordinatorfirstnameDataGridViewTextBoxColumn,
            this.coordinatorlastnameDataGridViewTextBoxColumn,
            this.coordinatoridpassportDataGridViewTextBoxColumn,
            this.coordinatoremailaddressDataGridViewTextBoxColumn,
            this.coordinatorcellnumberDataGridViewTextBoxColumn,
            this.tutoridDataGridViewTextBoxColumn,
            this.tutorfirstnameDataGridViewTextBoxColumn,
            this.tutorlastnameDataGridViewTextBoxColumn,
            this.tutoridpassportDataGridViewTextBoxColumn,
            this.tutoremailaddressDataGridViewTextBoxColumn,
            this.tutorcellnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aCTIVITYFULLDATARowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 305);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aCTIVITYFULLDATARowBindingSource
            // 
            this.aCTIVITYFULLDATARowBindingSource.DataSource = typeof(SSS_Library.IS2G10_DBSSSDataSet.ACTIVITY_FULL_DATARow);
            // 
            // activitY_FULL_DATATableAdapter1
            // 
            this.activitY_FULL_DATATableAdapter1.ClearBeforeFill = true;
            // 
            // studentactivityidDataGridViewTextBoxColumn
            // 
            this.studentactivityidDataGridViewTextBoxColumn.DataPropertyName = "student_activity_id";
            this.studentactivityidDataGridViewTextBoxColumn.HeaderText = "Activity Id";
            this.studentactivityidDataGridViewTextBoxColumn.Name = "studentactivityidDataGridViewTextBoxColumn";
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // studentfirstnameDataGridViewTextBoxColumn
            // 
            this.studentfirstnameDataGridViewTextBoxColumn.DataPropertyName = "student_firstname";
            this.studentfirstnameDataGridViewTextBoxColumn.HeaderText = "student_firstname";
            this.studentfirstnameDataGridViewTextBoxColumn.Name = "studentfirstnameDataGridViewTextBoxColumn";
            // 
            // studentlastnameDataGridViewTextBoxColumn
            // 
            this.studentlastnameDataGridViewTextBoxColumn.DataPropertyName = "student_lastname";
            this.studentlastnameDataGridViewTextBoxColumn.HeaderText = "student_lastname";
            this.studentlastnameDataGridViewTextBoxColumn.Name = "studentlastnameDataGridViewTextBoxColumn";
            // 
            // studentactivitynameDataGridViewTextBoxColumn
            // 
            this.studentactivitynameDataGridViewTextBoxColumn.DataPropertyName = "student_activity_name";
            this.studentactivitynameDataGridViewTextBoxColumn.HeaderText = "student_activity_name";
            this.studentactivitynameDataGridViewTextBoxColumn.Name = "studentactivitynameDataGridViewTextBoxColumn";
            // 
            // studentarrivedDataGridViewCheckBoxColumn
            // 
            this.studentarrivedDataGridViewCheckBoxColumn.DataPropertyName = "student_arrived";
            this.studentarrivedDataGridViewCheckBoxColumn.HeaderText = "student_arrived";
            this.studentarrivedDataGridViewCheckBoxColumn.Name = "studentarrivedDataGridViewCheckBoxColumn";
            // 
            // studentactivitypointvalueDataGridViewTextBoxColumn
            // 
            this.studentactivitypointvalueDataGridViewTextBoxColumn.DataPropertyName = "student_activity_pointvalue";
            this.studentactivitypointvalueDataGridViewTextBoxColumn.HeaderText = "student_activity_pointvalue";
            this.studentactivitypointvalueDataGridViewTextBoxColumn.Name = "studentactivitypointvalueDataGridViewTextBoxColumn";
            // 
            // studentactivityweekDataGridViewTextBoxColumn
            // 
            this.studentactivityweekDataGridViewTextBoxColumn.DataPropertyName = "student_activity_week";
            this.studentactivityweekDataGridViewTextBoxColumn.HeaderText = "student_activity_week";
            this.studentactivityweekDataGridViewTextBoxColumn.Name = "studentactivityweekDataGridViewTextBoxColumn";
            // 
            // studentactivitydescriptionDataGridViewTextBoxColumn
            // 
            this.studentactivitydescriptionDataGridViewTextBoxColumn.DataPropertyName = "student_activity_description";
            this.studentactivitydescriptionDataGridViewTextBoxColumn.HeaderText = "student_activity_description";
            this.studentactivitydescriptionDataGridViewTextBoxColumn.Name = "studentactivitydescriptionDataGridViewTextBoxColumn";
            // 
            // studentactivitytutorratingDataGridViewTextBoxColumn
            // 
            this.studentactivitytutorratingDataGridViewTextBoxColumn.DataPropertyName = "student_activity_tutorrating";
            this.studentactivitytutorratingDataGridViewTextBoxColumn.HeaderText = "student_activity_tutorrating";
            this.studentactivitytutorratingDataGridViewTextBoxColumn.Name = "studentactivitytutorratingDataGridViewTextBoxColumn";
            // 
            // studentactivityratingDataGridViewTextBoxColumn
            // 
            this.studentactivityratingDataGridViewTextBoxColumn.DataPropertyName = "student_activity_rating";
            this.studentactivityratingDataGridViewTextBoxColumn.HeaderText = "student_activity_rating";
            this.studentactivityratingDataGridViewTextBoxColumn.Name = "studentactivityratingDataGridViewTextBoxColumn";
            // 
            // studentemailaddressDataGridViewTextBoxColumn
            // 
            this.studentemailaddressDataGridViewTextBoxColumn.DataPropertyName = "student_emailaddress";
            this.studentemailaddressDataGridViewTextBoxColumn.HeaderText = "student_emailaddress";
            this.studentemailaddressDataGridViewTextBoxColumn.Name = "studentemailaddressDataGridViewTextBoxColumn";
            // 
            // studentmobilenumberDataGridViewTextBoxColumn
            // 
            this.studentmobilenumberDataGridViewTextBoxColumn.DataPropertyName = "student_mobilenumber";
            this.studentmobilenumberDataGridViewTextBoxColumn.HeaderText = "student_mobilenumber";
            this.studentmobilenumberDataGridViewTextBoxColumn.Name = "studentmobilenumberDataGridViewTextBoxColumn";
            // 
            // coordinatoridDataGridViewTextBoxColumn
            // 
            this.coordinatoridDataGridViewTextBoxColumn.DataPropertyName = "coordinator_id";
            this.coordinatoridDataGridViewTextBoxColumn.HeaderText = "coordinator_id";
            this.coordinatoridDataGridViewTextBoxColumn.Name = "coordinatoridDataGridViewTextBoxColumn";
            // 
            // coordinatorfirstnameDataGridViewTextBoxColumn
            // 
            this.coordinatorfirstnameDataGridViewTextBoxColumn.DataPropertyName = "coordinator_firstname";
            this.coordinatorfirstnameDataGridViewTextBoxColumn.HeaderText = "coordinator_firstname";
            this.coordinatorfirstnameDataGridViewTextBoxColumn.Name = "coordinatorfirstnameDataGridViewTextBoxColumn";
            // 
            // coordinatorlastnameDataGridViewTextBoxColumn
            // 
            this.coordinatorlastnameDataGridViewTextBoxColumn.DataPropertyName = "coordinator_lastname";
            this.coordinatorlastnameDataGridViewTextBoxColumn.HeaderText = "coordinator_lastname";
            this.coordinatorlastnameDataGridViewTextBoxColumn.Name = "coordinatorlastnameDataGridViewTextBoxColumn";
            // 
            // coordinatoridpassportDataGridViewTextBoxColumn
            // 
            this.coordinatoridpassportDataGridViewTextBoxColumn.DataPropertyName = "coordinator_id_passport";
            this.coordinatoridpassportDataGridViewTextBoxColumn.HeaderText = "coordinator_id_passport";
            this.coordinatoridpassportDataGridViewTextBoxColumn.Name = "coordinatoridpassportDataGridViewTextBoxColumn";
            // 
            // coordinatoremailaddressDataGridViewTextBoxColumn
            // 
            this.coordinatoremailaddressDataGridViewTextBoxColumn.DataPropertyName = "coordinator_emailaddress";
            this.coordinatoremailaddressDataGridViewTextBoxColumn.HeaderText = "coordinator_emailaddress";
            this.coordinatoremailaddressDataGridViewTextBoxColumn.Name = "coordinatoremailaddressDataGridViewTextBoxColumn";
            // 
            // coordinatorcellnumberDataGridViewTextBoxColumn
            // 
            this.coordinatorcellnumberDataGridViewTextBoxColumn.DataPropertyName = "coordinator_cellnumber";
            this.coordinatorcellnumberDataGridViewTextBoxColumn.HeaderText = "coordinator_cellnumber";
            this.coordinatorcellnumberDataGridViewTextBoxColumn.Name = "coordinatorcellnumberDataGridViewTextBoxColumn";
            // 
            // tutoridDataGridViewTextBoxColumn
            // 
            this.tutoridDataGridViewTextBoxColumn.DataPropertyName = "tutor_id";
            this.tutoridDataGridViewTextBoxColumn.HeaderText = "tutor_id";
            this.tutoridDataGridViewTextBoxColumn.Name = "tutoridDataGridViewTextBoxColumn";
            // 
            // tutorfirstnameDataGridViewTextBoxColumn
            // 
            this.tutorfirstnameDataGridViewTextBoxColumn.DataPropertyName = "tutor_firstname";
            this.tutorfirstnameDataGridViewTextBoxColumn.HeaderText = "tutor_firstname";
            this.tutorfirstnameDataGridViewTextBoxColumn.Name = "tutorfirstnameDataGridViewTextBoxColumn";
            // 
            // tutorlastnameDataGridViewTextBoxColumn
            // 
            this.tutorlastnameDataGridViewTextBoxColumn.DataPropertyName = "tutor_lastname";
            this.tutorlastnameDataGridViewTextBoxColumn.HeaderText = "tutor_lastname";
            this.tutorlastnameDataGridViewTextBoxColumn.Name = "tutorlastnameDataGridViewTextBoxColumn";
            // 
            // tutoridpassportDataGridViewTextBoxColumn
            // 
            this.tutoridpassportDataGridViewTextBoxColumn.DataPropertyName = "tutor_id_passport";
            this.tutoridpassportDataGridViewTextBoxColumn.HeaderText = "tutor_id_passport";
            this.tutoridpassportDataGridViewTextBoxColumn.Name = "tutoridpassportDataGridViewTextBoxColumn";
            // 
            // tutoremailaddressDataGridViewTextBoxColumn
            // 
            this.tutoremailaddressDataGridViewTextBoxColumn.DataPropertyName = "tutor_emailaddress";
            this.tutoremailaddressDataGridViewTextBoxColumn.HeaderText = "tutor_emailaddress";
            this.tutoremailaddressDataGridViewTextBoxColumn.Name = "tutoremailaddressDataGridViewTextBoxColumn";
            // 
            // tutorcellnumberDataGridViewTextBoxColumn
            // 
            this.tutorcellnumberDataGridViewTextBoxColumn.DataPropertyName = "tutor_cellnumber";
            this.tutorcellnumberDataGridViewTextBoxColumn.HeaderText = "tutor_cellnumber";
            this.tutorcellnumberDataGridViewTextBoxColumn.Name = "tutorcellnumberDataGridViewTextBoxColumn";
            // 
            // UpdateActivityModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 539);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateActivityModal";
            this.Text = "UpdateActivityModal";
            this.Load += new System.EventHandler(this.UpdateActivityModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCTIVITYFULLDATARowBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SSS_Library.IS2G10_DBSSSDataSetTableAdapters.ACTIVITY_FULL_DATATableAdapter activitY_FULL_DATATableAdapter1;
        private System.Windows.Forms.BindingSource aCTIVITYFULLDATARowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivitynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn studentarrivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivitypointvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivityweekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivitydescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivitytutorratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentactivityratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentemailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentmobilenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinatoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinatorfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinatorlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinatoridpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinatoremailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordinatorcellnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutoridpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutoremailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorcellnumberDataGridViewTextBoxColumn;
    }
}