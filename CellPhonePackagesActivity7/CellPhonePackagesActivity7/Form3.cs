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
    public partial class FormFamilyPlan : Form
    {

        /*Author: Gustavo Marin Borges
         Title: CellPhonePackages:FamilyPlan*/

        public FormFamilyPlan()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Catches non integers in the textBoxNumberOfPhones
            try
            {
                double NumberOfPhones = Convert.ToDouble(textBoxNumberOfPhones.Text);

                //Initialize array to save results
                double[] TotalArray = new double[6];

                //First space in the Totals groupbox
                double PhoneSubTotal = SelectPhone();
                TotalArray[0] = PhoneSubTotal * NumberOfPhones;
                labelDisplayPhoneSubtotal.Text = TotalArray[0].ToString("C2");

                //Second space in the Totals groupbox
                double Tax = TotalTax(PhoneSubTotal);
                TotalArray[1] = Tax * NumberOfPhones;
                labelDisplayTax.Text = TotalArray[1].ToString("C2");

                //Third space in the Totals groupbox
                double PhoneTotal = Tax + PhoneSubTotal;
                TotalArray[2] = PhoneTotal * NumberOfPhones;
                labelDisplayPhoneTotal.Text = TotalArray[2].ToString("C2");

                //Fourth space in the Totals groupbox
                double Options = SelectOptions();
                TotalArray[3] = Options * NumberOfPhones;
                labelDisplayOptions.Text = TotalArray[3].ToString("C2");

                //Fith space in the Totals groupbox
                double PackageCharge = SelectPackage();
                TotalArray[4] = PackageCharge * NumberOfPhones;
                labelDisplayPackageCharge.Text = TotalArray[4].ToString("C2");

                //Sixth space in the Totals groupbox
                double TotalMonthlyCharge = PhoneTotal + Options + PackageCharge;
                TotalArray[5] = TotalMonthlyCharge * NumberOfPhones;
                labelDisplayTotalMonthlyCharge.Text = TotalArray[5].ToString("C2");

                //For-loop for confirmation of 0 values in array 
                for (int i = 1; i < TotalArray.Length; i++)
                {
                    //Verifys that at least one field was selected 
                    if (TotalMonthlyCharge == 0)
                    {
                        labelDisplayPhoneSubtotal.Text = "";
                        labelDisplayTax.Text = "";
                        labelDisplayPhoneTotal.Text = "";
                        labelDisplayOptions.Text = "";
                        labelDisplayPackageCharge.Text = "";
                        labelDisplayTotalMonthlyCharge.Text = "";
                        MessageBox.Show("You do not choose anything! You need to make a selection.", "No Selection Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
                        break;
                    }

                    if (TotalArray[i] == 0)
                    {
                        labelDisplayPhoneSubtotal.Text = "";
                        labelDisplayTax.Text = "";
                        labelDisplayPhoneTotal.Text = "";
                        labelDisplayOptions.Text = "";
                        labelDisplayPackageCharge.Text = "";
                        labelDisplayTotalMonthlyCharge.Text = "";

                        MessageBox.Show("Please make sure having correct selections.", "Selection Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        labelDisplayPhoneSubtotal.Text = TotalArray[0].ToString("C2");
                        labelDisplayTax.Text = TotalArray[1].ToString("C2");
                        labelDisplayPhoneTotal.Text = TotalArray[2].ToString("C2");
                        labelDisplayOptions.Text = TotalArray[3].ToString("C2");
                        labelDisplayPackageCharge.Text = TotalArray[4].ToString("C2");
                        labelDisplayTotalMonthlyCharge.Text = TotalArray[5].ToString("C2");

                        //If erase it will return a message for every cero value, do not erase
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Quantity should be an integer or numeric value! Please make necessary chnages. Enter to proceed.", "Invalid Data Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Select phone method
        private double SelectPhone()
        {
            double Sum = 0;
            if (radioButtonModel100.Checked)
            {
                Sum += 29.95;
            }
            if (radioButtonModel110.Checked)
            {
                Sum += 49.95;
            }
            if (radioButtonModel200.Checked)
            {
                Sum += 99.95;
            }
            return Sum;
        }

        //Select package method
        private double SelectPackage()
        {
            double Sum = 0;
            if (radioButton800MPM.Checked)
            {
                Sum += 45.00;
            }
            if (radioButton1500MPM.Checked)
            {
                Sum += 65.00;
            }
            if (radioButtonUnlimitedMPM.Checked)
            {
                Sum += 99.00;
            }
            return Sum;
        }

        //Select Options
        private double SelectOptions()
        {
            double Sum = 0;
            if (checkBoxEmail.Checked)
            {
                Sum += 25.00;
            }
            if (checkBoxTextMessaging.Checked)
            {
                Sum += 10.00;
            }
            return Sum;
        }

        //Tax calculation method
        private double TotalTax(double Sum)
        {
            Sum = Sum * 0.06875;
            return Sum;
        }

        //Exit button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Back button
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCellPhonePackages f1 = new FormCellPhonePackages();
            f1.ShowDialog();
            this.Close();
        }
    }
}
