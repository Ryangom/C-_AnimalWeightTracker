
namespace _00185511_AnimalWeightTracker
{
    partial class frmStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gv = new System.Windows.Forms.DataGridView();
            this.staff_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAllOrg = new System.Windows.Forms.Label();
            this.pnlLnput = new System.Windows.Forms.Panel();
            this.pnClose = new System.Windows.Forms.Button();
            this.cboOrg = new System.Windows.Forms.ComboBox();
            this.txtStaffAddress = new System.Windows.Forms.TextBox();
            this.txtStaffDesig = new System.Windows.Forms.TextBox();
            this.txtStaffAge = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.StafId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
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
            this.staff_Id,
            this.sName,
            this.age,
            this.staffAddress,
            this.deg,
            this.org_Id,
            this.btnEdit,
            this.btnDelete});
            this.gv.Location = new System.Drawing.Point(12, 81);
            this.gv.Name = "gv";
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(999, 343);
            this.gv.TabIndex = 13;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // staff_Id
            // 
            this.staff_Id.HeaderText = "Staff ID";
            this.staff_Id.Name = "staff_Id";
            // 
            // sName
            // 
            this.sName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sName.HeaderText = "Staff Name";
            this.sName.Name = "sName";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // staffAddress
            // 
            this.staffAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.staffAddress.HeaderText = "Address";
            this.staffAddress.Name = "staffAddress";
            // 
            // deg
            // 
            this.deg.HeaderText = "Designation";
            this.deg.Name = "deg";
            // 
            // org_Id
            // 
            this.org_Id.HeaderText = "Organization Name";
            this.org_Id.Name = "org_Id";
            this.org_Id.Width = 200;
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
            this.lblAllOrg.Location = new System.Drawing.Point(12, 15);
            this.lblAllOrg.Name = "lblAllOrg";
            this.lblAllOrg.Size = new System.Drawing.Size(245, 63);
            this.lblAllOrg.TabIndex = 1;
            this.lblAllOrg.Text = "Staffs Information";
            this.lblAllOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLnput
            // 
            this.pnlLnput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(129)))));
            this.pnlLnput.Controls.Add(this.pnClose);
            this.pnlLnput.Controls.Add(this.cboOrg);
            this.pnlLnput.Controls.Add(this.txtStaffAddress);
            this.pnlLnput.Controls.Add(this.txtStaffDesig);
            this.pnlLnput.Controls.Add(this.txtStaffAge);
            this.pnlLnput.Controls.Add(this.txtStaffName);
            this.pnlLnput.Controls.Add(this.StafId);
            this.pnlLnput.Controls.Add(this.label2);
            this.pnlLnput.Controls.Add(this.label6);
            this.pnlLnput.Controls.Add(this.label1);
            this.pnlLnput.Controls.Add(this.label3);
            this.pnlLnput.Controls.Add(this.label4);
            this.pnlLnput.Controls.Add(this.btnInsert);
            this.pnlLnput.Controls.Add(this.btnUpdate);
            this.pnlLnput.Location = new System.Drawing.Point(247, 124);
            this.pnlLnput.Name = "pnlLnput";
            this.pnlLnput.Size = new System.Drawing.Size(624, 436);
            this.pnlLnput.TabIndex = 17;
            // 
            // pnClose
            // 
            this.pnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnClose.FlatAppearance.BorderSize = 0;
            this.pnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnClose.Location = new System.Drawing.Point(408, 343);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(117, 32);
            this.pnClose.TabIndex = 8;
            this.pnClose.Text = "Close";
            this.pnClose.UseVisualStyleBackColor = false;
            this.pnClose.Click += new System.EventHandler(this.pnClose_Click);
            // 
            // cboOrg
            // 
            this.cboOrg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrg.FormattingEnabled = true;
            this.cboOrg.Location = new System.Drawing.Point(235, 276);
            this.cboOrg.Name = "cboOrg";
            this.cboOrg.Size = new System.Drawing.Size(290, 29);
            this.cboOrg.TabIndex = 7;
            // 
            // txtStaffAddress
            // 
            this.txtStaffAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAddress.Location = new System.Drawing.Point(235, 169);
            this.txtStaffAddress.Multiline = true;
            this.txtStaffAddress.Name = "txtStaffAddress";
            this.txtStaffAddress.Size = new System.Drawing.Size(290, 52);
            this.txtStaffAddress.TabIndex = 6;
            // 
            // txtStaffDesig
            // 
            this.txtStaffDesig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffDesig.Location = new System.Drawing.Point(235, 234);
            this.txtStaffDesig.Name = "txtStaffDesig";
            this.txtStaffDesig.Size = new System.Drawing.Size(290, 29);
            this.txtStaffDesig.TabIndex = 5;
            // 
            // txtStaffAge
            // 
            this.txtStaffAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffAge.Location = new System.Drawing.Point(235, 122);
            this.txtStaffAge.Name = "txtStaffAge";
            this.txtStaffAge.Size = new System.Drawing.Size(290, 29);
            this.txtStaffAge.TabIndex = 5;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(235, 71);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(290, 29);
            this.txtStaffName.TabIndex = 5;
            // 
            // StafId
            // 
            this.StafId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StafId.Location = new System.Drawing.Point(3, 3);
            this.StafId.Name = "StafId";
            this.StafId.ReadOnly = true;
            this.StafId.Size = new System.Drawing.Size(19, 29);
            this.StafId.TabIndex = 4;
            this.StafId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Organization Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(150, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Designation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(150, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(84)))));
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(285, 343);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(117, 32);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(285, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 32);
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
            this.btnAdd.Location = new System.Drawing.Point(12, 436);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 37);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 629);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAllOrg);
            this.Controls.Add(this.pnlLnput);
            this.Controls.Add(this.gv);
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlLnput.ResumeLayout(false);
            this.pnlLnput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label lblAllOrg;
        private System.Windows.Forms.Panel pnlLnput;
        private System.Windows.Forms.Button pnClose;
        private System.Windows.Forms.ComboBox cboOrg;
        private System.Windows.Forms.TextBox txtStaffAddress;
        private System.Windows.Forms.TextBox txtStaffAge;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox StafId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtStaffDesig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn staff_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn deg;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_Id;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}