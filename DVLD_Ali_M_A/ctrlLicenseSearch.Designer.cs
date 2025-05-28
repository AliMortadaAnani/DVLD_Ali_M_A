namespace DVLD_Presentation
{
    partial class ctrlLicenseSearch
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
            btnSearch = new Krypton.Toolkit.KryptonButton();
            mtbLicenseFilterInput = new MaskedTextBox();
            lblLocalTotalRecords = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(456, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.OverrideDefault.Back.Color1 = Color.Silver;
            btnSearch.OverrideDefault.Border.Rounding = 50F;
            btnSearch.OverrideFocus.Back.Color1 = Color.Silver;
            btnSearch.OverrideFocus.Border.Rounding = 50F;
            btnSearch.Size = new Size(200, 47);
            btnSearch.StateDisabled.Back.Color1 = Color.Silver;
            btnSearch.StateDisabled.Border.Rounding = 50F;
            btnSearch.StateNormal.Back.Color1 = Color.Silver;
            btnSearch.StateNormal.Back.Color2 = Color.Silver;
            btnSearch.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSearch.StateNormal.Border.Rounding = 50F;
            btnSearch.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnSearch.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.StatePressed.Back.Color1 = Color.Silver;
            btnSearch.StatePressed.Back.Color2 = Color.Silver;
            btnSearch.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSearch.StatePressed.Border.Color1 = Color.Gainsboro;
            btnSearch.StatePressed.Border.Color2 = Color.Gainsboro;
            btnSearch.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSearch.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSearch.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSearch.StatePressed.Border.Rounding = 50F;
            btnSearch.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnSearch.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.StateTracking.Back.Color1 = Color.Silver;
            btnSearch.StateTracking.Back.Color2 = Color.Silver;
            btnSearch.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSearch.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnSearch.StateTracking.Border.Color1 = Color.Gainsboro;
            btnSearch.StateTracking.Border.Color2 = Color.Gainsboro;
            btnSearch.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnSearch.StateTracking.Border.Rounding = 50F;
            btnSearch.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnSearch.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnSearch.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnSearch.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnSearch.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.TabIndex = 244;
            btnSearch.Values.DropDownArrowColor = Color.Empty;
            btnSearch.Values.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // mtbLicenseFilterInput
            // 
            mtbLicenseFilterInput.BackColor = Color.Gainsboro;
            mtbLicenseFilterInput.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbLicenseFilterInput.ForeColor = SystemColors.InfoText;
            mtbLicenseFilterInput.Location = new Point(208, 13);
            mtbLicenseFilterInput.Name = "mtbLicenseFilterInput";
            mtbLicenseFilterInput.Size = new Size(242, 34);
            mtbLicenseFilterInput.TabIndex = 243;
            // 
            // lblLocalTotalRecords
            // 
            lblLocalTotalRecords.AutoSize = false;
            lblLocalTotalRecords.Location = new Point(2, 7);
            lblLocalTotalRecords.Name = "lblLocalTotalRecords";
            lblLocalTotalRecords.Size = new Size(223, 47);
            lblLocalTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblLocalTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalTotalRecords.TabIndex = 242;
            lblLocalTotalRecords.TabStop = false;
            lblLocalTotalRecords.Values.Text = "Local License ID:";
            // 
            // ctrlLicenseSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(btnSearch);
            Controls.Add(mtbLicenseFilterInput);
            Controls.Add(lblLocalTotalRecords);
            Name = "ctrlLicenseSearch";
            Size = new Size(661, 59);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnSearch;
        private MaskedTextBox mtbLicenseFilterInput;
        private Krypton.Toolkit.KryptonLabel lblLocalTotalRecords;
    }
}
