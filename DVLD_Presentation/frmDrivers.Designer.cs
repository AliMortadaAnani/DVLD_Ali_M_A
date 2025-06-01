namespace DVLD_Presentation
{
    partial class frmDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            mtbPeopleFilterInput = new MaskedTextBox();
            cbPeopleFilterBox = new Krypton.Toolkit.KryptonComboBox();
            lblPeopleFilter = new Krypton.Toolkit.KryptonLabel();
            lblPeopleTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblPeopleTotalRecords = new Krypton.Toolkit.KryptonLabel();
            dgvPeople = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStripLocal = new ContextMenuStrip(components);
            showLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbPeopleFilterBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            contextMenuStripLocal.SuspendLayout();
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
            // mtbPeopleFilterInput
            // 
            mtbPeopleFilterInput.BackColor = Color.Gainsboro;
            mtbPeopleFilterInput.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbPeopleFilterInput.ForeColor = SystemColors.InfoText;
            mtbPeopleFilterInput.Location = new Point(226, 445);
            mtbPeopleFilterInput.Name = "mtbPeopleFilterInput";
            mtbPeopleFilterInput.Size = new Size(203, 34);
            mtbPeopleFilterInput.TabIndex = 219;
            mtbPeopleFilterInput.TextChanged += mtbPeopleFilterInput_TextChanged;
            // 
            // cbPeopleFilterBox
            // 
            cbPeopleFilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPeopleFilterBox.DropDownWidth = 175;
            cbPeopleFilterBox.Items.AddRange(new object[] { "None", "ID", "PersonID", "NationalNumber", "YearOfBirth", "FullName", "ActiveLicensesNumber" });
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
            cbPeopleFilterBox.TabIndex = 218;
            cbPeopleFilterBox.Text = "None";
            cbPeopleFilterBox.SelectedIndexChanged += cbPeopleFilterBox_SelectedIndexChanged;
            // 
            // lblPeopleFilter
            // 
            lblPeopleFilter.AutoSize = false;
            lblPeopleFilter.Location = new Point(0, 405);
            lblPeopleFilter.Name = "lblPeopleFilter";
            lblPeopleFilter.Size = new Size(123, 47);
            lblPeopleFilter.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleFilter.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleFilter.TabIndex = 223;
            lblPeopleFilter.TabStop = false;
            lblPeopleFilter.Values.Text = "Filter By:";
            // 
            // lblPeopleTotalRecordsNb
            // 
            lblPeopleTotalRecordsNb.AutoSize = false;
            lblPeopleTotalRecordsNb.Location = new Point(760, 431);
            lblPeopleTotalRecordsNb.Name = "lblPeopleTotalRecordsNb";
            lblPeopleTotalRecordsNb.Size = new Size(71, 47);
            lblPeopleTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTotalRecordsNb.TabIndex = 222;
            lblPeopleTotalRecordsNb.TabStop = false;
            lblPeopleTotalRecordsNb.Values.Text = "0";
            // 
            // lblPeopleTotalRecords
            // 
            lblPeopleTotalRecords.AutoSize = false;
            lblPeopleTotalRecords.Location = new Point(585, 431);
            lblPeopleTotalRecords.Name = "lblPeopleTotalRecords";
            lblPeopleTotalRecords.Size = new Size(191, 47);
            lblPeopleTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTotalRecords.TabIndex = 221;
            lblPeopleTotalRecords.TabStop = false;
            lblPeopleTotalRecords.Values.Text = "Total Records : ";
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
            dgvPeople.ContextMenuStrip = contextMenuStripLocal;
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
            dgvPeople.TabIndex = 220;
            dgvPeople.TabStop = false;
            // 
            // contextMenuStripLocal
            // 
            contextMenuStripLocal.BackColor = Color.Gainsboro;
            contextMenuStripLocal.Font = new Font("Segoe UI", 9F);
            contextMenuStripLocal.ImageScalingSize = new Size(36, 36);
            contextMenuStripLocal.Items.AddRange(new ToolStripItem[] { showLicenseHistoryToolStripMenuItem });
            contextMenuStripLocal.Name = "contextMenuStripPeople";
            contextMenuStripLocal.Size = new Size(330, 48);
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            showLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseHistoryToolStripMenuItem.Image");
            showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            showLicenseHistoryToolStripMenuItem.Size = new Size(329, 44);
            showLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showLicenseHistoryToolStripMenuItem.Click += showLicenseHistoryToolStripMenuItem_Click;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 224;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmDrivers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(mtbPeopleFilterInput);
            Controls.Add(cbPeopleFilterBox);
            Controls.Add(lblPeopleFilter);
            Controls.Add(lblPeopleTotalRecordsNb);
            Controls.Add(lblPeopleTotalRecords);
            Controls.Add(dgvPeople);
            Name = "frmDrivers";
            StartPosition = FormStartPosition.Manual;
            Text = "frmDrivers";
            Load += frmDrivers_Load;
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(dgvPeople, 0);
            Controls.SetChildIndex(lblPeopleTotalRecords, 0);
            Controls.SetChildIndex(lblPeopleTotalRecordsNb, 0);
            Controls.SetChildIndex(lblPeopleFilter, 0);
            Controls.SetChildIndex(cbPeopleFilterBox, 0);
            Controls.SetChildIndex(mtbPeopleFilterInput, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbPeopleFilterBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            contextMenuStripLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbPeopleFilterInput;
        private Krypton.Toolkit.KryptonComboBox cbPeopleFilterBox;
        private Krypton.Toolkit.KryptonLabel lblPeopleFilter;
        private Krypton.Toolkit.KryptonLabel lblPeopleTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblPeopleTotalRecords;
        private Krypton.Toolkit.KryptonDataGridView dgvPeople;
        private ContextMenuStrip contextMenuStripLocal;
        private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}