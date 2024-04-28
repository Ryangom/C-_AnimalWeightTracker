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
    public partial class frmSpecies : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();
        public frmSpecies()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var data = db.species.Select(d => new { d.Id, d.Species_name }).ToList();
            gv.DataSource = data;

        }

        private void frmSpecise_Load(object sender, EventArgs e)
        {
            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "Id";
            gv.Columns[1].DataPropertyName = "Species_name";
            pnlLnput.Visible = false;
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            btnInsert.Visible = true;
        }
        private void BtnHidePnl_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            species speciess = new species();
            //org.Id = int.Parse(txtOrgTypeID.Text);
            speciess.Species_name = txtSpeciesName.Text;

            db.species.Add(speciess);
            db.SaveChanges();


            txtSpeciesName.Text = "";

            LoadData();
            pnlLnput.Visible = false;
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 2)
            {
                btnUpdate.Visible = true;
                btnInsert.Visible = false;
                pnlLnput.Visible = true;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtSpicesId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtSpeciesName.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();

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
                    var data = db.species.Where(d => d.Id == rowId).FirstOrDefault();

                    db.species.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Specise Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtSpicesId.Text);
            var upData = db.species.Where(d => d.Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.Species_name = txtSpeciesName.Text;
                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }
    }
}
