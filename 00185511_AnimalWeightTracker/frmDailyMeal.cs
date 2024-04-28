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
    public partial class frmDailyMeal : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmDailyMeal()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var data = db.daily_meal.Select(d => new { d.Id, d.log_id, d.meal.name, d.meal_intake }).ToList();
            gv.DataSource = data;
        }

        private void frmDailyMeal_Load(object sender, EventArgs e)
        {
            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "Id";
            gv.Columns[1].DataPropertyName = "log_Id";
            gv.Columns[2].DataPropertyName = "name";
            gv.Columns[3].DataPropertyName = "meal_intake";

            LoadData();

            //Get Log Information
            var logData = db.daily_log.ToList();

            cobLog.DataSource = logData;
            cobLog.DisplayMember = "course_id";
            cobLog.ValueMember = "log_Id";

            //Get Meal Information
            var mealData = db.meals.ToList();

            cobMeal.DataSource = mealData;
            cobMeal.DisplayMember = "name";
            cobMeal.ValueMember = "Id";


            pnlLnput.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

            txtMealId.Text = "";
            cobLog.Text = "";
            cobMeal.Text = "";
            txtIntake.Text = "";
        }


        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 4)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtMealId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cobLog.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        cobMeal.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtIntake.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    catch (Exception)
                    {


                    }
                }

            }

            //Delete Button
            if (e.ColumnIndex == 5)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure about deleting this data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    int rowId = Int32.Parse(gv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var data = db.daily_meal.Where(d => d.Id == rowId).FirstOrDefault();

                    db.daily_meal.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Meal Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            daily_meal meal = new daily_meal();
            meal.log_id = Int32.Parse(cobLog.SelectedValue.ToString());
            meal.meal_id = Int32.Parse(cobMeal.SelectedValue.ToString());
            meal.meal_intake = Decimal.Parse(txtIntake.Text);

            db.daily_meal.Add(meal);
            db.SaveChanges();

            cobLog.Text = "";
            cobMeal.Text = "";
            txtIntake.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtMealId.Text);
            var upData = db.daily_meal.Where(d => d.Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.log_id = Int32.Parse(cobLog.SelectedValue.ToString());
                upData.meal_id = Int32.Parse(cobMeal.SelectedValue.ToString());
                upData.meal_intake = Decimal.Parse(txtIntake.Text);

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }

    }
}
