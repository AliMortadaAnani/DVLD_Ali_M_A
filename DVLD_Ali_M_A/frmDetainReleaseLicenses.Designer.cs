namespace DVLD_Presentation
{
    partial class frmDetainReleaseLicenses
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
            btnhistory = new Krypton.Toolkit.KryptonButton();
            btnIntIssue = new Krypton.Toolkit.KryptonButton();
            ctrlLicenseInfo1 = new ctrlLicenseInfo();
            ctrlLicenseDetain1 = new ctrlLicenseDetain();
            ctrlDetainReleaseInfo1 = new ctrlDetainReleaseInfo();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            SuspendLayout();
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Title";
            // 
            // btnhistory
            // 
            btnhistory.Location = new Point(1068, 209);
            btnhistory.Name = "btnhistory";
            btnhistory.OverrideDefault.Back.Color1 = Color.Silver;
            btnhistory.OverrideDefault.Border.Rounding = 50F;
            btnhistory.OverrideFocus.Back.Color1 = Color.Silver;
            btnhistory.OverrideFocus.Border.Rounding = 50F;
            btnhistory.Size = new Size(485, 63);
            btnhistory.StateDisabled.Back.Color1 = Color.Silver;
            btnhistory.StateDisabled.Border.Rounding = 50F;
            btnhistory.StateNormal.Back.Color1 = Color.Silver;
            btnhistory.StateNormal.Back.Color2 = Color.Silver;
            btnhistory.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnhistory.StateNormal.Border.Rounding = 50F;
            btnhistory.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnhistory.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhistory.StatePressed.Back.Color1 = Color.Silver;
            btnhistory.StatePressed.Back.Color2 = Color.Silver;
            btnhistory.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnhistory.StatePressed.Border.Color1 = Color.Gainsboro;
            btnhistory.StatePressed.Border.Color2 = Color.Gainsboro;
            btnhistory.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnhistory.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnhistory.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnhistory.StatePressed.Border.Rounding = 50F;
            btnhistory.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnhistory.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhistory.StateTracking.Back.Color1 = Color.Silver;
            btnhistory.StateTracking.Back.Color2 = Color.Silver;
            btnhistory.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnhistory.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnhistory.StateTracking.Border.Color1 = Color.Gainsboro;
            btnhistory.StateTracking.Border.Color2 = Color.Gainsboro;
            btnhistory.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnhistory.StateTracking.Border.Rounding = 50F;
            btnhistory.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnhistory.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnhistory.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnhistory.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnhistory.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnhistory.TabIndex = 214;
            btnhistory.Values.DropDownArrowColor = Color.Empty;
            btnhistory.Values.Text = "Show License History";
            btnhistory.Click += btnhistory_Click;
            // 
            // btnIntIssue
            // 
            btnIntIssue.Location = new Point(1068, 140);
            btnIntIssue.Name = "btnIntIssue";
            btnIntIssue.OverrideDefault.Back.Color1 = Color.Silver;
            btnIntIssue.OverrideDefault.Border.Rounding = 50F;
            btnIntIssue.OverrideFocus.Back.Color1 = Color.Silver;
            btnIntIssue.OverrideFocus.Border.Rounding = 50F;
            btnIntIssue.Size = new Size(485, 63);
            btnIntIssue.StateDisabled.Back.Color1 = Color.Silver;
            btnIntIssue.StateDisabled.Border.Rounding = 50F;
            btnIntIssue.StateNormal.Back.Color1 = Color.Silver;
            btnIntIssue.StateNormal.Back.Color2 = Color.Silver;
            btnIntIssue.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnIntIssue.StateNormal.Border.Rounding = 50F;
            btnIntIssue.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnIntIssue.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntIssue.StatePressed.Back.Color1 = Color.Silver;
            btnIntIssue.StatePressed.Back.Color2 = Color.Silver;
            btnIntIssue.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnIntIssue.StatePressed.Border.Color1 = Color.Gainsboro;
            btnIntIssue.StatePressed.Border.Color2 = Color.Gainsboro;
            btnIntIssue.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnIntIssue.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnIntIssue.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnIntIssue.StatePressed.Border.Rounding = 50F;
            btnIntIssue.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnIntIssue.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntIssue.StateTracking.Back.Color1 = Color.Silver;
            btnIntIssue.StateTracking.Back.Color2 = Color.Silver;
            btnIntIssue.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnIntIssue.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnIntIssue.StateTracking.Border.Color1 = Color.Gainsboro;
            btnIntIssue.StateTracking.Border.Color2 = Color.Gainsboro;
            btnIntIssue.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnIntIssue.StateTracking.Border.Rounding = 50F;
            btnIntIssue.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnIntIssue.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnIntIssue.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnIntIssue.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnIntIssue.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntIssue.TabIndex = 215;
            btnIntIssue.Values.DropDownArrowColor = Color.Empty;
            btnIntIssue.Values.Text = "Detain Local Driving License";
            btnIntIssue.Click += btnIntIssue_Click;
            // 
            // ctrlLicenseInfo1
            // 
            ctrlLicenseInfo1._LicenseID = 0;
            ctrlLicenseInfo1.BackColor = Color.Lavender;
            ctrlLicenseInfo1.Location = new Point(12, 278);
            ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            ctrlLicenseInfo1.Size = new Size(1546, 476);
            ctrlLicenseInfo1.TabIndex = 217;
            // 
            // ctrlLicenseDetain1
            // 
            ctrlLicenseDetain1.BackColor = Color.Lavender;
            ctrlLicenseDetain1.Location = new Point(12, 140);
            ctrlLicenseDetain1.Name = "ctrlLicenseDetain1";
            ctrlLicenseDetain1.Size = new Size(694, 59);
            ctrlLicenseDetain1.TabIndex = 218;
            ctrlLicenseDetain1.OnLicenseSearchComplete += ctrlLicenseDetain1_OnLicenseSearchComplete;
            ctrlLicenseDetain1.OnLicenseSearchFail += ctrlLicenseDetain1_OnLicenseSearchFail;
            // 
            // ctrlDetainReleaseInfo1
            // 
            ctrlDetainReleaseInfo1.BackColor = Color.Lavender;
            ctrlDetainReleaseInfo1.DetainID = 0;
            ctrlDetainReleaseInfo1.LicenseID = 0;
            ctrlDetainReleaseInfo1.Location = new Point(12, 760);
            ctrlDetainReleaseInfo1.Mode = DVLD_General.enLicenseMode.Detain;
            ctrlDetainReleaseInfo1.Name = "ctrlDetainReleaseInfo1";
            ctrlDetainReleaseInfo1.Size = new Size(1546, 320);
            ctrlDetainReleaseInfo1.TabIndex = 219;
            // 
            // frmDetainReleaseLicenses
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(ctrlDetainReleaseInfo1);
            Controls.Add(ctrlLicenseDetain1);
            Controls.Add(btnhistory);
            Controls.Add(btnIntIssue);
            Controls.Add(ctrlLicenseInfo1);
            Name = "frmDetainReleaseLicenses";
            StartPosition = FormStartPosition.Manual;
            Text = "frmDetainReleaseLicenses";
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(ctrlLicenseInfo1, 0);
            Controls.SetChildIndex(btnIntIssue, 0);
            Controls.SetChildIndex(btnhistory, 0);
            Controls.SetChildIndex(ctrlLicenseDetain1, 0);
            Controls.SetChildIndex(ctrlDetainReleaseInfo1, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnhistory;
        private Krypton.Toolkit.KryptonButton btnIntIssue;
        private ctrlLicenseInfo ctrlLicenseInfo1;
        private ctrlLicenseDetain ctrlLicenseDetain1;
        private ctrlDetainReleaseInfo ctrlDetainReleaseInfo1;
    }
}