namespace DVLD_Presentation
{
    partial class frmTests
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
            date = new DateTimePicker();
            lbldateofbirth = new Krypton.Toolkit.KryptonLabel();
            lblfeestxt = new Krypton.Toolkit.KryptonLabel();
            lbltrialtxt = new Krypton.Toolkit.KryptonLabel();
            lblnametxt = new Krypton.Toolkit.KryptonLabel();
            lblidtxt = new Krypton.Toolkit.KryptonLabel();
            lbllicensetxt = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            lblstatus = new Krypton.Toolkit.KryptonLabel();
            lbladdress = new Krypton.Toolkit.KryptonLabel();
            lblid = new Krypton.Toolkit.KryptonLabel();
            rbfail = new Krypton.Toolkit.KryptonRadioButton();
            rbpass = new Krypton.Toolkit.KryptonRadioButton();
            tbnotes = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            lblgender = new Krypton.Toolkit.KryptonLabel();
            btnPeopleSave = new Krypton.Toolkit.KryptonButton();
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
            // date
            // 
            date.Enabled = false;
            date.Location = new Point(456, 652);
            date.MinDate = new DateTime(1909, 12, 31, 0, 0, 0, 0);
            date.Name = "date";
            date.Size = new Size(321, 31);
            date.TabIndex = 275;
            // 
            // lbldateofbirth
            // 
            lbldateofbirth.AutoSize = false;
            lbldateofbirth.Location = new Point(212, 649);
            lbldateofbirth.Name = "lbldateofbirth";
            lbldateofbirth.Size = new Size(238, 31);
            lbldateofbirth.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbldateofbirth.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldateofbirth.TabIndex = 276;
            lbldateofbirth.TabStop = false;
            lbldateofbirth.Values.Text = "Appointment Date:";
            // 
            // lblfeestxt
            // 
            lblfeestxt.AutoSize = false;
            lblfeestxt.Location = new Point(291, 585);
            lblfeestxt.Name = "lblfeestxt";
            lblfeestxt.Size = new Size(677, 47);
            lblfeestxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblfeestxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfeestxt.TabIndex = 274;
            lblfeestxt.TabStop = false;
            lblfeestxt.Values.Text = "";
            // 
            // lbltrialtxt
            // 
            lbltrialtxt.AutoSize = false;
            lbltrialtxt.Location = new Point(291, 521);
            lbltrialtxt.Name = "lbltrialtxt";
            lbltrialtxt.Size = new Size(666, 47);
            lbltrialtxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lbltrialtxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltrialtxt.TabIndex = 273;
            lbltrialtxt.TabStop = false;
            lbltrialtxt.Values.Text = "";
            // 
            // lblnametxt
            // 
            lblnametxt.AutoSize = false;
            lblnametxt.Location = new Point(304, 457);
            lblnametxt.Name = "lblnametxt";
            lblnametxt.Size = new Size(790, 47);
            lblnametxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblnametxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnametxt.TabIndex = 272;
            lblnametxt.TabStop = false;
            lblnametxt.Values.Text = "";
            // 
            // lblidtxt
            // 
            lblidtxt.AutoSize = false;
            lblidtxt.Location = new Point(384, 329);
            lblidtxt.Name = "lblidtxt";
            lblidtxt.Size = new Size(754, 47);
            lblidtxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblidtxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidtxt.TabIndex = 268;
            lblidtxt.TabStop = false;
            lblidtxt.Values.Text = "";
            // 
            // lbllicensetxt
            // 
            lbllicensetxt.AutoSize = false;
            lbllicensetxt.Location = new Point(321, 393);
            lbllicensetxt.Name = "lbllicensetxt";
            lbllicensetxt.Size = new Size(680, 47);
            lbllicensetxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lbllicensetxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllicensetxt.TabIndex = 271;
            lbllicensetxt.TabStop = false;
            lbllicensetxt.Values.Text = "";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.AutoSize = false;
            kryptonLabel2.Location = new Point(212, 585);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(209, 47);
            kryptonLabel2.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel2.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 270;
            kryptonLabel2.TabStop = false;
            kryptonLabel2.Values.Text = "Fees:";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.AutoSize = false;
            kryptonLabel1.Location = new Point(212, 521);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(255, 47);
            kryptonLabel1.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 269;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "Trial:";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = false;
            lblstatus.Location = new Point(212, 393);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(158, 47);
            lblstatus.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblstatus.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.TabIndex = 267;
            lblstatus.TabStop = false;
            lblstatus.Values.Text = "License:";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = false;
            lbladdress.Location = new Point(212, 457);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(167, 47);
            lbladdress.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbladdress.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladdress.TabIndex = 266;
            lbladdress.TabStop = false;
            lbladdress.Values.Text = "Name:";
            // 
            // lblid
            // 
            lblid.AutoSize = false;
            lblid.Location = new Point(212, 329);
            lblid.Name = "lblid";
            lblid.Size = new Size(300, 47);
            lblid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.TabIndex = 265;
            lblid.TabStop = false;
            lblid.Values.Text = "Local DLA ID:";
            // 
            // rbfail
            // 
            rbfail.Location = new Point(212, 249);
            rbfail.Name = "rbfail";
            rbfail.Size = new Size(94, 45);
            rbfail.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            rbfail.StateNormal.ShortText.Font = new Font("Tahoma", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rbfail.TabIndex = 278;
            rbfail.Values.Text = "Fail";
            // 
            // rbpass
            // 
            rbpass.Location = new Point(212, 209);
            rbpass.Name = "rbpass";
            rbpass.Size = new Size(110, 45);
            rbpass.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            rbpass.StateNormal.ShortText.Font = new Font("Tahoma", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            rbpass.TabIndex = 277;
            rbpass.Values.Text = "Pass";
            // 
            // tbnotes
            // 
            tbnotes.Location = new Point(304, 743);
            tbnotes.Multiline = true;
            tbnotes.Name = "tbnotes";
            tbnotes.Size = new Size(757, 233);
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
            tbnotes.TabIndex = 279;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.AutoSize = false;
            kryptonLabel3.Location = new Point(212, 733);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(158, 47);
            kryptonLabel3.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel3.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 281;
            kryptonLabel3.TabStop = false;
            kryptonLabel3.Values.Text = "Notes:";
            // 
            // lblgender
            // 
            lblgender.AutoSize = false;
            lblgender.Location = new Point(212, 153);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(307, 34);
            lblgender.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblgender.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgender.TabIndex = 280;
            lblgender.TabStop = false;
            lblgender.Values.Text = "TEST RESULT:";
            // 
            // btnPeopleSave
            // 
            btnPeopleSave.Location = new Point(1116, 907);
            btnPeopleSave.Name = "btnPeopleSave";
            btnPeopleSave.OverrideDefault.Back.Color1 = Color.Silver;
            btnPeopleSave.OverrideDefault.Border.Rounding = 50F;
            btnPeopleSave.OverrideFocus.Back.Color1 = Color.Silver;
            btnPeopleSave.OverrideFocus.Border.Rounding = 50F;
            btnPeopleSave.Size = new Size(187, 69);
            btnPeopleSave.StateDisabled.Back.Color1 = Color.Silver;
            btnPeopleSave.StateDisabled.Border.Rounding = 50F;
            btnPeopleSave.StateNormal.Back.Color1 = Color.Silver;
            btnPeopleSave.StateNormal.Back.Color2 = Color.Silver;
            btnPeopleSave.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSave.StateNormal.Border.Rounding = 50F;
            btnPeopleSave.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleSave.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSave.StatePressed.Back.Color1 = Color.Silver;
            btnPeopleSave.StatePressed.Back.Color2 = Color.Silver;
            btnPeopleSave.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSave.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPeopleSave.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPeopleSave.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSave.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSave.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSave.StatePressed.Border.Rounding = 50F;
            btnPeopleSave.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleSave.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSave.StateTracking.Back.Color1 = Color.Silver;
            btnPeopleSave.StateTracking.Back.Color2 = Color.Silver;
            btnPeopleSave.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSave.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSave.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPeopleSave.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPeopleSave.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSave.StateTracking.Border.Rounding = 50F;
            btnPeopleSave.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSave.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPeopleSave.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPeopleSave.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPeopleSave.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSave.TabIndex = 282;
            btnPeopleSave.Values.DropDownArrowColor = Color.Empty;
            btnPeopleSave.Values.Text = "Save";
            btnPeopleSave.Click += btnPeopleSave_Click;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 283;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmTests
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(btnPeopleSave);
            Controls.Add(rbfail);
            Controls.Add(rbpass);
            Controls.Add(tbnotes);
            Controls.Add(kryptonLabel3);
            Controls.Add(lblgender);
            Controls.Add(date);
            Controls.Add(lbldateofbirth);
            Controls.Add(lblfeestxt);
            Controls.Add(lbltrialtxt);
            Controls.Add(lblnametxt);
            Controls.Add(lblidtxt);
            Controls.Add(lbllicensetxt);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(lblstatus);
            Controls.Add(lbladdress);
            Controls.Add(lblid);
            Name = "frmTests";
            StartPosition = FormStartPosition.Manual;
            Text = "frmTests";
            Load += frmTests_Load;
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(lblid, 0);
            Controls.SetChildIndex(lbladdress, 0);
            Controls.SetChildIndex(lblstatus, 0);
            Controls.SetChildIndex(kryptonLabel1, 0);
            Controls.SetChildIndex(kryptonLabel2, 0);
            Controls.SetChildIndex(lbllicensetxt, 0);
            Controls.SetChildIndex(lblidtxt, 0);
            Controls.SetChildIndex(lblnametxt, 0);
            Controls.SetChildIndex(lbltrialtxt, 0);
            Controls.SetChildIndex(lblfeestxt, 0);
            Controls.SetChildIndex(lbldateofbirth, 0);
            Controls.SetChildIndex(date, 0);
            Controls.SetChildIndex(lblgender, 0);
            Controls.SetChildIndex(kryptonLabel3, 0);
            Controls.SetChildIndex(tbnotes, 0);
            Controls.SetChildIndex(rbpass, 0);
            Controls.SetChildIndex(rbfail, 0);
            Controls.SetChildIndex(btnPeopleSave, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker date;
        private Krypton.Toolkit.KryptonLabel lbldateofbirth;
        private Krypton.Toolkit.KryptonLabel lblfeestxt;
        private Krypton.Toolkit.KryptonLabel lbltrialtxt;
        private Krypton.Toolkit.KryptonLabel lblnametxt;
        private Krypton.Toolkit.KryptonLabel lblidtxt;
        private Krypton.Toolkit.KryptonLabel lbllicensetxt;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel lblstatus;
        private Krypton.Toolkit.KryptonLabel lbladdress;
        private Krypton.Toolkit.KryptonLabel lblid;
        private Krypton.Toolkit.KryptonRadioButton rbfail;
        private Krypton.Toolkit.KryptonRadioButton rbpass;
        private Krypton.Toolkit.KryptonTextBox tbnotes;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblgender;
        private Krypton.Toolkit.KryptonButton btnPeopleSave;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}