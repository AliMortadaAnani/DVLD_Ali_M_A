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
            lbLoginTitle = new Krypton.Toolkit.KryptonLabel();
            pbLoginCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTip1 = new ToolTip(components);
            pnLoginPanel = new Krypton.Toolkit.KryptonPanel();
            tbLoginPassword = new Krypton.Toolkit.KryptonTextBox();
            pbLoginPasswordImg = new Krypton.Toolkit.KryptonPictureBox();
            btnLoginButton = new Krypton.Toolkit.KryptonButton();
            tbLoginUsername = new Krypton.Toolkit.KryptonTextBox();
            pbLoginEmailImg = new Krypton.Toolkit.KryptonPictureBox();
            cbLoginRememberMe = new Krypton.Toolkit.KryptonCheckBox();
            lbLoginFormTitle = new Krypton.Toolkit.KryptonLabel();
            btnLoginLine2 = new Krypton.Toolkit.KryptonButton();
            btnLoginLine1 = new Krypton.Toolkit.KryptonButton();
            gbLoginGroup = new Krypton.Toolkit.KryptonGroupBox();
            errorProvider1 = new ErrorProvider(components);
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLoginCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnLoginPanel).BeginInit();
            pnLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoginPasswordImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLoginEmailImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbLoginGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gbLoginGroup.Panel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // lbLoginTitle
            // 
            lbLoginTitle.AutoSize = false;
            lbLoginTitle.Location = new Point(115, 27);
            lbLoginTitle.Name = "lbLoginTitle";
            lbLoginTitle.Size = new Size(770, 263);
            lbLoginTitle.StateNormal.ShortText.Color1 = Color.Gainsboro;
            lbLoginTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLoginTitle.TabIndex = 99;
            lbLoginTitle.TabStop = false;
            lbLoginTitle.Values.Text = "Drivers && Vehicles \r\nLicenses Department\r\nSystem";
            // 
            // pbLoginCancel
            // 
            pbLoginCancel.Cursor = Cursors.Hand;
            pbLoginCancel.Image = (Image)resources.GetObject("pbLoginCancel.Image");
            pbLoginCancel.Location = new Point(1750, 30);
            pbLoginCancel.Name = "pbLoginCancel";
            pbLoginCancel.Size = new Size(150, 100);
            pbLoginCancel.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoginCancel.TabIndex = 100;
            pbLoginCancel.TabStop = false;
            toolTip1.SetToolTip(pbLoginCancel, "Close");
            pbLoginCancel.Click += LoginCancel_Click;
            // 
            // pnLoginPanel
            // 
            pnLoginPanel.Controls.Add(tbLoginPassword);
            pnLoginPanel.Controls.Add(pbLoginPasswordImg);
            pnLoginPanel.Controls.Add(btnLoginButton);
            pnLoginPanel.Controls.Add(tbLoginUsername);
            pnLoginPanel.Controls.Add(pbLoginEmailImg);
            pnLoginPanel.Controls.Add(cbLoginRememberMe);
            pnLoginPanel.Controls.Add(lbLoginFormTitle);
            pnLoginPanel.Controls.Add(btnLoginLine2);
            pnLoginPanel.Controls.Add(btnLoginLine1);
            pnLoginPanel.Controls.Add(pbLoginCancel);
            pnLoginPanel.Controls.Add(lbLoginTitle);
            pnLoginPanel.Controls.Add(gbLoginGroup);
            pnLoginPanel.Dock = DockStyle.Fill;
            pnLoginPanel.Location = new Point(0, 0);
            pnLoginPanel.Name = "pnLoginPanel";
            pnLoginPanel.Size = new Size(1902, 1028);
            pnLoginPanel.StateNormal.Color1 = Color.DarkSlateBlue;
            pnLoginPanel.StateNormal.Color2 = Color.Black;
            pnLoginPanel.StateNormal.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            pnLoginPanel.TabIndex = 102;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Location = new Point(841, 614);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(432, 68);
            tbLoginPassword.StateActive.Back.Color1 = Color.DarkSlateBlue;
            tbLoginPassword.StateActive.Border.Color1 = Color.Gainsboro;
            tbLoginPassword.StateActive.Border.Rounding = 50F;
            tbLoginPassword.StateActive.Content.Color1 = Color.Gainsboro;
            tbLoginPassword.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLoginPassword.StateCommon.Back.Color1 = Color.Transparent;
            tbLoginPassword.StateCommon.Border.Rounding = 50F;
            tbLoginPassword.StateDisabled.Back.Color1 = Color.Transparent;
            tbLoginPassword.StateDisabled.Border.Rounding = 50F;
            tbLoginPassword.StateNormal.Back.Color1 = Color.Transparent;
            tbLoginPassword.StateNormal.Border.Rounding = 50F;
            tbLoginPassword.TabIndex = 1;
            tbLoginPassword.Text = "Password";
            tbLoginPassword.TextChanged += LoginPassword_TextChanged;
            tbLoginPassword.KeyDown += LoginPassword_KeyDown;
            tbLoginPassword.Validating += tbLoginPassword_Validating;
            // 
            // pbLoginPasswordImg
            // 
            pbLoginPasswordImg.Image = DVLD_Presentation.Properties.Resources.password;
            pbLoginPasswordImg.Location = new Point(708, 614);
            pbLoginPasswordImg.Name = "pbLoginPasswordImg";
            pbLoginPasswordImg.Size = new Size(150, 75);
            pbLoginPasswordImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoginPasswordImg.TabIndex = 109;
            pbLoginPasswordImg.TabStop = false;
            // 
            // btnLoginButton
            // 
            btnLoginButton.Cursor = Cursors.Hand;
            btnLoginButton.Location = new Point(884, 851);
            btnLoginButton.Name = "btnLoginButton";
            btnLoginButton.OverrideDefault.Back.Color1 = Color.Silver;
            btnLoginButton.OverrideDefault.Border.Rounding = 50F;
            btnLoginButton.OverrideFocus.Back.Color1 = Color.Silver;
            btnLoginButton.OverrideFocus.Border.Rounding = 50F;
            btnLoginButton.Size = new Size(203, 73);
            btnLoginButton.StateDisabled.Back.Color1 = Color.Silver;
            btnLoginButton.StateDisabled.Border.Rounding = 50F;
            btnLoginButton.StateNormal.Back.Color1 = Color.Silver;
            btnLoginButton.StateNormal.Back.Color2 = Color.Silver;
            btnLoginButton.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLoginButton.StateNormal.Border.Rounding = 50F;
            btnLoginButton.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnLoginButton.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginButton.StatePressed.Back.Color1 = Color.Silver;
            btnLoginButton.StatePressed.Back.Color2 = Color.Silver;
            btnLoginButton.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLoginButton.StatePressed.Border.Color1 = Color.Gainsboro;
            btnLoginButton.StatePressed.Border.Color2 = Color.Gainsboro;
            btnLoginButton.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLoginButton.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLoginButton.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLoginButton.StatePressed.Border.Rounding = 50F;
            btnLoginButton.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnLoginButton.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginButton.StateTracking.Back.Color1 = Color.Silver;
            btnLoginButton.StateTracking.Back.Color2 = Color.Silver;
            btnLoginButton.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLoginButton.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLoginButton.StateTracking.Border.Color1 = Color.Gainsboro;
            btnLoginButton.StateTracking.Border.Color2 = Color.Gainsboro;
            btnLoginButton.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLoginButton.StateTracking.Border.Rounding = 50F;
            btnLoginButton.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnLoginButton.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnLoginButton.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnLoginButton.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnLoginButton.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginButton.TabIndex = 4;
            btnLoginButton.Values.DropDownArrowColor = Color.Empty;
            btnLoginButton.Values.Text = "Login";
            btnLoginButton.Click += LoginButton_Click;
            btnLoginButton.KeyDown += LoginButton_KeyDown;
            // 
            // tbLoginUsername
            // 
            tbLoginUsername.Location = new Point(841, 466);
            tbLoginUsername.Name = "tbLoginUsername";
            tbLoginUsername.Size = new Size(432, 68);
            tbLoginUsername.StateActive.Back.Color1 = Color.DarkSlateBlue;
            tbLoginUsername.StateActive.Border.Color1 = Color.Gainsboro;
            tbLoginUsername.StateActive.Border.Rounding = 50F;
            tbLoginUsername.StateActive.Content.Color1 = Color.Gainsboro;
            tbLoginUsername.StateActive.Content.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLoginUsername.StateCommon.Back.Color1 = Color.Transparent;
            tbLoginUsername.StateCommon.Border.Color1 = Color.Gainsboro;
            tbLoginUsername.StateCommon.Border.Rounding = 50F;
            tbLoginUsername.StateDisabled.Back.Color1 = Color.Transparent;
            tbLoginUsername.StateDisabled.Border.Color1 = Color.Gainsboro;
            tbLoginUsername.StateDisabled.Border.Rounding = 50F;
            tbLoginUsername.StateNormal.Back.Color1 = Color.Transparent;
            tbLoginUsername.StateNormal.Border.Color1 = Color.Gainsboro;
            tbLoginUsername.StateNormal.Border.Rounding = 50F;
            tbLoginUsername.TabIndex = 0;
            tbLoginUsername.Text = "Username";
            tbLoginUsername.KeyDown += LoginUsername_KeyDown;
            tbLoginUsername.Validating += tbLoginUsername_Validating;
            // 
            // pbLoginEmailImg
            // 
            pbLoginEmailImg.Image = DVLD_Presentation.Properties.Resources.email1;
            pbLoginEmailImg.Location = new Point(708, 466);
            pbLoginEmailImg.Name = "pbLoginEmailImg";
            pbLoginEmailImg.Size = new Size(150, 75);
            pbLoginEmailImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoginEmailImg.TabIndex = 108;
            pbLoginEmailImg.TabStop = false;
            // 
            // cbLoginRememberMe
            // 
            cbLoginRememberMe.AutoSize = false;
            cbLoginRememberMe.Cursor = Cursors.Hand;
            cbLoginRememberMe.Location = new Point(712, 777);
            cbLoginRememberMe.Name = "cbLoginRememberMe";
            cbLoginRememberMe.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueLightMode;
            cbLoginRememberMe.Size = new Size(217, 42);
            cbLoginRememberMe.StateNormal.ShortText.Color1 = Color.Gainsboro;
            cbLoginRememberMe.StateNormal.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cbLoginRememberMe.TabIndex = 3;
            cbLoginRememberMe.Values.Text = "Remember Me";
            cbLoginRememberMe.KeyDown += LoginRememberMe_KeyDown;
            // 
            // lbLoginFormTitle
            // 
            lbLoginFormTitle.AutoSize = false;
            lbLoginFormTitle.Location = new Point(890, 327);
            lbLoginFormTitle.Name = "lbLoginFormTitle";
            lbLoginFormTitle.Size = new Size(197, 90);
            lbLoginFormTitle.StateNormal.ShortText.Color1 = Color.DimGray;
            lbLoginFormTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLoginFormTitle.TabIndex = 104;
            lbLoginFormTitle.TabStop = false;
            lbLoginFormTitle.Values.Text = "Log In\r\n";
            // 
            // btnLoginLine2
            // 
            btnLoginLine2.Location = new Point(708, 719);
            btnLoginLine2.Name = "btnLoginLine2";
            btnLoginLine2.Size = new Size(587, 1);
            btnLoginLine2.TabIndex = 103;
            btnLoginLine2.TabStop = false;
            btnLoginLine2.Values.DropDownArrowColor = Color.Empty;
            btnLoginLine2.Values.Text = "";
            // 
            // btnLoginLine1
            // 
            btnLoginLine1.Location = new Point(708, 562);
            btnLoginLine1.Name = "btnLoginLine1";
            btnLoginLine1.Size = new Size(587, 1);
            btnLoginLine1.TabIndex = 102;
            btnLoginLine1.TabStop = false;
            btnLoginLine1.Values.DropDownArrowColor = Color.Empty;
            btnLoginLine1.Values.Text = "";
            // 
            // gbLoginGroup
            // 
            gbLoginGroup.Location = new Point(647, 317);
            gbLoginGroup.Size = new Size(685, 641);
            gbLoginGroup.StateNormal.Back.Color1 = Color.Transparent;
            gbLoginGroup.StateNormal.Back.Color2 = Color.Transparent;
            gbLoginGroup.StateNormal.Border.Color1 = Color.Gainsboro;
            gbLoginGroup.StateNormal.Border.Rounding = 100F;
            gbLoginGroup.TabIndex = 101;
            gbLoginGroup.Values.Heading = "";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = DVLD_Presentation.Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 210;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1902, 1028);
            ControlBox = false;
            Controls.Add(btnDocumentation);
            Controls.Add(pnLoginPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            WindowState = FormWindowState.Maximized;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pbLoginCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnLoginPanel).EndInit();
            pnLoginPanel.ResumeLayout(false);
            pnLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoginPasswordImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLoginEmailImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbLoginGroup.Panel).EndInit();
            ((System.ComponentModel.ISupportInitialize)gbLoginGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbLoginTitle;
        private Krypton.Toolkit.KryptonPictureBox pbLoginCancel;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonPanel pnLoginPanel;
        private Krypton.Toolkit.KryptonGroupBox gbLoginGroup;
        private Krypton.Toolkit.KryptonButton btnLoginLine1;
        private Krypton.Toolkit.KryptonButton btnLoginLine2;
        private Krypton.Toolkit.KryptonLabel lbLoginFormTitle;
        private Krypton.Toolkit.KryptonTextBox tbLoginUsername;
        private Krypton.Toolkit.KryptonTextBox tbLoginPassword;
        private Krypton.Toolkit.KryptonCheckBox cbLoginRememberMe;
        private Krypton.Toolkit.KryptonPictureBox pbLoginEmailImg;
        private Krypton.Toolkit.KryptonButton btnLoginButton;
        private Krypton.Toolkit.KryptonPictureBox pbLoginPasswordImg;
        private ErrorProvider errorProvider1;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
        private ToolTip toolTip2;
    }
}