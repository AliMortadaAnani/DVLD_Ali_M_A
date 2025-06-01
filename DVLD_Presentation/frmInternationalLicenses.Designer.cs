namespace DVLD_Presentation
{
    partial class frmInternationalLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalLicenses));
            btnLocalAddNew = new Krypton.Toolkit.KryptonButton();
            lblLocalTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblLocalTotalRecords = new Krypton.Toolkit.KryptonLabel();
            dgvLocal = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStripLocal = new ContextMenuStrip(components);
            showLicenseStripMenuItem = new ToolStripMenuItem();
            showLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            cbUsersFilterBox = new Krypton.Toolkit.KryptonComboBox();
            lblUsersFilter = new Krypton.Toolkit.KryptonLabel();
            mtbUsersFilterInput = new MaskedTextBox();
            cbUsersStatusOptions = new Krypton.Toolkit.KryptonComboBox();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocal).BeginInit();
            contextMenuStripLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbUsersFilterBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbUsersStatusOptions).BeginInit();
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
            // btnLocalAddNew
            // 
            btnLocalAddNew.Location = new Point(1067, 521);
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
            btnLocalAddNew.TabIndex = 241;
            btnLocalAddNew.Values.DropDownArrowColor = Color.Empty;
            btnLocalAddNew.Values.Text = "Issue New International Driving License";
            btnLocalAddNew.Click += btnLocalAddNew_Click;
            // 
            // lblLocalTotalRecordsNb
            // 
            lblLocalTotalRecordsNb.AutoSize = false;
            lblLocalTotalRecordsNb.Location = new Point(756, 537);
            lblLocalTotalRecordsNb.Name = "lblLocalTotalRecordsNb";
            lblLocalTotalRecordsNb.Size = new Size(71, 47);
            lblLocalTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblLocalTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalTotalRecordsNb.TabIndex = 233;
            lblLocalTotalRecordsNb.TabStop = false;
            lblLocalTotalRecordsNb.Values.Text = "0";
            // 
            // lblLocalTotalRecords
            // 
            lblLocalTotalRecords.AutoSize = false;
            lblLocalTotalRecords.Location = new Point(581, 536);
            lblLocalTotalRecords.Name = "lblLocalTotalRecords";
            lblLocalTotalRecords.Size = new Size(191, 47);
            lblLocalTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblLocalTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalTotalRecords.TabIndex = 232;
            lblLocalTotalRecords.TabStop = false;
            lblLocalTotalRecords.Values.Text = "Total Records : ";
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
            dgvLocal.Location = new Point(0, 590);
            dgvLocal.Name = "dgvLocal";
            dgvLocal.ReadOnly = true;
            dgvLocal.RowHeadersVisible = false;
            dgvLocal.RowHeadersWidth = 100;
            dgvLocal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocal.ShowEditingIcon = false;
            dgvLocal.ShowRowErrors = false;
            dgvLocal.Size = new Size(1570, 494);
            dgvLocal.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvLocal.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvLocal.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvLocal.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvLocal.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvLocal.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvLocal.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvLocal.TabIndex = 240;
            dgvLocal.TabStop = false;
            // 
            // contextMenuStripLocal
            // 
            contextMenuStripLocal.BackColor = Color.Gainsboro;
            contextMenuStripLocal.Font = new Font("Segoe UI", 9F);
            contextMenuStripLocal.ImageScalingSize = new Size(36, 36);
            contextMenuStripLocal.Items.AddRange(new ToolStripItem[] { showLicenseStripMenuItem, showLicenseHistoryToolStripMenuItem });
            contextMenuStripLocal.Name = "contextMenuStripPeople";
            contextMenuStripLocal.Size = new Size(372, 92);
            // 
            // showLicenseStripMenuItem
            // 
            showLicenseStripMenuItem.Image = Properties.Resources.infoPerson;
            showLicenseStripMenuItem.Name = "showLicenseStripMenuItem";
            showLicenseStripMenuItem.Size = new Size(371, 44);
            showLicenseStripMenuItem.Text = "Show International License Details";
            showLicenseStripMenuItem.Click += showLicenseStripMenuItem_Click;
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            showLicenseHistoryToolStripMenuItem.Image = (Image)resources.GetObject("showLicenseHistoryToolStripMenuItem.Image");
            showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            showLicenseHistoryToolStripMenuItem.Size = new Size(371, 44);
            showLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            showLicenseHistoryToolStripMenuItem.Click += showLicenseHistoryToolStripMenuItem_Click;
            // 
            // cbUsersFilterBox
            // 
            cbUsersFilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsersFilterBox.DropDownWidth = 175;
            cbUsersFilterBox.Items.AddRange(new object[] { "None", "InternationalLicenseID", "LocalLicenseID", "DriverID", "IsActive" });
            cbUsersFilterBox.Location = new Point(0, 538);
            cbUsersFilterBox.MaxDropDownItems = 12;
            cbUsersFilterBox.Name = "cbUsersFilterBox";
            cbUsersFilterBox.Size = new Size(216, 33);
            cbUsersFilterBox.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbUsersFilterBox.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersFilterBox.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersFilterBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbUsersFilterBox.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersFilterBox.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersFilterBox.TabIndex = 236;
            cbUsersFilterBox.Text = "None";
            cbUsersFilterBox.SelectedIndexChanged += cbUsersFilterBox_SelectedIndexChanged;
            // 
            // lblUsersFilter
            // 
            lblUsersFilter.AutoSize = false;
            lblUsersFilter.Location = new Point(0, 498);
            lblUsersFilter.Name = "lblUsersFilter";
            lblUsersFilter.Size = new Size(123, 47);
            lblUsersFilter.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUsersFilter.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsersFilter.TabIndex = 235;
            lblUsersFilter.TabStop = false;
            lblUsersFilter.Values.Text = "Filter By:";
            // 
            // mtbUsersFilterInput
            // 
            mtbUsersFilterInput.BackColor = Color.Gainsboro;
            mtbUsersFilterInput.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbUsersFilterInput.ForeColor = SystemColors.InfoText;
            mtbUsersFilterInput.Location = new Point(226, 539);
            mtbUsersFilterInput.Name = "mtbUsersFilterInput";
            mtbUsersFilterInput.Size = new Size(203, 34);
            mtbUsersFilterInput.TabIndex = 237;
            mtbUsersFilterInput.TextChanged += mtbUsersFilterInput_TextChanged;
            // 
            // cbUsersStatusOptions
            // 
            cbUsersStatusOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsersStatusOptions.DropDownWidth = 175;
            cbUsersStatusOptions.Items.AddRange(new object[] { "All", "Active", "Not Active" });
            cbUsersStatusOptions.Location = new Point(226, 539);
            cbUsersStatusOptions.MaxDropDownItems = 12;
            cbUsersStatusOptions.Name = "cbUsersStatusOptions";
            cbUsersStatusOptions.Size = new Size(203, 33);
            cbUsersStatusOptions.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbUsersStatusOptions.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersStatusOptions.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersStatusOptions.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbUsersStatusOptions.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersStatusOptions.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersStatusOptions.TabIndex = 250;
            cbUsersStatusOptions.Text = "All";
            cbUsersStatusOptions.SelectedIndexChanged += cbUsersStatusOptions_SelectedIndexChanged;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 239;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmInternationalLicenses
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(cbUsersFilterBox);
            Controls.Add(lblUsersFilter);
            Controls.Add(mtbUsersFilterInput);
            Controls.Add(cbUsersStatusOptions);
            Controls.Add(btnLocalAddNew);
            Controls.Add(lblLocalTotalRecordsNb);
            Controls.Add(lblLocalTotalRecords);
            Controls.Add(dgvLocal);
            Name = "frmInternationalLicenses";
            StartPosition = FormStartPosition.Manual;
            Text = "frmInternationalLicenses";
            Load += frmInternationalLicenses_Load;
            Controls.SetChildIndex(dgvLocal, 0);
            Controls.SetChildIndex(lblLocalTotalRecords, 0);
            Controls.SetChildIndex(lblLocalTotalRecordsNb, 0);
            Controls.SetChildIndex(btnLocalAddNew, 0);
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(cbUsersStatusOptions, 0);
            Controls.SetChildIndex(mtbUsersFilterInput, 0);
            Controls.SetChildIndex(lblUsersFilter, 0);
            Controls.SetChildIndex(cbUsersFilterBox, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocal).EndInit();
            contextMenuStripLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbUsersFilterBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbUsersStatusOptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnLocalAddNew;
        private Krypton.Toolkit.KryptonLabel lblLocalTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblLocalTotalRecords;
        private Krypton.Toolkit.KryptonDataGridView dgvLocal;
        private ContextMenuStrip contextMenuStripLocal;
        private ToolStripMenuItem showLicenseStripMenuItem;
        private ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
        private Krypton.Toolkit.KryptonComboBox cbUsersFilterBox;
        private Krypton.Toolkit.KryptonLabel lblUsersFilter;
        private MaskedTextBox mtbUsersFilterInput;
        private Krypton.Toolkit.KryptonComboBox cbUsersStatusOptions;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}