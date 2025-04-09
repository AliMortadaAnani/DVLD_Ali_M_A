namespace DVLD_Ali_M_A
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            LoginTitle = new Krypton.Toolkit.KryptonLabel();
            LoginCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTip1 = new ToolTip(components);
            LoginPanel = new Krypton.Toolkit.KryptonPanel();
            LoginPassword = new Krypton.Toolkit.KryptonTextBox();
            LoginPasswordImg = new Krypton.Toolkit.KryptonPictureBox();
            LoginButton = new Krypton.Toolkit.KryptonButton();
            LoginUsername = new Krypton.Toolkit.KryptonTextBox();
            LoginEmailImg = new Krypton.Toolkit.KryptonPictureBox();
            LoginRememberMe = new Krypton.Toolkit.KryptonCheckBox();
            LoginFormTitle = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            LoginLine1 = new Krypton.Toolkit.KryptonButton();
            LoginGroup = new Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)LoginCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginPanel).BeginInit();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPasswordImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginEmailImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginGroup.Panel).BeginInit();
            SuspendLayout();
            // 
            // LoginTitle
            // 
            LoginTitle.AutoSize = false;
            LoginTitle.Location = new Point(115, 27);
            LoginTitle.Name = "LoginTitle";
            LoginTitle.Size = new Size(770, 263);
            LoginTitle.StateNormal.ShortText.Color1 = Color.Gainsboro;
            LoginTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitle.TabIndex = 99;
            LoginTitle.TabStop = false;
            LoginTitle.Values.Text = "Drivers && Vehicules \r\nLicenses Department\r\nSystem";
            // 
            // LoginCancel
            // 
            LoginCancel.Cursor = Cursors.Hand;
            LoginCancel.Image = (Image)resources.GetObject("LoginCancel.Image");
            LoginCancel.Location = new Point(1750, 30);
            LoginCancel.Name = "LoginCancel";
            LoginCancel.Size = new Size(150, 100);
            LoginCancel.SizeMode = PictureBoxSizeMode.Zoom;
            LoginCancel.TabIndex = 100;
            LoginCancel.TabStop = false;
            toolTip1.SetToolTip(LoginCancel, "Close");
            LoginCancel.Click += LoginCancel_Click;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LoginPassword);
            LoginPanel.Controls.Add(LoginPasswordImg);
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(LoginUsername);
            LoginPanel.Controls.Add(LoginEmailImg);
            LoginPanel.Controls.Add(LoginRememberMe);
            LoginPanel.Controls.Add(LoginFormTitle);
            LoginPanel.Controls.Add(kryptonButton1);
            LoginPanel.Controls.Add(LoginLine1);
            LoginPanel.Controls.Add(LoginCancel);
            LoginPanel.Controls.Add(LoginTitle);
            LoginPanel.Controls.Add(LoginGroup);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(1902, 1028);
            LoginPanel.StateNormal.Color1 = Color.DarkSlateBlue;
            LoginPanel.StateNormal.Color2 = Color.Black;
            LoginPanel.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            LoginPanel.TabIndex = 102;
            // 
            // LoginPassword
            // 
            LoginPassword.Location = new Point(841, 614);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.Size = new Size(432, 68);
            LoginPassword.StateActive.Back.Color1 = Color.DarkSlateBlue;
            LoginPassword.StateActive.Border.Color1 = Color.Gainsboro;
            LoginPassword.StateActive.Border.Rounding = 50F;
            LoginPassword.StateActive.Content.Color1 = Color.Gainsboro;
            LoginPassword.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginPassword.StateCommon.Back.Color1 = Color.Transparent;
            LoginPassword.StateCommon.Border.Rounding = 50F;
            LoginPassword.StateDisabled.Back.Color1 = Color.Transparent;
            LoginPassword.StateDisabled.Border.Rounding = 50F;
            LoginPassword.StateNormal.Back.Color1 = Color.Transparent;
            LoginPassword.StateNormal.Border.Rounding = 50F;
            LoginPassword.TabIndex = 1;
            LoginPassword.Text = "Password";
            LoginPassword.TextChanged += LoginPassword_TextChanged;
            LoginPassword.KeyDown += LoginPassword_KeyDown;
            // 
            // LoginPasswordImg
            // 
            LoginPasswordImg.Image = DVLD_Presentation.Properties.Resources.password;
            LoginPasswordImg.Location = new Point(708, 614);
            LoginPasswordImg.Name = "LoginPasswordImg";
            LoginPasswordImg.Size = new Size(150, 75);
            LoginPasswordImg.SizeMode = PictureBoxSizeMode.Zoom;
            LoginPasswordImg.TabIndex = 109;
            LoginPasswordImg.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(884, 851);
            LoginButton.Name = "LoginButton";
            LoginButton.OverrideDefault.Back.Color1 = Color.Silver;
            LoginButton.OverrideDefault.Border.Rounding = 50F;
            LoginButton.OverrideFocus.Back.Color1 = Color.Silver;
            LoginButton.OverrideFocus.Border.Rounding = 50F;
            LoginButton.Size = new Size(203, 73);
            LoginButton.StateDisabled.Back.Color1 = Color.Silver;
            LoginButton.StateDisabled.Border.Rounding = 50F;
            LoginButton.StateNormal.Back.Color1 = Color.Silver;
            LoginButton.StateNormal.Back.Color2 = Color.Silver;
            LoginButton.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            LoginButton.StateNormal.Border.Rounding = 50F;
            LoginButton.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            LoginButton.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.StatePressed.Back.Color1 = Color.Silver;
            LoginButton.StatePressed.Back.Color2 = Color.Silver;
            LoginButton.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoginButton.StatePressed.Border.Color1 = Color.Gainsboro;
            LoginButton.StatePressed.Border.Color2 = Color.Gainsboro;
            LoginButton.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            LoginButton.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            LoginButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoginButton.StatePressed.Border.Rounding = 50F;
            LoginButton.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            LoginButton.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.StateTracking.Back.Color1 = Color.Silver;
            LoginButton.StateTracking.Back.Color2 = Color.Silver;
            LoginButton.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            LoginButton.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            LoginButton.StateTracking.Border.Color1 = Color.Gainsboro;
            LoginButton.StateTracking.Border.Color2 = Color.Gainsboro;
            LoginButton.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            LoginButton.StateTracking.Border.Rounding = 50F;
            LoginButton.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            LoginButton.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            LoginButton.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            LoginButton.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            LoginButton.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.TabIndex = 4;
            LoginButton.Values.DropDownArrowColor = Color.Empty;
            LoginButton.Values.Text = "Login";
            LoginButton.Click += LoginButton_Click;
            LoginButton.KeyDown += LoginButton_KeyDown;
            // 
            // LoginUsername
            // 
            LoginUsername.Location = new Point(841, 466);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(432, 68);
            LoginUsername.StateActive.Back.Color1 = Color.DarkSlateBlue;
            LoginUsername.StateActive.Border.Color1 = Color.Gainsboro;
            LoginUsername.StateActive.Border.Rounding = 50F;
            LoginUsername.StateActive.Content.Color1 = Color.Gainsboro;
            LoginUsername.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginUsername.StateCommon.Back.Color1 = Color.Transparent;
            LoginUsername.StateCommon.Border.Color1 = Color.Gainsboro;
            LoginUsername.StateCommon.Border.Rounding = 50F;
            LoginUsername.StateDisabled.Back.Color1 = Color.Transparent;
            LoginUsername.StateDisabled.Border.Color1 = Color.Gainsboro;
            LoginUsername.StateDisabled.Border.Rounding = 50F;
            LoginUsername.StateNormal.Back.Color1 = Color.Transparent;
            LoginUsername.StateNormal.Border.Color1 = Color.Gainsboro;
            LoginUsername.StateNormal.Border.Rounding = 50F;
            LoginUsername.TabIndex = 0;
            LoginUsername.Text = "Username";
            LoginUsername.KeyDown += LoginUsername_KeyDown;
            // 
            // LoginEmailImg
            // 
            LoginEmailImg.Image = DVLD_Presentation.Properties.Resources.email1;
            LoginEmailImg.Location = new Point(708, 466);
            LoginEmailImg.Name = "LoginEmailImg";
            LoginEmailImg.Size = new Size(150, 75);
            LoginEmailImg.SizeMode = PictureBoxSizeMode.Zoom;
            LoginEmailImg.TabIndex = 108;
            LoginEmailImg.TabStop = false;
            // 
            // LoginRememberMe
            // 
            LoginRememberMe.AutoSize = false;
            LoginRememberMe.Location = new Point(712, 777);
            LoginRememberMe.Name = "LoginRememberMe";
            LoginRememberMe.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueLightMode;
            LoginRememberMe.Size = new Size(217, 42);
            LoginRememberMe.StateNormal.ShortText.Color1 = Color.Gainsboro;
            LoginRememberMe.StateNormal.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LoginRememberMe.TabIndex = 3;
            LoginRememberMe.Values.Text = "Remember Me";
            LoginRememberMe.KeyDown += LoginRememberMe_KeyDown;
            // 
            // LoginFormTitle
            // 
            LoginFormTitle.AutoSize = false;
            LoginFormTitle.Location = new Point(890, 327);
            LoginFormTitle.Name = "LoginFormTitle";
            LoginFormTitle.Size = new Size(197, 90);
            LoginFormTitle.StateNormal.ShortText.Color1 = Color.DimGray;
            LoginFormTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginFormTitle.TabIndex = 104;
            LoginFormTitle.TabStop = false;
            LoginFormTitle.Values.Text = "Log In\r\n";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(708, 719);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(587, 1);
            kryptonButton1.TabIndex = 103;
            kryptonButton1.TabStop = false;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "";
            // 
            // LoginLine1
            // 
            LoginLine1.Location = new Point(708, 562);
            LoginLine1.Name = "LoginLine1";
            LoginLine1.Size = new Size(587, 1);
            LoginLine1.TabIndex = 102;
            LoginLine1.TabStop = false;
            LoginLine1.Values.DropDownArrowColor = Color.Empty;
            LoginLine1.Values.Text = "";
            // 
            // LoginGroup
            // 
            LoginGroup.Location = new Point(647, 317);
            LoginGroup.Size = new Size(685, 641);
            LoginGroup.StateNormal.Back.Color1 = Color.Transparent;
            LoginGroup.StateNormal.Back.Color2 = Color.Transparent;
            LoginGroup.StateNormal.Border.Color1 = Color.Gainsboro;
            LoginGroup.StateNormal.Border.Rounding = 100F;
            LoginGroup.TabIndex = 101;
            LoginGroup.Values.Heading = "";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1902, 1028);
            ControlBox = false;
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)LoginCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginPanel).EndInit();
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LoginPasswordImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginEmailImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginGroup.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginGroup).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel LoginTitle;
        private Krypton.Toolkit.KryptonPictureBox LoginCancel;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonPanel LoginPanel;
        private Krypton.Toolkit.KryptonGroupBox LoginGroup;
        private Krypton.Toolkit.KryptonButton LoginLine1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel LoginFormTitle;
        private Krypton.Toolkit.KryptonTextBox LoginUsername;
        private Krypton.Toolkit.KryptonTextBox LoginPassword;
        private Krypton.Toolkit.KryptonCheckBox LoginRememberMe;
        private Krypton.Toolkit.KryptonPictureBox LoginEmailImg;
        private Krypton.Toolkit.KryptonButton LoginButton;
        private Krypton.Toolkit.KryptonPictureBox LoginPasswordImg;
    }
}