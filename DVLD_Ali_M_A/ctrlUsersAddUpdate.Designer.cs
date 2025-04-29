namespace DVLD_Presentation
{
    partial class ctrlUsersAddUpdate
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
            components = new System.ComponentModel.Container();
            lblid = new Krypton.Toolkit.KryptonLabel();
            lblusername = new Krypton.Toolkit.KryptonLabel();
            lblpasswordconfirm = new Krypton.Toolkit.KryptonLabel();
            lblpassword = new Krypton.Toolkit.KryptonLabel();
            lblstatus = new Krypton.Toolkit.KryptonLabel();
            tbpassword = new Krypton.Toolkit.KryptonTextBox();
            tbusername = new Krypton.Toolkit.KryptonTextBox();
            tbpasswordconfirm = new Krypton.Toolkit.KryptonTextBox();
            cbisactive = new Krypton.Toolkit.KryptonCheckBox();
            lbluserid = new Krypton.Toolkit.KryptonLabel();
            btnUserSave = new Krypton.Toolkit.KryptonButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = false;
            lblid.Enabled = false;
            lblid.Location = new Point(15, 18);
            lblid.Name = "lblid";
            lblid.Size = new Size(158, 47);
            lblid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.TabIndex = 219;
            lblid.TabStop = false;
            lblid.Values.Text = "User ID:";
            // 
            // lblusername
            // 
            lblusername.AutoSize = false;
            lblusername.Enabled = false;
            lblusername.Location = new Point(15, 100);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(158, 47);
            lblusername.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblusername.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.TabIndex = 220;
            lblusername.TabStop = false;
            lblusername.Values.Text = "Username:";
            // 
            // lblpasswordconfirm
            // 
            lblpasswordconfirm.AutoSize = false;
            lblpasswordconfirm.Enabled = false;
            lblpasswordconfirm.Location = new Point(15, 264);
            lblpasswordconfirm.Name = "lblpasswordconfirm";
            lblpasswordconfirm.Size = new Size(230, 47);
            lblpasswordconfirm.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblpasswordconfirm.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpasswordconfirm.TabIndex = 221;
            lblpasswordconfirm.TabStop = false;
            lblpasswordconfirm.Values.Text = "Confirm Password:";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = false;
            lblpassword.Enabled = false;
            lblpassword.Location = new Point(15, 182);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(158, 47);
            lblpassword.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblpassword.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.TabIndex = 222;
            lblpassword.TabStop = false;
            lblpassword.Values.Text = "Password:";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = false;
            lblstatus.Enabled = false;
            lblstatus.Location = new Point(15, 347);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(158, 47);
            lblstatus.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblstatus.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.TabIndex = 223;
            lblstatus.TabStop = false;
            lblstatus.Values.Text = "Status:";
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(266, 182);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(217, 52);
            tbpassword.StateActive.Back.Color1 = Color.LightGray;
            tbpassword.StateActive.Border.Rounding = 30F;
            tbpassword.StateActive.Content.Color1 = Color.Black;
            tbpassword.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.StateCommon.Back.Color1 = Color.White;
            tbpassword.StateCommon.Border.Rounding = 30F;
            tbpassword.StateCommon.Content.Color1 = Color.Black;
            tbpassword.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbpassword.StateDisabled.Border.Rounding = 30F;
            tbpassword.StateDisabled.Content.Color1 = Color.Black;
            tbpassword.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbpassword.StateNormal.Border.Rounding = 30F;
            tbpassword.StateNormal.Content.Color1 = Color.Black;
            tbpassword.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpassword.TabIndex = 224;
            tbpassword.TextChanged += tbpassword_TextChanged;
            tbpassword.Validating += tbpassword_Validating;
            // 
            // tbusername
            // 
            tbusername.Location = new Point(266, 100);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(217, 52);
            tbusername.StateActive.Back.Color1 = Color.LightGray;
            tbusername.StateActive.Border.Rounding = 30F;
            tbusername.StateActive.Content.Color1 = Color.Black;
            tbusername.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.StateCommon.Back.Color1 = Color.White;
            tbusername.StateCommon.Border.Rounding = 30F;
            tbusername.StateCommon.Content.Color1 = Color.Black;
            tbusername.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbusername.StateDisabled.Border.Rounding = 30F;
            tbusername.StateDisabled.Content.Color1 = Color.Black;
            tbusername.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbusername.StateNormal.Border.Rounding = 30F;
            tbusername.StateNormal.Content.Color1 = Color.Black;
            tbusername.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbusername.TabIndex = 225;
            tbusername.Validating += tbusername_Validating;
            // 
            // tbpasswordconfirm
            // 
            tbpasswordconfirm.Location = new Point(266, 264);
            tbpasswordconfirm.Name = "tbpasswordconfirm";
            tbpasswordconfirm.Size = new Size(217, 52);
            tbpasswordconfirm.StateActive.Back.Color1 = Color.LightGray;
            tbpasswordconfirm.StateActive.Border.Rounding = 30F;
            tbpasswordconfirm.StateActive.Content.Color1 = Color.Black;
            tbpasswordconfirm.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpasswordconfirm.StateCommon.Back.Color1 = Color.White;
            tbpasswordconfirm.StateCommon.Border.Rounding = 30F;
            tbpasswordconfirm.StateCommon.Content.Color1 = Color.Black;
            tbpasswordconfirm.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpasswordconfirm.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbpasswordconfirm.StateDisabled.Border.Rounding = 30F;
            tbpasswordconfirm.StateDisabled.Content.Color1 = Color.Black;
            tbpasswordconfirm.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpasswordconfirm.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbpasswordconfirm.StateNormal.Border.Rounding = 30F;
            tbpasswordconfirm.StateNormal.Content.Color1 = Color.Black;
            tbpasswordconfirm.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbpasswordconfirm.TabIndex = 227;
            tbpasswordconfirm.TextChanged += tbpasswordconfirm_TextChanged;
            tbpasswordconfirm.Validating += tbpasswordconfirm_Validating;
            // 
            // cbisactive
            // 
            cbisactive.AutoSize = false;
            cbisactive.Cursor = Cursors.Hand;
            cbisactive.Location = new Point(266, 352);
            cbisactive.Name = "cbisactive";
            cbisactive.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueLightMode;
            cbisactive.Size = new Size(217, 42);
            cbisactive.StateNormal.ShortText.Color1 = Color.DimGray;
            cbisactive.StateNormal.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cbisactive.TabIndex = 228;
            cbisactive.Values.Text = "Active";
            // 
            // lbluserid
            // 
            lbluserid.AutoSize = false;
            lbluserid.Enabled = false;
            lbluserid.Location = new Point(266, 18);
            lbluserid.Name = "lbluserid";
            lbluserid.Size = new Size(158, 47);
            lbluserid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbluserid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserid.TabIndex = 229;
            lbluserid.TabStop = false;
            lbluserid.Values.Text = "-1";
            // 
            // btnUserSave
            // 
            btnUserSave.Location = new Point(402, 424);
            btnUserSave.Name = "btnUserSave";
            btnUserSave.OverrideDefault.Back.Color1 = Color.Silver;
            btnUserSave.OverrideDefault.Border.Rounding = 50F;
            btnUserSave.OverrideFocus.Back.Color1 = Color.Silver;
            btnUserSave.OverrideFocus.Border.Rounding = 50F;
            btnUserSave.Size = new Size(187, 69);
            btnUserSave.StateDisabled.Back.Color1 = Color.Silver;
            btnUserSave.StateDisabled.Border.Rounding = 50F;
            btnUserSave.StateNormal.Back.Color1 = Color.Silver;
            btnUserSave.StateNormal.Back.Color2 = Color.Silver;
            btnUserSave.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserSave.StateNormal.Border.Rounding = 50F;
            btnUserSave.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnUserSave.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserSave.StatePressed.Back.Color1 = Color.Silver;
            btnUserSave.StatePressed.Back.Color2 = Color.Silver;
            btnUserSave.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserSave.StatePressed.Border.Color1 = Color.Gainsboro;
            btnUserSave.StatePressed.Border.Color2 = Color.Gainsboro;
            btnUserSave.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserSave.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserSave.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserSave.StatePressed.Border.Rounding = 50F;
            btnUserSave.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnUserSave.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserSave.StateTracking.Back.Color1 = Color.Silver;
            btnUserSave.StateTracking.Back.Color2 = Color.Silver;
            btnUserSave.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserSave.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserSave.StateTracking.Border.Color1 = Color.Gainsboro;
            btnUserSave.StateTracking.Border.Color2 = Color.Gainsboro;
            btnUserSave.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserSave.StateTracking.Border.Rounding = 50F;
            btnUserSave.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserSave.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnUserSave.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnUserSave.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnUserSave.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserSave.TabIndex = 230;
            btnUserSave.Values.DropDownArrowColor = Color.Empty;
            btnUserSave.Values.Text = "Save";
            btnUserSave.Click += btnUserSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlUsersAddUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(btnUserSave);
            Controls.Add(lbluserid);
            Controls.Add(cbisactive);
            Controls.Add(tbpasswordconfirm);
            Controls.Add(tbusername);
            Controls.Add(tbpassword);
            Controls.Add(lblstatus);
            Controls.Add(lblpassword);
            Controls.Add(lblpasswordconfirm);
            Controls.Add(lblusername);
            Controls.Add(lblid);
            Name = "ctrlUsersAddUpdate";
            Size = new Size(592, 506);
         
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblid;
        private Krypton.Toolkit.KryptonLabel lblusername;
        private Krypton.Toolkit.KryptonLabel lblpasswordconfirm;
        private Krypton.Toolkit.KryptonLabel lblpassword;
        private Krypton.Toolkit.KryptonLabel lblstatus;
        private Krypton.Toolkit.KryptonTextBox tbpassword;
        private Krypton.Toolkit.KryptonTextBox tbusername;
        private Krypton.Toolkit.KryptonTextBox tbpasswordconfirm;
        private Krypton.Toolkit.KryptonCheckBox cbisactive;
        private Krypton.Toolkit.KryptonLabel lbluserid;
        private Krypton.Toolkit.KryptonButton btnUserSave;
        private ErrorProvider errorProvider1;
    }
}
