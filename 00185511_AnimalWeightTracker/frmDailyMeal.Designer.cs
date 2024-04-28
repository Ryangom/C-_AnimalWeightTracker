
namespace _00185511_AnimalWeightTracker
{
    partial class frmDailyMeal
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
            this.lblAllOrg = new System.Windows.Forms.Label();
            this.gv = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meal_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meal_Intake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlLnput = new System.Windows.Forms.Panel();
            this.cobMeal = new System.Windows.Forms.ComboBox();
            this.cobLog = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnHidePnl = new System.Windows.Forms.Button();
            this.txtIntake = new System.Windows.Forms.TextBox();
            this.txtMealId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.pnlLnput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAllOrg
            // 
            this.lblAllOrg.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllOrg.Location = new System.Drawing.Point(12, 9);
            this.lblAllOrg.Name = "lblAllOrg";
            this.lblAllOrg.Size = new System.Drawing.Size(303, 63);
            this.lblAllOrg.TabIndex = 1;
            this.lblAllOrg.Text = "Daily Meal Information";
            this.lblAllOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.log_Id,
            this.meal_Id,
            this.meal_Intake,
            this.btnEdit,
            this.btnDelete});
            this.gv.Location = new System.Drawing.Point(12, 81);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(1008, 354);
            this.gv.TabIndex = 17;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // log_Id
            // 
            this.log_Id.HeaderText = "Log ID";
            this.log_Id.Name = "log_Id";
            // 
            // meal_Id
            // 
            this.meal_Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.meal_Id.HeaderText = "Meal Name";
            this.meal_Id.Name = "meal_Id";
            this.meal_Id.Width = 115;
            // 
            // meal_Intake
            // 
            this.meal_Intake.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.meal_Intake.HeaderText = "Meal Intake";
            this.meal_Intake.Name = "meal_Intake";
            this.meal_Intake.Width = 115;
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
            // pnlLnput
            // 
            this.pnlLnput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(70)))), ((int)(((byte)(129)))));
            this.pnlLnput.Controls.Add(this.cobMeal);
            this.pnlLnput.Controls.Add(this.cobLog);
            this.pnlLnput.Controls.Add(this.label2);
            this.pnlLnput.Controls.Add(this.label13);
            this.pnlLnput.Controls.Add(this.BtnHidePnl);
            this.pnlLnput.Controls.Add(this.txtIntake);
            this.pnlLnput.Controls.Add(this.txtMealId);
            this.pnlLnput.Controls.Add(this.label10);
            this.pnlLnput.Controls.Add(this.label8);
            this.pnlLnput.Controls.Add(this.btnSave);
            this.pnlLnput.Controls.Add(this.btnUpdate);
            this.pnlLnput.Location = new System.Drawing.Point(202, 190);
            this.pnlLnput.Name = "pnlLnput";
            this.pnlLnput.Size = new System.Drawing.Size(622, 321);
            this.pnlLnput.TabIndex = 22;
            // 
            // cobMeal
            // 
            this.cobMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobMeal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobMeal.FormattingEnabled = true;
            this.cobMeal.Location = new System.Drawing.Point(189, 108);
            this.cobMeal.Name = "cobMeal";
            this.cobMeal.Size = new System.Drawing.Size(290, 29);
            this.cobMeal.TabIndex = 10;
            // 
            // cobLog
            // 
            this.cobLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobLog.FormattingEnabled = true;
            this.cobLog.Location = new System.Drawing.Point(189, 68);
            this.cobLog.Name = "cobLog";
            this.cobLog.Size = new System.Drawing.Size(290, 29);
            this.cobLog.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(483, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "(in gram)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(53, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Intake Amount:";
            // 
            // BtnHidePnl
            // 
            this.BtnHidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnHidePnl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHidePnl.FlatAppearance.BorderSize = 0;
            this.BtnHidePnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHidePnl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHidePnl.Location = new System.Drawing.Point(342, 214);
            this.BtnHidePnl.Name = "BtnHidePnl";
            this.BtnHidePnl.Size = new System.Drawing.Size(132, 37);
            this.BtnHidePnl.TabIndex = 8;
            this.BtnHidePnl.Text = "Close";
            this.BtnHidePnl.UseVisualStyleBackColor = false;
            this.BtnHidePnl.Click += new System.EventHandler(this.btnClosePanel_Click);
            // 
            // txtIntake
            // 
            this.txtIntake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntake.Location = new System.Drawing.Point(187, 150);
            this.txtIntake.Name = "txtIntake";
            this.txtIntake.Size = new System.Drawing.Size(290, 29);
            this.txtIntake.TabIndex = 5;
            // 
            // txtMealId
            // 
            this.txtMealId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealId.Location = new System.Drawing.Point(3, 3);
            this.txtMealId.Name = "txtMealId";
            this.txtMealId.ReadOnly = true;
            this.txtMealId.Size = new System.Drawing.Size(35, 29);
            this.txtMealId.TabIndex = 4;
            this.txtMealId.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(111, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Meal Id:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(121, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Log Id:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(189, 214);
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
            this.btnUpdate.Location = new System.Drawing.Point(189, 214);
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
            this.btnAdd.Location = new System.Drawing.Point(12, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 37);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add Data";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmDailyMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 629);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAllOrg);
            this.Controls.Add(this.pnlLnput);
            this.Controls.Add(this.gv);
            this.Name = "frmDailyMeal";
            this.Text = "frmDailyMeal";
            this.Load += new System.EventHandler(this.frmDailyMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlLnput.ResumeLayout(false);
            this.pnlLnput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAllOrg;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Panel pnlLnput;
        private System.Windows.Forms.ComboBox cobLog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnHidePnl;
        private System.Windows.Forms.TextBox txtIntake;
        private System.Windows.Forms.TextBox txtMealId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cobMeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn meal_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn meal_Intake;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}