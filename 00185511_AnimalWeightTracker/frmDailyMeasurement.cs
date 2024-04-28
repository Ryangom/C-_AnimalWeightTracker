using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00185511_AnimalWeightTracker
{
    public partial class frmDailyMeasurement : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmDailyMeasurement()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void frmDailyMeasurement_Load(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;


            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "Id";
            gv.Columns[1].DataPropertyName = "log_Id";
            gv.Columns[2].DataPropertyName = "waist_Size";
            gv.Columns[3].DataPropertyName = "weight";
            gv.Columns[4].DataPropertyName = "shift";
            gv.Columns[5].DataPropertyName = "Excersice_date";

            LoadData();

            //Get DailyLog Info
            var logData = db.daily_log.ToList();

            cboLogId.DataSource = logData;
            cboLogId.DisplayMember = "ID";
            cboLogId.ValueMember = "log_Id";

            pnlLnput.Visible = false;

            //Button Icons
            //btnAdd.Text = char.ConvertFromUtf32('\u2795') + " ADD";
            //btnClosePanel.Text = char.ConvertFromUtf32('\u274c');
            //btnSave.Text = "\uD83D\uDCBE";
            //btnEdit.Text = "\uD83D\uDD8A" + " Edit";
            //btnDelete.Text = "\uD83D\uDDD1" + " Delete";
            //btnUpdate.Text = "\uD83D\uDCBE";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

            txtMeasurementId.Text = "";
            cboLogId.Text = "";
            txtWaist.Text = "";
            txtWeight.Text = "";
            txtShift.Text = "";
        }

        private void BtnHidePnl_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }



        private void LoadData()
        {
            var data = db.daily_measurement.Select(t => new { t.Id, t.log_id, t.waist_size, t.weight, t.shift,t.Excersice_date}).ToList();
            gv.DataSource = data;
        }


        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 6)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtMeasurementId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cboLogId.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtWaist.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtWeight.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtShift.Text = gv.Rows[e.RowIndex].Cells[4].Value.ToString();
                        dtExerciseDate.Value = DateTime.Parse(gv.Rows[e.RowIndex].Cells[5].Value.ToString());
                    }
                    catch (Exception)
                    {


                    }
                }

            }

            //Delete Button
            if (e.ColumnIndex == 7)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure about deleting this data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    int rowId = Int32.Parse(gv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var data = db.daily_measurement.Where(d => d.Id == rowId).FirstOrDefault();

                    db.daily_measurement.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            daily_measurement dm = new daily_measurement();
            dm.log_id = Int32.Parse(cboLogId.SelectedValue.ToString());
            dm.waist_size = Int32.Parse(txtWaist.Text);
            dm.weight = Decimal.Parse(txtWeight.Text);
            dm.shift = txtShift.Text;
           dm.Excersice_date= dtExerciseDate.Value;

            db.daily_measurement.Add(dm);
            db.SaveChanges();

            cboLogId.Text = "";
            txtWaist.Text = "";
            txtWeight.Text = "";
            txtShift.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtMeasurementId.Text);
            var upData = db.daily_measurement.Where(d => d.Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.log_id = Int32.Parse(cboLogId.SelectedValue.ToString());
                upData.waist_size = Int32.Parse(txtWaist.Text);
                upData.weight = Decimal.Parse(txtWeight.Text);
                upData.shift = txtShift.Text;
                upData.Excersice_date = dtExerciseDate.Value;

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
