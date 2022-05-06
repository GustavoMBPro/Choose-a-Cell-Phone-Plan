using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhonePackagesActivity7
{
    public partial class FormCellPhonePackages : Form
    {
        /*Author: Gustavo Marin Borges
         Title: CellPhonePackages*/

        public FormCellPhonePackages()
        {
            InitializeComponent();
        }

        //File list menu > Exit
        private void exitCtrlQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Packages > Individual opens individual form
        private void individualPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIndividualPlan f2 = new FormIndividualPlan();
            f2.ShowDialog();
            this.Close();

        }

        //Packages > Family opens Family form
        private void familyPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFamilyPlan f3 = new FormFamilyPlan();
            f3.ShowDialog();
            this.Close();
        }

        //Individual button
        private void buttonIndividual_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIndividualPlan f2 = new FormIndividualPlan();
            f2.ShowDialog();
            this.Close();

        }

        //Family button
        private void buttonFamily_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFamilyPlan f3 = new FormFamilyPlan();
            f3.ShowDialog();
            this.Close();
        }

        //Help > About displays message
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This app will help you calculate the price for your phone package on Bubblegum Phones Inc. Family plan will let you calculate the price for a single model, but multiple phones of that same model whereas Individual will not.", "Help!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        //Key board shortcuts
        private void FormCellPhonePackages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "Q")
            {
                this.Close();
            }

            if (e.Control && e.KeyCode.ToString() == "I")
            {
                this.Hide();
                FormIndividualPlan f2 = new FormIndividualPlan();
                f2.ShowDialog();
                this.Close();
            }

            if (e.Control && e.KeyCode.ToString() == "F")
            {
                this.Hide();
                FormFamilyPlan f3 = new FormFamilyPlan();
                f3.ShowDialog();
                this.Close();
            }

            if (e.Control && e.KeyCode.ToString() == "H")
            {
                MessageBox.Show("This app will help you calculate the price for your phone package on Bubblegum Phones Inc. Family plan will let you calculate the price for a single model, but multiple phones of that same model whereas Individual will not.", "Help!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
