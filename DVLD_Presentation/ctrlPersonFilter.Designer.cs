namespace DVLD_Presentation
{
    partial class ctrlPersonFilter
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
            pnPeopleShowDetails = new Krypton.Toolkit.KryptonPanel();
            btnPersonAddNew = new Krypton.Toolkit.KryptonButton();
            btnPersonSearch = new Krypton.Toolkit.KryptonButton();
            mtbPersonFilterInput = new MaskedTextBox();
            cbPersonFilterBox = new Krypton.Toolkit.KryptonComboBox();
            lblFindBy = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)pnPeopleShowDetails).BeginInit();
            pnPeopleShowDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbPersonFilterBox).BeginInit();
            SuspendLayout();
            // 
            // pnPeopleShowDetails
            // 
            pnPeopleShowDetails.Controls.Add(btnPersonAddNew);
            pnPeopleShowDetails.Controls.Add(btnPersonSearch);
            pnPeopleShowDetails.Controls.Add(mtbPersonFilterInput);
            pnPeopleShowDetails.Controls.Add(cbPersonFilterBox);
            pnPeopleShowDetails.Controls.Add(lblFindBy);
            pnPeopleShowDetails.Location = new Point(3, 45);
            pnPeopleShowDetails.Name = "pnPeopleShowDetails";
            pnPeopleShowDetails.Size = new Size(1300, 103);
            pnPeopleShowDetails.StateNormal.Color1 = Color.Lavender;
            pnPeopleShowDetails.TabIndex = 1;
            // 
            // btnPersonAddNew
            // 
            btnPersonAddNew.Location = new Point(1075, 22);
            btnPersonAddNew.Name = "btnPersonAddNew";
            btnPersonAddNew.OverrideDefault.Back.Color1 = Color.Silver;
            btnPersonAddNew.OverrideDefault.Border.Rounding = 50F;
            btnPersonAddNew.OverrideFocus.Back.Color1 = Color.Silver;
            btnPersonAddNew.OverrideFocus.Border.Rounding = 50F;
            btnPersonAddNew.Size = new Size(222, 47);
            btnPersonAddNew.StateDisabled.Back.Color1 = Color.Silver;
            btnPersonAddNew.StateDisabled.Border.Rounding = 50F;
            btnPersonAddNew.StateNormal.Back.Color1 = Color.Silver;
            btnPersonAddNew.StateNormal.Back.Color2 = Color.Silver;
            btnPersonAddNew.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPersonAddNew.StateNormal.Border.Rounding = 50F;
            btnPersonAddNew.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPersonAddNew.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonAddNew.StatePressed.Back.Color1 = Color.Silver;
            btnPersonAddNew.StatePressed.Back.Color2 = Color.Silver;
            btnPersonAddNew.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPersonAddNew.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPersonAddNew.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPersonAddNew.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPersonAddNew.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPersonAddNew.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPersonAddNew.StatePressed.Border.Rounding = 50F;
            btnPersonAddNew.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPersonAddNew.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonAddNew.StateTracking.Back.Color1 = Color.Silver;
            btnPersonAddNew.StateTracking.Back.Color2 = Color.Silver;
            btnPersonAddNew.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPersonAddNew.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPersonAddNew.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPersonAddNew.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPersonAddNew.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPersonAddNew.StateTracking.Border.Rounding = 50F;
            btnPersonAddNew.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPersonAddNew.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPersonAddNew.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPersonAddNew.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPersonAddNew.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonAddNew.TabIndex = 240;
            btnPersonAddNew.Values.DropDownArrowColor = Color.Empty;
            btnPersonAddNew.Values.Text = "Add New Person";
            btnPersonAddNew.Click += btnPersonAddNew_Click;
            // 
            // btnPersonSearch
            // 
            btnPersonSearch.Location = new Point(856, 22);
            btnPersonSearch.Name = "btnPersonSearch";
            btnPersonSearch.OverrideDefault.Back.Color1 = Color.Silver;
            btnPersonSearch.OverrideDefault.Border.Rounding = 50F;
            btnPersonSearch.OverrideFocus.Back.Color1 = Color.Silver;
            btnPersonSearch.OverrideFocus.Border.Rounding = 50F;
            btnPersonSearch.Size = new Size(200, 47);
            btnPersonSearch.StateDisabled.Back.Color1 = Color.Silver;
            btnPersonSearch.StateDisabled.Border.Rounding = 50F;
            btnPersonSearch.StateNormal.Back.Color1 = Color.Silver;
            btnPersonSearch.StateNormal.Back.Color2 = Color.Silver;
            btnPersonSearch.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPersonSearch.StateNormal.Border.Rounding = 50F;
            btnPersonSearch.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPersonSearch.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonSearch.StatePressed.Back.Color1 = Color.Silver;
            btnPersonSearch.StatePressed.Back.Color2 = Color.Silver;
            btnPersonSearch.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPersonSearch.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPersonSearch.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPersonSearch.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPersonSearch.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPersonSearch.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPersonSearch.StatePressed.Border.Rounding = 50F;
            btnPersonSearch.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPersonSearch.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonSearch.StateTracking.Back.Color1 = Color.Silver;
            btnPersonSearch.StateTracking.Back.Color2 = Color.Silver;
            btnPersonSearch.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPersonSearch.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPersonSearch.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPersonSearch.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPersonSearch.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPersonSearch.StateTracking.Border.Rounding = 50F;
            btnPersonSearch.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPersonSearch.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPersonSearch.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPersonSearch.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPersonSearch.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPersonSearch.TabIndex = 239;
            btnPersonSearch.Values.DropDownArrowColor = Color.Empty;
            btnPersonSearch.Values.Text = "Search Person";
            btnPersonSearch.Click += btnPersonSearch_Click;
            // 
            // mtbPersonFilterInput
            // 
            mtbPersonFilterInput.BackColor = Color.Gainsboro;
            mtbPersonFilterInput.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbPersonFilterInput.ForeColor = SystemColors.InfoText;
            mtbPersonFilterInput.Location = new Point(451, 28);
            mtbPersonFilterInput.Name = "mtbPersonFilterInput";
            mtbPersonFilterInput.Size = new Size(242, 34);
            mtbPersonFilterInput.TabIndex = 238;
            mtbPersonFilterInput.Validating += mtbPersonFilterInput_Validating;
            // 
            // cbPersonFilterBox
            // 
            cbPersonFilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPersonFilterBox.DropDownWidth = 175;
            cbPersonFilterBox.Items.AddRange(new object[] { "PersonID", "NationalNumber" });
            cbPersonFilterBox.Location = new Point(178, 29);
            cbPersonFilterBox.MaxDropDownItems = 12;
            cbPersonFilterBox.Name = "cbPersonFilterBox";
            cbPersonFilterBox.Size = new Size(242, 33);
            cbPersonFilterBox.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbPersonFilterBox.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbPersonFilterBox.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPersonFilterBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbPersonFilterBox.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbPersonFilterBox.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPersonFilterBox.TabIndex = 237;
            cbPersonFilterBox.Text = "PersonID";
            cbPersonFilterBox.SelectedIndexChanged += cbPersonFilterBox_SelectedIndexChanged;
            // 
            // lblFindBy
            // 
            lblFindBy.AutoSize = false;
            lblFindBy.Location = new Point(49, 20);
            lblFindBy.Name = "lblFindBy";
            lblFindBy.Size = new Size(123, 51);
            lblFindBy.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblFindBy.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFindBy.TabIndex = 236;
            lblFindBy.TabStop = false;
            lblFindBy.Values.Text = "Find By:";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.AutoSize = false;
            kryptonLabel1.Location = new Point(454, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(396, 43);
            kryptonLabel1.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 238;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "Filter for Person Information:";
            // 
            // ctrlPersonFilter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonLabel1);
            Controls.Add(pnPeopleShowDetails);
            Name = "ctrlPersonFilter";
            Size = new Size(1313, 162);
            ((System.ComponentModel.ISupportInitialize)pnPeopleShowDetails).EndInit();
            pnPeopleShowDetails.ResumeLayout(false);
            pnPeopleShowDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cbPersonFilterBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnPeopleShowDetails;
        private Krypton.Toolkit.KryptonLabel lblFindBy;
        private Krypton.Toolkit.KryptonComboBox cbPersonFilterBox;
        private MaskedTextBox mtbPersonFilterInput;
        private Krypton.Toolkit.KryptonButton btnPersonAddNew;
        private Krypton.Toolkit.KryptonButton btnPersonSearch;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
