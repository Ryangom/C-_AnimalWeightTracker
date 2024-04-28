using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _00185511_AnimalWeightTracker
{
    public partial class frmReport : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();


        public frmReport()
        {
            InitializeComponent();
            Chart1.ChartAreas["ChartArea1"].AxisX.Title = "Day";
            Chart1.ChartAreas["ChartArea1"].AxisY.Title = "Weight";
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var animalData = db.animals.ToList();

            animalData.Insert(0, new animal() { animal_Id = 0, name = "--Select--" });

            cboAnimal.DataSource = animalData;
            cboAnimal.DisplayMember = "Name";
            cboAnimal.ValueMember = "animal_Id";

            if (animalData.Count <= 0)
            {
                MessageBox.Show("No Animal Found");
                this.Close();
                return;
            }

            var data = db.daily_measurement.Select(t => new { t.log_id, t.daily_log.course.animal.name, t.waist_size, t.weight, t.shift, t.Excersice_date }).ToList();

            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "log_Id";
            gv.Columns[1].DataPropertyName = "Name";
            gv.Columns[2].DataPropertyName = "waist_Size";
            gv.Columns[3].DataPropertyName = "weight";
            gv.Columns[4].DataPropertyName = "shift";
            gv.Columns[5].DataPropertyName = "Excersice_date";
            gv.DataSource = data;
        }

        private void cboAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int aniId = Int32.Parse(cboAnimal.SelectedValue.ToString());

            if (aniId.ToString() != null)
            {
                var chartData = db.daily_measurement.Where(d => d.daily_log.course.animal.animal_Id == aniId).ToList();
                Chart1.DataSource = chartData;
                Chart1.Series["Series1"].XValueMember = "Excersice_date";
                Chart1.Series["Series1"].YValueMembers = "weight";
                Chart1.Series["Series1"].XValueType = ChartValueType.DateTime;
                Chart1.Series[0].ChartType = SeriesChartType.Line;
            }

            //Total Sum of Weight 
            var total_Weight = db.daily_measurement.Where(t => t.daily_log.course.animal.animal_Id == aniId).Sum(s => s.weight);
            var count = db.daily_measurement.Count(a => a.daily_log.course.animal.animal_Id == aniId);
            // Average Weight
            var averageWeight = total_Weight / count;
            var firstDay = db.animals.Where(t => t.animal_Id == aniId).FirstOrDefault();
            // Calculate Weight
            Decimal weight = Decimal.Parse(firstDay.Weight.ToString());

            // Calculate weight loss or gain
            var loss_Gain = averageWeight - weight;

            if (loss_Gain < 0)
            {
                lblDisplay.Text = "Weight Loss";
                lblLossGain.Text = loss_Gain.ToString();
            }

            else
            {
                lblDisplay.Text = "Weight Gain";
                lblLossGain.Text = loss_Gain.ToString();
            }

            lblWeight.Text = weight.ToString();
            lblAvgWeight.Text = averageWeight.ToString();
        }

        private void btn3D_Click(object sender, EventArgs e)
        {
            if (btn3D.Text == "3D")
            {
                Chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                btn3D.Text = "2D";
            }

            else
            {
                Chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
                btn3D.Text = "3D";
            }
        }

        private void btnSpline_Click(object sender, EventArgs e)
        {
            Chart1.Series[0].ChartType = SeriesChartType.StepLine;
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            Chart1.Series[0].ChartType = SeriesChartType.Pie;
        }
    }
}
