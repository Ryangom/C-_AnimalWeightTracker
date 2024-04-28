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
    public partial class frmCourse : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmCourse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;

            pnlLnput.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

            txtCourseId.Text = "";
            cboAnimalName.Text = "";
            cobStaffName.Text = "";
            txtGoal.Text = "";
            txtBMI.Text = "";
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "Id";
            gv.Columns[1].DataPropertyName = "start_date";
            gv.Columns[2].DataPropertyName = "end_date";
            gv.Columns[3].DataPropertyName = "name";
            gv.Columns[4].DataPropertyName = "Staff_name";
            gv.Columns[5].DataPropertyName = "goal";
            gv.Columns[6].DataPropertyName = "BMI";

            LoadData();

            //Get Animal Info
            var aniData = db.animals.ToList();

            cboAnimalName.DataSource = aniData;
            cboAnimalName.DisplayMember = "name";
            cboAnimalName.ValueMember = "animal_Id";

            //Get Staff Information
            var staffData = db.staffs.ToList();

            cobStaffName.DataSource = staffData;
            cobStaffName.DisplayMember = "Staff_name";
            cobStaffName.ValueMember = "staff_Id";

            pnlLnput.Visible = false;
        }

        private void BtnHidePnl_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }


        private void LoadData()
        {
            var data = db.courses.Select(d => new { d.Id, d.start_date, d.end_date,d.animal.name,d.staff.Staff_name, d.goal, d.BMI }).ToList();
            gv.DataSource = data;
        }


        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 7)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtCourseId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        dtStatingDate.Value = DateTime.Parse(gv.Rows[e.RowIndex].Cells[1].Value.ToString());
                        dtEndDate.Value = DateTime.Parse(gv.Rows[e.RowIndex].Cells[2].Value.ToString());
                        cboAnimalName.SelectedValue = gv.Rows[e.RowIndex].Cells[3].Value;
                        cobStaffName.SelectedValue = gv.Rows[e.RowIndex].Cells[4].Value;
                        txtGoal.Text = gv.Rows[e.RowIndex].Cells[5].Value.ToString();
                        txtBMI.Text = gv.Rows[e.RowIndex].Cells[6].Value.ToString();
                    }
                    catch (Exception)
                    {


                    }
                }

            }

            //Delete Button
            if (e.ColumnIndex == 8)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure about deleting this data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    int rowId = Int32.Parse(gv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var data = db.courses.Where(d => d.Id == rowId).FirstOrDefault();

                    db.courses.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Course Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            course course = new course();
            course.start_date = dtStatingDate.Value;
            course.end_date = dtEndDate.Value;
            course.animal_Id = Int32.Parse(cboAnimalName.SelectedValue.ToString());
            course.staff_id = Int32.Parse(cobStaffName.SelectedValue.ToString());
            course.goal = txtGoal.Text;

            var animalData = db.animals.Where(d => d.animal_Id == course.animal_Id).FirstOrDefault();
            decimal weight = Decimal.Parse(animalData.Weight.ToString());
            decimal height = Decimal.Parse(animalData.Height.ToString());

            decimal BMI = weight / (height * height);
            txtBMI.Text = BMI.ToString();
            course.BMI = Decimal.Parse(txtBMI.Text);


            db.courses.Add(course);
            db.SaveChanges();

            cboAnimalName.Text = "";
            cobStaffName.Text = "";
            txtGoal.Text = "";
            txtBMI.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtCourseId.Text);
            var upData = db.courses.Where(d => d.Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.start_date = dtStatingDate.Value;
                upData.end_date = dtEndDate.Value;
                upData.animal_Id = Int32.Parse(cboAnimalName.SelectedValue.ToString());
                upData.staff_id = Int32.Parse(cobStaffName.SelectedValue.ToString());
                upData.goal = txtGoal.Text;
                upData.BMI = Decimal.Parse(txtBMI.Text);

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }




    }
}
