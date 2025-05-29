namespace DVLD_Presentation
{
    partial class frmRenewLicense
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
            ctrlLicenseRenew1 = new ctrlLicenseRenew();
            ctrlLicenseInfo1 = new ctrlLicenseInfo();
            ctrlApplicationShow1 = new ctrlApplicationShow();
            btnhistory = new Krypton.Toolkit.KryptonButton();
            btnlicenseinfo = new Krypton.Toolkit.KryptonButton();
            btnIntIssue = new Krypton.Toolkit.KryptonButton();
            tbnotes = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            Renewlicenseidtxt = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            lblLicensefeestxt = new Krypton.Toolkit.KryptonLabel();
            lbladdress = new Krypton.Toolkit.KryptonLabel();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // btnGeneralCancel
            // 
            toolTipCancel.SetToolTip(btnGeneralCancel, "Close");
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Title";
            // 
            // ctrlLicenseRenew1
            // 
            ctrlLicenseRenew1.BackColor = Color.Lavender;
            ctrlLicenseRenew1.Location = new Point(12, 135);
            ctrlLicenseRenew1.Name = "ctrlLicenseRenew1";
            ctrlLicenseRenew1.Size = new Size(733, 62);
            ctrlLicenseRenew1.TabIndex = 1;
            ctrlLicenseRenew1.OnLicenseSearchComplete += ctrlLicenseRenew1_OnLicenseSearchComplete;
            ctrlLicenseRenew1.OnLicenseSearchFail += ctrlLicenseRenew1_OnLicenseSearchFail;
            // 
            // ctrlLicenseInfo1
            // 
            ctrlLicenseInfo1._LicenseID = 0;
            ctrlLicenseInfo1.BackColor = Color.Lavender;
            ctrlLicenseInfo1.Location = new Point(9, 272);
            ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            ctrlLicenseInfo1.Size = new Size(1546, 476);
            ctrlLicenseInfo1.TabIndex = 213;
            // 
            // ctrlApplicationShow1
            // 
            ctrlApplicationShow1._ApplicationID = 0;
            ctrlApplicationShow1.BackColor = Color.Lavender;
            ctrlApplicationShow1.Location = new Point(9, 732);
            ctrlApplicationShow1.Name = "ctrlApplicationShow1";
            ctrlApplicationShow1.Size = new Size(1538, 300);
            ctrlApplicationShow1.TabIndex = 214;
            // 
            // btnhistory
            // 
            btnhistory.Location = new Point(757, 203);
            btnhistory.Name = "btnhistory";
            btnhistory.OverrideDefault.Back.Color1 = Color.Silver;
            btnhistory.OverrideDefault.Border.Rounding = 50F;
            btnhistory.OverrideFocus.Back.Color1 = Color.Silver;
            btnhistory.OverrideFocus.Border.Rounding = 50F;
            btnhistory.Size = new Size(303, 63);
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
            btnhistory.TabIndex = 3;
            btnhistory.Values.DropDownArrowColor = Color.Empty;
            btnhistory.Values.Text = "Show License History";
            btnhistory.Click += btnhistory_Click;
            // 
            // btnlicenseinfo
            // 
            btnlicenseinfo.Location = new Point(1065, 203);
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
            btnlicenseinfo.TabIndex = 5;
            btnlicenseinfo.Values.DropDownArrowColor = Color.Empty;
            btnlicenseinfo.Values.Text = "Show Renewed License Info";
            btnlicenseinfo.Click += btnlicenseinfo_Click;
            // 
            // btnIntIssue
            // 
            btnIntIssue.Location = new Point(1065, 134);
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
            btnIntIssue.TabIndex = 4;
            btnIntIssue.Values.DropDownArrowColor = Color.Empty;
            btnIntIssue.Values.Text = "Renew Local Driving License";
            btnIntIssue.Click += btnIntIssue_Click;
            // 
            // tbnotes
            // 
            tbnotes.Location = new Point(106, 1033);
            tbnotes.Name = "tbnotes";
            tbnotes.Size = new Size(1010, 52);
            tbnotes.StateActive.Back.Color1 = Color.LightGray;
            tbnotes.StateActive.Border.Rounding = 30F;
            tbnotes.StateActive.Content.Color1 = Color.Black;
            tbnotes.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.StateCommon.Back.Color1 = Color.White;
            tbnotes.StateCommon.Border.Rounding = 30F;
            tbnotes.StateCommon.Content.Color1 = Color.Black;
            tbnotes.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbnotes.StateDisabled.Border.Rounding = 30F;
            tbnotes.StateDisabled.Content.Color1 = Color.Black;
            tbnotes.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbnotes.StateNormal.Border.Rounding = 30F;
            tbnotes.StateNormal.Content.Color1 = Color.Black;
            tbnotes.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.AutoSize = false;
            kryptonLabel3.Location = new Point(17, 1033);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(158, 47);
            kryptonLabel3.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel3.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 285;
            kryptonLabel3.TabStop = false;
            kryptonLabel3.Values.Text = "Notes:";
            // 
            // Renewlicenseidtxt
            // 
            Renewlicenseidtxt.AutoSize = false;
            Renewlicenseidtxt.Location = new Point(250, 219);
            Renewlicenseidtxt.Name = "Renewlicenseidtxt";
            Renewlicenseidtxt.Size = new Size(193, 47);
            Renewlicenseidtxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            Renewlicenseidtxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Renewlicenseidtxt.TabIndex = 287;
            Renewlicenseidtxt.TabStop = false;
            Renewlicenseidtxt.Values.Text = "";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.AutoSize = false;
            kryptonLabel4.Location = new Point(9, 219);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(260, 47);
            kryptonLabel4.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel4.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 286;
            kryptonLabel4.TabStop = false;
            kryptonLabel4.Values.Text = "Renewed License ID:";
            // 
            // lblLicensefeestxt
            // 
            lblLicensefeestxt.AutoSize = false;
            lblLicensefeestxt.Location = new Point(593, 219);
            lblLicensefeestxt.Name = "lblLicensefeestxt";
            lblLicensefeestxt.Size = new Size(152, 47);
            lblLicensefeestxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblLicensefeestxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicensefeestxt.TabIndex = 289;
            lblLicensefeestxt.TabStop = false;
            lblLicensefeestxt.Values.Text = "";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = false;
            lbladdress.Location = new Point(510, 219);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(77, 47);
            lbladdress.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbladdress.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladdress.TabIndex = 288;
            lbladdress.TabStop = false;
            lbladdress.Values.Text = "Fees:";
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 290;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmRenewLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(lblLicensefeestxt);
            Controls.Add(lbladdress);
            Controls.Add(Renewlicenseidtxt);
            Controls.Add(kryptonLabel4);
            Controls.Add(tbnotes);
            Controls.Add(kryptonLabel3);
            Controls.Add(btnhistory);
            Controls.Add(btnlicenseinfo);
            Controls.Add(btnIntIssue);
            Controls.Add(ctrlApplicationShow1);
            Controls.Add(ctrlLicenseInfo1);
            Controls.Add(ctrlLicenseRenew1);
            Name = "frmRenewLicense";
            StartPosition = FormStartPosition.Manual;
            Text = "frmRenewLicense";
            Controls.SetChildIndex(ctrlLicenseRenew1, 0);
            Controls.SetChildIndex(ctrlLicenseInfo1, 0);
            Controls.SetChildIndex(ctrlApplicationShow1, 0);
            Controls.SetChildIndex(btnIntIssue, 0);
            Controls.SetChildIndex(btnlicenseinfo, 0);
            Controls.SetChildIndex(btnhistory, 0);
            Controls.SetChildIndex(kryptonLabel3, 0);
            Controls.SetChildIndex(tbnotes, 0);
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(kryptonLabel4, 0);
            Controls.SetChildIndex(Renewlicenseidtxt, 0);
            Controls.SetChildIndex(lbladdress, 0);
            Controls.SetChildIndex(lblLicensefeestxt, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlLicenseRenew ctrlLicenseRenew1;
        private ctrlLicenseInfo ctrlLicenseInfo1;
        private ctrlApplicationShow ctrlApplicationShow1;
        private Krypton.Toolkit.KryptonButton btnhistory;
        private Krypton.Toolkit.KryptonButton btnlicenseinfo;
        private Krypton.Toolkit.KryptonButton btnIntIssue;
        private Krypton.Toolkit.KryptonTextBox tbnotes;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel Renewlicenseidtxt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        public Krypton.Toolkit.KryptonLabel lblLicensefeestxt;
        public Krypton.Toolkit.KryptonLabel lbladdress;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}