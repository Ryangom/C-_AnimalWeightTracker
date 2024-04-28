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
    public partial class frmStaff : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();

        public frmStaff()
        {
            InitializeComponent();
        }
        private void frmStaff_Load(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            gv.AutoGenerateColumns = false;

            //Bind Data to Grid View
            gv.Columns[0].DataPropertyName = "staff_Id";
            gv.Columns[1].DataPropertyName = "Staff_name";
            gv.Columns[2].DataPropertyName = "age";
            gv.Columns[3].DataPropertyName = "staff_address";
            gv.Columns[4].DataPropertyName = "deg";
            gv.Columns[5].DataPropertyName = "orgName";
            LoadData();

            //Get Organization Information
            var orgData = db.organizations.ToList();
            if (db.organizations.ToList().Count == 0)
            {
                MessageBox.Show("No Organization Record Found !", "Organizations", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                cboOrg.DataSource = orgData;
                cboOrg.DisplayMember = "orgName";
                cboOrg.ValueMember = "Organization_Id";
                cboOrg.SelectedIndex = 0;
            }


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

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }

        private void pnClose_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }


        private void LoadData()
        {
            var data = db.staffs.Select(d => new { d.staff_Id, d.Staff_name, d.age,d.staff_address ,d.deg, d.organization.orgName}).ToList();
            gv.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = true;
            txtStaffName.Text = "";
            txtStaffAge.Text = "";
            txtStaffAddress.Text = "";
            txtStaffDesig.Text = "";
            cboOrg.SelectedIndex = 0;
            if (db.organizations.ToList().Count == 0)
            {
                MessageBox.Show("No Organization Record Found !", "Organizations", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pnlLnput.Visible = true;
            btnInsert.Visible = true;
           btnUpdate.Visible = false;
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Update Button
            if (e.ColumnIndex == 6)
            {
                pnlLnput.Visible = true;
                btnUpdate.Visible = true;
                btnInsert.Visible = false;

                if (gv.SelectedCells.Count > 0)
                {
                    try
                    {
                        StafId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtStaffName.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtStaffAge.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        txtStaffAddress.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
                        txtStaffDesig.Text = gv.Rows[e.RowIndex].Cells[4].Value.ToString();
                        cboOrg.SelectedIndex =int.Parse(gv.Rows[e.RowIndex].Cells[5].Value.ToString());
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
                    var data = db.staffs.Where(d => d.staff_Id == rowId).FirstOrDefault();

                    db.staffs.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Staff Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;

            staff stf = new staff();
            stf.Staff_name = txtStaffName.Text;
            stf.age = txtStaffAge.Text;
            stf.staff_address = txtStaffAddress.Text;
            stf.deg = txtStaffDesig.Text;
            stf.org_id = Int32.Parse(cboOrg.SelectedValue.ToString());

            db.staffs.Add(stf);
            db.SaveChanges();

            txtStaffName.Text = "";
            txtStaffAge.Text = "";
            txtStaffAddress.Text = "";
            txtStaffDesig.Text = "";
            cboOrg.SelectedIndex = 0;

            LoadData();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(StafId.Text);
            var upData = db.staffs.Where(d => d.staff_Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.Staff_name = txtStaffName.Text;
                upData.age = txtStaffAge.Text;
                upData.staff_address = txtStaffAddress.Text;
                upData.deg = txtStaffDesig.Text;
                upData.org_id = Int32.Parse(cboOrg.SelectedValue.ToString());

                db.SaveChanges();

                LoadData();
            }
            pnlLnput.Visible = false;
        }
    }
}
