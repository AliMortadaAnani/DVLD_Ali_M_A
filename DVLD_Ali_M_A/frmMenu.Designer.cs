namespace DVLD_Ali_M_A
{
    partial class frmMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            pnMenuPanel = new Krypton.Toolkit.KryptonPanel();
            lblnote = new Krypton.Toolkit.KryptonLabel();
            lbMenuSettings = new Krypton.Toolkit.KryptonLabel();
            lbMenuUsers = new Krypton.Toolkit.KryptonLabel();
            lbMenuDrivers = new Krypton.Toolkit.KryptonLabel();
            lbMenuPeople = new Krypton.Toolkit.KryptonLabel();
            lbMenuApplications = new Krypton.Toolkit.KryptonLabel();
            pbMenuCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTip1 = new ToolTip(components);
            lbMenuTitle = new Krypton.Toolkit.KryptonLabel();
            pbMenuCar = new Krypton.Toolkit.KryptonPictureBox();
            pbMenuTest = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)pnMenuPanel).BeginInit();
            pnMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMenuCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuTest).BeginInit();
            SuspendLayout();
            // 
            // pnMenuPanel
            // 
            pnMenuPanel.Controls.Add(lblnote);
            pnMenuPanel.Controls.Add(lbMenuSettings);
            pnMenuPanel.Controls.Add(lbMenuUsers);
            pnMenuPanel.Controls.Add(lbMenuDrivers);
            pnMenuPanel.Controls.Add(lbMenuPeople);
            pnMenuPanel.Controls.Add(lbMenuApplications);
            pnMenuPanel.Dock = DockStyle.Left;
            pnMenuPanel.Location = new Point(0, 0);
            pnMenuPanel.Name = "pnMenuPanel";
            pnMenuPanel.Size = new Size(350, 981);
            pnMenuPanel.StateNormal.Color1 = SystemColors.ControlText;
            pnMenuPanel.StateNormal.Color2 = Color.DarkSlateBlue;
            pnMenuPanel.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            pnMenuPanel.TabIndex = 0;
            pnMenuPanel.TabStop = true;
            // 
            // lblnote
            // 
            lblnote.AutoSize = false;
            lblnote.Location = new Point(0, 854);
            lblnote.Name = "lblnote";
            lblnote.Size = new Size(425, 98);
            lblnote.StateNormal.ShortText.Color1 = Color.OrangeRed;
            lblnote.StateNormal.ShortText.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblnote.TabIndex = 240;
            lblnote.TabStop = false;
            lblnote.Values.Text = "Exit Current Form \r\nto Access The Panel";
            // 
            // lbMenuSettings
            // 
            lbMenuSettings.AutoSize = false;
            lbMenuSettings.Cursor = Cursors.Hand;
            lbMenuSettings.Location = new Point(20, 741);
            lbMenuSettings.Name = "lbMenuSettings";
            lbMenuSettings.Size = new Size(347, 107);
            lbMenuSettings.StateNormal.ShortText.Color1 = Color.Gainsboro;
            lbMenuSettings.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMenuSettings.TabIndex = 5;
            lbMenuSettings.Values.Text = "Account Settings";
            lbMenuSettings.Click += MenuSettings_Click;
            // 
            // lbMenuUsers
            // 
            lbMenuUsers.AutoSize = false;
            lbMenuUsers.Cursor = Cursors.Hand;
            lbMenuUsers.Location = new Point(20, 565);
            lbMenuUsers.Name = "lbMenuUsers";
            lbMenuUsers.Size = new Size(330, 117);
            lbMenuUsers.StateNormal.ShortText.Color1 = Color.Gainsboro;
            lbMenuUsers.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMenuUsers.TabIndex = 4;
            lbMenuUsers.Values.Text = "Users";
            lbMenuUsers.Click += lbMenuUsers_Click;
            // 
            // lbMenuDrivers
            // 
            lbMenuDrivers.AutoSize = false;
            lbMenuDrivers.Cursor = Cursors.Hand;
            lbMenuDrivers.Location = new Point(20, 389);
            lbMenuDrivers.Name = "lbMenuDrivers";
            lbMenuDrivers.Size = new Size(330, 117);
            lbMenuDrivers.StateNormal.ShortText.Color1 = Color.Gainsboro;
            lbMenuDrivers.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMenuDrivers.TabIndex = 3;
            lbMenuDrivers.Values.Text = "Drivers";
            lbMenuDrivers.Click += lbMenuDrivers_Click;
            // 
            // lbMenuPeople
            // 
            lbMenuPeople.AutoSize = false;
            lbMenuPeople.Cursor = Cursors.Hand;
            lbMenuPeople.Location = new Point(20, 203);
            lbMenuPeople.Name = "lbMenuPeople";
            lbMenuPeople.Size = new Size(330, 117);
            lbMenuPeople.StateNormal.ShortText.Color1 = Color.Gainsboro;
            lbMenuPeople.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMenuPeople.TabIndex = 2;
            lbMenuPeople.Values.Text = "People";
            lbMenuPeople.Click += MenuPeople_Click;
            // 
            // lbMenuApplications
            // 
            lbMenuApplications.AutoSize = false;
            lbMenuApplications.Cursor = Cursors.Hand;
            lbMenuApplications.Location = new Point(20, 30);
            lbMenuApplications.Name = "lbMenuApplications";
            lbMenuApplications.Size = new Size(330, 117);
            lbMenuApplications.StateNormal.ShortText.Color1 = Color.Gainsboro;
            lbMenuApplications.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMenuApplications.TabIndex = 1;
            lbMenuApplications.Values.Text = "Applications";
            lbMenuApplications.Click += lbMenuApplications_Click;
            // 
            // pbMenuCancel
            // 
            pbMenuCancel.Cursor = Cursors.Hand;
            pbMenuCancel.Image = (Image)resources.GetObject("pbMenuCancel.Image");
            pbMenuCancel.Location = new Point(1750, 30);
            pbMenuCancel.Name = "pbMenuCancel";
            pbMenuCancel.Size = new Size(150, 100);
            pbMenuCancel.SizeMode = PictureBoxSizeMode.Zoom;
            pbMenuCancel.TabIndex = 201;
            pbMenuCancel.TabStop = false;
            toolTip1.SetToolTip(pbMenuCancel, "Close");
            pbMenuCancel.Click += MenuCancel_Click;
            // 
            // lbMenuTitle
            // 
            lbMenuTitle.AutoSize = false;
            lbMenuTitle.Location = new Point(987, 0);
            lbMenuTitle.Name = "lbMenuTitle";
            lbMenuTitle.Size = new Size(226, 107);
            lbMenuTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbMenuTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMenuTitle.TabIndex = 210;
            lbMenuTitle.TabStop = false;
            lbMenuTitle.Values.Text = "Main Menu";
            // 
            // pbMenuCar
            // 
            pbMenuCar.Image = DVLD_Presentation.Properties.Resources.menu_car;
            pbMenuCar.Location = new Point(1190, 559);
            pbMenuCar.Name = "pbMenuCar";
            pbMenuCar.Size = new Size(670, 406);
            pbMenuCar.SizeMode = PictureBoxSizeMode.Zoom;
            pbMenuCar.TabIndex = 237;
            pbMenuCar.TabStop = false;
            // 
            // pbMenuTest
            // 
            pbMenuTest.Image = DVLD_Presentation.Properties.Resources.menu_license;
            pbMenuTest.Location = new Point(1190, 158);
            pbMenuTest.Name = "pbMenuTest";
            pbMenuTest.Size = new Size(670, 379);
            pbMenuTest.SizeMode = PictureBoxSizeMode.Zoom;
            pbMenuTest.TabIndex = 238;
            pbMenuTest.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.AutoSize = false;
            kryptonLabel1.Location = new Point(429, 104);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(686, 386);
            kryptonLabel1.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 239;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "Welcome to Drivers && Vehicules\r\nLicenses Department System.\r\n\r\n\r\nPlease choose a section\r\nfrom the left panel.";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1946, 981);
            Controls.Add(kryptonLabel1);
            Controls.Add(pbMenuTest);
            Controls.Add(pbMenuCar);
            Controls.Add(lbMenuTitle);
            Controls.Add(pbMenuCancel);
            Controls.Add(pnMenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            Text = "frmMenu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pnMenuPanel).EndInit();
            pnMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMenuCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuTest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnMenuPanel;
        private Krypton.Toolkit.KryptonLabel lbMenuSettings;
        private Krypton.Toolkit.KryptonLabel lbMenuUsers;
        private Krypton.Toolkit.KryptonLabel lbMenuDrivers;
        private Krypton.Toolkit.KryptonLabel lbMenuPeople;
        private Krypton.Toolkit.KryptonLabel lbMenuApplications;
        private Krypton.Toolkit.KryptonPictureBox pbMenuCancel;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonLabel lbMenuTitle;
        private Krypton.Toolkit.KryptonPictureBox pbMenuCar;
        private Krypton.Toolkit.KryptonPictureBox pbMenuTest;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblnote;
    }
}