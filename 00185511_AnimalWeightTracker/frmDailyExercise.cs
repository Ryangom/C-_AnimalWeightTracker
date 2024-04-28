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
    public partial class frmDailyExercise : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmDailyExercise()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var data = db.daily_exercise.Select(d => new { d.Id, d.log_id, d.time, d.exercise.name,d.exercise_dates}).ToList();
            gv.DataSource = data;
        }

        private void frmDailyExercise_Load(object sender, EventArgs e)
        {
            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "Id";
            gv.Columns[1].DataPropertyName = "log_Id";
            gv.Columns[2].DataPropertyName = "time";
            gv.Columns[3].DataPropertyName = "name";
            gv.Columns[4].DataPropertyName = "exercise_dates";

            LoadData();

            //Get DailyLog Info
            var logData = db.daily_log.ToList();

            cboLogID.DataSource = logData;
            cboLogID.DisplayMember = "Name";
            cboLogID.ValueMember = "log_Id";

            //Get Exercise Info
            var exData = db.exercises.ToList();

            cboExerciseID.DataSource = exData;
            cboExerciseID.DisplayMember = "Name";
            cboExerciseID.ValueMember = "Id";

            pnlLnput.Visible = false;

            //Button Icons
            //btnAdd.Text = char.ConvertFromUtf32('\u2795') + " ADD";
            //btnClosePanel.Text = char.ConvertFromUtf32('\u274c');
            //btnSave.Text = "\uD83D\uDCBE";
            //btnEdit.Text = "\uD83D\uDD8A" + " Edit";
            //btnDelete.Text = "\uD83D\uDDD1" + " Delete";
            //btnUpdate.Text = "\uD83D\uDCBE";
            //btnClose.Text = char.ConvertFromUtf32('\u274c'); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

            cboExerciseID.Text = "";
            cboLogID.Text = "";
            txtDuration.Text = "";
            cboExerciseID.Text = "";
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 5)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtDailyExercise.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cboLogID.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtDuration.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        cboExerciseID.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
                        dtExercise.Value = DateTime.Parse(gv.Rows[e.RowIndex].Cells[4].Value.ToString());
                    }
                    catch (Exception)
                    {


                    }
                }

            }

            //Delete Button
            if (e.ColumnIndex == 6)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure about deleting this data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    int rowId = Int32.Parse(gv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var data = db.daily_exercise.Where(d => d.Id == rowId).FirstOrDefault();

                    db.daily_exercise.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Daily Exercise Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            daily_exercise dEx = new daily_exercise();

            dEx.log_id = Int32.Parse(cboLogID.SelectedValue.ToString());
            dEx.time = txtDuration.Text;
            dEx.exercise_id = Int32.Parse(cboExerciseID.SelectedValue.ToString());
            dEx.exercise_dates = dtExercise.Value;

            db.daily_exercise.Add(dEx);
            db.SaveChanges();

            txtDailyExercise.Text = "";
            cboLogID.Text = "";
            txtDuration.Text = "";
            cboExerciseID.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtDailyExercise.Text);
            var upData = db.daily_exercise.Where(d => d.Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.log_id = Int32.Parse(cboLogID.SelectedValue.ToString());
                upData.time = txtDuration.Text;
                upData.exercise_id = Int32.Parse(cboExerciseID.Text);
                upData.exercise_dates = dtExercise.Value;

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
