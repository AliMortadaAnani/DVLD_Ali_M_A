namespace DVLD_Presentation
{
    partial class frmInternationalLicensesAdd
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
            ctrlLicenseInfo1 = new ctrlLicenseInfo();
            ctrlApplicationShow1 = new ctrlApplicationShow();
            btnIntIssue = new Krypton.Toolkit.KryptonButton();
            btnlicenseinfo = new Krypton.Toolkit.KryptonButton();
            btnhistory = new Krypton.Toolkit.KryptonButton();
            ctrlLicenseSearch1 = new ctrlLicenseSearch();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // btnGeneralCancel
            // 
            toolTipCancel.SetToolTip(btnGeneralCancel, "Close");
            btnGeneralCancel.Click += btnGeneralCancel_Click_1;
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Title";
            // 
            // ctrlLicenseInfo1
            // 
            ctrlLicenseInfo1._LicenseID = 0;
            ctrlLicenseInfo1.BackColor = Color.Lavender;
            ctrlLicenseInfo1.Location = new Point(12, 273);
            ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            ctrlLicenseInfo1.Size = new Size(1546, 483);
            ctrlLicenseInfo1.TabIndex = 212;
            ctrlLicenseInfo1.TabStop = false;
            // 
            // ctrlApplicationShow1
            // 
            ctrlApplicationShow1._ApplicationID = 0;
            ctrlApplicationShow1.BackColor = Color.Lavender;
            ctrlApplicationShow1.Location = new Point(12, 762);
            ctrlApplicationShow1.Name = "ctrlApplicationShow1";
            ctrlApplicationShow1.Size = new Size(1546, 321);
            ctrlApplicationShow1.TabIndex = 213;
            // 
            // btnIntIssue
            // 
            btnIntIssue.Location = new Point(1073, 136);
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
            btnIntIssue.TabIndex = 235;
            btnIntIssue.Values.DropDownArrowColor = Color.Empty;
            btnIntIssue.Values.Text = "Issue New International Driving License";
            btnIntIssue.Click += btnIntIssue_Click;
            // 
            // btnlicenseinfo
            // 
            btnlicenseinfo.Location = new Point(503, 204);
            btnlicenseinfo.Name = "btnlicenseinfo";
            btnlicenseinfo.OverrideDefault.Back.Color1 = Color.Silver;
            btnlicenseinfo.OverrideDefault.Border.Rounding = 50F;
            btnlicenseinfo.OverrideFocus.Back.Color1 = Color.Silver;
            btnlicenseinfo.OverrideFocus.Border.Rounding = 50F;
            btnlicenseinfo.Size = new Size(485, 63);
            btnlicenseinfo.StateDisabled.Back.Color1 = Color.Silver;
            btnlicenseinfo.StateDisabled.Border.Rounding = 50F;
            btnlicenseinfo.StateNormal.Back.Color1 = Color.Silver;
            btnlicenseinfo.StateNormal.Back.Color2 = Color.Silver;
            btnlicenseinfo.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnlicenseinfo.StateNormal.Border.Rounding = 50F;
            btnlicenseinfo.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnlicenseinfo.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlicenseinfo.StatePressed.Back.Color1 = Color.Silver;
            btnlicenseinfo.StatePressed.Back.Color2 = Color.Silver;
            btnlicenseinfo.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnlicenseinfo.StatePressed.Border.Color1 = Color.Gainsboro;
            btnlicenseinfo.StatePressed.Border.Color2 = Color.Gainsboro;
            btnlicenseinfo.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnlicenseinfo.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnlicenseinfo.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnlicenseinfo.StatePressed.Border.Rounding = 50F;
            btnlicenseinfo.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnlicenseinfo.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlicenseinfo.StateTracking.Back.Color1 = Color.Silver;
            btnlicenseinfo.StateTracking.Back.Color2 = Color.Silver;
            btnlicenseinfo.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnlicenseinfo.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnlicenseinfo.StateTracking.Border.Color1 = Color.Gainsboro;
            btnlicenseinfo.StateTracking.Border.Color2 = Color.Gainsboro;
            btnlicenseinfo.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnlicenseinfo.StateTracking.Border.Rounding = 50F;
            btnlicenseinfo.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnlicenseinfo.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnlicenseinfo.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnlicenseinfo.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnlicenseinfo.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlicenseinfo.TabIndex = 236;
            btnlicenseinfo.Values.DropDownArrowColor = Color.Empty;
            btnlicenseinfo.Values.Text = "Show International License Info";
            btnlicenseinfo.Click += btnlicenseinfo_Click;
            // 
            // btnhistory
            // 
            btnhistory.Location = new Point(12, 204);
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
            btnhistory.TabIndex = 237;
            btnhistory.Values.DropDownArrowColor = Color.Empty;
            btnhistory.Values.Text = "Show License History";
            btnhistory.Click += btnhistory_Click;
            // 
            // ctrlLicenseSearch1
            // 
            ctrlLicenseSearch1.BackColor = Color.Lavender;
            ctrlLicenseSearch1.Location = new Point(12, 136);
            ctrlLicenseSearch1.Name = "ctrlLicenseSearch1";
            ctrlLicenseSearch1.Size = new Size(672, 61);
            ctrlLicenseSearch1.TabIndex = 238;
            ctrlLicenseSearch1.OnLicenseSearchComplete += ctrlLicenseSearch1_OnLicenseSearchComplete;
            ctrlLicenseSearch1.OnLicenseSearchFail += ctrlLicenseSearch1_OnLicenseSearchFail;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 239;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmInternationalLicensesAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(ctrlLicenseSearch1);
            Controls.Add(btnhistory);
            Controls.Add(btnlicenseinfo);
            Controls.Add(btnIntIssue);
            Controls.Add(ctrlApplicationShow1);
            Controls.Add(ctrlLicenseInfo1);
            Name = "frmInternationalLicensesAdd";
            StartPosition = FormStartPosition.Manual;
            Text = "frmInternationalLicensesAdd";
            Load += frmInternationalLicensesAdd_Load;
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(ctrlLicenseInfo1, 0);
            Controls.SetChildIndex(ctrlApplicationShow1, 0);
            Controls.SetChildIndex(btnIntIssue, 0);
            Controls.SetChildIndex(btnlicenseinfo, 0);
            Controls.SetChildIndex(btnhistory, 0);
            Controls.SetChildIndex(ctrlLicenseSearch1, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlLicenseInfo ctrlLicenseInfo1;
        private ctrlApplicationShow ctrlApplicationShow1;
        private Krypton.Toolkit.KryptonButton btnIntIssue;
        private Krypton.Toolkit.KryptonButton btnlicenseinfo;
        private Krypton.Toolkit.KryptonButton btnhistory;
        private ctrlLicenseSearch ctrlLicenseSearch1;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}