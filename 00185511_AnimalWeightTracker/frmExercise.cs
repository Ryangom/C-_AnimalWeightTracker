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
    public partial class frmExercise : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmExercise()
        {
            InitializeComponent();
        }

        private void frmExercise_Load(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "Id";
            gv.Columns[1].DataPropertyName = "name";
            gv.Columns[2].DataPropertyName = "time";
            gv.Columns[3].DataPropertyName = "calories_burn";
            gv.Columns[4].DataPropertyName = "exercise_type";

            LoadData();


            pnlLnput.Visible = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;


            pnlLnput.Visible = true;
            btnInsert.Visible = true;
            btnUpdate.Visible = false;

            txtExerciseId.Text = "";
            txtExerciseName.Text = "";
            txtDuration.Text = "";
            txtCaloriesBurn.Text = "";
            txtExerciseType.Text = "";
        }

        private void BtnHidePnl_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }


        private void LoadData()
        {
            var data = db.exercises.Select(d => new { d.Id, d.name, d.time, d.calories_burn, d.exercise_type }).ToList();
            gv.DataSource = data;
        }

        //private void frmExercise_Load(object sender, EventArgs e)
        //{
            

        //    //Button Icons
        //    //btnAdd.Text = char.ConvertFromUtf32('\u2795') + " ADD";
        //    //btnClosePanel.Text = char.ConvertFromUtf32('\u274c');
        //    //btnSave.Text = "\uD83D\uDCBE";
        //    //btnEdit.Text = "\uD83D\uDD8A" + " Edit";
        //    //btnDelete.Text = "\uD83D\uDDD1" + " Delete";
        //    //btnUpdate.Text = "\uD83D\uDCBE";
        //}


        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 5)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnInsert.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtExerciseId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtExerciseName.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtDuration.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtCaloriesBurn.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtExerciseType.Text = gv.Rows[e.RowIndex].Cells[4].Value.ToString();
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
                    var data = db.exercises.Where(d => d.Id == rowId).FirstOrDefault();

                    db.exercises.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Exercise Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            exercise Ex = new exercise();
            Ex.name = txtExerciseName.Text;
            Ex.time = Int32.Parse(txtDuration.Text);
            Ex.calories_burn = int.Parse(txtCaloriesBurn.Text);
            Ex.exercise_type = txtExerciseType.Text;

            db.exercises.Add(Ex);
            db.SaveChanges();

            txtExerciseId.Text = "";
            txtExerciseName.Text = "";
            txtDuration.Text = "";
            txtCaloriesBurn.Text = "";
            txtExerciseType.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtExerciseId.Text);
            var upData = db.exercises.Where(d => d.Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.name = txtExerciseName.Text;
                upData.time = Int32.Parse(txtDuration.Text);
                upData.calories_burn = Int32.Parse(txtCaloriesBurn.Text);
                upData.exercise_type = txtExerciseType.Text;

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }


    }
}
