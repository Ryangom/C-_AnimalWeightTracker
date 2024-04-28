
namespace _00185511_AnimalWeightTracker
{
    partial class frmReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblAvgWeight = new System.Windows.Forms.Label();
            this.lblLossGain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnSpline = new System.Windows.Forms.Button();
            this.btn3D = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            this.log_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waist_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(121, 354);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(15, 17);
            this.lblWeight.TabIndex = 18;
            this.lblWeight.Text = "0";
            // 
            // lblAvgWeight
            // 
            this.lblAvgWeight.AutoSize = true;
            this.lblAvgWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgWeight.Location = new System.Drawing.Point(121, 384);
            this.lblAvgWeight.Name = "lblAvgWeight";
            this.lblAvgWeight.Size = new System.Drawing.Size(15, 17);
            this.lblAvgWeight.TabIndex = 19;
            this.lblAvgWeight.Text = "0";
            // 
            // lblLossGain
            // 
            this.lblLossGain.AutoSize = true;
            this.lblLossGain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLossGain.Location = new System.Drawing.Point(120, 323);
            this.lblLossGain.Name = "lblLossGain";
            this.lblLossGain.Size = new System.Drawing.Size(15, 17);
            this.lblLossGain.TabIndex = 20;
            this.lblLossGain.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Weight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Average Weight";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(29, 323);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(77, 17);
            this.lblDisplay.TabIndex = 17;
            this.lblDisplay.Text = "Loss / Gain";
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(905, 337);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(75, 23);
            this.btnPi.TabIndex = 14;
            this.btnPi.Text = "Pie";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnSpline
            // 
            this.btnSpline.Location = new System.Drawing.Point(804, 337);
            this.btnSpline.Name = "btnSpline";
            this.btnSpline.Size = new System.Drawing.Size(75, 23);
            this.btnSpline.TabIndex = 13;
            this.btnSpline.Text = "Line";
            this.btnSpline.UseVisualStyleBackColor = true;
            this.btnSpline.Click += new System.EventHandler(this.btnSpline_Click);
            // 
            // btn3D
            // 
            this.btn3D.Location = new System.Drawing.Point(699, 337);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(75, 23);
            this.btn3D.TabIndex = 12;
            this.btn3D.Text = "3D";
            this.btn3D.UseVisualStyleBackColor = true;
            this.btn3D.Click += new System.EventHandler(this.btn3D_Click);
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.log_Id,
            this.name,
            this.waist_size,
            this.weight,
            this.shift,
            this.m_date});
            this.gv.Location = new System.Drawing.Point(32, 405);
            this.gv.Name = "gv";
            this.gv.Size = new System.Drawing.Size(979, 212);
            this.gv.TabIndex = 11;
            // 
            // log_Id
            // 
            this.log_Id.HeaderText = "Log ID";
            this.log_Id.Name = "log_Id";
            // 
            // name
            // 
            this.name.HeaderText = "Animal Name";
            this.name.Name = "name";
            // 
            // waist_size
            // 
            this.waist_size.HeaderText = "Waist Size";
            this.waist_size.Name = "waist_size";
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            // 
            // shift
            // 
            this.shift.HeaderText = "Shift";
            this.shift.Name = "shift";
            // 
            // m_date
            // 
            this.m_date.HeaderText = "Date";
            this.m_date.Name = "m_date";
            // 
            // cboAnimal
            // 
            this.cboAnimal.FormattingEnabled = true;
            this.cboAnimal.Location = new System.Drawing.Point(548, 337);
            this.cboAnimal.Name = "cboAnimal";
            this.cboAnimal.Size = new System.Drawing.Size(121, 21);
            this.cboAnimal.TabIndex = 10;
            this.cboAnimal.SelectionChangeCommitted += new System.EventHandler(this.cboAnimal_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Animal :";
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(116, 12);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(828, 300);
            this.Chart1.TabIndex = 21;
            this.Chart1.Text = "chart1";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 629);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblAvgWeight);
            this.Controls.Add(this.lblLossGain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnSpline);
            this.Controls.Add(this.btn3D);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.cboAnimal);
            this.Controls.Add(this.label1);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblAvgWeight;
        private System.Windows.Forms.Label lblLossGain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnSpline;
        private System.Windows.Forms.Button btn3D;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn waist_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_date;
        private System.Windows.Forms.ComboBox cboAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
    }
}