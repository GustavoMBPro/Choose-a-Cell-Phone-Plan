
namespace CellPhonePackagesActivity7
{
    partial class FormFamilyPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFamilyPlan));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxTotals = new System.Windows.Forms.GroupBox();
            this.labelTotalMonthlyCharge = new System.Windows.Forms.Label();
            this.labelPackageCharge = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelPhoneTotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelPhoneSubtotal = new System.Windows.Forms.Label();
            this.labelDisplayTotalMonthlyCharge = new System.Windows.Forms.Label();
            this.labelDisplayPackageCharge = new System.Windows.Forms.Label();
            this.labelDisplayOptions = new System.Windows.Forms.Label();
            this.labelDisplayPhoneTotal = new System.Windows.Forms.Label();
            this.labelDisplayTax = new System.Windows.Forms.Label();
            this.labelDisplayPhoneSubtotal = new System.Windows.Forms.Label();
            this.groupBoxSelectPackage = new System.Windows.Forms.GroupBox();
            this.labelUnlimitedMPM = new System.Windows.Forms.Label();
            this.labelPrice1500MPM = new System.Windows.Forms.Label();
            this.radioButton800MPM = new System.Windows.Forms.RadioButton();
            this.labelPrice800MPM = new System.Windows.Forms.Label();
            this.radioButton1500MPM = new System.Windows.Forms.RadioButton();
            this.radioButtonUnlimitedMPM = new System.Windows.Forms.RadioButton();
            this.groupBoxSelectOptions = new System.Windows.Forms.GroupBox();
            this.labelPriceTextMessaging = new System.Windows.Forms.Label();
            this.labelPriceEmail = new System.Windows.Forms.Label();
            this.checkBoxTextMessaging = new System.Windows.Forms.CheckBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.groupBoxSelectPhone = new System.Windows.Forms.GroupBox();
            this.labelPriceM200 = new System.Windows.Forms.Label();
            this.labelPriceM110 = new System.Windows.Forms.Label();
            this.labelPriceM100 = new System.Windows.Forms.Label();
            this.radioButtonModel200 = new System.Windows.Forms.RadioButton();
            this.radioButtonModel110 = new System.Windows.Forms.RadioButton();
            this.radioButtonModel100 = new System.Windows.Forms.RadioButton();
            this.groupBoxNumberOfPhones = new System.Windows.Forms.GroupBox();
            this.textBoxNumberOfPhones = new System.Windows.Forms.TextBox();
            this.labelNumberOfPhones = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBoxTotals.SuspendLayout();
            this.groupBoxSelectPackage.SuspendLayout();
            this.groupBoxSelectOptions.SuspendLayout();
            this.groupBoxSelectPhone.SuspendLayout();
            this.groupBoxNumberOfPhones.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(7, 448);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(234, 46);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.Red;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.White;
            this.buttonCalculate.Location = new System.Drawing.Point(7, 381);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(234, 47);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxTotals
            // 
            this.groupBoxTotals.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBoxTotals.Controls.Add(this.labelTotalMonthlyCharge);
            this.groupBoxTotals.Controls.Add(this.labelPackageCharge);
            this.groupBoxTotals.Controls.Add(this.labelOptions);
            this.groupBoxTotals.Controls.Add(this.labelPhoneTotal);
            this.groupBoxTotals.Controls.Add(this.labelTax);
            this.groupBoxTotals.Controls.Add(this.labelPhoneSubtotal);
            this.groupBoxTotals.Controls.Add(this.labelDisplayTotalMonthlyCharge);
            this.groupBoxTotals.Controls.Add(this.labelDisplayPackageCharge);
            this.groupBoxTotals.Controls.Add(this.labelDisplayOptions);
            this.groupBoxTotals.Controls.Add(this.labelDisplayPhoneTotal);
            this.groupBoxTotals.Controls.Add(this.labelDisplayTax);
            this.groupBoxTotals.Controls.Add(this.labelDisplayPhoneSubtotal);
            this.groupBoxTotals.Location = new System.Drawing.Point(247, 215);
            this.groupBoxTotals.Name = "groupBoxTotals";
            this.groupBoxTotals.Size = new System.Drawing.Size(389, 279);
            this.groupBoxTotals.TabIndex = 5;
            this.groupBoxTotals.TabStop = false;
            this.groupBoxTotals.Text = "Totals";
            // 
            // labelTotalMonthlyCharge
            // 
            this.labelTotalMonthlyCharge.AutoSize = true;
            this.labelTotalMonthlyCharge.Location = new System.Drawing.Point(35, 241);
            this.labelTotalMonthlyCharge.Name = "labelTotalMonthlyCharge";
            this.labelTotalMonthlyCharge.Size = new System.Drawing.Size(108, 13);
            this.labelTotalMonthlyCharge.TabIndex = 18;
            this.labelTotalMonthlyCharge.Text = "TotalMonthly Charge:";
            // 
            // labelPackageCharge
            // 
            this.labelPackageCharge.AutoSize = true;
            this.labelPackageCharge.Location = new System.Drawing.Point(53, 200);
            this.labelPackageCharge.Name = "labelPackageCharge";
            this.labelPackageCharge.Size = new System.Drawing.Size(90, 13);
            this.labelPackageCharge.TabIndex = 17;
            this.labelPackageCharge.Text = "Package Charge:";
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(97, 157);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(46, 13);
            this.labelOptions.TabIndex = 16;
            this.labelOptions.Text = "Options:";
            // 
            // labelPhoneTotal
            // 
            this.labelPhoneTotal.AutoSize = true;
            this.labelPhoneTotal.Location = new System.Drawing.Point(75, 117);
            this.labelPhoneTotal.Name = "labelPhoneTotal";
            this.labelPhoneTotal.Size = new System.Drawing.Size(68, 13);
            this.labelPhoneTotal.TabIndex = 15;
            this.labelPhoneTotal.Text = "Phone Total:";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(115, 73);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(28, 13);
            this.labelTax.TabIndex = 14;
            this.labelTax.Text = "Tax:";
            // 
            // labelPhoneSubtotal
            // 
            this.labelPhoneSubtotal.AutoSize = true;
            this.labelPhoneSubtotal.Location = new System.Drawing.Point(60, 31);
            this.labelPhoneSubtotal.Name = "labelPhoneSubtotal";
            this.labelPhoneSubtotal.Size = new System.Drawing.Size(83, 13);
            this.labelPhoneSubtotal.TabIndex = 13;
            this.labelPhoneSubtotal.Text = "Phone Subtotal:";
            // 
            // labelDisplayTotalMonthlyCharge
            // 
            this.labelDisplayTotalMonthlyCharge.BackColor = System.Drawing.Color.Silver;
            this.labelDisplayTotalMonthlyCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayTotalMonthlyCharge.Location = new System.Drawing.Point(187, 233);
            this.labelDisplayTotalMonthlyCharge.Name = "labelDisplayTotalMonthlyCharge";
            this.labelDisplayTotalMonthlyCharge.Size = new System.Drawing.Size(184, 33);
            this.labelDisplayTotalMonthlyCharge.TabIndex = 5;
            // 
            // labelDisplayPackageCharge
            // 
            this.labelDisplayPackageCharge.BackColor = System.Drawing.Color.Silver;
            this.labelDisplayPackageCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayPackageCharge.Location = new System.Drawing.Point(187, 191);
            this.labelDisplayPackageCharge.Name = "labelDisplayPackageCharge";
            this.labelDisplayPackageCharge.Size = new System.Drawing.Size(184, 33);
            this.labelDisplayPackageCharge.TabIndex = 4;
            // 
            // labelDisplayOptions
            // 
            this.labelDisplayOptions.BackColor = System.Drawing.Color.Silver;
            this.labelDisplayOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayOptions.Location = new System.Drawing.Point(187, 149);
            this.labelDisplayOptions.Name = "labelDisplayOptions";
            this.labelDisplayOptions.Size = new System.Drawing.Size(184, 33);
            this.labelDisplayOptions.TabIndex = 3;
            // 
            // labelDisplayPhoneTotal
            // 
            this.labelDisplayPhoneTotal.BackColor = System.Drawing.Color.Silver;
            this.labelDisplayPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayPhoneTotal.Location = new System.Drawing.Point(187, 106);
            this.labelDisplayPhoneTotal.Name = "labelDisplayPhoneTotal";
            this.labelDisplayPhoneTotal.Size = new System.Drawing.Size(184, 33);
            this.labelDisplayPhoneTotal.TabIndex = 2;
            // 
            // labelDisplayTax
            // 
            this.labelDisplayTax.BackColor = System.Drawing.Color.Silver;
            this.labelDisplayTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayTax.Location = new System.Drawing.Point(187, 63);
            this.labelDisplayTax.Name = "labelDisplayTax";
            this.labelDisplayTax.Size = new System.Drawing.Size(184, 33);
            this.labelDisplayTax.TabIndex = 1;
            // 
            // labelDisplayPhoneSubtotal
            // 
            this.labelDisplayPhoneSubtotal.BackColor = System.Drawing.Color.Silver;
            this.labelDisplayPhoneSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplayPhoneSubtotal.Location = new System.Drawing.Point(187, 21);
            this.labelDisplayPhoneSubtotal.Name = "labelDisplayPhoneSubtotal";
            this.labelDisplayPhoneSubtotal.Size = new System.Drawing.Size(184, 33);
            this.labelDisplayPhoneSubtotal.TabIndex = 0;
            // 
            // groupBoxSelectPackage
            // 
            this.groupBoxSelectPackage.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBoxSelectPackage.Controls.Add(this.labelUnlimitedMPM);
            this.groupBoxSelectPackage.Controls.Add(this.labelPrice1500MPM);
            this.groupBoxSelectPackage.Controls.Add(this.radioButton800MPM);
            this.groupBoxSelectPackage.Controls.Add(this.labelPrice800MPM);
            this.groupBoxSelectPackage.Controls.Add(this.radioButton1500MPM);
            this.groupBoxSelectPackage.Controls.Add(this.radioButtonUnlimitedMPM);
            this.groupBoxSelectPackage.Location = new System.Drawing.Point(247, 64);
            this.groupBoxSelectPackage.Name = "groupBoxSelectPackage";
            this.groupBoxSelectPackage.Size = new System.Drawing.Size(389, 145);
            this.groupBoxSelectPackage.TabIndex = 6;
            this.groupBoxSelectPackage.TabStop = false;
            this.groupBoxSelectPackage.Text = "Select a Package";
            // 
            // labelUnlimitedMPM
            // 
            this.labelUnlimitedMPM.AutoSize = true;
            this.labelUnlimitedMPM.Location = new System.Drawing.Point(322, 104);
            this.labelUnlimitedMPM.Name = "labelUnlimitedMPM";
            this.labelUnlimitedMPM.Size = new System.Drawing.Size(40, 13);
            this.labelUnlimitedMPM.TabIndex = 12;
            this.labelUnlimitedMPM.Text = "$99.00";
            // 
            // labelPrice1500MPM
            // 
            this.labelPrice1500MPM.AutoSize = true;
            this.labelPrice1500MPM.Location = new System.Drawing.Point(322, 67);
            this.labelPrice1500MPM.Name = "labelPrice1500MPM";
            this.labelPrice1500MPM.Size = new System.Drawing.Size(40, 13);
            this.labelPrice1500MPM.TabIndex = 11;
            this.labelPrice1500MPM.Text = "$65.00";
            // 
            // radioButton800MPM
            // 
            this.radioButton800MPM.AutoSize = true;
            this.radioButton800MPM.Location = new System.Drawing.Point(27, 33);
            this.radioButton800MPM.Name = "radioButton800MPM";
            this.radioButton800MPM.Size = new System.Drawing.Size(134, 17);
            this.radioButton800MPM.TabIndex = 7;
            this.radioButton800MPM.Text = "800 Minutes per Month";
            this.radioButton800MPM.UseVisualStyleBackColor = true;
            // 
            // labelPrice800MPM
            // 
            this.labelPrice800MPM.AutoSize = true;
            this.labelPrice800MPM.Location = new System.Drawing.Point(322, 33);
            this.labelPrice800MPM.Name = "labelPrice800MPM";
            this.labelPrice800MPM.Size = new System.Drawing.Size(40, 13);
            this.labelPrice800MPM.TabIndex = 10;
            this.labelPrice800MPM.Text = "$45.00";
            // 
            // radioButton1500MPM
            // 
            this.radioButton1500MPM.AutoSize = true;
            this.radioButton1500MPM.Location = new System.Drawing.Point(27, 67);
            this.radioButton1500MPM.Name = "radioButton1500MPM";
            this.radioButton1500MPM.Size = new System.Drawing.Size(140, 17);
            this.radioButton1500MPM.TabIndex = 8;
            this.radioButton1500MPM.Text = "1500 Minutes per Month";
            this.radioButton1500MPM.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnlimitedMPM
            // 
            this.radioButtonUnlimitedMPM.AutoSize = true;
            this.radioButtonUnlimitedMPM.Location = new System.Drawing.Point(27, 104);
            this.radioButtonUnlimitedMPM.Name = "radioButtonUnlimitedMPM";
            this.radioButtonUnlimitedMPM.Size = new System.Drawing.Size(159, 17);
            this.radioButtonUnlimitedMPM.TabIndex = 9;
            this.radioButtonUnlimitedMPM.Text = "Unlimited Minutes per Month";
            this.radioButtonUnlimitedMPM.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectOptions
            // 
            this.groupBoxSelectOptions.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBoxSelectOptions.Controls.Add(this.labelPriceTextMessaging);
            this.groupBoxSelectOptions.Controls.Add(this.labelPriceEmail);
            this.groupBoxSelectOptions.Controls.Add(this.checkBoxTextMessaging);
            this.groupBoxSelectOptions.Controls.Add(this.checkBoxEmail);
            this.groupBoxSelectOptions.Location = new System.Drawing.Point(7, 215);
            this.groupBoxSelectOptions.Name = "groupBoxSelectOptions";
            this.groupBoxSelectOptions.Size = new System.Drawing.Size(234, 145);
            this.groupBoxSelectOptions.TabIndex = 7;
            this.groupBoxSelectOptions.TabStop = false;
            this.groupBoxSelectOptions.Text = "Select Options";
            // 
            // labelPriceTextMessaging
            // 
            this.labelPriceTextMessaging.AutoSize = true;
            this.labelPriceTextMessaging.Location = new System.Drawing.Point(163, 92);
            this.labelPriceTextMessaging.Name = "labelPriceTextMessaging";
            this.labelPriceTextMessaging.Size = new System.Drawing.Size(40, 13);
            this.labelPriceTextMessaging.TabIndex = 3;
            this.labelPriceTextMessaging.Text = "$10.00";
            // 
            // labelPriceEmail
            // 
            this.labelPriceEmail.AutoSize = true;
            this.labelPriceEmail.Location = new System.Drawing.Point(163, 41);
            this.labelPriceEmail.Name = "labelPriceEmail";
            this.labelPriceEmail.Size = new System.Drawing.Size(40, 13);
            this.labelPriceEmail.TabIndex = 2;
            this.labelPriceEmail.Text = "$25.00";
            // 
            // checkBoxTextMessaging
            // 
            this.checkBoxTextMessaging.AutoSize = true;
            this.checkBoxTextMessaging.Location = new System.Drawing.Point(22, 92);
            this.checkBoxTextMessaging.Name = "checkBoxTextMessaging";
            this.checkBoxTextMessaging.Size = new System.Drawing.Size(101, 17);
            this.checkBoxTextMessaging.TabIndex = 1;
            this.checkBoxTextMessaging.TabStop = false;
            this.checkBoxTextMessaging.Text = "Text Messaging";
            this.checkBoxTextMessaging.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(22, 41);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(51, 17);
            this.checkBoxEmail.TabIndex = 0;
            this.checkBoxEmail.TabStop = false;
            this.checkBoxEmail.Text = "Email";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // groupBoxSelectPhone
            // 
            this.groupBoxSelectPhone.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBoxSelectPhone.Controls.Add(this.labelPriceM200);
            this.groupBoxSelectPhone.Controls.Add(this.labelPriceM110);
            this.groupBoxSelectPhone.Controls.Add(this.labelPriceM100);
            this.groupBoxSelectPhone.Controls.Add(this.radioButtonModel200);
            this.groupBoxSelectPhone.Controls.Add(this.radioButtonModel110);
            this.groupBoxSelectPhone.Controls.Add(this.radioButtonModel100);
            this.groupBoxSelectPhone.Location = new System.Drawing.Point(7, 64);
            this.groupBoxSelectPhone.Name = "groupBoxSelectPhone";
            this.groupBoxSelectPhone.Size = new System.Drawing.Size(234, 145);
            this.groupBoxSelectPhone.TabIndex = 4;
            this.groupBoxSelectPhone.TabStop = false;
            this.groupBoxSelectPhone.Text = "Select a Phone";
            // 
            // labelPriceM200
            // 
            this.labelPriceM200.AutoSize = true;
            this.labelPriceM200.Location = new System.Drawing.Point(173, 104);
            this.labelPriceM200.Name = "labelPriceM200";
            this.labelPriceM200.Size = new System.Drawing.Size(40, 13);
            this.labelPriceM200.TabIndex = 6;
            this.labelPriceM200.Text = "$99.95";
            // 
            // labelPriceM110
            // 
            this.labelPriceM110.AutoSize = true;
            this.labelPriceM110.Location = new System.Drawing.Point(173, 67);
            this.labelPriceM110.Name = "labelPriceM110";
            this.labelPriceM110.Size = new System.Drawing.Size(40, 13);
            this.labelPriceM110.TabIndex = 5;
            this.labelPriceM110.Text = "$49.95";
            // 
            // labelPriceM100
            // 
            this.labelPriceM100.AutoSize = true;
            this.labelPriceM100.Location = new System.Drawing.Point(173, 33);
            this.labelPriceM100.Name = "labelPriceM100";
            this.labelPriceM100.Size = new System.Drawing.Size(40, 13);
            this.labelPriceM100.TabIndex = 4;
            this.labelPriceM100.Text = "$29.95";
            // 
            // radioButtonModel200
            // 
            this.radioButtonModel200.AutoSize = true;
            this.radioButtonModel200.Location = new System.Drawing.Point(22, 104);
            this.radioButtonModel200.Name = "radioButtonModel200";
            this.radioButtonModel200.Size = new System.Drawing.Size(75, 17);
            this.radioButtonModel200.TabIndex = 2;
            this.radioButtonModel200.Text = "Model 200";
            this.radioButtonModel200.UseVisualStyleBackColor = true;
            // 
            // radioButtonModel110
            // 
            this.radioButtonModel110.AutoSize = true;
            this.radioButtonModel110.Location = new System.Drawing.Point(22, 67);
            this.radioButtonModel110.Name = "radioButtonModel110";
            this.radioButtonModel110.Size = new System.Drawing.Size(75, 17);
            this.radioButtonModel110.TabIndex = 1;
            this.radioButtonModel110.Text = "Model 110";
            this.radioButtonModel110.UseVisualStyleBackColor = true;
            // 
            // radioButtonModel100
            // 
            this.radioButtonModel100.AutoSize = true;
            this.radioButtonModel100.Location = new System.Drawing.Point(22, 33);
            this.radioButtonModel100.Name = "radioButtonModel100";
            this.radioButtonModel100.Size = new System.Drawing.Size(75, 17);
            this.radioButtonModel100.TabIndex = 0;
            this.radioButtonModel100.Text = "Model 100";
            this.radioButtonModel100.UseVisualStyleBackColor = true;
            // 
            // groupBoxNumberOfPhones
            // 
            this.groupBoxNumberOfPhones.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBoxNumberOfPhones.Controls.Add(this.textBoxNumberOfPhones);
            this.groupBoxNumberOfPhones.Controls.Add(this.labelNumberOfPhones);
            this.groupBoxNumberOfPhones.Location = new System.Drawing.Point(7, 10);
            this.groupBoxNumberOfPhones.Name = "groupBoxNumberOfPhones";
            this.groupBoxNumberOfPhones.Size = new System.Drawing.Size(629, 48);
            this.groupBoxNumberOfPhones.TabIndex = 10;
            this.groupBoxNumberOfPhones.TabStop = false;
            this.groupBoxNumberOfPhones.Text = "Enter Number of Phones";
            // 
            // textBoxNumberOfPhones
            // 
            this.textBoxNumberOfPhones.Location = new System.Drawing.Point(511, 17);
            this.textBoxNumberOfPhones.Name = "textBoxNumberOfPhones";
            this.textBoxNumberOfPhones.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfPhones.TabIndex = 20;
            // 
            // labelNumberOfPhones
            // 
            this.labelNumberOfPhones.AutoSize = true;
            this.labelNumberOfPhones.Location = new System.Drawing.Point(264, 20);
            this.labelNumberOfPhones.Name = "labelNumberOfPhones";
            this.labelNumberOfPhones.Size = new System.Drawing.Size(98, 13);
            this.labelNumberOfPhones.TabIndex = 19;
            this.labelNumberOfPhones.Text = "Number of Phones:";
            // 
            // buttonBack
            // 
            this.buttonBack.AutoSize = true;
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonBack.Location = new System.Drawing.Point(537, 510);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 45);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormFamilyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 706);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBoxNumberOfPhones);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxTotals);
            this.Controls.Add(this.groupBoxSelectPackage);
            this.Controls.Add(this.groupBoxSelectOptions);
            this.Controls.Add(this.groupBoxSelectPhone);
            this.Name = "FormFamilyPlan";
            this.Text = "Family Plan";
            this.groupBoxTotals.ResumeLayout(false);
            this.groupBoxTotals.PerformLayout();
            this.groupBoxSelectPackage.ResumeLayout(false);
            this.groupBoxSelectPackage.PerformLayout();
            this.groupBoxSelectOptions.ResumeLayout(false);
            this.groupBoxSelectOptions.PerformLayout();
            this.groupBoxSelectPhone.ResumeLayout(false);
            this.groupBoxSelectPhone.PerformLayout();
            this.groupBoxNumberOfPhones.ResumeLayout(false);
            this.groupBoxNumberOfPhones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxTotals;
        private System.Windows.Forms.Label labelTotalMonthlyCharge;
        private System.Windows.Forms.Label labelPackageCharge;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Label labelPhoneTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelPhoneSubtotal;
        private System.Windows.Forms.Label labelDisplayTotalMonthlyCharge;
        private System.Windows.Forms.Label labelDisplayPackageCharge;
        private System.Windows.Forms.Label labelDisplayOptions;
        private System.Windows.Forms.Label labelDisplayPhoneTotal;
        private System.Windows.Forms.Label labelDisplayTax;
        private System.Windows.Forms.Label labelDisplayPhoneSubtotal;
        private System.Windows.Forms.GroupBox groupBoxSelectPackage;
        private System.Windows.Forms.Label labelUnlimitedMPM;
        private System.Windows.Forms.Label labelPrice1500MPM;
        private System.Windows.Forms.RadioButton radioButton800MPM;
        private System.Windows.Forms.Label labelPrice800MPM;
        private System.Windows.Forms.RadioButton radioButton1500MPM;
        private System.Windows.Forms.RadioButton radioButtonUnlimitedMPM;
        private System.Windows.Forms.GroupBox groupBoxSelectOptions;
        private System.Windows.Forms.Label labelPriceTextMessaging;
        private System.Windows.Forms.Label labelPriceEmail;
        private System.Windows.Forms.CheckBox checkBoxTextMessaging;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxSelectPhone;
        private System.Windows.Forms.Label labelPriceM200;
        private System.Windows.Forms.Label labelPriceM110;
        private System.Windows.Forms.Label labelPriceM100;
        private System.Windows.Forms.RadioButton radioButtonModel200;
        private System.Windows.Forms.RadioButton radioButtonModel110;
        private System.Windows.Forms.RadioButton radioButtonModel100;
        private System.Windows.Forms.GroupBox groupBoxNumberOfPhones;
        private System.Windows.Forms.Label labelNumberOfPhones;
        private System.Windows.Forms.TextBox textBoxNumberOfPhones;
        private System.Windows.Forms.Button buttonBack;
    }
}