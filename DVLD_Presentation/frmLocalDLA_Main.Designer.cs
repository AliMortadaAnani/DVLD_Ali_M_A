namespace DVLD_Presentation
{
    partial class frmLocalDLA_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDLA_Main));
            dgvLocal = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStripLocal = new ContextMenuStrip(components);
            CancelApplicationtoolStripMenuItem1 = new ToolStripMenuItem();
            updateApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            showApplicationToolStripMenuItem = new ToolStripMenuItem();
            scheduleTestToolStripMenuItem = new ToolStripMenuItem();
            visionTestToolStripMenuItem = new ToolStripMenuItem();
            writtenTestToolStripMenuItem = new ToolStripMenuItem();
            drivingTestToolStripMenuItem1 = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseStripMenuItem = new ToolStripMenuItem();
            showLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            btnLocalAddNew = new Krypton.Toolkit.KryptonButton();
            lblLocalTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblLocalTotalRecords = new Krypton.Toolkit.KryptonLabel();
            cbLocalFilterBox = new Krypton.Toolkit.KryptonComboBox();
            lblLocalFilter = new Krypton.Toolkit.KryptonLabel();
            mtbLocalFilterInput = new MaskedTextBox();
            cbLocalStatusOptions = new Krypton.Toolkit.KryptonComboBox();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocal).BeginInit();
            contextMenuStripLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbLocalFilterBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbLocalStatusOptions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // btnGeneralCancel
            // 
            toolTipCancel.SetToolTip(btnGeneralCancel, "Close");
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.Size = new Size(440, 151);
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Manage Local Driving\r\nLicenses Applications";
            // 
            // dgvLocal
            // 
            dgvLocal.AllowUserToAddRows = false;
            dgvLocal.AllowUserToDeleteRows = false;
            dgvLocal.AllowUserToResizeColumns = false;
            dgvLocal.AllowUserToResizeRows = false;
            dgvLocal.AutoGenerateKryptonColumns = false;
            dgvLocal.BorderStyle = BorderStyle.Fixed3D;
            dgvLocal.ColumnHeadersHeight = 60;
            dgvLocal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLocal.ContextMenuStrip = contextMenuStripLocal;
            dgvLocal.Cursor = Cursors.Hand;
            dgvLocal.Dock = DockStyle.Bottom;
            dgvLocal.Location = new Point(0, 484);
            dgvLocal.Name = "dgvLocal";
            dgvLocal.ReadOnly = true;
            dgvLocal.RowHeadersVisible = false;
            dgvLocal.RowHeadersWidth = 100;
            dgvLocal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocal.ShowEditingIcon = false;
            dgvLocal.ShowRowErrors = false;
            dgvLocal.Size = new Size(1570, 600);
            dgvLocal.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvLocal.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvLocal.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvLocal.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvLocal.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvLocal.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvLocal.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvLocal.TabIndex = 220;
            dgvLocal.TabStop = false;
            // 
            // contextMenuStripLocal
            // 
            contextMenuStripLocal.BackColor = Color.Gainsboro;
            contextMenuStripLocal.Font = new Font("Segoe UI", 9F);
            contextMenuStripLocal.ImageScalingSize = new Size(36, 36);
            contextMenuStripLocal.Items.AddRange(new ToolStripItem[] { CancelApplicationtoolStripMenuItem1, updateApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, showApplicationToolStripMenuItem, scheduleTestToolStripMenuItem, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseStripMenuItem, showLicenseHistoryToolStripMenuItem });
            contextMenuStripLocal.Name = "contextMenuStripPeople";
            contextMenuStripLocal.Size = new Size(359, 356);
            contextMenuStripLocal.Opening += contextMenuStripLocal_Opening;
            // 
            // CancelApplicationtoolStripMenuItem1
            // 
            CancelApplicationtoolStripMenuItem1.Image = Properties.Resources.CancelApp;
            CancelApplicationtoolStripMenuItem1.Name = "CancelApplicationtoolStripMenuItem1";
            CancelApplicationtoolStripMenuItem1.Size = new Size(358, 44);
            CancelApplicationtoolStripMenuItem1.Text = "Cancel Application";
            CancelApplicationtoolStripMenuItem1.Click += CancelApplicationtoolStripMenuItem1_Click;
            // 
            // updateApplicationToolStripMenuItem
            // 
            updateApplicationToolStripMenuItem.Image = Properties.Resources.editPerson;
            updateApplicationToolStripMenuItem.Name = "updateApplicationToolStripMenuItem";
            updateApplicationToolStripMenuItem.Size = new Size(358, 44);
            updateApplicationToolStripMenuItem.Text = "Update Application";
            updateApplicationToolStripMenuItem.Click += updateApplicationToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.deleteapp;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(358, 44);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // showApplicationToolStripMenuItem
            // 
            showApplicationToolStripMenuItem.Image = Properties.Resources.showapp;
            showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            showApplicationToolStripMenuItem.Size = new Size(358, 44);
            showApplicationToolStripMenuItem.Text = "Show Application";
            showApplicationToolStripMenuItem.Click += showApplicationToolStripMenuItem_Click;
            // 
            // scheduleTestToolStripMenuItem
            // 
            scheduleTestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visionTestToolStripMenuItem, writtenTestToolStripMenuItem, drivingTestToolStripMenuItem1 });
            scheduleTestToolStripMenuItem.Image = Properties.Resources.scheduletest;
            scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            scheduleTestToolStripMenuItem.Size = new Size(358, 44);
            scheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // visionTestToolStripMenuItem
            // 
            visionTestToolStripMenuItem.Image = Properties.Resources.vision;
            visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            visionTestToolStripMenuItem.Size = new Size(295, 46);
            visionTestToolStripMenuItem.Text = "Schedule Vision Test";
            visionTestToolStripMenuItem.Click += visionTestToolStripMenuItem_Click;
            // 
            // writtenTestToolStripMenuItem
            // 
            writtenTestToolStripMenuItem.Image = Properties.Resources.writing;
            writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            writtenTestToolStripMenuItem.Size = new Size(295, 46);
            writtenTestToolStripMenuItem.Text = "Schedule Written Test";
            writtenTestToolStripMenuItem.Click += writtenTestToolStripMenuItem_Click;
            // 
            // drivingTestToolStripMenuItem1
            // 
            drivingTestToolStripMenuItem1.Image = Properties.Resources.street;
            drivingTestToolStripMenuItem1.Name = "drivingTestToolStripMenuItem1";
            drivingTestToolStripMenuItem1.Size = new Size(295, 46);
            drivingTestToolStripMenuItem1.Text = "Schedule Driving Test";
            drivingTestToolStripMenuItem1.Click += drivingTestToolStripMenuItem1_Click;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.menu_license;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(358, 44);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseStripMenuItem
            // 
            showLicenseStripMenuItem.Image = Properties.Resources.infoPerson;
            showLicenseStripMenuItem.Name = "showLicenseStripMenuItem";
            showLicenseStripMenuItem.Size = new Size(358, 44);
            showLicenseStripMenuItem.Text = "Show License Details";
            showLicenseStripMenuItem.Click += showLicenseStripMenuItem_Click;
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            showLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseHistoryToolStripMenuItem.Image");
            showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            showLicenseHistoryToolStripMenuItem.Size = new Size(358, 44);
            showLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showLicenseHistoryToolStripMenuItem.Click += showLicenseHistoryToolStripMenuItem_Click;
            // 
            // btnLocalAddNew
            // 
            btnLocalAddNew.Location = new Point(1073, 416);
            btnLocalAddNew.Name = "btnLocalAddNew";
            btnLocalAddNew.OverrideDefault.Back.Color1 = Color.Silver;
            btnLocalAddNew.OverrideDefault.Border.Rounding = 50F;
            btnLocalAddNew.OverrideFocus.Back.Color1 = Color.Silver;
            btnLocalAddNew.OverrideFocus.Border.Rounding = 50F;
            btnLocalAddNew.Size = new Size(485, 63);
            btnLocalAddNew.StateDisabled.Back.Color1 = Color.Silver;
            btnLocalAddNew.StateDisabled.Border.Rounding = 50F;
            btnLocalAddNew.StateNormal.Back.Color1 = Color.Silver;
            btnLocalAddNew.StateNormal.Back.Color2 = Color.Silver;
            btnLocalAddNew.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalAddNew.StateNormal.Border.Rounding = 50F;
            btnLocalAddNew.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnLocalAddNew.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalAddNew.StatePressed.Back.Color1 = Color.Silver;
            btnLocalAddNew.StatePressed.Back.Color2 = Color.Silver;
            btnLocalAddNew.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalAddNew.StatePressed.Border.Color1 = Color.Gainsboro;
            btnLocalAddNew.StatePressed.Border.Color2 = Color.Gainsboro;
            btnLocalAddNew.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalAddNew.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalAddNew.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalAddNew.StatePressed.Border.Rounding = 50F;
            btnLocalAddNew.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnLocalAddNew.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalAddNew.StateTracking.Back.Color1 = Color.Silver;
            btnLocalAddNew.StateTracking.Back.Color2 = Color.Silver;
            btnLocalAddNew.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalAddNew.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalAddNew.StateTracking.Border.Color1 = Color.Gainsboro;
            btnLocalAddNew.StateTracking.Border.Color2 = Color.Gainsboro;
            btnLocalAddNew.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalAddNew.StateTracking.Border.Rounding = 50F;
            btnLocalAddNew.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalAddNew.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnLocalAddNew.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnLocalAddNew.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnLocalAddNew.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalAddNew.TabIndex = 230;
            btnLocalAddNew.Values.DropDownArrowColor = Color.Empty;
            btnLocalAddNew.Values.Text = "Add New Local Driving License Application";
            btnLocalAddNew.Click += btnLocalAddNew_Click;
            // 
            // lblLocalTotalRecordsNb
            // 
            lblLocalTotalRecordsNb.AutoSize = false;
            lblLocalTotalRecordsNb.Location = new Point(762, 432);
            lblLocalTotalRecordsNb.Name = "lblLocalTotalRecordsNb";
            lblLocalTotalRecordsNb.Size = new Size(71, 47);
            lblLocalTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblLocalTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalTotalRecordsNb.TabIndex = 229;
            lblLocalTotalRecordsNb.TabStop = false;
            lblLocalTotalRecordsNb.Values.Text = "0";
            // 
            // lblLocalTotalRecords
            // 
            lblLocalTotalRecords.AutoSize = false;
            lblLocalTotalRecords.Location = new Point(587, 431);
            lblLocalTotalRecords.Name = "lblLocalTotalRecords";
            lblLocalTotalRecords.Size = new Size(191, 47);
            lblLocalTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblLocalTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalTotalRecords.TabIndex = 228;
            lblLocalTotalRecords.TabStop = false;
            lblLocalTotalRecords.Values.Text = "Total Records : ";
            // 
            // cbLocalFilterBox
            // 
            cbLocalFilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocalFilterBox.DropDownWidth = 175;
            cbLocalFilterBox.Items.AddRange(new object[] { "None", "ID", "NationalNumber", "FullName", "Status" });
            cbLocalFilterBox.Location = new Point(2, 445);
            cbLocalFilterBox.MaxDropDownItems = 12;
            cbLocalFilterBox.Name = "cbLocalFilterBox";
            cbLocalFilterBox.Size = new Size(216, 33);
            cbLocalFilterBox.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbLocalFilterBox.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbLocalFilterBox.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLocalFilterBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbLocalFilterBox.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbLocalFilterBox.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLocalFilterBox.TabIndex = 226;
            cbLocalFilterBox.Text = "None";
            cbLocalFilterBox.SelectedIndexChanged += cbLocalFilterBox_SelectedIndexChanged;
            // 
            // lblLocalFilter
            // 
            lblLocalFilter.AutoSize = false;
            lblLocalFilter.Location = new Point(2, 405);
            lblLocalFilter.Name = "lblLocalFilter";
            lblLocalFilter.Size = new Size(123, 47);
            lblLocalFilter.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblLocalFilter.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalFilter.TabIndex = 225;
            lblLocalFilter.TabStop = false;
            lblLocalFilter.Values.Text = "Filter By:";
            // 
            // mtbLocalFilterInput
            // 
            mtbLocalFilterInput.BackColor = Color.Gainsboro;
            mtbLocalFilterInput.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbLocalFilterInput.ForeColor = SystemColors.InfoText;
            mtbLocalFilterInput.Location = new Point(228, 446);
            mtbLocalFilterInput.Name = "mtbLocalFilterInput";
            mtbLocalFilterInput.Size = new Size(203, 34);
            mtbLocalFilterInput.TabIndex = 227;
            mtbLocalFilterInput.TextChanged += mtbLocalFilterInput_TextChanged;
            // 
            // cbLocalStatusOptions
            // 
            cbLocalStatusOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocalStatusOptions.DropDownWidth = 175;
            cbLocalStatusOptions.Items.AddRange(new object[] { "All", "New", "Cancelled", "Completed" });
            cbLocalStatusOptions.Location = new Point(228, 447);
            cbLocalStatusOptions.MaxDropDownItems = 12;
            cbLocalStatusOptions.Name = "cbLocalStatusOptions";
            cbLocalStatusOptions.Size = new Size(203, 33);
            cbLocalStatusOptions.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbLocalStatusOptions.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbLocalStatusOptions.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLocalStatusOptions.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbLocalStatusOptions.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbLocalStatusOptions.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLocalStatusOptions.TabIndex = 231;
            cbLocalStatusOptions.SelectedIndexChanged += cbLocalStatusOptions_SelectedIndexChanged;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 232;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmLocalDLA_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(btnLocalAddNew);
            Controls.Add(lblLocalTotalRecordsNb);
            Controls.Add(lblLocalTotalRecords);
            Controls.Add(cbLocalFilterBox);
            Controls.Add(lblLocalFilter);
            Controls.Add(mtbLocalFilterInput);
            Controls.Add(dgvLocal);
            Controls.Add(cbLocalStatusOptions);
            Name = "frmLocalDLA_Main";
            StartPosition = FormStartPosition.Manual;
            Text = "frmLocalDLA_Main";
            Load += frmLocalDLA_Main_Load;
            Controls.SetChildIndex(cbLocalStatusOptions, 0);
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(dgvLocal, 0);
            Controls.SetChildIndex(mtbLocalFilterInput, 0);
            Controls.SetChildIndex(lblLocalFilter, 0);
            Controls.SetChildIndex(cbLocalFilterBox, 0);
            Controls.SetChildIndex(lblLocalTotalRecords, 0);
            Controls.SetChildIndex(lblLocalTotalRecordsNb, 0);
            Controls.SetChildIndex(btnLocalAddNew, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocal).EndInit();
            contextMenuStripLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbLocalFilterBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbLocalStatusOptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvLocal;
        private Krypton.Toolkit.KryptonButton btnLocalAddNew;
        private Krypton.Toolkit.KryptonLabel lblLocalTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblLocalTotalRecords;
        private Krypton.Toolkit.KryptonComboBox cbLocalFilterBox;
        private Krypton.Toolkit.KryptonLabel lblLocalFilter;
        private MaskedTextBox mtbLocalFilterInput;
        private Krypton.Toolkit.KryptonComboBox cbLocalStatusOptions;
        private ContextMenuStrip contextMenuStripLocal;
        private ToolStripMenuItem CancelApplicationtoolStripMenuItem1;
        private ToolStripMenuItem updateApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem showApplicationToolStripMenuItem;
        private ToolStripMenuItem scheduleTestToolStripMenuItem;
        private ToolStripMenuItem visionTestToolStripMenuItem;
        private ToolStripMenuItem writtenTestToolStripMenuItem;
        private ToolStripMenuItem showLicenseStripMenuItem;
        private ToolStripMenuItem drivingTestToolStripMenuItem1;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}