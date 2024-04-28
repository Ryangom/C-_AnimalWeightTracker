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
    public partial class frmActivity : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();


        public frmActivity()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var data = db.activities.Select(d => new { d.activity_Id, d.Name }).ToList();
            gv.DataSource = data;
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "activity_Id";
            gv.Columns[1].DataPropertyName = "Name";

            LoadData();


            pnlLnput.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;

            txtActId.Text = "";
            txtActName.Text = "";
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 2)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtActId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtActName.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();

                    }
                    catch (Exception)
                    {


                    }
                }

            }

            //Delete Button
            if (e.ColumnIndex == 3)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure about deleting this data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    int rowId = Int32.Parse(gv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var data = db.activities.Where(d => d.activity_Id == rowId).FirstOrDefault();

                    db.activities.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Activity Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            activity act = new activity();
            act.Name = txtActName.Text;

            db.activities.Add(act);
            db.SaveChanges();

            txtActName.Text = "";

            LoadData();
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtActId.Text);
            var upData = db.activities.Where(d => d.activity_Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.Name = txtActName.Text;

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }



    }
}
