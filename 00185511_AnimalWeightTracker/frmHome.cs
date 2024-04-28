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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }


        private void frmHome_Load(object sender, EventArgs e)
        {
            hideAllSubMenu();
        }

        //Opening Other Forms
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }
        //Hide All Sub-Menu

        private void hideAllSubMenu()
        {
            pnlOrganization.Visible = false;
            pnlAnimal.Visible = false;
            pnlDailyRecord.Visible = false;
        }

        //Show/Hide Sub-Menu
        private void toggleMenu(Panel panelSub)
        {
            if (panelSub.Visible == false)
            {
                hideAllSubMenu();
                panelSub.Visible = true;
            }
            else
            {
                panelSub.Visible = false;
            }
        }

        private void btnOrganization_Click(object sender, EventArgs e)
        {
            toggleMenu(pnlOrganization);
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            toggleMenu(pnlAnimal);
        }

        private void btnDailyRecords_Click(object sender, EventArgs e)
        {
            toggleMenu(pnlDailyRecord);
        }

       



        //showing windows according to button click


        private void btnAllOrganization_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrganizations());
            
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStaff());
        }

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAnimal());
        }

        private void btnAllMeal_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMeal()); 
        }

        private void btnAnimalCourses_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCourse());
        }

        private void btnAllExercise_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExercise());
        }

        private void btnDailyExercise_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDailyExercise());
        }

        private void btnDailyLog_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDailyLog());
        }

        private void btnDailyMeal_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDailyMeal());
        }

        private void btnDailyMeasurment_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDailyMeasurement());
        }

        private void btnDailyExercise_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmDailyExercise());

        }

        private void btnOrganizationType_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrganizationType());
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            openChildForm(new frmActivity());
        }


        private void btnSpecies_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSpecies());
        } 
        private void btnReport_Click(object sender, EventArgs e)
        {
            openChildForm(new frmReport());
        }
    }
}
