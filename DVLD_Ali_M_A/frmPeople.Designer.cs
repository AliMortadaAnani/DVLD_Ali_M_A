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
            PeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            PeopleTitle = new Krypton.Toolkit.KryptonLabel();
            dgvPeople = new Krypton.Toolkit.KryptonDataGridView();
            PeopleTotalRecords = new Krypton.Toolkit.KryptonLabel();
            PeopleTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            AddNewPerson = new Krypton.Toolkit.KryptonButton();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonMaskedTextBox1 = new Krypton.Toolkit.KryptonMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)PeopleCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // PeopleCancel
            // 
            PeopleCancel.Cursor = Cursors.Hand;
            PeopleCancel.Image = (Image)resources.GetObject("PeopleCancel.Image");
            PeopleCancel.Location = new Point(1400, 30);
            PeopleCancel.Name = "PeopleCancel";
            PeopleCancel.Size = new Size(150, 100);
            PeopleCancel.SizeMode = PictureBoxSizeMode.Zoom;
            PeopleCancel.TabIndex = 203;
            PeopleCancel.TabStop = false;
            toolTip1.SetToolTip(PeopleCancel, "Close");
            PeopleCancel.Click += PeopleCancel_Click;
            // 
            // PeopleTitle
            // 
            PeopleTitle.AutoSize = false;
            PeopleTitle.Location = new Point(575, 2);
            PeopleTitle.Name = "PeopleTitle";
            PeopleTitle.Size = new Size(347, 107);
            PeopleTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            PeopleTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PeopleTitle.TabIndex = 209;
            PeopleTitle.TabStop = false;
            PeopleTitle.Values.Text = "Manage People";
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
            // PeopleTotalRecords
            // 
            PeopleTotalRecords.AutoSize = false;
            PeopleTotalRecords.Location = new Point(0, 421);
            PeopleTotalRecords.Name = "PeopleTotalRecords";
            PeopleTotalRecords.Size = new Size(191, 47);
            PeopleTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            PeopleTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PeopleTotalRecords.TabIndex = 211;
            PeopleTotalRecords.TabStop = false;
            PeopleTotalRecords.Values.Text = "Total Records : ";
            // 
            // PeopleTotalRecordsNb
            // 
            PeopleTotalRecordsNb.AutoSize = false;
            PeopleTotalRecordsNb.Location = new Point(175, 421);
            PeopleTotalRecordsNb.Name = "PeopleTotalRecordsNb";
            PeopleTotalRecordsNb.Size = new Size(40, 47);
            PeopleTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            PeopleTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PeopleTotalRecordsNb.TabIndex = 212;
            PeopleTotalRecordsNb.TabStop = false;
            PeopleTotalRecordsNb.Values.Text = "0";
            // 
            // AddNewPerson
            // 
            AddNewPerson.Location = new Point(1337, 405);
            AddNewPerson.Name = "AddNewPerson";
            AddNewPerson.OverrideDefault.Back.Color1 = Color.Silver;
            AddNewPerson.OverrideDefault.Border.Rounding = 50F;
            AddNewPerson.OverrideFocus.Back.Color1 = Color.Silver;
            AddNewPerson.OverrideFocus.Border.Rounding = 50F;
            AddNewPerson.Size = new Size(221, 63);
            AddNewPerson.StateDisabled.Back.Color1 = Color.Silver;
            AddNewPerson.StateDisabled.Border.Rounding = 50F;
            AddNewPerson.StateNormal.Back.Color1 = Color.Silver;
            AddNewPerson.StateNormal.Back.Color2 = Color.Silver;
            AddNewPerson.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            AddNewPerson.StateNormal.Border.Rounding = 50F;
            AddNewPerson.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            AddNewPerson.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewPerson.StatePressed.Back.Color1 = Color.Silver;
            AddNewPerson.StatePressed.Back.Color2 = Color.Silver;
            AddNewPerson.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            AddNewPerson.StatePressed.Border.Color1 = Color.Gainsboro;
            AddNewPerson.StatePressed.Border.Color2 = Color.Gainsboro;
            AddNewPerson.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            AddNewPerson.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            AddNewPerson.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            AddNewPerson.StatePressed.Border.Rounding = 50F;
            AddNewPerson.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            AddNewPerson.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewPerson.StateTracking.Back.Color1 = Color.Silver;
            AddNewPerson.StateTracking.Back.Color2 = Color.Silver;
            AddNewPerson.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            AddNewPerson.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            AddNewPerson.StateTracking.Border.Color1 = Color.Gainsboro;
            AddNewPerson.StateTracking.Border.Color2 = Color.Gainsboro;
            AddNewPerson.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            AddNewPerson.StateTracking.Border.Rounding = 50F;
            AddNewPerson.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            AddNewPerson.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            AddNewPerson.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            AddNewPerson.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            AddNewPerson.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewPerson.TabIndex = 213;
            AddNewPerson.Values.DropDownArrowColor = Color.Empty;
            AddNewPerson.Values.Text = "Add New Person";
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.DropDownWidth = 216;
            kryptonComboBox1.Items.AddRange(new object[] { "name", "location" });
            kryptonComboBox1.Location = new Point(404, 293);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(216, 30);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 214;
            kryptonComboBox1.Text = "None";
            kryptonComboBox1.SelectedIndexChanged += kryptonComboBox1_SelectedIndexChanged;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(657, 297);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(150, 32);
            kryptonTextBox1.TabIndex = 215;
            kryptonTextBox1.Text = "kryptonTextBox1";
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // kryptonMaskedTextBox1
            // 
            kryptonMaskedTextBox1.Location = new Point(702, 183);
            kryptonMaskedTextBox1.Name = "kryptonMaskedTextBox1";
            kryptonMaskedTextBox1.Size = new Size(150, 32);
            kryptonMaskedTextBox1.TabIndex = 216;
            kryptonMaskedTextBox1.Text = "kryptonMaskedTextBox1";
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1570, 1084);
            Controls.Add(kryptonMaskedTextBox1);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonComboBox1);
            Controls.Add(AddNewPerson);
            Controls.Add(PeopleTotalRecordsNb);
            Controls.Add(PeopleTotalRecords);
            Controls.Add(dgvPeople);
            Controls.Add(PeopleTitle);
            Controls.Add(PeopleCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPeople";
            StartPosition = FormStartPosition.Manual;
            Text = "frmPeople";
            Load += frmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)PeopleCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonPictureBox PeopleCancel;
        private Krypton.Toolkit.KryptonLabel PeopleTitle;
        private Krypton.Toolkit.KryptonDataGridView dgvPeople;
        private Krypton.Toolkit.KryptonLabel PeopleTotalRecords;
        private Krypton.Toolkit.KryptonLabel PeopleTotalRecordsNb;
        private Krypton.Toolkit.KryptonButton AddNewPerson;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox1;
    }
}