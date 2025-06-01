namespace DVLD_Presentation
{
    partial class frmApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplications));
            lbApplicationsTitle = new Krypton.Toolkit.KryptonLabel();
            pbApplicationsCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTipClose = new ToolTip(components);
            btnApplicationTypes = new Krypton.Toolkit.KryptonButton();
            btnTestTypes = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)pbApplicationsCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // lbApplicationsTitle
            // 
            lbApplicationsTitle.AutoSize = false;
            lbApplicationsTitle.Location = new Point(575, 2);
            lbApplicationsTitle.Name = "lbApplicationsTitle";
            lbApplicationsTitle.Size = new Size(256, 107);
            lbApplicationsTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbApplicationsTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApplicationsTitle.TabIndex = 211;
            lbApplicationsTitle.TabStop = false;
            lbApplicationsTitle.Values.Text = "Applications";
            // 
            // pbApplicationsCancel
            // 
            pbApplicationsCancel.Cursor = Cursors.Hand;
            pbApplicationsCancel.Image = (Image)resources.GetObject("pbApplicationsCancel.Image");
            pbApplicationsCancel.Location = new Point(1400, 30);
            pbApplicationsCancel.Name = "pbApplicationsCancel";
            pbApplicationsCancel.Size = new Size(150, 100);
            pbApplicationsCancel.SizeMode = PictureBoxSizeMode.Zoom;
            pbApplicationsCancel.TabIndex = 209;
            pbApplicationsCancel.TabStop = false;
            toolTipClose.SetToolTip(pbApplicationsCancel, "Close");
            pbApplicationsCancel.Click += pbSettingsCancel_Click;
            // 
            // btnApplicationTypes
            // 
            btnApplicationTypes.Cursor = Cursors.Hand;
            btnApplicationTypes.Location = new Point(809, 623);
            btnApplicationTypes.Name = "btnApplicationTypes";
            btnApplicationTypes.OverrideDefault.Back.Color1 = Color.Silver;
            btnApplicationTypes.OverrideDefault.Border.Rounding = 50F;
            btnApplicationTypes.OverrideFocus.Back.Color1 = Color.Silver;
            btnApplicationTypes.OverrideFocus.Border.Rounding = 50F;
            btnApplicationTypes.Size = new Size(680, 158);
            btnApplicationTypes.StateDisabled.Back.Color1 = Color.Silver;
            btnApplicationTypes.StateDisabled.Border.Rounding = 50F;
            btnApplicationTypes.StateNormal.Back.Color1 = Color.Silver;
            btnApplicationTypes.StateNormal.Back.Color2 = Color.Silver;
            btnApplicationTypes.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnApplicationTypes.StateNormal.Border.Rounding = 50F;
            btnApplicationTypes.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnApplicationTypes.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplicationTypes.StatePressed.Back.Color1 = Color.Silver;
            btnApplicationTypes.StatePressed.Back.Color2 = Color.Silver;
            btnApplicationTypes.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnApplicationTypes.StatePressed.Border.Color1 = Color.Gainsboro;
            btnApplicationTypes.StatePressed.Border.Color2 = Color.Gainsboro;
            btnApplicationTypes.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnApplicationTypes.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnApplicationTypes.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnApplicationTypes.StatePressed.Border.Rounding = 50F;
            btnApplicationTypes.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnApplicationTypes.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplicationTypes.StateTracking.Back.Color1 = Color.Silver;
            btnApplicationTypes.StateTracking.Back.Color2 = Color.Silver;
            btnApplicationTypes.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnApplicationTypes.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnApplicationTypes.StateTracking.Border.Color1 = Color.Gainsboro;
            btnApplicationTypes.StateTracking.Border.Color2 = Color.Gainsboro;
            btnApplicationTypes.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnApplicationTypes.StateTracking.Border.Rounding = 50F;
            btnApplicationTypes.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnApplicationTypes.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnApplicationTypes.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnApplicationTypes.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnApplicationTypes.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplicationTypes.TabIndex = 218;
            btnApplicationTypes.Values.DropDownArrowColor = Color.Empty;
            btnApplicationTypes.Values.Text = "Manage Application Types";
            btnApplicationTypes.Click += btnApplicationTypes_Click;
            // 
            // btnTestTypes
            // 
            btnTestTypes.Cursor = Cursors.Hand;
            btnTestTypes.Location = new Point(42, 864);
            btnTestTypes.Name = "btnTestTypes";
            btnTestTypes.OverrideDefault.Back.Color1 = Color.Silver;
            btnTestTypes.OverrideDefault.Border.Rounding = 50F;
            btnTestTypes.OverrideFocus.Back.Color1 = Color.Silver;
            btnTestTypes.OverrideFocus.Border.Rounding = 50F;
            btnTestTypes.Size = new Size(680, 158);
            btnTestTypes.StateDisabled.Back.Color1 = Color.Silver;
            btnTestTypes.StateDisabled.Border.Rounding = 50F;
            btnTestTypes.StateNormal.Back.Color1 = Color.Silver;
            btnTestTypes.StateNormal.Back.Color2 = Color.Silver;
            btnTestTypes.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnTestTypes.StateNormal.Border.Rounding = 50F;
            btnTestTypes.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnTestTypes.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestTypes.StatePressed.Back.Color1 = Color.Silver;
            btnTestTypes.StatePressed.Back.Color2 = Color.Silver;
            btnTestTypes.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnTestTypes.StatePressed.Border.Color1 = Color.Gainsboro;
            btnTestTypes.StatePressed.Border.Color2 = Color.Gainsboro;
            btnTestTypes.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnTestTypes.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnTestTypes.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnTestTypes.StatePressed.Border.Rounding = 50F;
            btnTestTypes.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnTestTypes.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestTypes.StateTracking.Back.Color1 = Color.Silver;
            btnTestTypes.StateTracking.Back.Color2 = Color.Silver;
            btnTestTypes.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnTestTypes.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnTestTypes.StateTracking.Border.Color1 = Color.Gainsboro;
            btnTestTypes.StateTracking.Border.Color2 = Color.Gainsboro;
            btnTestTypes.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnTestTypes.StateTracking.Border.Rounding = 50F;
            btnTestTypes.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnTestTypes.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnTestTypes.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnTestTypes.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnTestTypes.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestTypes.TabIndex = 219;
            btnTestTypes.Values.DropDownArrowColor = Color.Empty;
            btnTestTypes.Values.Text = "Manage Test Types";
            btnTestTypes.Click += btnTestTypes_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(42, 151);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton1.OverrideDefault.Border.Rounding = 50F;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButton1.OverrideFocus.Border.Rounding = 50F;
            kryptonButton1.Size = new Size(680, 158);
            kryptonButton1.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButton1.StateDisabled.Border.Rounding = 50F;
            kryptonButton1.StateNormal.Back.Color1 = Color.Silver;
            kryptonButton1.StateNormal.Back.Color2 = Color.Silver;
            kryptonButton1.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton1.StateNormal.Border.Rounding = 50F;
            kryptonButton1.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton1.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.Silver;
            kryptonButton1.StatePressed.Back.Color2 = Color.Silver;
            kryptonButton1.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StatePressed.Border.Color1 = Color.Gainsboro;
            kryptonButton1.StatePressed.Border.Color2 = Color.Gainsboro;
            kryptonButton1.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton1.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StatePressed.Border.Rounding = 50F;
            kryptonButton1.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton1.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton1.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton1.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton1.StateTracking.Border.Color1 = Color.Gainsboro;
            kryptonButton1.StateTracking.Border.Color2 = Color.Gainsboro;
            kryptonButton1.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton1.StateTracking.Border.Rounding = 50F;
            kryptonButton1.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton1.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton1.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.TabIndex = 213;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Manage Local Driving License Applications";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Cursor = Cursors.Hand;
            kryptonButton2.Location = new Point(809, 151);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton2.OverrideDefault.Border.Rounding = 50F;
            kryptonButton2.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButton2.OverrideFocus.Border.Rounding = 50F;
            kryptonButton2.Size = new Size(680, 158);
            kryptonButton2.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButton2.StateDisabled.Border.Rounding = 50F;
            kryptonButton2.StateNormal.Back.Color1 = Color.Silver;
            kryptonButton2.StateNormal.Back.Color2 = Color.Silver;
            kryptonButton2.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton2.StateNormal.Border.Rounding = 50F;
            kryptonButton2.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton2.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StatePressed.Back.Color1 = Color.Silver;
            kryptonButton2.StatePressed.Back.Color2 = Color.Silver;
            kryptonButton2.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton2.StatePressed.Border.Color1 = Color.Gainsboro;
            kryptonButton2.StatePressed.Border.Color2 = Color.Gainsboro;
            kryptonButton2.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton2.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton2.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton2.StatePressed.Border.Rounding = 50F;
            kryptonButton2.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton2.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton2.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton2.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton2.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton2.StateTracking.Border.Color1 = Color.Gainsboro;
            kryptonButton2.StateTracking.Border.Color2 = Color.Gainsboro;
            kryptonButton2.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton2.StateTracking.Border.Rounding = 50F;
            kryptonButton2.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton2.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton2.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton2.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton2.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton2.TabIndex = 214;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Text = "Manage International Driving License Applications";
            kryptonButton2.Click += kryptonButton2_Click;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Cursor = Cursors.Hand;
            kryptonButton3.Location = new Point(42, 387);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton3.OverrideDefault.Border.Rounding = 50F;
            kryptonButton3.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButton3.OverrideFocus.Border.Rounding = 50F;
            kryptonButton3.Size = new Size(680, 158);
            kryptonButton3.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButton3.StateDisabled.Border.Rounding = 50F;
            kryptonButton3.StateNormal.Back.Color1 = Color.Silver;
            kryptonButton3.StateNormal.Back.Color2 = Color.Silver;
            kryptonButton3.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton3.StateNormal.Border.Rounding = 50F;
            kryptonButton3.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton3.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StatePressed.Back.Color1 = Color.Silver;
            kryptonButton3.StatePressed.Back.Color2 = Color.Silver;
            kryptonButton3.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton3.StatePressed.Border.Color1 = Color.Gainsboro;
            kryptonButton3.StatePressed.Border.Color2 = Color.Gainsboro;
            kryptonButton3.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton3.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton3.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton3.StatePressed.Border.Rounding = 50F;
            kryptonButton3.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton3.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton3.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton3.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton3.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton3.StateTracking.Border.Color1 = Color.Gainsboro;
            kryptonButton3.StateTracking.Border.Color2 = Color.Gainsboro;
            kryptonButton3.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton3.StateTracking.Border.Rounding = 50F;
            kryptonButton3.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton3.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton3.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton3.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton3.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton3.TabIndex = 215;
            kryptonButton3.Values.DropDownArrowColor = Color.Empty;
            kryptonButton3.Values.Text = "Renew Local License Applications";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // kryptonButton4
            // 
            kryptonButton4.Cursor = Cursors.Hand;
            kryptonButton4.Location = new Point(809, 363);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton4.OverrideDefault.Border.Rounding = 50F;
            kryptonButton4.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButton4.OverrideFocus.Border.Rounding = 50F;
            kryptonButton4.Size = new Size(680, 158);
            kryptonButton4.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButton4.StateDisabled.Border.Rounding = 50F;
            kryptonButton4.StateNormal.Back.Color1 = Color.Silver;
            kryptonButton4.StateNormal.Back.Color2 = Color.Silver;
            kryptonButton4.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton4.StateNormal.Border.Rounding = 50F;
            kryptonButton4.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton4.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton4.StatePressed.Back.Color1 = Color.Silver;
            kryptonButton4.StatePressed.Back.Color2 = Color.Silver;
            kryptonButton4.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton4.StatePressed.Border.Color1 = Color.Gainsboro;
            kryptonButton4.StatePressed.Border.Color2 = Color.Gainsboro;
            kryptonButton4.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton4.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton4.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton4.StatePressed.Border.Rounding = 50F;
            kryptonButton4.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton4.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton4.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton4.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton4.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton4.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton4.StateTracking.Border.Color1 = Color.Gainsboro;
            kryptonButton4.StateTracking.Border.Color2 = Color.Gainsboro;
            kryptonButton4.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton4.StateTracking.Border.Rounding = 50F;
            kryptonButton4.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton4.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton4.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton4.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton4.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton4.TabIndex = 216;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.Text = "Replace Local License Applications";
            kryptonButton4.Click += kryptonButton4_Click;
            // 
            // kryptonButton5
            // 
            kryptonButton5.Cursor = Cursors.Hand;
            kryptonButton5.Location = new Point(42, 623);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.OverrideDefault.Back.Color1 = Color.Silver;
            kryptonButton5.OverrideDefault.Border.Rounding = 50F;
            kryptonButton5.OverrideFocus.Back.Color1 = Color.Silver;
            kryptonButton5.OverrideFocus.Border.Rounding = 50F;
            kryptonButton5.Size = new Size(680, 158);
            kryptonButton5.StateDisabled.Back.Color1 = Color.Silver;
            kryptonButton5.StateDisabled.Border.Rounding = 50F;
            kryptonButton5.StateNormal.Back.Color1 = Color.Silver;
            kryptonButton5.StateNormal.Back.Color2 = Color.Silver;
            kryptonButton5.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton5.StateNormal.Border.Rounding = 50F;
            kryptonButton5.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton5.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton5.StatePressed.Back.Color1 = Color.Silver;
            kryptonButton5.StatePressed.Back.Color2 = Color.Silver;
            kryptonButton5.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton5.StatePressed.Border.Color1 = Color.Gainsboro;
            kryptonButton5.StatePressed.Border.Color2 = Color.Gainsboro;
            kryptonButton5.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton5.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton5.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton5.StatePressed.Border.Rounding = 50F;
            kryptonButton5.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            kryptonButton5.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton5.StateTracking.Back.Color1 = Color.Silver;
            kryptonButton5.StateTracking.Back.Color2 = Color.Silver;
            kryptonButton5.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton5.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonButton5.StateTracking.Border.Color1 = Color.Gainsboro;
            kryptonButton5.StateTracking.Border.Color2 = Color.Gainsboro;
            kryptonButton5.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            kryptonButton5.StateTracking.Border.Rounding = 50F;
            kryptonButton5.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton5.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            kryptonButton5.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonButton5.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            kryptonButton5.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton5.TabIndex = 217;
            kryptonButton5.Values.DropDownArrowColor = Color.Empty;
            kryptonButton5.Values.Text = "Manage Detained Local Licenses";
            kryptonButton5.Click += kryptonButton5_Click;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 218;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmApplications
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1581, 1074);
            Controls.Add(btnDocumentation);
            Controls.Add(kryptonButton5);
            Controls.Add(kryptonButton4);
            Controls.Add(kryptonButton3);
            Controls.Add(kryptonButton2);
            Controls.Add(kryptonButton1);
            Controls.Add(btnTestTypes);
            Controls.Add(lbApplicationsTitle);
            Controls.Add(pbApplicationsCancel);
            Controls.Add(btnApplicationTypes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmApplications";
            Text = "frmApplications";
            Load += frmApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pbApplicationsCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbApplicationsTitle;
        private Krypton.Toolkit.KryptonPictureBox pbApplicationsCancel;
        private ToolTip toolTipClose;
        private Krypton.Toolkit.KryptonButton btnApplicationTypes;
        private Krypton.Toolkit.KryptonButton btnTestTypes;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}