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
    public partial class frmAnimal : Form
    {
        StringBuilder errors;
        WeightTrackerEntities db = new WeightTrackerEntities();
        public frmAnimal()
        {
            InitializeComponent();
        }
        private void frmAnimal_Load(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
            cboAnimalGender.SelectedIndex = 0;
            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "animal_Id";
            gv.Columns[1].DataPropertyName = "name";
            gv.Columns[2].DataPropertyName = "age";
            gv.Columns[3].DataPropertyName = "Height";
            gv.Columns[4].DataPropertyName = "Weight";
            gv.Columns[5].DataPropertyName = "gender";
            gv.Columns[6].DataPropertyName = "Species_name";
            gv.Columns[7].DataPropertyName = "orgName";



            LoadData();

            //Get Organization Information
            var orgData = db.organizations.ToList();

            if (orgData.Count <= 0)
            {
                MessageBox.Show("Please input some organization data");
                this.Close();
                return;
            }
            cboOrgName.DataSource = orgData;
            cboOrgName.DisplayMember = "orgName";
            cboOrgName.ValueMember = "Organization_Id";
            cboOrgName.SelectedIndex = 0;


            //Get species Info
            var speciesData = db.species.ToList();
            cboSpecies.DataSource = speciesData;
            cboSpecies.DisplayMember = "Species_name";
            cboSpecies.ValueMember = "id";
            cboSpecies.SelectedIndex = 0;



            pnlLnput.Visible = false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            btnInsert.Visible = true;
            btnUpdate.Visible = false;

            txtAnimalId.Text = "";
            txtAnimalName.Text = "";
            txtAnimalAge.Text = "";
            txtHeight.Text = "";
            txtAnimalWeight.Text = "";

        }

        private void BtnHidePnl_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }


        private void LoadData()
        {
            var data = db.animals.Select(d => new { d.animal_Id, d.name, d.age,d.Height,d.Weight,d.gender,d.species.Species_name ,d.organization.orgName}).ToList();
            gv.DataSource = data;
        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    pnlInput.Visible = true;
        //    btnSave.Visible = true;
        //    btnUpdate.Visible = false;
        //}

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 8)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnInsert.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        txtAnimalId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtAnimalName.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtAnimalAge.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtHeight.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtAnimalWeight.Text = gv.Rows[e.RowIndex].Cells[4].Value.ToString();
                        cboAnimalGender.Text = gv.Rows[e.RowIndex].Cells[5].Value.ToString();
                        cboSpecies.Text = gv.Rows[e.RowIndex].Cells[6].Value.ToString();
                        cboOrgName.SelectedIndex =int.Parse( gv.Rows[e.RowIndex].Cells[7].Value.ToString());
                    }
                    catch (Exception)
                    {


                    }
                }

            }

            //Delete Button
            if (e.ColumnIndex == 9)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure about deleting this data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    int rowId = Int32.Parse(gv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var data = db.animals.Where(d => d.animal_Id == rowId).FirstOrDefault();

                    db.animals.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Animal Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errors = new StringBuilder();
            if (string.IsNullOrEmpty(txtAnimalName.Text))
            {
                errors.AppendLine("Name cannot be empty");
            }

            if (string.IsNullOrEmpty(txtAnimalAge.Text))
            {
                errors.AppendLine("Age cannot be empty");
            }

            //if (!System.Text.RegularExpressions.Regex.IsMatch(txtAge.Text, @"^[0-9][1-9]$"))
            //{
            //    errors.AppendLine("Animal Age MUST BE BETWEEN 1 - 99");
            //}

            if (cboAnimalGender.SelectedIndex == 0)
            {
                errors.AppendLine("Please Select Gender");
            }

            if (errors.ToString() != String.Empty)
            {
                MessageBox.Show(errors.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pnlLnput.Visible = false;

            animal ani = new animal();
            ani.name = txtAnimalName.Text;
            ani.age = txtAnimalAge.Text;
            ani.Height = decimal.Parse(txtHeight.Text);
            ani.Weight =int.Parse(txtAnimalWeight.Text);
            ani.gender = cboAnimalGender.SelectedItem.ToString();
            ani.species_Id = Int32.Parse(cboSpecies.SelectedValue.ToString());
            ani.organization_Id = Int32.Parse(cboOrgName.SelectedValue.ToString());

            db.animals.Add(ani);
            db.SaveChanges();

            txtAnimalName.Text = "";
            txtAnimalAge.Text = "";
            txtHeight.Text = "";
            txtAnimalWeight.Text = "";
            cboOrgName.SelectedIndex = 0;
            cboAnimalGender.SelectedIndex = 0;
            cboSpecies.SelectedIndex = 0;

            LoadData();
        }

        //private void btnClosePanel_Click(object sender, EventArgs e)
        //{
        //    pnlInput.Visible = false;
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtAnimalId.Text);
            var upData = db.animals.Where(d => d.animal_Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.name = txtAnimalName.Text;
                upData.age = txtAnimalAge.Text;
                upData.Height = decimal.Parse(txtHeight.Text);
                upData.Weight = Int32.Parse(txtAnimalWeight.Text);
                upData.gender = cboAnimalGender.SelectedItem.ToString();
                upData.species_Id =Int32.Parse(cboSpecies.SelectedValue.ToString());
                upData.organization_Id = Int32.Parse(cboOrgName.SelectedValue.ToString());

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }

        private void cboOrgName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
