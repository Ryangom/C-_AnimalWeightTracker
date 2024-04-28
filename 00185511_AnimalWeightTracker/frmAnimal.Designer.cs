
namespace _00185511_AnimalWeightTracker
{
    partial class frmAnimal
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
            this.animal_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.species_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.org_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblAllOrg = new System.Windows.Forms.Label();
            this.pnlLnput = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSpecies = new System.Windows.Forms.ComboBox();
            this.cboOrgName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnHidePnl = new System.Windows.Forms.Button();
            this.cboAnimalGender = new System.Windows.Forms.ComboBox();
            this.txtAnimalWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtAnimalAge = new System.Windows.Forms.TextBox();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAnimalId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.animal_Id,
            this.aName,
            this.age,
            this.Height,
            this.Weight,
            this.Gender,
            this.species_id,
            this.org_Id,
            this.btnEdit,
            this.btnDelete});
            this.gv.Location = new System.Drawing.Point(7, 97);
            this.gv.Name = "gv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv.Size = new System.Drawing.Size(1017, 336);
            this.gv.TabIndex = 17;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // animal_Id
            // 
            this.animal_Id.HeaderText = "Animal ID";
            this.animal_Id.Name = "animal_Id";
            this.animal_Id.Width = 110;
            // 
            // aName
            // 
            this.aName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aName.HeaderText = "Name";
            this.aName.Name = "aName";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // Height
            // 
            this.Height.HeaderText = "Height (ft)";
            this.Height.Name = "Height";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight(Kg)";
            this.Weight.Name = "Weight";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // species_id
            // 
            this.species_id.HeaderText = "Species";
            this.species_id.Name = "species_id";
            // 
            // org_Id
            // 
            this.org_Id.HeaderText = "Organization Name";
            this.org_Id.Name = "org_Id";
            this.org_Id.Width = 150;
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
            this.lblAllOrg.Location = new System.Drawing.Point(12, 19);
            this.lblAllOrg.Name = "lblAllOrg";
            this.lblAllOrg.Size = new System.Drawing.Size(264, 63);
            this.lblAllOrg.TabIndex = 1;
            this.lblAllOrg.Text = "All Animal Information";
            this.lblAllOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLnput
            // 
            this.pnlLnput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(129)))));
            this.pnlLnput.Controls.Add(this.label1);
            this.pnlLnput.Controls.Add(this.label3);
            this.pnlLnput.Controls.Add(this.label2);
            this.pnlLnput.Controls.Add(this.cboSpecies);
            this.pnlLnput.Controls.Add(this.cboOrgName);
            this.pnlLnput.Controls.Add(this.label13);
            this.pnlLnput.Controls.Add(this.BtnHidePnl);
            this.pnlLnput.Controls.Add(this.cboAnimalGender);
            this.pnlLnput.Controls.Add(this.txtAnimalWeight);
            this.pnlLnput.Controls.Add(this.txtHeight);
            this.pnlLnput.Controls.Add(this.txtAnimalAge);
            this.pnlLnput.Controls.Add(this.txtAnimalName);
            this.pnlLnput.Controls.Add(this.label12);
            this.pnlLnput.Controls.Add(this.txtAnimalId);
            this.pnlLnput.Controls.Add(this.label11);
            this.pnlLnput.Controls.Add(this.label6);
            this.pnlLnput.Controls.Add(this.label4);
            this.pnlLnput.Controls.Add(this.label10);
            this.pnlLnput.Controls.Add(this.label8);
            this.pnlLnput.Controls.Add(this.btnInsert);
            this.pnlLnput.Controls.Add(this.btnUpdate);
            this.pnlLnput.Location = new System.Drawing.Point(166, 138);
            this.pnlLnput.Name = "pnlLnput";
            this.pnlLnput.Size = new System.Drawing.Size(622, 425);
            this.pnlLnput.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "(In Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(511, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(492, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "ft";
            // 
            // cboSpecies
            // 
            this.cboSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpecies.FormattingEnabled = true;
            this.cboSpecies.Location = new System.Drawing.Point(197, 272);
            this.cboSpecies.Name = "cboSpecies";
            this.cboSpecies.Size = new System.Drawing.Size(290, 29);
            this.cboSpecies.TabIndex = 10;
            this.cboSpecies.SelectedIndexChanged += new System.EventHandler(this.cboOrgName_SelectedIndexChanged);
            // 
            // cboOrgName
            // 
            this.cboOrgName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrgName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrgName.FormattingEnabled = true;
            this.cboOrgName.Location = new System.Drawing.Point(197, 232);
            this.cboOrgName.Name = "cboOrgName";
            this.cboOrgName.Size = new System.Drawing.Size(290, 29);
            this.cboOrgName.TabIndex = 10;
            this.cboOrgName.SelectedIndexChanged += new System.EventHandler(this.cboOrgName_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Organization Name:";
            // 
            // BtnHidePnl
            // 
            this.BtnHidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnHidePnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHidePnl.FlatAppearance.BorderSize = 0;
            this.BtnHidePnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHidePnl.Location = new System.Drawing.Point(345, 345);
            this.BtnHidePnl.Name = "BtnHidePnl";
            this.BtnHidePnl.Size = new System.Drawing.Size(132, 37);
            this.BtnHidePnl.TabIndex = 8;
            this.BtnHidePnl.Text = "Close";
            this.BtnHidePnl.UseVisualStyleBackColor = false;
            this.BtnHidePnl.Click += new System.EventHandler(this.BtnHidePnl_Click);
            // 
            // cboAnimalGender
            // 
            this.cboAnimalGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimalGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnimalGender.FormattingEnabled = true;
            this.cboAnimalGender.Items.AddRange(new object[] {
            "Select",
            "Male",
            "Female"});
            this.cboAnimalGender.Location = new System.Drawing.Point(197, 121);
            this.cboAnimalGender.Name = "cboAnimalGender";
            this.cboAnimalGender.Size = new System.Drawing.Size(290, 29);
            this.cboAnimalGender.TabIndex = 7;
            // 
            // txtAnimalWeight
            // 
            this.txtAnimalWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalWeight.Location = new System.Drawing.Point(197, 194);
            this.txtAnimalWeight.Name = "txtAnimalWeight";
            this.txtAnimalWeight.Size = new System.Drawing.Size(290, 29);
            this.txtAnimalWeight.TabIndex = 5;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(197, 156);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(290, 29);
            this.txtHeight.TabIndex = 5;
            // 
            // txtAnimalAge
            // 
            this.txtAnimalAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalAge.Location = new System.Drawing.Point(197, 84);
            this.txtAnimalAge.Name = "txtAnimalAge";
            this.txtAnimalAge.Size = new System.Drawing.Size(290, 29);
            this.txtAnimalAge.TabIndex = 5;
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalName.Location = new System.Drawing.Point(197, 44);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(290, 29);
            this.txtAnimalName.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(120, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Weight:";
            // 
            // txtAnimalId
            // 
            this.txtAnimalId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalId.Location = new System.Drawing.Point(3, 3);
            this.txtAnimalId.Name = "txtAnimalId";
            this.txtAnimalId.ReadOnly = true;
            this.txtAnimalId.Size = new System.Drawing.Size(20, 29);
            this.txtAnimalId.TabIndex = 4;
            this.txtAnimalId.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(124, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(120, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Species:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(146, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(130, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Green;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(192, 345);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 37);
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
            this.btnUpdate.Location = new System.Drawing.Point(192, 345);
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
            this.btnAdd.Location = new System.Drawing.Point(7, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 629);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAllOrg);
            this.Controls.Add(this.pnlLnput);
            this.Controls.Add(this.gv);
            this.Name = "frmAnimal";
            this.Text = "frmAnimal";
            this.Load += new System.EventHandler(this.frmAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlLnput.ResumeLayout(false);
            this.pnlLnput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Label lblAllOrg;
        private System.Windows.Forms.Panel pnlLnput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOrgName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnHidePnl;
        private System.Windows.Forms.ComboBox cboAnimalGender;
        private System.Windows.Forms.TextBox txtAnimalWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtAnimalAge;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAnimalId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSpecies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn animal_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn species_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_Id;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}