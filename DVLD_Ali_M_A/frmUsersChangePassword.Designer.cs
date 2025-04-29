namespace DVLD_Presentation
{
    partial class frmUsersChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersChangePassword));
            toolTipCancel = new ToolTip(components);
            btnPeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            lblUserTitle = new Krypton.Toolkit.KryptonLabel();
            ctrlUsersShowDetails1 = new ctrlUsersShowDetails();
            btnUserSave = new Krypton.Toolkit.KryptonButton();
            tbpasswordconfirm = new Krypton.Toolkit.KryptonTextBox();
            tbpassword = new Krypton.Toolkit.KryptonTextBox();
            lblpasswordcurrent = new Krypton.Toolkit.KryptonLabel();
            lblpasswordconfirm = new Krypton.Toolkit.KryptonLabel();
            lblpasswordnew = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).BeginInit();
            SuspendLayout();
            // 
            // toolTipCancel
            // 
            toolTipCancel.BackColor = Color.Gainsboro;
            toolTipCancel.ForeColor = Color.DarkSlateBlue;
            // 
            // btnPeopleCancel
            // 
            btnPeopleCancel.Cursor = Cursors.Hand;
            btnPeopleCancel.Image = (Image)resources.GetObject("btnPeopleCancel.Image");
            btnPeopleCancel.Location = new Point(1400, 30);
            btnPeopleCancel.Name = "btnPeopleCancel";
            btnPeopleCancel.Size = new Size(150, 100);
            btnPeopleCancel.SizeMode = PictureBoxSizeMode.Zoom;
            btnPeopleCancel.TabIndex = 214;
            btnPeopleCancel.TabStop = false;
            toolTipCancel.SetToolTip(btnPeopleCancel, "Close");
            btnPeopleCancel.Click += btnPeopleCancel_Click;
            // 
            // lblUserTitle
            // 
            lblUserTitle.AutoSize = false;
            lblUserTitle.Location = new Point(575, 2);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(461, 107);
            lblUserTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUserTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserTitle.TabIndex = 215;
            lblUserTitle.TabStop = false;
            lblUserTitle.Values.Text = "Change User Password";
            // 
            // ctrlUsersShowDetails1
            // 
            ctrlUsersShowDetails1.BackColor = Color.Lavender;
            ctrlUsersShowDetails1.Location = new Point(289, 183);
            ctrlUsersShowDetails1.Name = "ctrlUsersShowDetails1";
            ctrlUsersShowDetails1.Size = new Size(988, 130);
            ctrlUsersShowDetails1.TabIndex = 216;
            // 
            // btnUserSave
            // 
            btnUserSave.Location = new Point(329, 719);
            btnUserSave.Name = "btnUserSave";
            btnUserSave.OverrideDefault.Back.Color1 = Color.Silver;
            btnUserSave.OverrideDefault.Border.Rounding = 50F;
            btnUserSave.OverrideFocus.Back.Color1 = Color.Silver;
            btnUserSave.OverrideFocus.Border.Rounding = 50F;
            btnUserSave.Size = new Size(187, 92);
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
            btnUserSave.TabIndex = 225;
            btnUserSave.Values.DropDownArrowColor = Color.Empty;
            btnUserSave.Values.Text = "Save";
            // 
            // tbpasswordconfirm
            // 
            tbpasswordconfirm.Location = new Point(619, 560);
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
            tbpasswordconfirm.TabIndex = 224;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(619, 390);
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
            tbpassword.TabIndex = 223;
            // 
            // lblpasswordcurrent
            // 
            lblpasswordcurrent.AutoSize = false;
            lblpasswordcurrent.Location = new Point(329, 390);
            lblpasswordcurrent.Name = "lblpasswordcurrent";
            lblpasswordcurrent.Size = new Size(241, 47);
            lblpasswordcurrent.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblpasswordcurrent.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpasswordcurrent.TabIndex = 227;
            lblpasswordcurrent.TabStop = false;
            lblpasswordcurrent.Values.Text = "Current Password:";
            // 
            // lblpasswordconfirm
            // 
            lblpasswordconfirm.AutoSize = false;
            lblpasswordconfirm.Location = new Point(329, 565);
            lblpasswordconfirm.Name = "lblpasswordconfirm";
            lblpasswordconfirm.Size = new Size(307, 47);
            lblpasswordconfirm.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblpasswordconfirm.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpasswordconfirm.TabIndex = 226;
            lblpasswordconfirm.TabStop = false;
            lblpasswordconfirm.Values.Text = "Confirm New Password:";
            // 
            // lblpasswordnew
            // 
            lblpasswordnew.AutoSize = false;
            lblpasswordnew.Location = new Point(329, 483);
            lblpasswordnew.Name = "lblpasswordnew";
            lblpasswordnew.Size = new Size(204, 47);
            lblpasswordnew.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblpasswordnew.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpasswordnew.TabIndex = 228;
            lblpasswordnew.TabStop = false;
            lblpasswordnew.Values.Text = "New Password:";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(619, 483);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(217, 52);
            kryptonTextBox1.StateActive.Back.Color1 = Color.LightGray;
            kryptonTextBox1.StateActive.Border.Rounding = 30F;
            kryptonTextBox1.StateActive.Content.Color1 = Color.Black;
            kryptonTextBox1.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateCommon.Back.Color1 = Color.White;
            kryptonTextBox1.StateCommon.Border.Rounding = 30F;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox1.StateDisabled.Border.Rounding = 30F;
            kryptonTextBox1.StateDisabled.Content.Color1 = Color.Black;
            kryptonTextBox1.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.StateNormal.Back.Color1 = Color.WhiteSmoke;
            kryptonTextBox1.StateNormal.Border.Rounding = 30F;
            kryptonTextBox1.StateNormal.Content.Color1 = Color.Black;
            kryptonTextBox1.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonTextBox1.TabIndex = 229;
            // 
            // frmUsersChangePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1592, 881);
            Controls.Add(kryptonTextBox1);
            Controls.Add(lblpasswordnew);
            Controls.Add(btnUserSave);
            Controls.Add(tbpasswordconfirm);
            Controls.Add(tbpassword);
            Controls.Add(lblpasswordcurrent);
            Controls.Add(lblpasswordconfirm);
            Controls.Add(ctrlUsersShowDetails1);
            Controls.Add(lblUserTitle);
            Controls.Add(btnPeopleCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsersChangePassword";
            Text = "frmUsersChangePassword";
            Load += frmUsersChangePassword_Load;
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTipCancel;
        private Krypton.Toolkit.KryptonPictureBox btnPeopleCancel;
        private Krypton.Toolkit.KryptonLabel lblUserTitle;
        private ctrlUsersShowDetails ctrlUsersShowDetails1;
        private Krypton.Toolkit.KryptonButton btnUserSave;
        private Krypton.Toolkit.KryptonTextBox tbpasswordconfirm;
        private Krypton.Toolkit.KryptonTextBox tbpassword;
        private Krypton.Toolkit.KryptonLabel lblpasswordcurrent;
        private Krypton.Toolkit.KryptonLabel lblpasswordconfirm;
        private Krypton.Toolkit.KryptonLabel lblpasswordnew;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
    }
}