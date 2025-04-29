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
            pbSettingsCancel = new Krypton.Toolkit.KryptonPictureBox();
            btnSettingsCurrentUserInfo = new Krypton.Toolkit.KryptonButton();
            btnSettingsChangePassword = new Krypton.Toolkit.KryptonButton();
            btnSettingsSignOut = new Krypton.Toolkit.KryptonButton();
            lbSettingsTitle = new Krypton.Toolkit.KryptonLabel();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pbSettingsCancel).BeginInit();
            SuspendLayout();
            // 
            // pbSettingsCancel
            // 
            pbSettingsCancel.Cursor = Cursors.Hand;
            pbSettingsCancel.Image = (Image)resources.GetObject("pbSettingsCancel.Image");
            pbSettingsCancel.Location = new Point(1400, 30);
            pbSettingsCancel.Name = "pbSettingsCancel";
            pbSettingsCancel.Size = new Size(150, 100);
            pbSettingsCancel.SizeMode = PictureBoxSizeMode.Zoom;
            pbSettingsCancel.TabIndex = 204;
            pbSettingsCancel.TabStop = false;
            toolTip1.SetToolTip(pbSettingsCancel, "Close");
            pbSettingsCancel.Click += SettingsCancel_Click;
            // 
            // btnSettingsCurrentUserInfo
            // 
            btnSettingsCurrentUserInfo.Cursor = Cursors.Hand;
            btnSettingsCurrentUserInfo.Location = new Point(42, 139);
            btnSettingsCurrentUserInfo.Name = "btnSettingsCurrentUserInfo";
            btnSettingsCurrentUserInfo.OverrideDefault.Back.Color1 = Color.Silver;
            btnSettingsCurrentUserInfo.OverrideDefault.Border.Rounding = 50F;
            btnSettingsCurrentUserInfo.OverrideFocus.Back.Color1 = Color.Silver;
            btnSettingsCurrentUserInfo.OverrideFocus.Border.Rounding = 50F;
            btnSettingsCurrentUserInfo.Size = new Size(596, 360);
            btnSettingsCurrentUserInfo.StateDisabled.Back.Color1 = Color.Silver;
            btnSettingsCurrentUserInfo.StateDisabled.Border.Rounding = 50F;
            btnSettingsCurrentUserInfo.StateNormal.Back.Color1 = Color.Silver;
            btnSettingsCurrentUserInfo.StateNormal.Back.Color2 = Color.Silver;
            btnSettingsCurrentUserInfo.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsCurrentUserInfo.StateNormal.Border.Rounding = 50F;
            btnSettingsCurrentUserInfo.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnSettingsCurrentUserInfo.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsCurrentUserInfo.StatePressed.Back.Color1 = Color.Silver;
            btnSettingsCurrentUserInfo.StatePressed.Back.Color2 = Color.Silver;
            btnSettingsCurrentUserInfo.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsCurrentUserInfo.StatePressed.Border.Color1 = Color.Gainsboro;
            btnSettingsCurrentUserInfo.StatePressed.Border.Color2 = Color.Gainsboro;
            btnSettingsCurrentUserInfo.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsCurrentUserInfo.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsCurrentUserInfo.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsCurrentUserInfo.StatePressed.Border.Rounding = 50F;
            btnSettingsCurrentUserInfo.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnSettingsCurrentUserInfo.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsCurrentUserInfo.StateTracking.Back.Color1 = Color.Silver;
            btnSettingsCurrentUserInfo.StateTracking.Back.Color2 = Color.Silver;
            btnSettingsCurrentUserInfo.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsCurrentUserInfo.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsCurrentUserInfo.StateTracking.Border.Color1 = Color.Gainsboro;
            btnSettingsCurrentUserInfo.StateTracking.Border.Color2 = Color.Gainsboro;
            btnSettingsCurrentUserInfo.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsCurrentUserInfo.StateTracking.Border.Rounding = 50F;
            btnSettingsCurrentUserInfo.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsCurrentUserInfo.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnSettingsCurrentUserInfo.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnSettingsCurrentUserInfo.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnSettingsCurrentUserInfo.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsCurrentUserInfo.TabIndex = 205;
            btnSettingsCurrentUserInfo.Values.DropDownArrowColor = Color.Empty;
            btnSettingsCurrentUserInfo.Values.Text = "Show Current User Information";
            // 
            // btnSettingsChangePassword
            // 
            btnSettingsChangePassword.Cursor = Cursors.Hand;
            btnSettingsChangePassword.Location = new Point(809, 139);
            btnSettingsChangePassword.Name = "btnSettingsChangePassword";
            btnSettingsChangePassword.OverrideDefault.Back.Color1 = Color.Silver;
            btnSettingsChangePassword.OverrideDefault.Border.Rounding = 50F;
            btnSettingsChangePassword.OverrideFocus.Back.Color1 = Color.Silver;
            btnSettingsChangePassword.OverrideFocus.Border.Rounding = 50F;
            btnSettingsChangePassword.Size = new Size(596, 360);
            btnSettingsChangePassword.StateDisabled.Back.Color1 = Color.Silver;
            btnSettingsChangePassword.StateDisabled.Border.Rounding = 50F;
            btnSettingsChangePassword.StateNormal.Back.Color1 = Color.Silver;
            btnSettingsChangePassword.StateNormal.Back.Color2 = Color.Silver;
            btnSettingsChangePassword.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsChangePassword.StateNormal.Border.Rounding = 50F;
            btnSettingsChangePassword.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnSettingsChangePassword.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsChangePassword.StatePressed.Back.Color1 = Color.Silver;
            btnSettingsChangePassword.StatePressed.Back.Color2 = Color.Silver;
            btnSettingsChangePassword.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsChangePassword.StatePressed.Border.Color1 = Color.Gainsboro;
            btnSettingsChangePassword.StatePressed.Border.Color2 = Color.Gainsboro;
            btnSettingsChangePassword.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsChangePassword.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsChangePassword.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsChangePassword.StatePressed.Border.Rounding = 50F;
            btnSettingsChangePassword.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnSettingsChangePassword.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsChangePassword.StateTracking.Back.Color1 = Color.Silver;
            btnSettingsChangePassword.StateTracking.Back.Color2 = Color.Silver;
            btnSettingsChangePassword.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsChangePassword.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsChangePassword.StateTracking.Border.Color1 = Color.Gainsboro;
            btnSettingsChangePassword.StateTracking.Border.Color2 = Color.Gainsboro;
            btnSettingsChangePassword.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsChangePassword.StateTracking.Border.Rounding = 50F;
            btnSettingsChangePassword.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsChangePassword.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnSettingsChangePassword.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnSettingsChangePassword.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnSettingsChangePassword.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsChangePassword.TabIndex = 206;
            btnSettingsChangePassword.Values.DropDownArrowColor = Color.Empty;
            btnSettingsChangePassword.Values.Text = "Change Current User Password";
            // 
            // btnSettingsSignOut
            // 
            btnSettingsSignOut.Cursor = Cursors.Hand;
            btnSettingsSignOut.Location = new Point(435, 570);
            btnSettingsSignOut.Name = "btnSettingsSignOut";
            btnSettingsSignOut.OverrideDefault.Back.Color1 = Color.Silver;
            btnSettingsSignOut.OverrideDefault.Border.Rounding = 50F;
            btnSettingsSignOut.OverrideFocus.Back.Color1 = Color.Silver;
            btnSettingsSignOut.OverrideFocus.Border.Rounding = 50F;
            btnSettingsSignOut.Size = new Size(596, 360);
            btnSettingsSignOut.StateDisabled.Back.Color1 = Color.Silver;
            btnSettingsSignOut.StateDisabled.Border.Rounding = 50F;
            btnSettingsSignOut.StateNormal.Back.Color1 = Color.Silver;
            btnSettingsSignOut.StateNormal.Back.Color2 = Color.Silver;
            btnSettingsSignOut.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsSignOut.StateNormal.Border.Rounding = 50F;
            btnSettingsSignOut.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnSettingsSignOut.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsSignOut.StatePressed.Back.Color1 = Color.Silver;
            btnSettingsSignOut.StatePressed.Back.Color2 = Color.Silver;
            btnSettingsSignOut.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsSignOut.StatePressed.Border.Color1 = Color.Gainsboro;
            btnSettingsSignOut.StatePressed.Border.Color2 = Color.Gainsboro;
            btnSettingsSignOut.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsSignOut.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsSignOut.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsSignOut.StatePressed.Border.Rounding = 50F;
            btnSettingsSignOut.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnSettingsSignOut.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsSignOut.StateTracking.Back.Color1 = Color.Silver;
            btnSettingsSignOut.StateTracking.Back.Color2 = Color.Silver;
            btnSettingsSignOut.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsSignOut.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSettingsSignOut.StateTracking.Border.Color1 = Color.Gainsboro;
            btnSettingsSignOut.StateTracking.Border.Color2 = Color.Gainsboro;
            btnSettingsSignOut.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSettingsSignOut.StateTracking.Border.Rounding = 50F;
            btnSettingsSignOut.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnSettingsSignOut.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnSettingsSignOut.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnSettingsSignOut.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnSettingsSignOut.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettingsSignOut.TabIndex = 207;
            btnSettingsSignOut.Values.DropDownArrowColor = Color.Empty;
            btnSettingsSignOut.Values.Text = "Sign Out Of Current User Account";
            btnSettingsSignOut.Click += SettingsSignOut_Click;
            // 
            // lbSettingsTitle
            // 
            lbSettingsTitle.AutoSize = false;
            lbSettingsTitle.Location = new Point(556, -6);
            lbSettingsTitle.Name = "lbSettingsTitle";
            lbSettingsTitle.Size = new Size(347, 107);
            lbSettingsTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbSettingsTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSettingsTitle.TabIndex = 208;
            lbSettingsTitle.TabStop = false;
            lbSettingsTitle.Values.Text = "Account Settings";
            // 
            // frmAccountSettings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1548, 1028);
            Controls.Add(lbSettingsTitle);
            Controls.Add(btnSettingsSignOut);
            Controls.Add(btnSettingsChangePassword);
            Controls.Add(btnSettingsCurrentUserInfo);
            Controls.Add(pbSettingsCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAccountSettings";
            Text = "frmAccountSettings";
            Load += frmAccountSettings_Load;
            ((System.ComponentModel.ISupportInitialize)pbSettingsCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox pbSettingsCancel;
        private Krypton.Toolkit.KryptonButton btnSettingsCurrentUserInfo;
        private Krypton.Toolkit.KryptonButton btnSettingsChangePassword;
        private Krypton.Toolkit.KryptonButton btnSettingsSignOut;
        private Krypton.Toolkit.KryptonLabel lbSettingsTitle;
        private ToolTip toolTip1;
    }
}