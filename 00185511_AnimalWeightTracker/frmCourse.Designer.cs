
namespace _00185511_AnimalWeightTracker
{
    partial class frmCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animal_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staff_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAllOrg = new System.Windows.Forms.Label();
            this.pnlLnput = new System.Windows.Forms.Panel();
            this.dtStatingDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboAnimalName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnHidePnl = new System.Windows.Forms.Button();
            this.cobStaffName = new System.Windows.Forms.ComboBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCourseId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.pnlLnput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.start_date,
            this.end_date,
            this.animal_Id,
            this.staff_Id,
            this.goal,
            this.BMI,
            this.btnEdit,
            this.btnDelete});
            this.gv.Location = new System.Drawing.Point(12, 81);
            this.gv.Name = "gv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(999, 403);
            this.gv.TabIndex = 17;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // start_date
            // 
            this.start_date.HeaderText = "Start Date";
            this.start_date.Name = "start_date";
            this.start_date.Width = 150;
            // 
            // end_date
            // 
            this.end_date.HeaderText = "End Date";
            this.end_date.Name = "end_date";
            // 
            // animal_Id
            // 
            this.animal_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.animal_Id.HeaderText = "Animal Name";
            this.animal_Id.Name = "animal_Id";
            // 
            // staff_Id
            // 
            this.staff_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staff_Id.HeaderText = "Staff Name";
            this.staff_Id.Name = "staff_Id";
            // 
            // goal
            // 
            this.goal.HeaderText = "Goal";
            this.goal.Name = "goal";
            // 
            // BMI
            // 
            this.BMI.HeaderText = "BMI";
            this.BMI.Name = "BMI";
            // 
            // btnEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Update";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // lblAllOrg
            // 
            this.lblAllOrg.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllOrg.Location = new System.Drawing.Point(8, 1);
            this.lblAllOrg.Name = "lblAllOrg";
            this.lblAllOrg.Size = new System.Drawing.Size(1179, 77);
            this.lblAllOrg.TabIndex = 1;
            this.lblAllOrg.Text = "Course Information";
            this.lblAllOrg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlLnput
            // 
            this.pnlLnput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(129)))));
            this.pnlLnput.Controls.Add(this.dtStatingDate);
            this.pnlLnput.Controls.Add(this.dtEndDate);
            this.pnlLnput.Controls.Add(this.cboAnimalName);
            this.pnlLnput.Controls.Add(this.label13);
            this.pnlLnput.Controls.Add(this.BtnHidePnl);
            this.pnlLnput.Controls.Add(this.cobStaffName);
            this.pnlLnput.Controls.Add(this.txtBMI);
            this.pnlLnput.Controls.Add(this.txtGoal);
            this.pnlLnput.Controls.Add(this.label5);
            this.pnlLnput.Controls.Add(this.label12);
            this.pnlLnput.Controls.Add(this.txtCourseId);
            this.pnlLnput.Controls.Add(this.label8);
            this.pnlLnput.Controls.Add(this.label10);
            this.pnlLnput.Controls.Add(this.label14);
            this.pnlLnput.Controls.Add(this.btnSave);
            this.pnlLnput.Controls.Add(this.btnUpdate);
            this.pnlLnput.Location = new System.Drawing.Point(219, 174);
            this.pnlLnput.Name = "pnlLnput";
            this.pnlLnput.Size = new System.Drawing.Size(580, 401);
            this.pnlLnput.TabIndex = 22;
            // 
            // dtStatingDate
            // 
            this.dtStatingDate.CustomFormat = "dd-MM-yyyy ";
            this.dtStatingDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtStatingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStatingDate.Location = new System.Drawing.Point(181, 57);
            this.dtStatingDate.Name = "dtStatingDate";
            this.dtStatingDate.Size = new System.Drawing.Size(290, 29);
            this.dtStatingDate.TabIndex = 23;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "dd-MM-yyyy ";
            this.dtEndDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(182, 98);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(290, 29);
            this.dtEndDate.TabIndex = 23;
            // 
            // cboAnimalName
            // 
            this.cboAnimalName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimalName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnimalName.FormattingEnabled = true;
            this.cboAnimalName.Location = new System.Drawing.Point(182, 137);
            this.cboAnimalName.Name = "cboAnimalName";
            this.cboAnimalName.Size = new System.Drawing.Size(290, 29);
            this.cboAnimalName.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(57, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Animal Name:";
            // 
            // BtnHidePnl
            // 
            this.BtnHidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnHidePnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHidePnl.FlatAppearance.BorderSize = 0;
            this.BtnHidePnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHidePnl.Location = new System.Drawing.Point(331, 313);
            this.BtnHidePnl.Name = "BtnHidePnl";
            this.BtnHidePnl.Size = new System.Drawing.Size(132, 37);
            this.BtnHidePnl.TabIndex = 8;
            this.BtnHidePnl.Text = "Close";
            this.BtnHidePnl.UseVisualStyleBackColor = false;
            this.BtnHidePnl.Click += new System.EventHandler(this.BtnHidePnl_Click);
            // 
            // cobStaffName
            // 
            this.cobStaffName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobStaffName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobStaffName.FormattingEnabled = true;
            this.cobStaffName.Location = new System.Drawing.Point(182, 177);
            this.cobStaffName.Name = "cobStaffName";
            this.cobStaffName.Size = new System.Drawing.Size(290, 29);
            this.cobStaffName.TabIndex = 7;
            // 
            // txtBMI
            // 
            this.txtBMI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBMI.Location = new System.Drawing.Point(182, 256);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(290, 29);
            this.txtBMI.TabIndex = 5;
            // 
            // txtGoal
            // 
            this.txtGoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.Location = new System.Drawing.Point(182, 218);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(290, 29);
            this.txtGoal.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(132, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "BMI:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(99, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Set Goal:";
            // 
            // txtCourseId
            // 
            this.txtCourseId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseId.Location = new System.Drawing.Point(539, 13);
            this.txtCourseId.Name = "txtCourseId";
            this.txtCourseId.ReadOnly = true;
            this.txtCourseId.Size = new System.Drawing.Size(28, 29);
            this.txtCourseId.TabIndex = 4;
            this.txtCourseId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Staff Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(68, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ending Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(61, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Starting Date:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(178, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Insert";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(178, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 37);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(12, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 37);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 629);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAllOrg);
            this.Controls.Add(this.pnlLnput);
            this.Controls.Add(this.gv);
            this.Name = "frmCourse";
            this.Text = "frmCourse";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlLnput.ResumeLayout(false);
            this.pnlLnput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label lblAllOrg;
        private System.Windows.Forms.Panel pnlLnput;
        private System.Windows.Forms.ComboBox cboAnimalName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnHidePnl;
        private System.Windows.Forms.ComboBox cobStaffName;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCourseId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStatingDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BMI;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}