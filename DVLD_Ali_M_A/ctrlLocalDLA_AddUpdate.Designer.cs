namespace DVLD_Presentation
{
    partial class ctrlLocalDLA_AddUpdate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLocalSave = new Krypton.Toolkit.KryptonButton();
            lbldate = new Krypton.Toolkit.KryptonLabel();
            lbllicense = new Krypton.Toolkit.KryptonLabel();
            lblfees = new Krypton.Toolkit.KryptonLabel();
            lbluser = new Krypton.Toolkit.KryptonLabel();
            lblid = new Krypton.Toolkit.KryptonLabel();
            lblidtxt = new Krypton.Toolkit.KryptonLabel();
            lbldatetxt = new Krypton.Toolkit.KryptonLabel();
            lblfeestxt = new Krypton.Toolkit.KryptonLabel();
            lblusertxt = new Krypton.Toolkit.KryptonLabel();
            cbLicenses = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)cbLicenses).BeginInit();
            SuspendLayout();
            // 
            // btnUserSave
            // 
            btnLocalSave.Location = new Point(708, 476);
            btnLocalSave.Name = "btnUserSave";
            btnLocalSave.OverrideDefault.Back.Color1 = Color.Silver;
            btnLocalSave.OverrideDefault.Border.Rounding = 50F;
            btnLocalSave.OverrideFocus.Back.Color1 = Color.Silver;
            btnLocalSave.OverrideFocus.Border.Rounding = 50F;
            btnLocalSave.Size = new Size(187, 69);
            btnLocalSave.StateDisabled.Back.Color1 = Color.Silver;
            btnLocalSave.StateDisabled.Border.Rounding = 50F;
            btnLocalSave.StateNormal.Back.Color1 = Color.Silver;
            btnLocalSave.StateNormal.Back.Color2 = Color.Silver;
            btnLocalSave.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalSave.StateNormal.Border.Rounding = 50F;
            btnLocalSave.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnLocalSave.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalSave.StatePressed.Back.Color1 = Color.Silver;
            btnLocalSave.StatePressed.Back.Color2 = Color.Silver;
            btnLocalSave.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalSave.StatePressed.Border.Color1 = Color.Gainsboro;
            btnLocalSave.StatePressed.Border.Color2 = Color.Gainsboro;
            btnLocalSave.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalSave.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalSave.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalSave.StatePressed.Border.Rounding = 50F;
            btnLocalSave.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnLocalSave.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalSave.StateTracking.Back.Color1 = Color.Silver;
            btnLocalSave.StateTracking.Back.Color2 = Color.Silver;
            btnLocalSave.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalSave.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalSave.StateTracking.Border.Color1 = Color.Gainsboro;
            btnLocalSave.StateTracking.Border.Color2 = Color.Gainsboro;
            btnLocalSave.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalSave.StateTracking.Border.Rounding = 50F;
            btnLocalSave.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalSave.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnLocalSave.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnLocalSave.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnLocalSave.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalSave.TabIndex = 221;
            btnLocalSave.Values.DropDownArrowColor = Color.Empty;
            btnLocalSave.Values.Text = "Save";
            btnLocalSave.Click += btnLocalSave_Click;
            // 
            // lbldate
            // 
            lbldate.AutoSize = false;
            lbldate.Location = new Point(15, 103);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(231, 47);
            lbldate.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbldate.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldate.TabIndex = 222;
            lbldate.TabStop = false;
            lbldate.Values.Text = "Application Date:";
            // 
            // lbllicense
            // 
            lbllicense.AutoSize = false;
            lbllicense.Location = new Point(50, 184);
            lbllicense.Name = "lbllicense";
            lbllicense.Size = new Size(196, 47);
            lbllicense.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbllicense.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllicense.TabIndex = 223;
            lbllicense.TabStop = false;
            lbllicense.Values.Text = "License Class:";
            // 
            // lblfees
            // 
            lblfees.AutoSize = false;
            lblfees.Location = new Point(15, 279);
            lblfees.Name = "lblfees";
            lblfees.Size = new Size(231, 47);
            lblfees.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblfees.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfees.TabIndex = 224;
            lblfees.TabStop = false;
            lblfees.Values.Text = "Application Fees:";
            // 
            // lbluser
            // 
            lbluser.AutoSize = false;
            lbluser.Location = new Point(37, 367);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(209, 47);
            lbluser.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbluser.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluser.TabIndex = 225;
            lbluser.TabStop = false;
            lbluser.Values.Text = "Create By User:";
            // 
            // lblid
            // 
            lblid.AutoSize = false;
            lblid.Enabled = false;
            lblid.Location = new Point(71, 15);
            lblid.Name = "lblid";
            lblid.Size = new Size(175, 47);
            lblid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.TabIndex = 226;
            lblid.TabStop = false;
            lblid.Values.Text = "Local DLA ID:";
            // 
            // lblidtxt
            // 
            lblidtxt.AutoSize = false;
            lblidtxt.Location = new Point(238, 15);
            lblidtxt.Name = "lblidtxt";
            lblidtxt.Size = new Size(175, 47);
            lblidtxt.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblidtxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidtxt.TabIndex = 227;
            lblidtxt.TabStop = false;
            lblidtxt.Values.Text = "";
            lblidtxt.Visible = false;
            // 
            // lbldatetxt
            // 
            lbldatetxt.AutoSize = false;
            lbldatetxt.Location = new Point(238, 103);
            lbldatetxt.Name = "lbldatetxt";
            lbldatetxt.Size = new Size(614, 47);
            lbldatetxt.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbldatetxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldatetxt.TabIndex = 228;
            lbldatetxt.TabStop = false;
            lbldatetxt.Values.Text = "";
            // 
            // lblfeestxt
            // 
            lblfeestxt.AutoSize = false;
            lblfeestxt.Location = new Point(238, 279);
            lblfeestxt.Name = "lblfeestxt";
            lblfeestxt.Size = new Size(614, 47);
            lblfeestxt.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblfeestxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfeestxt.TabIndex = 229;
            lblfeestxt.TabStop = false;
            lblfeestxt.Values.Text = "";
            // 
            // lblusertxt
            // 
            lblusertxt.AutoSize = false;
            lblusertxt.Location = new Point(238, 367);
            lblusertxt.Name = "lblusertxt";
            lblusertxt.Size = new Size(628, 47);
            lblusertxt.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblusertxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusertxt.TabIndex = 230;
            lblusertxt.TabStop = false;
            lblusertxt.Values.Text = "";
            // 
            // cbLicenses
            // 
            cbLicenses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenses.DropDownWidth = 175;
            cbLicenses.Location = new Point(223, 191);
            cbLicenses.MaxDropDownItems = 12;
            cbLicenses.Name = "cbLicenses";
            cbLicenses.Size = new Size(643, 33);
            cbLicenses.StateCommon.ComboBox.Back.Color1 = Color.Gainsboro;
            cbLicenses.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbLicenses.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLicenses.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbLicenses.StateDisabled.ComboBox.Content.Color1 = Color.Black;
            cbLicenses.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLicenses.TabIndex = 231;
            // 
            // ctrlLocalDLA_AddUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(cbLicenses);
            Controls.Add(lblusertxt);
            Controls.Add(lblfeestxt);
            Controls.Add(lbldatetxt);
            Controls.Add(lblidtxt);
            Controls.Add(lblid);
            Controls.Add(lbluser);
            Controls.Add(lblfees);
            Controls.Add(lbllicense);
            Controls.Add(btnLocalSave);
            Controls.Add(lbldate);
            Name = "ctrlLocalDLA_AddUpdate";
            Size = new Size(922, 596);
            Load += ctrlLocalDLA_AddUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)cbLicenses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnLocalSave;
        private Krypton.Toolkit.KryptonLabel lbldate;
        private Krypton.Toolkit.KryptonLabel lbllicense;
        private Krypton.Toolkit.KryptonLabel lblfees;
        private Krypton.Toolkit.KryptonLabel lbluser;
        private Krypton.Toolkit.KryptonLabel lblid;
        private Krypton.Toolkit.KryptonLabel lblidtxt;
        private Krypton.Toolkit.KryptonLabel lbldatetxt;
        private Krypton.Toolkit.KryptonLabel lblfeestxt;
        private Krypton.Toolkit.KryptonLabel lblusertxt;
        private Krypton.Toolkit.KryptonComboBox cbLicenses;
    }
}
