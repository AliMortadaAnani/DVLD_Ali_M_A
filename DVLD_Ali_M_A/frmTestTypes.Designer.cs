namespace DVLD_Presentation
{
    partial class frmTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestTypes));
            toolTipCancel = new ToolTip(components);
            btnPeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            lblPeopleTitle = new Krypton.Toolkit.KryptonLabel();
            lbltestsTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblPeopleTotalRecords = new Krypton.Toolkit.KryptonLabel();
            dgvtests = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editTestTypeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvtests).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolTipCancel
            // 
            toolTipCancel.BackColor = Color.Gainsboro;
            toolTipCancel.ForeColor = Color.DarkSlateBlue;
            // 
            // btnPeopleCancel
            // 
            btnPeopleCancel.Cursor = Cursors.Hand;
            btnPeopleCancel.Image = (Image)resources.GetObject("btnPeopleCancel.Image");
            btnPeopleCancel.Location = new Point(1400, 30);
            btnPeopleCancel.Name = "btnPeopleCancel";
            btnPeopleCancel.Size = new Size(150, 100);
            btnPeopleCancel.SizeMode = PictureBoxSizeMode.Zoom;
            btnPeopleCancel.TabIndex = 210;
            btnPeopleCancel.TabStop = false;
            toolTipCancel.SetToolTip(btnPeopleCancel, "Close");
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
            lblPeopleTitle.TabIndex = 211;
            lblPeopleTitle.TabStop = false;
            lblPeopleTitle.Values.Text = "Test Types";
            // 
            // lbltestsTotalRecordsNb
            // 
            lbltestsTotalRecordsNb.AutoSize = false;
            lbltestsTotalRecordsNb.Location = new Point(754, 558);
            lbltestsTotalRecordsNb.Name = "lbltestsTotalRecordsNb";
            lbltestsTotalRecordsNb.Size = new Size(71, 47);
            lbltestsTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbltestsTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltestsTotalRecordsNb.TabIndex = 215;
            lbltestsTotalRecordsNb.TabStop = false;
            lbltestsTotalRecordsNb.Values.Text = "0";
            // 
            // lblPeopleTotalRecords
            // 
            lblPeopleTotalRecords.AutoSize = false;
            lblPeopleTotalRecords.Location = new Point(575, 558);
            lblPeopleTotalRecords.Name = "lblPeopleTotalRecords";
            lblPeopleTotalRecords.Size = new Size(191, 47);
            lblPeopleTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTotalRecords.TabIndex = 214;
            lblPeopleTotalRecords.TabStop = false;
            lblPeopleTotalRecords.Values.Text = "Total Records : ";
            // 
            // dgvtests
            // 
            dgvtests.AllowUserToAddRows = false;
            dgvtests.AllowUserToDeleteRows = false;
            dgvtests.AllowUserToResizeColumns = false;
            dgvtests.AllowUserToResizeRows = false;
            dgvtests.AutoGenerateKryptonColumns = false;
            dgvtests.BorderStyle = BorderStyle.Fixed3D;
            dgvtests.ColumnHeadersHeight = 60;
            dgvtests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvtests.ContextMenuStrip = contextMenuStrip1;
            dgvtests.Cursor = Cursors.Hand;
            dgvtests.Dock = DockStyle.Bottom;
            dgvtests.Location = new Point(0, 611);
            dgvtests.Name = "dgvtests";
            dgvtests.ReadOnly = true;
            dgvtests.RowHeadersVisible = false;
            dgvtests.RowHeadersWidth = 100;
            dgvtests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvtests.ShowEditingIcon = false;
            dgvtests.ShowRowErrors = false;
            dgvtests.Size = new Size(1689, 475);
            dgvtests.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvtests.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvtests.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvtests.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvtests.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvtests.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvtests.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvtests.TabIndex = 213;
            dgvtests.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F);
            contextMenuStrip1.ImageScalingSize = new Size(36, 36);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editTestTypeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 48);
            // 
            // editTestTypeToolStripMenuItem
            // 
            editTestTypeToolStripMenuItem.Image = Properties.Resources.exam;
            editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            editTestTypeToolStripMenuItem.Size = new Size(211, 44);
            editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            editTestTypeToolStripMenuItem.Click += editTestTypeToolStripMenuItem_Click;
            // 
            // frmTestTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1689, 1086);
            Controls.Add(lbltestsTotalRecordsNb);
            Controls.Add(lblPeopleTotalRecords);
            Controls.Add(dgvtests);
            Controls.Add(lblPeopleTitle);
            Controls.Add(btnPeopleCancel);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTestTypes";
            Text = "frmTestTypes";
            Load += frmTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvtests).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTipCancel;
        private Krypton.Toolkit.KryptonPictureBox btnPeopleCancel;
        private Krypton.Toolkit.KryptonLabel lblPeopleTitle;
        private Krypton.Toolkit.KryptonLabel lbltestsTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblPeopleTotalRecords;
        private Krypton.Toolkit.KryptonDataGridView dgvtests;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}