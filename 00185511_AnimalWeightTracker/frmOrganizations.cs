using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _00185511_AnimalWeightTracker
{
    public partial class frmOrganizations : Form
    {
        WeightTrackerEntities db = new WeightTrackerEntities();
        public frmOrganizations()
        {
            InitializeComponent();
        }

        private void frmOrganizations_Load(object sender, EventArgs e)
        {
            gv.AutoGenerateColumns = false;

            pnlLnput.Visible = false;
            gv.Columns[0].DataPropertyName = "Organization_Id";
            gv.Columns[1].DataPropertyName = "orgName";
            gv.Columns[2].DataPropertyName = "Address";
            gv.Columns[3].DataPropertyName = "Type";
            LoadData();


            //Get Organization Information
            var OrgTypeData = db.organizationTypes.ToList();
            cboOrgType.DataSource = OrgTypeData;
            cboOrgType.DisplayMember = "Type";
            cboOrgType.ValueMember = "Id";
            cboOrgType.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtOrgName.Text = "";
            txtOrgAddress.Text = "";
            cboOrgType.SelectedIndex = 0;
            pnlLnput.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            txtOrgID.Text = "";
            
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlLnput.Visible = false;
        }


        private void LoadData()
        {   //Loading data from database
            var data = db.organizations.Select(d => new { d.Organization_Id,d.orgName ,d.Address, d.organizationType.Type }).ToList();
            gv.DataSource = data;
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
                        txtOrgID.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtOrgName.Text = gv.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtOrgAddress.Text = gv.Rows[e.RowIndex].Cells[2].Value.ToString();
                        cboOrgType.Text = gv.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                    catch (Exception)
                    {


                    }
                }

            }

            //Delete Button codes
            if (e.ColumnIndex == 5)
            {
                DialogResult dlgResult = MessageBox.Show("Are you sure? You want to delete this data ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlgResult == DialogResult.Yes)
                {
                    int rowId = Int32.Parse(gv.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var data = db.organizations.Where(d => d.Organization_Id == rowId).FirstOrDefault();

                    db.organizations.Remove(data);
                    db.SaveChanges();

                    LoadData();

                    MessageBox.Show("Selected Data Deleted Successfully", "Remove Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
           

            organization org = new organization();
            org.orgName = txtOrgName.Text;
            org.Address = txtOrgAddress.Text;
            org.type_id = int.Parse(cboOrgType.SelectedValue.ToString());

            if (cboOrgType.SelectedIndex == 0)
            {
                MessageBox.Show("Please ");
            }
            else
            {
                db.organizations.Add(org);
                db.SaveChanges();

                txtOrgName.Text = "";
                txtOrgAddress.Text = "";
                cboOrgType.SelectedIndex = 0;

                LoadData();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idn = Int32.Parse(txtOrgID.Text);
            var upData = db.organizations.Where(d => d.Organization_Id == idn).FirstOrDefault(); //Get single data

            if (upData != null)
            {
                upData.orgName = txtOrgName.Text;
                upData.Address = txtOrgAddress.Text;
                upData.type_id = Int32.Parse(cboOrgType.SelectedValue.ToString());

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
