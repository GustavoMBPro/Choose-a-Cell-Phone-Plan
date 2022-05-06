
namespace CellPhonePackagesActivity7
{
    partial class FormCellPhonePackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCellPhonePackages));
            this.menuStripCellPhone = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCtrlQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packagesToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.individualPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familyPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCellPhone = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIndividual = new System.Windows.Forms.Label();
            this.buttonFamily = new System.Windows.Forms.Button();
            this.buttonIndividual = new System.Windows.Forms.Button();
            this.menuStripCellPhone.SuspendLayout();
            this.groupBoxCellPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCellPhone
            // 
            this.menuStripCellPhone.BackColor = System.Drawing.Color.Red;
            this.menuStripCellPhone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenu,
            this.packagesToolStripMenu,
            this.helpToolStripMenu});
            this.menuStripCellPhone.Location = new System.Drawing.Point(0, 0);
            this.menuStripCellPhone.Name = "menuStripCellPhone";
            this.menuStripCellPhone.Size = new System.Drawing.Size(599, 24);
            this.menuStripCellPhone.TabIndex = 0;
            this.menuStripCellPhone.Text = "menuStrip1";
            // 
            // filesToolStripMenu
            // 
            this.filesToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitCtrlQToolStripMenuItem});
            this.filesToolStripMenu.Name = "filesToolStripMenu";
            this.filesToolStripMenu.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenu.Text = "Files";
            // 
            // exitCtrlQToolStripMenuItem
            // 
            this.exitCtrlQToolStripMenuItem.Name = "exitCtrlQToolStripMenuItem";
            this.exitCtrlQToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitCtrlQToolStripMenuItem.Text = "E&xit Ctrl+Q";
            this.exitCtrlQToolStripMenuItem.ToolTipText = "Click here to exit(Ctrl + Q)";
            this.exitCtrlQToolStripMenuItem.Click += new System.EventHandler(this.exitCtrlQToolStripMenuItem_Click);
            // 
            // packagesToolStripMenu
            // 
            this.packagesToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individualPlanToolStripMenuItem,
            this.familyPlanToolStripMenuItem});
            this.packagesToolStripMenu.Name = "packagesToolStripMenu";
            this.packagesToolStripMenu.Size = new System.Drawing.Size(68, 20);
            this.packagesToolStripMenu.Text = "Packages";
            // 
            // individualPlanToolStripMenuItem
            // 
            this.individualPlanToolStripMenuItem.Name = "individualPlanToolStripMenuItem";
            this.individualPlanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.individualPlanToolStripMenuItem.Text = "Individual Plan";
            this.individualPlanToolStripMenuItem.Click += new System.EventHandler(this.individualPlanToolStripMenuItem_Click);
            // 
            // familyPlanToolStripMenuItem
            // 
            this.familyPlanToolStripMenuItem.Name = "familyPlanToolStripMenuItem";
            this.familyPlanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.familyPlanToolStripMenuItem.Text = "Family Plan";
            this.familyPlanToolStripMenuItem.Click += new System.EventHandler(this.familyPlanToolStripMenuItem_Click);
            // 
            // helpToolStripMenu
            // 
            this.helpToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenu.Name = "helpToolStripMenu";
            this.helpToolStripMenu.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenu.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxCellPhone
            // 
            this.groupBoxCellPhone.BackColor = System.Drawing.Color.Red;
            this.groupBoxCellPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxCellPhone.Controls.Add(this.label1);
            this.groupBoxCellPhone.Controls.Add(this.labelIndividual);
            this.groupBoxCellPhone.Controls.Add(this.buttonFamily);
            this.groupBoxCellPhone.Controls.Add(this.buttonIndividual);
            this.groupBoxCellPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxCellPhone.Location = new System.Drawing.Point(24, 53);
            this.groupBoxCellPhone.Name = "groupBoxCellPhone";
            this.groupBoxCellPhone.Size = new System.Drawing.Size(552, 244);
            this.groupBoxCellPhone.TabIndex = 1;
            this.groupBoxCellPhone.TabStop = false;
            this.groupBoxCellPhone.Text = "Select a Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Family plan allows you to\r\npurchase multiple cell phones of\r\nthe same model w" +
    "ith each phone \r\nsharing one monthly package.";
            // 
            // labelIndividual
            // 
            this.labelIndividual.AutoSize = true;
            this.labelIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndividual.Location = new System.Drawing.Point(68, 32);
            this.labelIndividual.Name = "labelIndividual";
            this.labelIndividual.Size = new System.Drawing.Size(284, 72);
            this.labelIndividual.TabIndex = 2;
            this.labelIndividual.Text = "The Individual plan provides one\r\ncell phone and a variey of \r\nmonthly packages.";
            // 
            // buttonFamily
            // 
            this.buttonFamily.AutoSize = true;
            this.buttonFamily.BackColor = System.Drawing.Color.Black;
            this.buttonFamily.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonFamily.Location = new System.Drawing.Point(431, 146);
            this.buttonFamily.Name = "buttonFamily";
            this.buttonFamily.Size = new System.Drawing.Size(99, 45);
            this.buttonFamily.TabIndex = 1;
            this.buttonFamily.Text = "F&amily";
            this.buttonFamily.UseVisualStyleBackColor = false;
            this.buttonFamily.Click += new System.EventHandler(this.buttonFamily_Click);
            // 
            // buttonIndividual
            // 
            this.buttonIndividual.AutoSize = true;
            this.buttonIndividual.BackColor = System.Drawing.Color.Black;
            this.buttonIndividual.ForeColor = System.Drawing.Color.Lime;
            this.buttonIndividual.Location = new System.Drawing.Point(431, 49);
            this.buttonIndividual.Name = "buttonIndividual";
            this.buttonIndividual.Size = new System.Drawing.Size(99, 45);
            this.buttonIndividual.TabIndex = 0;
            this.buttonIndividual.Text = "I&ndividual";
            this.buttonIndividual.UseVisualStyleBackColor = false;
            this.buttonIndividual.Click += new System.EventHandler(this.buttonIndividual_Click);
            // 
            // FormCellPhonePackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.groupBoxCellPhone);
            this.Controls.Add(this.menuStripCellPhone);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripCellPhone;
            this.Name = "FormCellPhonePackages";
            this.Text = "Cell Phone Packages";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCellPhonePackages_KeyDown);
            this.menuStripCellPhone.ResumeLayout(false);
            this.menuStripCellPhone.PerformLayout();
            this.groupBoxCellPhone.ResumeLayout(false);
            this.groupBoxCellPhone.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCellPhone;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitCtrlQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familyPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxCellPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIndividual;
        private System.Windows.Forms.Button buttonFamily;
        private System.Windows.Forms.Button buttonIndividual;
    }
}

