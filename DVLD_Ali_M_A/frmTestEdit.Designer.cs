namespace DVLD_Presentation
{
    partial class frmTestEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestEdit));
            lbltitle = new Krypton.Toolkit.KryptonLabel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            toolTipCancel = new ToolTip(components);
            lblid = new Krypton.Toolkit.KryptonLabel();
            tbtitle = new Krypton.Toolkit.KryptonTextBox();
            lblidnb = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            tbfees = new Krypton.Toolkit.KryptonTextBox();
            tbdescription = new Krypton.Toolkit.KryptonTextBox();
            errorProvider1 = new ErrorProvider(components);
            btnPeopleAddNew = new Krypton.Toolkit.KryptonButton();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = false;
            lbltitle.Location = new Point(575, 2);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(384, 107);
            lbltitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbltitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitle.TabIndex = 216;
            lbltitle.TabStop = false;
            lbltitle.Values.Text = "Edit Test Type";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Cursor = Cursors.Hand;
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(1400, 30);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(150, 100);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 215;
            kryptonPictureBox1.TabStop = false;
            kryptonPictureBox1.Click += kryptonPictureBox1_Click;
            // 
            // toolTipCancel
            // 
            toolTipCancel.BackColor = Color.Gainsboro;
            toolTipCancel.ForeColor = Color.DarkSlateBlue;
            // 
            // lblid
            // 
            lblid.AutoSize = false;
            lblid.Location = new Point(136, 157);
            lblid.Name = "lblid";
            lblid.Size = new Size(112, 48);
            lblid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.TabIndex = 217;
            lblid.TabStop = false;
            lblid.Values.Text = "ID:";
            // 
            // tbtitle
            // 
            tbtitle.Location = new Point(233, 262);
            tbtitle.Name = "tbtitle";
            tbtitle.Size = new Size(1127, 52);
            tbtitle.StateActive.Back.Color1 = Color.LightGray;
            tbtitle.StateActive.Border.Rounding = 30F;
            tbtitle.StateActive.Content.Color1 = Color.Black;
            tbtitle.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtitle.StateCommon.Back.Color1 = Color.White;
            tbtitle.StateCommon.Border.Rounding = 30F;
            tbtitle.StateCommon.Content.Color1 = Color.Black;
            tbtitle.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtitle.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbtitle.StateDisabled.Border.Rounding = 30F;
            tbtitle.StateDisabled.Content.Color1 = Color.Black;
            tbtitle.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtitle.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbtitle.StateNormal.Border.Rounding = 30F;
            tbtitle.StateNormal.Content.Color1 = Color.Black;
            tbtitle.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtitle.TabIndex = 218;
            tbtitle.Validating += tbtitle_Validating;
            // 
            // lblidnb
            // 
            lblidnb.AutoSize = false;
            lblidnb.Location = new Point(237, 157);
            lblidnb.Name = "lblidnb";
            lblidnb.Size = new Size(56, 48);
            lblidnb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblidnb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidnb.TabIndex = 219;
            lblidnb.TabStop = false;
            lblidnb.Values.Text = "-1";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.AutoSize = false;
            kryptonLabel1.Location = new Point(136, 266);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(91, 48);
            kryptonLabel1.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 220;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "Title:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.AutoSize = false;
            kryptonLabel2.Location = new Point(136, 368);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(91, 48);
            kryptonLabel2.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel2.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 221;
            kryptonLabel2.TabStop = false;
            kryptonLabel2.Values.Text = "Fees:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.AutoSize = false;
            kryptonLabel3.Location = new Point(136, 463);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(166, 48);
            kryptonLabel3.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel3.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 222;
            kryptonLabel3.TabStop = false;
            kryptonLabel3.Values.Text = "Description:";
            // 
            // tbfees
            // 
            tbfees.Location = new Point(233, 368);
            tbfees.Name = "tbfees";
            tbfees.Size = new Size(1127, 52);
            tbfees.StateActive.Back.Color1 = Color.LightGray;
            tbfees.StateActive.Border.Rounding = 30F;
            tbfees.StateActive.Content.Color1 = Color.Black;
            tbfees.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfees.StateCommon.Back.Color1 = Color.White;
            tbfees.StateCommon.Border.Rounding = 30F;
            tbfees.StateCommon.Content.Color1 = Color.Black;
            tbfees.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfees.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbfees.StateDisabled.Border.Rounding = 30F;
            tbfees.StateDisabled.Content.Color1 = Color.Black;
            tbfees.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfees.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbfees.StateNormal.Border.Rounding = 30F;
            tbfees.StateNormal.Content.Color1 = Color.Black;
            tbfees.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbfees.TabIndex = 223;
            tbfees.Validating += tbtitle_Validating;
            // 
            // tbdescription
            // 
            tbdescription.Location = new Point(136, 517);
            tbdescription.Multiline = true;
            tbdescription.Name = "tbdescription";
            tbdescription.Size = new Size(1267, 352);
            tbdescription.StateActive.Back.Color1 = Color.LightGray;
            tbdescription.StateActive.Border.Rounding = 30F;
            tbdescription.StateActive.Content.Color1 = Color.Black;
            tbdescription.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbdescription.StateCommon.Back.Color1 = Color.White;
            tbdescription.StateCommon.Border.Rounding = 30F;
            tbdescription.StateCommon.Content.Color1 = Color.Black;
            tbdescription.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbdescription.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbdescription.StateDisabled.Border.Rounding = 30F;
            tbdescription.StateDisabled.Content.Color1 = Color.Black;
            tbdescription.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbdescription.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbdescription.StateNormal.Border.Rounding = 30F;
            tbdescription.StateNormal.Content.Color1 = Color.Black;
            tbdescription.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbdescription.TabIndex = 224;
            tbdescription.Validating += tbtitle_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnPeopleAddNew
            // 
            btnPeopleAddNew.Location = new Point(1165, 951);
            btnPeopleAddNew.Name = "btnPeopleAddNew";
            btnPeopleAddNew.OverrideDefault.Back.Color1 = Color.Silver;
            btnPeopleAddNew.OverrideDefault.Border.Rounding = 50F;
            btnPeopleAddNew.OverrideFocus.Back.Color1 = Color.Silver;
            btnPeopleAddNew.OverrideFocus.Border.Rounding = 50F;
            btnPeopleAddNew.Size = new Size(221, 69);
            btnPeopleAddNew.StateDisabled.Back.Color1 = Color.Silver;
            btnPeopleAddNew.StateDisabled.Border.Rounding = 50F;
            btnPeopleAddNew.StateNormal.Back.Color1 = Color.Silver;
            btnPeopleAddNew.StateNormal.Back.Color2 = Color.Silver;
            btnPeopleAddNew.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleAddNew.StateNormal.Border.Rounding = 50F;
            btnPeopleAddNew.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleAddNew.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleAddNew.StatePressed.Back.Color1 = Color.Silver;
            btnPeopleAddNew.StatePressed.Back.Color2 = Color.Silver;
            btnPeopleAddNew.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleAddNew.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPeopleAddNew.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPeopleAddNew.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleAddNew.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleAddNew.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleAddNew.StatePressed.Border.Rounding = 50F;
            btnPeopleAddNew.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleAddNew.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleAddNew.StateTracking.Back.Color1 = Color.Silver;
            btnPeopleAddNew.StateTracking.Back.Color2 = Color.Silver;
            btnPeopleAddNew.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleAddNew.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleAddNew.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPeopleAddNew.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPeopleAddNew.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleAddNew.StateTracking.Border.Rounding = 50F;
            btnPeopleAddNew.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleAddNew.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPeopleAddNew.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPeopleAddNew.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPeopleAddNew.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleAddNew.TabIndex = 225;
            btnPeopleAddNew.Values.DropDownArrowColor = Color.Empty;
            btnPeopleAddNew.Values.Text = "Save";
            btnPeopleAddNew.Click += btnPeopleAddNew_Click;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 226;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmTestEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1630, 1070);
            Controls.Add(btnDocumentation);
            Controls.Add(btnPeopleAddNew);
            Controls.Add(tbdescription);
            Controls.Add(tbfees);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(lblidnb);
            Controls.Add(tbtitle);
            Controls.Add(lbltitle);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(lblid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTestEdit";
            Text = "frmTestEdit";
            Load += frmTestEdit_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbltitle;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private ToolTip toolTipCancel;
        private Krypton.Toolkit.KryptonLabel lblid;
        private Krypton.Toolkit.KryptonTextBox tbtitle;
        private Krypton.Toolkit.KryptonLabel lblidnb;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox tbfees;
        private Krypton.Toolkit.KryptonTextBox tbdescription;
        private ErrorProvider errorProvider1;
        private Krypton.Toolkit.KryptonButton btnPeopleAddNew;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
        private ToolTip toolTip2;
    }
}