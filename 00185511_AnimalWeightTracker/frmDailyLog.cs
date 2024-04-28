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
    public partial class frmDailyLog : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmDailyLog()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;

            pnlLnput.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

            txtLogId.Text = "";
            cboCourse.Text = "";
            cboActivity.Text = "";
            txtProgress.Text = "";
        }

        private void frmDailyLog_Load(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;


            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "log_Id";
            gv.Columns[1].DataPropertyName = "course_Id";
            gv.Columns[2].DataPropertyName = "Name";
            gv.Columns[3].DataPropertyName = "date";
            gv.Columns[4].DataPropertyName = "progress";

            LoadData();

            //Get Course Info
            var courseData = db.courses.ToList();

            cboCourse.DataSource = courseData;
            cboCourse.DisplayMember = "Name";
            cboCourse.ValueMember = "Id";

            //Get Activity Information
            var activityData = db.activities.ToList();

            cboActivity.DataSource = activityData;
            cboActivity.DisplayMember = "Name";
            cboActivity.ValueMember = "activity_Id";

            pnlLnput.Visible = false;
        }

        private void BtnHidePnl_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }


        private void LoadData()
        {
            var data = db.daily_log.Select(d => new { d.log_Id, d.course_id, d.activity.Name, d.date, d.progress }).ToList();
            gv.DataSource = data;
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
                        txtLogId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cboCourse.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        cboActivity.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dtLogDate.Value = DateTime.Parse(gv.Rows[e.RowIndex].Cells[3].Value.ToString());
                        txtProgress.Text = gv.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                    var data = db.daily_log.Where(d => d.log_Id == rowId).FirstOrDefault();

                    db.daily_log.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            daily_log dl = new daily_log();
            dl.course_id = Int32.Parse(cboCourse.SelectedValue.ToString());
            dl.activity_id = Int32.Parse(cboActivity.SelectedValue.ToString());
            dl.date = dtLogDate.Value;
            dl.progress = txtProgress.Text;

            db.daily_log.Add(dl);
            db.SaveChanges();

            txtLogId.Text = "";
            cboCourse.Text = "";
            cboActivity.Text = "";
            txtProgress.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtLogId.Text);
            var upData = db.daily_log.Where(d => d.log_Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.course_id = Int32.Parse(cboCourse.SelectedValue.ToString());
                upData.activity_id = Int32.Parse(cboActivity.SelectedValue.ToString());
                upData.date = dtLogDate.Value;
                upData.progress = txtProgress.Text;

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }
    }
}
