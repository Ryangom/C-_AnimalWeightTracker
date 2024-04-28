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
    public partial class frmMeal : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmMeal()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            txtMealName.Text = "";
            txtMealGram.Text = "";
            txtCalorie.Text = "";
        }

        private void frmMeal_Load(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "Id";
            gv.Columns[1].DataPropertyName = "name";
            gv.Columns[2].DataPropertyName = "unit_in_gram";
            gv.Columns[3].DataPropertyName = "caloriers";

            LoadData();


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

        private void BtnHidePnl_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

        }


        private void LoadData()
        {
            var data = db.meals.Select(d => new { d.Id, d.name, d.unit_in_gram, d.caloriers }).ToList();
            gv.DataSource = data;
        }


        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 4)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnInsert.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtMealId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtMealName.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtMealGram.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtCalorie.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
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
                    var data = db.meals.Where(d => d.Id == rowId).FirstOrDefault();

                    db.meals.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Meal Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            meal meal = new meal();
            meal.name = txtMealName.Text;
            meal.unit_in_gram = txtMealGram.Text;
            meal.caloriers = Double.Parse(txtCalorie.Text);

            db.meals.Add(meal);
            db.SaveChanges();

            txtMealName.Text = "";
            txtMealGram.Text = "";
            txtCalorie.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtMealId.Text);
            var upData = db.meals.Where(d => d.Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.name = txtMealName.Text;
                upData.unit_in_gram = txtMealGram.Text;
                upData.caloriers = Double.Parse(txtCalorie.Text);

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }
    }
}
