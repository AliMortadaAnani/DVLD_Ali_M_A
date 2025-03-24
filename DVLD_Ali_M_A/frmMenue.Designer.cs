namespace DVLD_Ali_M_A
{
    partial class frmMenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenue));
            MenuePanel = new Krypton.Toolkit.KryptonPanel();
            MenueSettings = new Krypton.Toolkit.KryptonLabel();
            MenueUsers = new Krypton.Toolkit.KryptonLabel();
            MenueDrivers = new Krypton.Toolkit.KryptonLabel();
            MenuePeople = new Krypton.Toolkit.KryptonLabel();
            MenueApplications = new Krypton.Toolkit.KryptonLabel();
            MenueCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTip1 = new ToolTip(components);
            PeopleTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)MenuePanel).BeginInit();
            MenuePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenueCancel).BeginInit();
            SuspendLayout();
            // 
            // MenuePanel
            // 
            MenuePanel.Controls.Add(MenueSettings);
            MenuePanel.Controls.Add(MenueUsers);
            MenuePanel.Controls.Add(MenueDrivers);
            MenuePanel.Controls.Add(MenuePeople);
            MenuePanel.Controls.Add(MenueApplications);
            MenuePanel.Dock = DockStyle.Left;
            MenuePanel.Location = new Point(0, 0);
            MenuePanel.Name = "MenuePanel";
            MenuePanel.Size = new Size(350, 981);
            MenuePanel.StateNormal.Color1 = SystemColors.ControlText;
            MenuePanel.StateNormal.Color2 = Color.DarkSlateBlue;
            MenuePanel.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            MenuePanel.TabIndex = 200;
            // 
            // MenueSettings
            // 
            MenueSettings.AutoSize = false;
            MenueSettings.Cursor = Cursors.Hand;
            MenueSettings.Location = new Point(20, 741);
            MenueSettings.Name = "MenueSettings";
            MenueSettings.Size = new Size(347, 107);
            MenueSettings.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenueSettings.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenueSettings.TabIndex = 104;
            MenueSettings.TabStop = false;
            MenueSettings.Values.Text = "Account Settings";
            MenueSettings.Click += MenueSettings_Click;
            // 
            // MenueUsers
            // 
            MenueUsers.AutoSize = false;
            MenueUsers.Cursor = Cursors.Hand;
            MenueUsers.Location = new Point(20, 565);
            MenueUsers.Name = "MenueUsers";
            MenueUsers.Size = new Size(330, 117);
            MenueUsers.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenueUsers.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenueUsers.TabIndex = 103;
            MenueUsers.TabStop = false;
            MenueUsers.Values.Text = "Users";
            // 
            // MenueDrivers
            // 
            MenueDrivers.AutoSize = false;
            MenueDrivers.Cursor = Cursors.Hand;
            MenueDrivers.Location = new Point(20, 389);
            MenueDrivers.Name = "MenueDrivers";
            MenueDrivers.Size = new Size(330, 117);
            MenueDrivers.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenueDrivers.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenueDrivers.TabIndex = 102;
            MenueDrivers.TabStop = false;
            MenueDrivers.Values.Text = "Drivers";
            // 
            // MenuePeople
            // 
            MenuePeople.AutoSize = false;
            MenuePeople.Cursor = Cursors.Hand;
            MenuePeople.Location = new Point(20, 203);
            MenuePeople.Name = "MenuePeople";
            MenuePeople.Size = new Size(330, 117);
            MenuePeople.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenuePeople.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuePeople.TabIndex = 101;
            MenuePeople.TabStop = false;
            MenuePeople.Values.Text = "People";
            MenuePeople.Click += MenuePeople_Click;
            // 
            // MenueApplications
            // 
            MenueApplications.AutoSize = false;
            MenueApplications.Cursor = Cursors.Hand;
            MenueApplications.Location = new Point(20, 36);
            MenueApplications.Name = "MenueApplications";
            MenueApplications.Size = new Size(330, 117);
            MenueApplications.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenueApplications.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenueApplications.TabIndex = 100;
            MenueApplications.TabStop = false;
            MenueApplications.Values.Text = "Applications";
            // 
            // MenueCancel
            // 
            MenueCancel.Cursor = Cursors.Hand;
            MenueCancel.Image = (Image)resources.GetObject("MenueCancel.Image");
            MenueCancel.Location = new Point(1750, 30);
            MenueCancel.Name = "MenueCancel";
            MenueCancel.Size = new Size(150, 100);
            MenueCancel.SizeMode = PictureBoxSizeMode.Zoom;
            MenueCancel.TabIndex = 201;
            MenueCancel.TabStop = false;
            toolTip1.SetToolTip(MenueCancel, "Close");
            MenueCancel.Click += MenueCancel_Click;
            // 
            // PeopleTitle
            // 
            PeopleTitle.AutoSize = false;
            PeopleTitle.Cursor = Cursors.Hand;
            PeopleTitle.Location = new Point(987, 0);
            PeopleTitle.Name = "PeopleTitle";
            PeopleTitle.Size = new Size(226, 107);
            PeopleTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            PeopleTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PeopleTitle.TabIndex = 210;
            PeopleTitle.TabStop = false;
            PeopleTitle.Values.Text = "Main Menu";
            // 
            // frmMenue
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1946, 981);
            Controls.Add(PeopleTitle);
            Controls.Add(MenueCancel);
            Controls.Add(MenuePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenue";
            Text = "frmMenue";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)MenuePanel).EndInit();
            MenuePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenueCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MenuePanel;
        private Krypton.Toolkit.KryptonLabel MenueSettings;
        private Krypton.Toolkit.KryptonLabel MenueUsers;
        private Krypton.Toolkit.KryptonLabel MenueDrivers;
        private Krypton.Toolkit.KryptonLabel MenuePeople;
        private Krypton.Toolkit.KryptonLabel MenueApplications;
        private Krypton.Toolkit.KryptonPictureBox MenueCancel;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonLabel PeopleTitle;
    }
}