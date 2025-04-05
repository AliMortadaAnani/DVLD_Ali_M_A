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
            MenuPanel = new Krypton.Toolkit.KryptonPanel();
            MenuSettings = new Krypton.Toolkit.KryptonLabel();
            MenuUsers = new Krypton.Toolkit.KryptonLabel();
            MenuDrivers = new Krypton.Toolkit.KryptonLabel();
            MenuPeople = new Krypton.Toolkit.KryptonLabel();
            MenuApplications = new Krypton.Toolkit.KryptonLabel();
            MenuCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTip1 = new ToolTip(components);
            MenuTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)MenuPanel).BeginInit();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuCancel).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(MenuSettings);
            MenuPanel.Controls.Add(MenuUsers);
            MenuPanel.Controls.Add(MenuDrivers);
            MenuPanel.Controls.Add(MenuPeople);
            MenuPanel.Controls.Add(MenuApplications);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(350, 981);
            MenuPanel.StateNormal.Color1 = SystemColors.ControlText;
            MenuPanel.StateNormal.Color2 = Color.DarkSlateBlue;
            MenuPanel.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            MenuPanel.TabIndex = 200;
            // 
            // MenuSettings
            // 
            MenuSettings.AutoSize = false;
            MenuSettings.Cursor = Cursors.Hand;
            MenuSettings.Location = new Point(20, 741);
            MenuSettings.Name = "MenuSettings";
            MenuSettings.Size = new Size(347, 107);
            MenuSettings.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenuSettings.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuSettings.TabIndex = 104;
            MenuSettings.TabStop = false;
            MenuSettings.Values.Text = "Account Settings";
            MenuSettings.Click += MenuSettings_Click;
            // 
            // MenuUsers
            // 
            MenuUsers.AutoSize = false;
            MenuUsers.Cursor = Cursors.Hand;
            MenuUsers.Location = new Point(20, 565);
            MenuUsers.Name = "MenuUsers";
            MenuUsers.Size = new Size(330, 117);
            MenuUsers.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenuUsers.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuUsers.TabIndex = 103;
            MenuUsers.TabStop = false;
            MenuUsers.Values.Text = "Users";
            // 
            // MenuDrivers
            // 
            MenuDrivers.AutoSize = false;
            MenuDrivers.Cursor = Cursors.Hand;
            MenuDrivers.Location = new Point(20, 389);
            MenuDrivers.Name = "MenuDrivers";
            MenuDrivers.Size = new Size(330, 117);
            MenuDrivers.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenuDrivers.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuDrivers.TabIndex = 102;
            MenuDrivers.TabStop = false;
            MenuDrivers.Values.Text = "Drivers";
            // 
            // MenuPeople
            // 
            MenuPeople.AutoSize = false;
            MenuPeople.Cursor = Cursors.Hand;
            MenuPeople.Location = new Point(20, 203);
            MenuPeople.Name = "MenuPeople";
            MenuPeople.Size = new Size(330, 117);
            MenuPeople.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenuPeople.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuPeople.TabIndex = 101;
            MenuPeople.TabStop = false;
            MenuPeople.Values.Text = "People";
            MenuPeople.Click += MenuPeople_Click;
            // 
            // MenuApplications
            // 
            MenuApplications.AutoSize = false;
            MenuApplications.Cursor = Cursors.Hand;
            MenuApplications.Location = new Point(20, 36);
            MenuApplications.Name = "MenuApplications";
            MenuApplications.Size = new Size(330, 117);
            MenuApplications.StateNormal.ShortText.Color1 = Color.Gainsboro;
            MenuApplications.StateNormal.ShortText.Font = new Font("Trebuchet MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuApplications.TabIndex = 100;
            MenuApplications.TabStop = false;
            MenuApplications.Values.Text = "Applications";
            // 
            // MenuCancel
            // 
            MenuCancel.Cursor = Cursors.Hand;
            MenuCancel.Image = (Image)resources.GetObject("MenuCancel.Image");
            MenuCancel.Location = new Point(1750, 30);
            MenuCancel.Name = "MenuCancel";
            MenuCancel.Size = new Size(150, 100);
            MenuCancel.SizeMode = PictureBoxSizeMode.Zoom;
            MenuCancel.TabIndex = 201;
            MenuCancel.TabStop = false;
            toolTip1.SetToolTip(MenuCancel, "Close");
            MenuCancel.Click += MenuCancel_Click;
            // 
            // MenuTitle
            // 
            MenuTitle.AutoSize = false;
            MenuTitle.Cursor = Cursors.Hand;
            MenuTitle.Location = new Point(987, 0);
            MenuTitle.Name = "MenuTitle";
            MenuTitle.Size = new Size(226, 107);
            MenuTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            MenuTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuTitle.TabIndex = 210;
            MenuTitle.TabStop = false;
            MenuTitle.Values.Text = "Main Menu";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1946, 981);
            Controls.Add(MenuTitle);
            Controls.Add(MenuCancel);
            Controls.Add(MenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenu";
            Text = "frmMenu";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)MenuPanel).EndInit();
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MenuCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel MenuPanel;
        private Krypton.Toolkit.KryptonLabel MenuSettings;
        private Krypton.Toolkit.KryptonLabel MenuUsers;
        private Krypton.Toolkit.KryptonLabel MenuDrivers;
        private Krypton.Toolkit.KryptonLabel MenuPeople;
        private Krypton.Toolkit.KryptonLabel MenuApplications;
        private Krypton.Toolkit.KryptonPictureBox MenuCancel;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonLabel MenuTitle;
    }
}