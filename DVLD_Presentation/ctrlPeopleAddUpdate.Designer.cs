namespace DVLD_Presentation
{
    partial class ctrlPeopleAddUpdate
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
            pnPeopleAddUpdate = new Krypton.Toolkit.KryptonPanel();
            lblPid = new Krypton.Toolkit.KryptonLabel();
            cbCountries = new Krypton.Toolkit.KryptonComboBox();
            dateofbirth = new DateTimePicker();
            rbfemale = new Krypton.Toolkit.KryptonRadioButton();
            rbmale = new Krypton.Toolkit.KryptonRadioButton();
            tbaddress = new Krypton.Toolkit.KryptonTextBox();
            tbemail = new Krypton.Toolkit.KryptonTextBox();
            tbphone = new Krypton.Toolkit.KryptonTextBox();
            tbnationalnb = new Krypton.Toolkit.KryptonTextBox();
            tblname = new Krypton.Toolkit.KryptonTextBox();
            tbtname = new Krypton.Toolkit.KryptonTextBox();
            tbsname = new Krypton.Toolkit.KryptonTextBox();
            tbfname = new Krypton.Toolkit.KryptonTextBox();
            btnPeopleClose = new Krypton.Toolkit.KryptonButton();
            btnPeopleSave = new Krypton.Toolkit.KryptonButton();
            lblsname = new Krypton.Toolkit.KryptonLabel();
            lbllname = new Krypton.Toolkit.KryptonLabel();
            lbltname = new Krypton.Toolkit.KryptonLabel();
            lblfname = new Krypton.Toolkit.KryptonLabel();
            btnPeopleRemoveImage = new Krypton.Toolkit.KryptonButton();
            btnPeopleSetImage = new Krypton.Toolkit.KryptonButton();
            pbPeopleDetails = new Krypton.Toolkit.KryptonPictureBox();
            lblcountry = new Krypton.Toolkit.KryptonLabel();
            lblphone = new Krypton.Toolkit.KryptonLabel();
            lbldateofbirth = new Krypton.Toolkit.KryptonLabel();
            lbladdress = new Krypton.Toolkit.KryptonLabel();
            lblemail = new Krypton.Toolkit.KryptonLabel();
            lblgender = new Krypton.Toolkit.KryptonLabel();
            lblnationalnb = new Krypton.Toolkit.KryptonLabel();
            lblname = new Krypton.Toolkit.KryptonLabel();
            lblid = new Krypton.Toolkit.KryptonLabel();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pnPeopleAddUpdate).BeginInit();
            pnPeopleAddUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbCountries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPeopleDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnPeopleAddUpdate
            // 
            pnPeopleAddUpdate.Controls.Add(lblPid);
            pnPeopleAddUpdate.Controls.Add(cbCountries);
            pnPeopleAddUpdate.Controls.Add(dateofbirth);
            pnPeopleAddUpdate.Controls.Add(rbfemale);
            pnPeopleAddUpdate.Controls.Add(rbmale);
            pnPeopleAddUpdate.Controls.Add(tbaddress);
            pnPeopleAddUpdate.Controls.Add(tbemail);
            pnPeopleAddUpdate.Controls.Add(tbphone);
            pnPeopleAddUpdate.Controls.Add(tbnationalnb);
            pnPeopleAddUpdate.Controls.Add(tblname);
            pnPeopleAddUpdate.Controls.Add(tbtname);
            pnPeopleAddUpdate.Controls.Add(tbsname);
            pnPeopleAddUpdate.Controls.Add(tbfname);
            pnPeopleAddUpdate.Controls.Add(btnPeopleClose);
            pnPeopleAddUpdate.Controls.Add(btnPeopleSave);
            pnPeopleAddUpdate.Controls.Add(lblsname);
            pnPeopleAddUpdate.Controls.Add(lbllname);
            pnPeopleAddUpdate.Controls.Add(lbltname);
            pnPeopleAddUpdate.Controls.Add(lblfname);
            pnPeopleAddUpdate.Controls.Add(btnPeopleRemoveImage);
            pnPeopleAddUpdate.Controls.Add(btnPeopleSetImage);
            pnPeopleAddUpdate.Controls.Add(pbPeopleDetails);
            pnPeopleAddUpdate.Controls.Add(lblcountry);
            pnPeopleAddUpdate.Controls.Add(lblphone);
            pnPeopleAddUpdate.Controls.Add(lbldateofbirth);
            pnPeopleAddUpdate.Controls.Add(lbladdress);
            pnPeopleAddUpdate.Controls.Add(lblemail);
            pnPeopleAddUpdate.Controls.Add(lblgender);
            pnPeopleAddUpdate.Controls.Add(lblnationalnb);
            pnPeopleAddUpdate.Controls.Add(lblname);
            pnPeopleAddUpdate.Controls.Add(lblid);
            pnPeopleAddUpdate.Location = new Point(3, 3);
            pnPeopleAddUpdate.Name = "pnPeopleAddUpdate";
            pnPeopleAddUpdate.Size = new Size(1394, 897);
            pnPeopleAddUpdate.StateNormal.Color1 = Color.Lavender;
            pnPeopleAddUpdate.TabIndex = 1;
            // 
            // lblPid
            // 
            lblPid.AutoSize = false;
            lblPid.Enabled = false;
            lblPid.Location = new Point(124, 3);
            lblPid.Name = "lblPid";
            lblPid.Size = new Size(158, 47);
            lblPid.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblPid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPid.TabIndex = 257;
            lblPid.TabStop = false;
            lblPid.Values.Text = "";
            // 
            // cbCountries
            // 
            cbCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountries.DropDownWidth = 175;
            cbCountries.Location = new Point(577, 202);
            cbCountries.MaxDropDownItems = 12;
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(216, 33);
            cbCountries.StateCommon.ComboBox.Back.Color1 = Color.Gainsboro;
            cbCountries.StateCommon.ComboBox.Content.Color1 = Color.Black;
            cbCountries.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCountries.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbCountries.StateDisabled.ComboBox.Content.Color1 = Color.Black;
            cbCountries.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCountries.TabIndex = 6;
            // 
            // dateofbirth
            // 
            dateofbirth.Location = new Point(182, 378);
            dateofbirth.MinDate = new DateTime(1909, 12, 31, 0, 0, 0, 0);
            dateofbirth.Name = "dateofbirth";
            dateofbirth.Size = new Size(300, 31);
            dateofbirth.TabIndex = 10;
            // 
            // rbfemale
            // 
            rbfemale.Location = new Point(224, 291);
            rbfemale.Name = "rbfemale";
            rbfemale.Size = new Size(117, 34);
            rbfemale.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            rbfemale.StateNormal.ShortText.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbfemale.TabIndex = 8;
            rbfemale.Values.Text = "female";
            rbfemale.CheckedChanged += rbfemale_CheckedChanged;
            // 
            // rbmale
            // 
            rbmale.Location = new Point(113, 291);
            rbmale.Name = "rbmale";
            rbmale.Size = new Size(92, 34);
            rbmale.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            rbmale.StateNormal.ShortText.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbmale.TabIndex = 7;
            rbmale.Values.Text = "Male";
            rbmale.CheckedChanged += rbmale_CheckedChanged;
            // 
            // tbaddress
            // 
            tbaddress.Location = new Point(124, 541);
            tbaddress.Multiline = true;
            tbaddress.Name = "tbaddress";
            tbaddress.Size = new Size(757, 233);
            tbaddress.StateActive.Back.Color1 = Color.LightGray;
            tbaddress.StateActive.Border.Rounding = 30F;
            tbaddress.StateActive.Content.Color1 = Color.Black;
            tbaddress.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbaddress.StateCommon.Back.Color1 = Color.White;
            tbaddress.StateCommon.Border.Rounding = 30F;
            tbaddress.StateCommon.Content.Color1 = Color.Black;
            tbaddress.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbaddress.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbaddress.StateDisabled.Border.Rounding = 30F;
            tbaddress.StateDisabled.Content.Color1 = Color.Black;
            tbaddress.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbaddress.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbaddress.StateNormal.Border.Rounding = 30F;
            tbaddress.StateNormal.Content.Color1 = Color.Black;
            tbaddress.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbaddress.TabIndex = 12;
            tbaddress.Validating += RequiredField_Validating;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(102, 454);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(362, 52);
            tbemail.StateActive.Back.Color1 = Color.LightGray;
            tbemail.StateActive.Border.Rounding = 30F;
            tbemail.StateActive.Content.Color1 = Color.Black;
            tbemail.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.StateCommon.Back.Color1 = Color.White;
            tbemail.StateCommon.Border.Rounding = 30F;
            tbemail.StateCommon.Content.Color1 = Color.Black;
            tbemail.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbemail.StateDisabled.Border.Rounding = 30F;
            tbemail.StateDisabled.Content.Color1 = Color.Black;
            tbemail.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbemail.StateNormal.Border.Rounding = 30F;
            tbemail.StateNormal.Content.Color1 = Color.Black;
            tbemail.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.TabIndex = 11;
            tbemail.Validating += tbemail_Validating;
            // 
            // tbphone
            // 
            tbphone.Location = new Point(558, 275);
            tbphone.Name = "tbphone";
            tbphone.Size = new Size(217, 52);
            tbphone.StateActive.Back.Color1 = Color.LightGray;
            tbphone.StateActive.Border.Rounding = 30F;
            tbphone.StateActive.Content.Color1 = Color.Black;
            tbphone.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbphone.StateCommon.Back.Color1 = Color.White;
            tbphone.StateCommon.Border.Rounding = 30F;
            tbphone.StateCommon.Content.Color1 = Color.Black;
            tbphone.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbphone.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbphone.StateDisabled.Border.Rounding = 30F;
            tbphone.StateDisabled.Content.Color1 = Color.Black;
            tbphone.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbphone.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbphone.StateNormal.Border.Rounding = 30F;
            tbphone.StateNormal.Content.Color1 = Color.Black;
            tbphone.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbphone.TabIndex = 9;
            tbphone.Validating += RequiredField_Validating;
            // 
            // tbnationalnb
            // 
            tbnationalnb.Location = new Point(225, 183);
            tbnationalnb.Name = "tbnationalnb";
            tbnationalnb.Size = new Size(217, 52);
            tbnationalnb.StateActive.Back.Color1 = Color.LightGray;
            tbnationalnb.StateActive.Border.Rounding = 30F;
            tbnationalnb.StateActive.Content.Color1 = Color.Black;
            tbnationalnb.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnationalnb.StateCommon.Back.Color1 = Color.White;
            tbnationalnb.StateCommon.Border.Rounding = 30F;
            tbnationalnb.StateCommon.Content.Color1 = Color.Black;
            tbnationalnb.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnationalnb.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbnationalnb.StateDisabled.Border.Rounding = 30F;
            tbnationalnb.StateDisabled.Content.Color1 = Color.Black;
            tbnationalnb.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnationalnb.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbnationalnb.StateNormal.Border.Rounding = 30F;
            tbnationalnb.StateNormal.Content.Color1 = Color.Black;
            tbnationalnb.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnationalnb.TabIndex = 5;
            tbnationalnb.Validating += tbnationalnb_Validating;
            // 
            // tblname
            // 
            tblname.Location = new Point(1031, 104);
            tblname.Name = "tblname";
            tblname.Size = new Size(217, 52);
            tblname.StateActive.Back.Color1 = Color.LightGray;
            tblname.StateActive.Border.Rounding = 30F;
            tblname.StateActive.Content.Color1 = Color.Black;
            tblname.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblname.StateCommon.Back.Color1 = Color.White;
            tblname.StateCommon.Border.Rounding = 30F;
            tblname.StateCommon.Content.Color1 = Color.Black;
            tblname.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblname.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tblname.StateDisabled.Border.Rounding = 30F;
            tblname.StateDisabled.Content.Color1 = Color.Black;
            tblname.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblname.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tblname.StateNormal.Border.Rounding = 30F;
            tblname.StateNormal.Content.Color1 = Color.Black;
            tblname.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblname.TabIndex = 4;
            tblname.Validating += RequiredField_Validating;
            // 
            // tbtname
            // 
            tbtname.Location = new Point(727, 104);
            tbtname.Name = "tbtname";
            tbtname.Size = new Size(217, 52);
            tbtname.StateActive.Back.Color1 = Color.LightGray;
            tbtname.StateActive.Border.Rounding = 30F;
            tbtname.StateActive.Content.Color1 = Color.Black;
            tbtname.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtname.StateCommon.Back.Color1 = Color.White;
            tbtname.StateCommon.Border.Rounding = 30F;
            tbtname.StateCommon.Content.Color1 = Color.Black;
            tbtname.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtname.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbtname.StateDisabled.Border.Rounding = 30F;
            tbtname.StateDisabled.Content.Color1 = Color.Black;
            tbtname.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtname.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbtname.StateNormal.Border.Rounding = 30F;
            tbtname.StateNormal.Content.Color1 = Color.Black;
            tbtname.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtname.TabIndex = 3;
            // 
            // tbsname
            // 
            tbsname.Location = new Point(430, 104);
            tbsname.Name = "tbsname";
            tbsname.Size = new Size(217, 52);
            tbsname.StateActive.Back.Color1 = Color.LightGray;
            tbsname.StateActive.Border.Rounding = 30F;
            tbsname.StateActive.Content.Color1 = Color.Black;
            tbsname.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbsname.StateCommon.Back.Color1 = Color.White;
            tbsname.StateCommon.Border.Rounding = 30F;
            tbsname.StateCommon.Content.Color1 = Color.Black;
            tbsname.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbsname.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbsname.StateDisabled.Border.Rounding = 30F;
            tbsname.StateDisabled.Content.Color1 = Color.Black;
            tbsname.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbsname.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbsname.StateNormal.Border.Rounding = 30F;
            tbsname.StateNormal.Content.Color1 = Color.Black;
            tbsname.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbsname.TabIndex = 2;
            tbsname.Validating += RequiredField_Validating;
            // 
            // tbfname
            // 
            tbfname.Location = new Point(124, 104);
            tbfname.Name = "tbfname";
            tbfname.Size = new Size(217, 52);
            tbfname.StateActive.Back.Color1 = Color.LightGray;
            tbfname.StateActive.Border.Rounding = 30F;
            tbfname.StateActive.Content.Color1 = Color.Black;
            tbfname.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfname.StateCommon.Back.Color1 = Color.White;
            tbfname.StateCommon.Border.Rounding = 30F;
            tbfname.StateCommon.Content.Color1 = Color.Black;
            tbfname.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfname.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbfname.StateDisabled.Border.Rounding = 30F;
            tbfname.StateDisabled.Content.Color1 = Color.Black;
            tbfname.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfname.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbfname.StateNormal.Border.Rounding = 30F;
            tbfname.StateNormal.Content.Color1 = Color.Black;
            tbfname.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfname.TabIndex = 1;
            tbfname.Validating += RequiredField_Validating;
            // 
            // btnPeopleClose
            // 
            btnPeopleClose.Location = new Point(671, 822);
            btnPeopleClose.Name = "btnPeopleClose";
            btnPeopleClose.OverrideDefault.Back.Color1 = Color.Silver;
            btnPeopleClose.OverrideDefault.Border.Rounding = 50F;
            btnPeopleClose.OverrideFocus.Back.Color1 = Color.Silver;
            btnPeopleClose.OverrideFocus.Border.Rounding = 50F;
            btnPeopleClose.Size = new Size(187, 69);
            btnPeopleClose.StateDisabled.Back.Color1 = Color.Silver;
            btnPeopleClose.StateDisabled.Border.Rounding = 50F;
            btnPeopleClose.StateNormal.Back.Color1 = Color.Silver;
            btnPeopleClose.StateNormal.Back.Color2 = Color.Silver;
            btnPeopleClose.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleClose.StateNormal.Border.Rounding = 50F;
            btnPeopleClose.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleClose.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleClose.StatePressed.Back.Color1 = Color.Silver;
            btnPeopleClose.StatePressed.Back.Color2 = Color.Silver;
            btnPeopleClose.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleClose.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPeopleClose.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPeopleClose.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleClose.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleClose.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleClose.StatePressed.Border.Rounding = 50F;
            btnPeopleClose.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleClose.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleClose.StateTracking.Back.Color1 = Color.Silver;
            btnPeopleClose.StateTracking.Back.Color2 = Color.Silver;
            btnPeopleClose.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleClose.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleClose.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPeopleClose.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPeopleClose.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleClose.StateTracking.Border.Rounding = 50F;
            btnPeopleClose.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleClose.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPeopleClose.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPeopleClose.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPeopleClose.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleClose.TabIndex = 15;
            btnPeopleClose.Values.DropDownArrowColor = Color.Empty;
            btnPeopleClose.Values.Text = "Close";
            btnPeopleClose.Click += btnPeopleClose_Click;
            // 
            // btnPeopleSave
            // 
            btnPeopleSave.Location = new Point(888, 822);
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
            btnPeopleSave.TabIndex = 16;
            btnPeopleSave.Values.DropDownArrowColor = Color.Empty;
            btnPeopleSave.Values.Text = "Save";
            btnPeopleSave.Click += btnPeopleSave_Click;
            // 
            // lblsname
            // 
            lblsname.AutoSize = false;
            lblsname.Location = new Point(463, 47);
            lblsname.Name = "lblsname";
            lblsname.Size = new Size(158, 47);
            lblsname.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblsname.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsname.TabIndex = 242;
            lblsname.TabStop = false;
            lblsname.Values.Text = "Second:";
            // 
            // lbllname
            // 
            lbllname.AutoSize = false;
            lbllname.Location = new Point(1067, 47);
            lbllname.Name = "lbllname";
            lbllname.Size = new Size(158, 47);
            lbllname.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbllname.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbllname.TabIndex = 241;
            lbllname.TabStop = false;
            lbllname.Values.Text = "Last:";
            // 
            // lbltname
            // 
            lbltname.AutoSize = false;
            lbltname.Location = new Point(765, 47);
            lbltname.Name = "lbltname";
            lbltname.Size = new Size(158, 47);
            lbltname.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbltname.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltname.TabIndex = 240;
            lbltname.TabStop = false;
            lbltname.Values.Text = "Third:";
            // 
            // lblfname
            // 
            lblfname.AutoSize = false;
            lblfname.Location = new Point(161, 47);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(158, 47);
            lblfname.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblfname.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfname.TabIndex = 239;
            lblfname.TabStop = false;
            lblfname.Values.Text = "First:";
            // 
            // btnPeopleRemoveImage
            // 
            btnPeopleRemoveImage.Location = new Point(1003, 536);
            btnPeopleRemoveImage.Name = "btnPeopleRemoveImage";
            btnPeopleRemoveImage.OverrideDefault.Back.Color1 = Color.Silver;
            btnPeopleRemoveImage.OverrideDefault.Border.Rounding = 50F;
            btnPeopleRemoveImage.OverrideFocus.Back.Color1 = Color.Silver;
            btnPeopleRemoveImage.OverrideFocus.Border.Rounding = 50F;
            btnPeopleRemoveImage.Size = new Size(245, 43);
            btnPeopleRemoveImage.StateDisabled.Back.Color1 = Color.Silver;
            btnPeopleRemoveImage.StateDisabled.Border.Rounding = 50F;
            btnPeopleRemoveImage.StateNormal.Back.Color1 = Color.Silver;
            btnPeopleRemoveImage.StateNormal.Back.Color2 = Color.Silver;
            btnPeopleRemoveImage.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleRemoveImage.StateNormal.Border.Rounding = 50F;
            btnPeopleRemoveImage.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleRemoveImage.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleRemoveImage.StatePressed.Back.Color1 = Color.Silver;
            btnPeopleRemoveImage.StatePressed.Back.Color2 = Color.Silver;
            btnPeopleRemoveImage.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleRemoveImage.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPeopleRemoveImage.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPeopleRemoveImage.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleRemoveImage.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleRemoveImage.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleRemoveImage.StatePressed.Border.Rounding = 50F;
            btnPeopleRemoveImage.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleRemoveImage.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleRemoveImage.StateTracking.Back.Color1 = Color.Silver;
            btnPeopleRemoveImage.StateTracking.Back.Color2 = Color.Silver;
            btnPeopleRemoveImage.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleRemoveImage.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleRemoveImage.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPeopleRemoveImage.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPeopleRemoveImage.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleRemoveImage.StateTracking.Border.Rounding = 50F;
            btnPeopleRemoveImage.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleRemoveImage.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPeopleRemoveImage.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPeopleRemoveImage.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPeopleRemoveImage.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleRemoveImage.TabIndex = 14;
            btnPeopleRemoveImage.Values.DropDownArrowColor = Color.Empty;
            btnPeopleRemoveImage.Values.Text = "Remove Image";
            btnPeopleRemoveImage.Visible = false;
            btnPeopleRemoveImage.Click += btnPeopleRemoveImage_Click;
            // 
            // btnPeopleSetImage
            // 
            btnPeopleSetImage.Location = new Point(1003, 477);
            btnPeopleSetImage.Name = "btnPeopleSetImage";
            btnPeopleSetImage.OverrideDefault.Back.Color1 = Color.Silver;
            btnPeopleSetImage.OverrideDefault.Border.Rounding = 50F;
            btnPeopleSetImage.OverrideFocus.Back.Color1 = Color.Silver;
            btnPeopleSetImage.OverrideFocus.Border.Rounding = 50F;
            btnPeopleSetImage.Size = new Size(245, 43);
            btnPeopleSetImage.StateDisabled.Back.Color1 = Color.Silver;
            btnPeopleSetImage.StateDisabled.Border.Rounding = 50F;
            btnPeopleSetImage.StateNormal.Back.Color1 = Color.Silver;
            btnPeopleSetImage.StateNormal.Back.Color2 = Color.Silver;
            btnPeopleSetImage.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSetImage.StateNormal.Border.Rounding = 50F;
            btnPeopleSetImage.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleSetImage.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSetImage.StatePressed.Back.Color1 = Color.Silver;
            btnPeopleSetImage.StatePressed.Back.Color2 = Color.Silver;
            btnPeopleSetImage.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSetImage.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPeopleSetImage.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPeopleSetImage.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSetImage.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSetImage.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSetImage.StatePressed.Border.Rounding = 50F;
            btnPeopleSetImage.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleSetImage.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSetImage.StateTracking.Back.Color1 = Color.Silver;
            btnPeopleSetImage.StateTracking.Back.Color2 = Color.Silver;
            btnPeopleSetImage.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSetImage.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSetImage.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPeopleSetImage.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPeopleSetImage.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSetImage.StateTracking.Border.Rounding = 50F;
            btnPeopleSetImage.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSetImage.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPeopleSetImage.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPeopleSetImage.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPeopleSetImage.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSetImage.TabIndex = 13;
            btnPeopleSetImage.Values.DropDownArrowColor = Color.Empty;
            btnPeopleSetImage.Values.Text = "Set Image ";
            btnPeopleSetImage.Click += btnPeopleSetImage_Click;
            // 
            // pbPeopleDetails
            // 
            pbPeopleDetails.Image = Properties.Resources.male3;
            pbPeopleDetails.Location = new Point(1003, 210);
            pbPeopleDetails.Name = "pbPeopleDetails";
            pbPeopleDetails.Size = new Size(338, 244);
            pbPeopleDetails.SizeMode = PictureBoxSizeMode.Zoom;
            pbPeopleDetails.TabIndex = 236;
            pbPeopleDetails.TabStop = false;
            // 
            // lblcountry
            // 
            lblcountry.AutoSize = false;
            lblcountry.Location = new Point(463, 202);
            lblcountry.Name = "lblcountry";
            lblcountry.Size = new Size(158, 33);
            lblcountry.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblcountry.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcountry.TabIndex = 226;
            lblcountry.TabStop = false;
            lblcountry.Values.Text = "Country:";
            // 
            // lblphone
            // 
            lblphone.AutoSize = false;
            lblphone.Location = new Point(463, 280);
            lblphone.Name = "lblphone";
            lblphone.Size = new Size(158, 47);
            lblphone.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblphone.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblphone.TabIndex = 225;
            lblphone.TabStop = false;
            lblphone.Values.Text = "Phone:";
            // 
            // lbldateofbirth
            // 
            lbldateofbirth.AutoSize = false;
            lbldateofbirth.Location = new Point(3, 378);
            lbldateofbirth.Name = "lbldateofbirth";
            lbldateofbirth.Size = new Size(190, 31);
            lbldateofbirth.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbldateofbirth.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldateofbirth.TabIndex = 224;
            lbldateofbirth.TabStop = false;
            lbldateofbirth.Values.Text = "Date Of Birth:";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = false;
            lbladdress.Location = new Point(3, 546);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(158, 47);
            lbladdress.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbladdress.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladdress.TabIndex = 223;
            lbladdress.TabStop = false;
            lbladdress.Values.Text = "Address:";
            // 
            // lblemail
            // 
            lblemail.AutoSize = false;
            lblemail.Location = new Point(3, 459);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(158, 47);
            lblemail.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblemail.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblemail.TabIndex = 222;
            lblemail.TabStop = false;
            lblemail.Values.Text = "Email:";
            // 
            // lblgender
            // 
            lblgender.AutoSize = false;
            lblgender.Location = new Point(3, 291);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(158, 34);
            lblgender.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblgender.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgender.TabIndex = 221;
            lblgender.TabStop = false;
            lblgender.Values.Text = "Gender: ";
            // 
            // lblnationalnb
            // 
            lblnationalnb.AutoSize = false;
            lblnationalnb.Location = new Point(3, 188);
            lblnationalnb.Name = "lblnationalnb";
            lblnationalnb.Size = new Size(234, 47);
            lblnationalnb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblnationalnb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnationalnb.TabIndex = 220;
            lblnationalnb.TabStop = false;
            lblnationalnb.Values.Text = "National Number: ";
            // 
            // lblname
            // 
            lblname.AutoSize = false;
            lblname.Location = new Point(3, 109);
            lblname.Name = "lblname";
            lblname.Size = new Size(158, 47);
            lblname.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblname.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblname.TabIndex = 219;
            lblname.TabStop = false;
            lblname.Values.Text = "Name: ";
            // 
            // lblid
            // 
            lblid.AutoSize = false;
            lblid.Enabled = false;
            lblid.Location = new Point(3, 3);
            lblid.Name = "lblid";
            lblid.Size = new Size(158, 47);
            lblid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.TabIndex = 218;
            lblid.TabStop = false;
            lblid.Values.Text = "Person ID:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPeopleAddUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(pnPeopleAddUpdate);
            Name = "ctrlPeopleAddUpdate";
            Size = new Size(1400, 900);
            Load += ctrlPeopleAddUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)pnPeopleAddUpdate).EndInit();
            pnPeopleAddUpdate.ResumeLayout(false);
            pnPeopleAddUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbCountries).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPeopleDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnPeopleAddUpdate;
        private Krypton.Toolkit.KryptonButton btnPeopleSetImage;
        private Krypton.Toolkit.KryptonPictureBox pbPeopleDetails;
        private Krypton.Toolkit.KryptonLabel lblcountry;
        private Krypton.Toolkit.KryptonLabel lblphone;
        private Krypton.Toolkit.KryptonLabel lbldateofbirth;
        private Krypton.Toolkit.KryptonLabel lbladdress;
        private Krypton.Toolkit.KryptonLabel lblemail;
        private Krypton.Toolkit.KryptonLabel lblgender;
        private Krypton.Toolkit.KryptonLabel lblnationalnb;
        private Krypton.Toolkit.KryptonLabel lblname;
        private Krypton.Toolkit.KryptonLabel lblid;
        private Krypton.Toolkit.KryptonLabel lblsname;
        private Krypton.Toolkit.KryptonLabel lbllname;
        private Krypton.Toolkit.KryptonLabel lbltname;
        private Krypton.Toolkit.KryptonLabel lblfname;
        private Krypton.Toolkit.KryptonButton btnPeopleRemoveImage;
        private Krypton.Toolkit.KryptonButton btnPeopleClose;
        private Krypton.Toolkit.KryptonButton btnPeopleSave;
        private Krypton.Toolkit.KryptonTextBox tbfname;
        private Krypton.Toolkit.KryptonTextBox tbaddress;
        private Krypton.Toolkit.KryptonTextBox tbemail;
        private Krypton.Toolkit.KryptonTextBox tbphone;
        private Krypton.Toolkit.KryptonTextBox tbnationalnb;
        private Krypton.Toolkit.KryptonTextBox tblname;
        private Krypton.Toolkit.KryptonTextBox tbtname;
        private Krypton.Toolkit.KryptonTextBox tbsname;
        private Krypton.Toolkit.KryptonRadioButton rbfemale;
        private Krypton.Toolkit.KryptonRadioButton rbmale;
        private DateTimePicker dateofbirth;
        private Krypton.Toolkit.KryptonComboBox cbCountries;
        private Krypton.Toolkit.KryptonLabel lblPid;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}
