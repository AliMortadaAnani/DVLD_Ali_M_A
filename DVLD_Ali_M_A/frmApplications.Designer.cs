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
            ((System.ComponentModel.ISupportInitialize)pbApplicationsCancel).BeginInit();
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
            btnApplicationTypes.Location = new Point(42, 859);
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
            btnApplicationTypes.TabIndex = 210;
            btnApplicationTypes.Values.DropDownArrowColor = Color.Empty;
            btnApplicationTypes.Values.Text = "Manage Application Types";
            btnApplicationTypes.Click += btnApplicationTypes_Click;
            // 
            // btnTestTypes
            // 
            btnTestTypes.Cursor = Cursors.Hand;
            btnTestTypes.Location = new Point(872, 859);
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
            btnTestTypes.TabIndex = 212;
            btnTestTypes.Values.DropDownArrowColor = Color.Empty;
            btnTestTypes.Values.Text = "Manage Test Types";
            btnTestTypes.Click += btnTestTypes_Click;
            // 
            // frmApplications
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1581, 1074);
            Controls.Add(btnTestTypes);
            Controls.Add(lbApplicationsTitle);
            Controls.Add(pbApplicationsCancel);
            Controls.Add(btnApplicationTypes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmApplications";
            Text = "frmApplications";
            Load += frmApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pbApplicationsCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbApplicationsTitle;
        private Krypton.Toolkit.KryptonPictureBox pbApplicationsCancel;
        private ToolTip toolTipClose;
        private Krypton.Toolkit.KryptonButton btnApplicationTypes;
        private Krypton.Toolkit.KryptonButton btnTestTypes;
    }
}