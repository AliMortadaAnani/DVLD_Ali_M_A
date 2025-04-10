namespace DVLD_Ali_M_A
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            toolTip1 = new ToolTip(components);
            btnPeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            lblPeopleTitle = new Krypton.Toolkit.KryptonLabel();
            dgvPeople = new Krypton.Toolkit.KryptonDataGridView();
            lblPeopleTotalRecords = new Krypton.Toolkit.KryptonLabel();
            lblPeopleTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            btnAddNewPerson = new Krypton.Toolkit.KryptonButton();
            lblPeopleFilter = new Krypton.Toolkit.KryptonLabel();
            cbPeopleFilterBox = new Krypton.Toolkit.KryptonComboBox();
            mtbPeopleFilterInput = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbPeopleFilterBox).BeginInit();
            SuspendLayout();
            // 
            // btnPeopleCancel
            // 
            btnPeopleCancel.Cursor = Cursors.Hand;
            btnPeopleCancel.Image = (Image)resources.GetObject("btnPeopleCancel.Image");
            btnPeopleCancel.Location = new Point(1400, 30);
            btnPeopleCancel.Name = "btnPeopleCancel";
            btnPeopleCancel.Size = new Size(150, 100);
            btnPeopleCancel.SizeMode = PictureBoxSizeMode.Zoom;
            btnPeopleCancel.TabIndex = 203;
            btnPeopleCancel.TabStop = false;
            toolTip1.SetToolTip(btnPeopleCancel, "Close");
            btnPeopleCancel.Click += btnPeopleCancel_Click;
            // 
            // lblPeopleTitle
            // 
            lblPeopleTitle.AutoSize = false;
            lblPeopleTitle.Location = new Point(575, 2);
            lblPeopleTitle.Name = "lblPeopleTitle";
            lblPeopleTitle.Size = new Size(347, 107);
            lblPeopleTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTitle.TabIndex = 209;
            lblPeopleTitle.TabStop = false;
            lblPeopleTitle.Values.Text = "Manage People";
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeColumns = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.AutoGenerateKryptonColumns = false;
            dgvPeople.BorderStyle = BorderStyle.Fixed3D;
            dgvPeople.ColumnHeadersHeight = 60;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPeople.Cursor = Cursors.Hand;
            dgvPeople.Location = new Point(0, 484);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersVisible = false;
            dgvPeople.RowHeadersWidth = 100;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.ShowEditingIcon = false;
            dgvPeople.ShowRowErrors = false;
            dgvPeople.Size = new Size(1569, 600);
            dgvPeople.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvPeople.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvPeople.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvPeople.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvPeople.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvPeople.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvPeople.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvPeople.TabIndex = 210;
            // 
            // lblPeopleTotalRecords
            // 
            lblPeopleTotalRecords.AutoSize = false;
            lblPeopleTotalRecords.Location = new Point(585, 431);
            lblPeopleTotalRecords.Name = "lblPeopleTotalRecords";
            lblPeopleTotalRecords.Size = new Size(191, 47);
            lblPeopleTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTotalRecords.TabIndex = 211;
            lblPeopleTotalRecords.TabStop = false;
            lblPeopleTotalRecords.Values.Text = "Total Records : ";
            // 
            // lblPeopleTotalRecordsNb
            // 
            lblPeopleTotalRecordsNb.AutoSize = false;
            lblPeopleTotalRecordsNb.Location = new Point(760, 431);
            lblPeopleTotalRecordsNb.Name = "lblPeopleTotalRecordsNb";
            lblPeopleTotalRecordsNb.Size = new Size(40, 47);
            lblPeopleTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTotalRecordsNb.TabIndex = 212;
            lblPeopleTotalRecordsNb.TabStop = false;
            lblPeopleTotalRecordsNb.Values.Text = "0";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.Location = new Point(1337, 405);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.OverrideDefault.Back.Color1 = Color.Silver;
            btnAddNewPerson.OverrideDefault.Border.Rounding = 50F;
            btnAddNewPerson.OverrideFocus.Back.Color1 = Color.Silver;
            btnAddNewPerson.OverrideFocus.Border.Rounding = 50F;
            btnAddNewPerson.Size = new Size(221, 63);
            btnAddNewPerson.StateDisabled.Back.Color1 = Color.Silver;
            btnAddNewPerson.StateDisabled.Border.Rounding = 50F;
            btnAddNewPerson.StateNormal.Back.Color1 = Color.Silver;
            btnAddNewPerson.StateNormal.Back.Color2 = Color.Silver;
            btnAddNewPerson.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnAddNewPerson.StateNormal.Border.Rounding = 50F;
            btnAddNewPerson.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnAddNewPerson.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewPerson.StatePressed.Back.Color1 = Color.Silver;
            btnAddNewPerson.StatePressed.Back.Color2 = Color.Silver;
            btnAddNewPerson.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnAddNewPerson.StatePressed.Border.Color1 = Color.Gainsboro;
            btnAddNewPerson.StatePressed.Border.Color2 = Color.Gainsboro;
            btnAddNewPerson.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnAddNewPerson.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAddNewPerson.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnAddNewPerson.StatePressed.Border.Rounding = 50F;
            btnAddNewPerson.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnAddNewPerson.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewPerson.StateTracking.Back.Color1 = Color.Silver;
            btnAddNewPerson.StateTracking.Back.Color2 = Color.Silver;
            btnAddNewPerson.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAddNewPerson.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnAddNewPerson.StateTracking.Border.Color1 = Color.Gainsboro;
            btnAddNewPerson.StateTracking.Border.Color2 = Color.Gainsboro;
            btnAddNewPerson.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnAddNewPerson.StateTracking.Border.Rounding = 50F;
            btnAddNewPerson.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnAddNewPerson.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnAddNewPerson.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnAddNewPerson.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnAddNewPerson.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewPerson.TabIndex = 213;
            btnAddNewPerson.Values.DropDownArrowColor = Color.Empty;
            btnAddNewPerson.Values.Text = "Add New Person";
            // 
            // lblPeopleFilter
            // 
            lblPeopleFilter.AutoSize = false;
            lblPeopleFilter.Location = new Point(0, 405);
            lblPeopleFilter.Name = "lblPeopleFilter";
            lblPeopleFilter.Size = new Size(123, 47);
            lblPeopleFilter.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleFilter.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleFilter.TabIndex = 217;
            lblPeopleFilter.TabStop = false;
            lblPeopleFilter.Values.Text = "Filter By:";
            // 
            // cbPeopleFilterBox
            // 
            cbPeopleFilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPeopleFilterBox.DropDownWidth = 175;
            cbPeopleFilterBox.Items.AddRange(new object[] { "None", "ID", "NationalNumber", "FirstName", "SecondName", "LastName", "Nationality", "Gender", "DateOfBirth", "Address", "Phone", "Email" });
            cbPeopleFilterBox.Location = new Point(0, 445);
            cbPeopleFilterBox.MaxDropDownItems = 12;
            cbPeopleFilterBox.Name = "cbPeopleFilterBox";
            cbPeopleFilterBox.Size = new Size(216, 33);
            cbPeopleFilterBox.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbPeopleFilterBox.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbPeopleFilterBox.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPeopleFilterBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbPeopleFilterBox.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbPeopleFilterBox.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPeopleFilterBox.TabIndex = 220;
            cbPeopleFilterBox.Text = "None";
            cbPeopleFilterBox.SelectedIndexChanged += cbPeopleFilterBox_SelectedIndexChanged;
            // 
            // mtbPeopleFilterInput
            // 
            mtbPeopleFilterInput.BackColor = Color.Gainsboro;
            mtbPeopleFilterInput.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbPeopleFilterInput.ForeColor = SystemColors.InfoText;
            mtbPeopleFilterInput.Location = new Point(226, 445);
            mtbPeopleFilterInput.Name = "mtbPeopleFilterInput";
            mtbPeopleFilterInput.Size = new Size(203, 34);
            mtbPeopleFilterInput.TabIndex = 222;
            mtbPeopleFilterInput.TextChanged += mtbPeopleFilterInput_TextChanged;
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1570, 1084);
            Controls.Add(mtbPeopleFilterInput);
            Controls.Add(cbPeopleFilterBox);
            Controls.Add(lblPeopleFilter);
            Controls.Add(btnAddNewPerson);
            Controls.Add(lblPeopleTotalRecordsNb);
            Controls.Add(lblPeopleTotalRecords);
            Controls.Add(dgvPeople);
            Controls.Add(lblPeopleTitle);
            Controls.Add(btnPeopleCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPeople";
            StartPosition = FormStartPosition.Manual;
            Text = "frmPeople";
            Load += frmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbPeopleFilterBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonPictureBox btnPeopleCancel;
        private Krypton.Toolkit.KryptonLabel lblPeopleTitle;
        private Krypton.Toolkit.KryptonDataGridView dgvPeople;
        private Krypton.Toolkit.KryptonLabel lblPeopleTotalRecords;
        private Krypton.Toolkit.KryptonLabel lblPeopleTotalRecordsNb;
        private Krypton.Toolkit.KryptonButton btnAddNewPerson;
        private Krypton.Toolkit.KryptonLabel lblPeopleFilter;
        private Krypton.Toolkit.KryptonComboBox cbPeopleFilterBox;
       
        private MaskedTextBox mtbPeopleFilterInput;
    }
}