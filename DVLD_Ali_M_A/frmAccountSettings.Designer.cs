namespace DVLD_Ali_M_A
{
    partial class frmAccountSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountSettings));
            SettingsCancel = new Krypton.Toolkit.KryptonPictureBox();
            SettingsCurrentUserInfo = new Krypton.Toolkit.KryptonButton();
            SettingsChangePassword = new Krypton.Toolkit.KryptonButton();
            SettingsSignOut = new Krypton.Toolkit.KryptonButton();
            SettingsTitle = new Krypton.Toolkit.KryptonLabel();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)SettingsCancel).BeginInit();
            SuspendLayout();
            // 
            // SettingsCancel
            // 
            SettingsCancel.Cursor = Cursors.Hand;
            SettingsCancel.Image = (Image)resources.GetObject("SettingsCancel.Image");
            SettingsCancel.Location = new Point(1400, 30);
            SettingsCancel.Name = "SettingsCancel";
            SettingsCancel.Size = new Size(150, 100);
            SettingsCancel.SizeMode = PictureBoxSizeMode.Zoom;
            SettingsCancel.TabIndex = 204;
            SettingsCancel.TabStop = false;
            toolTip1.SetToolTip(SettingsCancel, "Close");
            SettingsCancel.Click += SettingsCancel_Click;
            // 
            // SettingsCurrentUserInfo
            // 
            SettingsCurrentUserInfo.Location = new Point(42, 139);
            SettingsCurrentUserInfo.Name = "SettingsCurrentUserInfo";
            SettingsCurrentUserInfo.OverrideDefault.Back.Color1 = Color.Silver;
            SettingsCurrentUserInfo.OverrideDefault.Border.Rounding = 50F;
            SettingsCurrentUserInfo.OverrideFocus.Back.Color1 = Color.Silver;
            SettingsCurrentUserInfo.OverrideFocus.Border.Rounding = 50F;
            SettingsCurrentUserInfo.Size = new Size(596, 360);
            SettingsCurrentUserInfo.StateDisabled.Back.Color1 = Color.Silver;
            SettingsCurrentUserInfo.StateDisabled.Border.Rounding = 50F;
            SettingsCurrentUserInfo.StateNormal.Back.Color1 = Color.Silver;
            SettingsCurrentUserInfo.StateNormal.Back.Color2 = Color.Silver;
            SettingsCurrentUserInfo.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsCurrentUserInfo.StateNormal.Border.Rounding = 50F;
            SettingsCurrentUserInfo.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            SettingsCurrentUserInfo.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsCurrentUserInfo.StatePressed.Back.Color1 = Color.Silver;
            SettingsCurrentUserInfo.StatePressed.Back.Color2 = Color.Silver;
            SettingsCurrentUserInfo.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsCurrentUserInfo.StatePressed.Border.Color1 = Color.Gainsboro;
            SettingsCurrentUserInfo.StatePressed.Border.Color2 = Color.Gainsboro;
            SettingsCurrentUserInfo.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsCurrentUserInfo.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsCurrentUserInfo.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsCurrentUserInfo.StatePressed.Border.Rounding = 50F;
            SettingsCurrentUserInfo.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            SettingsCurrentUserInfo.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsCurrentUserInfo.StateTracking.Back.Color1 = Color.Silver;
            SettingsCurrentUserInfo.StateTracking.Back.Color2 = Color.Silver;
            SettingsCurrentUserInfo.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsCurrentUserInfo.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsCurrentUserInfo.StateTracking.Border.Color1 = Color.Gainsboro;
            SettingsCurrentUserInfo.StateTracking.Border.Color2 = Color.Gainsboro;
            SettingsCurrentUserInfo.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsCurrentUserInfo.StateTracking.Border.Rounding = 50F;
            SettingsCurrentUserInfo.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsCurrentUserInfo.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            SettingsCurrentUserInfo.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            SettingsCurrentUserInfo.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            SettingsCurrentUserInfo.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsCurrentUserInfo.TabIndex = 205;
            SettingsCurrentUserInfo.Values.DropDownArrowColor = Color.Empty;
            SettingsCurrentUserInfo.Values.Text = "Show Current User Information";
            // 
            // SettingsChangePassword
            // 
            SettingsChangePassword.Location = new Point(809, 139);
            SettingsChangePassword.Name = "SettingsChangePassword";
            SettingsChangePassword.OverrideDefault.Back.Color1 = Color.Silver;
            SettingsChangePassword.OverrideDefault.Border.Rounding = 50F;
            SettingsChangePassword.OverrideFocus.Back.Color1 = Color.Silver;
            SettingsChangePassword.OverrideFocus.Border.Rounding = 50F;
            SettingsChangePassword.Size = new Size(596, 360);
            SettingsChangePassword.StateDisabled.Back.Color1 = Color.Silver;
            SettingsChangePassword.StateDisabled.Border.Rounding = 50F;
            SettingsChangePassword.StateNormal.Back.Color1 = Color.Silver;
            SettingsChangePassword.StateNormal.Back.Color2 = Color.Silver;
            SettingsChangePassword.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsChangePassword.StateNormal.Border.Rounding = 50F;
            SettingsChangePassword.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            SettingsChangePassword.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsChangePassword.StatePressed.Back.Color1 = Color.Silver;
            SettingsChangePassword.StatePressed.Back.Color2 = Color.Silver;
            SettingsChangePassword.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsChangePassword.StatePressed.Border.Color1 = Color.Gainsboro;
            SettingsChangePassword.StatePressed.Border.Color2 = Color.Gainsboro;
            SettingsChangePassword.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsChangePassword.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsChangePassword.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsChangePassword.StatePressed.Border.Rounding = 50F;
            SettingsChangePassword.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            SettingsChangePassword.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsChangePassword.StateTracking.Back.Color1 = Color.Silver;
            SettingsChangePassword.StateTracking.Back.Color2 = Color.Silver;
            SettingsChangePassword.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsChangePassword.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsChangePassword.StateTracking.Border.Color1 = Color.Gainsboro;
            SettingsChangePassword.StateTracking.Border.Color2 = Color.Gainsboro;
            SettingsChangePassword.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsChangePassword.StateTracking.Border.Rounding = 50F;
            SettingsChangePassword.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsChangePassword.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            SettingsChangePassword.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            SettingsChangePassword.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            SettingsChangePassword.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsChangePassword.TabIndex = 206;
            SettingsChangePassword.Values.DropDownArrowColor = Color.Empty;
            SettingsChangePassword.Values.Text = "Change Current User Password";
            // 
            // SettingsSignOut
            // 
            SettingsSignOut.Location = new Point(435, 570);
            SettingsSignOut.Name = "SettingsSignOut";
            SettingsSignOut.OverrideDefault.Back.Color1 = Color.Silver;
            SettingsSignOut.OverrideDefault.Border.Rounding = 50F;
            SettingsSignOut.OverrideFocus.Back.Color1 = Color.Silver;
            SettingsSignOut.OverrideFocus.Border.Rounding = 50F;
            SettingsSignOut.Size = new Size(596, 360);
            SettingsSignOut.StateDisabled.Back.Color1 = Color.Silver;
            SettingsSignOut.StateDisabled.Border.Rounding = 50F;
            SettingsSignOut.StateNormal.Back.Color1 = Color.Silver;
            SettingsSignOut.StateNormal.Back.Color2 = Color.Silver;
            SettingsSignOut.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsSignOut.StateNormal.Border.Rounding = 50F;
            SettingsSignOut.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            SettingsSignOut.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsSignOut.StatePressed.Back.Color1 = Color.Silver;
            SettingsSignOut.StatePressed.Back.Color2 = Color.Silver;
            SettingsSignOut.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsSignOut.StatePressed.Border.Color1 = Color.Gainsboro;
            SettingsSignOut.StatePressed.Border.Color2 = Color.Gainsboro;
            SettingsSignOut.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsSignOut.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsSignOut.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsSignOut.StatePressed.Border.Rounding = 50F;
            SettingsSignOut.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            SettingsSignOut.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsSignOut.StateTracking.Back.Color1 = Color.Silver;
            SettingsSignOut.StateTracking.Back.Color2 = Color.Silver;
            SettingsSignOut.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsSignOut.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            SettingsSignOut.StateTracking.Border.Color1 = Color.Gainsboro;
            SettingsSignOut.StateTracking.Border.Color2 = Color.Gainsboro;
            SettingsSignOut.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            SettingsSignOut.StateTracking.Border.Rounding = 50F;
            SettingsSignOut.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            SettingsSignOut.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            SettingsSignOut.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            SettingsSignOut.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            SettingsSignOut.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsSignOut.TabIndex = 207;
            SettingsSignOut.Values.DropDownArrowColor = Color.Empty;
            SettingsSignOut.Values.Text = "Sign Out Of Current User Account";
            SettingsSignOut.Click += SettingsSignOut_Click;
            // 
            // SettingsTitle
            // 
            SettingsTitle.AutoSize = false;
            SettingsTitle.Cursor = Cursors.Hand;
            SettingsTitle.Location = new Point(556, -6);
            SettingsTitle.Name = "SettingsTitle";
            SettingsTitle.Size = new Size(347, 107);
            SettingsTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            SettingsTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SettingsTitle.TabIndex = 208;
            SettingsTitle.TabStop = false;
            SettingsTitle.Values.Text = "Account Settings";
            // 
            // frmAccountSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1548, 1028);
            Controls.Add(SettingsTitle);
            Controls.Add(SettingsSignOut);
            Controls.Add(SettingsChangePassword);
            Controls.Add(SettingsCurrentUserInfo);
            Controls.Add(SettingsCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccountSettings";
            Text = "frmAccountSettings";
            Load += frmAccountSettings_Load;
            ((System.ComponentModel.ISupportInitialize)SettingsCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox SettingsCancel;
        private Krypton.Toolkit.KryptonButton SettingsCurrentUserInfo;
        private Krypton.Toolkit.KryptonButton SettingsChangePassword;
        private Krypton.Toolkit.KryptonButton SettingsSignOut;
        private Krypton.Toolkit.KryptonLabel SettingsTitle;
        private ToolTip toolTip1;
    }
}