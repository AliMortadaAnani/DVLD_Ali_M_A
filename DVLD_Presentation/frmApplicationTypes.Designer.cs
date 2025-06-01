namespace DVLD_Presentation
{
    partial class frmApplicationTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmApplicationTypes));
            toolTipCancel = new ToolTip(components);
            btnPeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            lblPeopleTitle = new Krypton.Toolkit.KryptonLabel();
            lblappsTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblPeopleTotalRecords = new Krypton.Toolkit.KryptonLabel();
            dgvapps = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvapps).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
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
            lblPeopleTitle.Size = new Size(384, 107);
            lblPeopleTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTitle.TabIndex = 211;
            lblPeopleTitle.TabStop = false;
            lblPeopleTitle.Values.Text = "Application Types";
            // 
            // lblappsTotalRecordsNb
            // 
            lblappsTotalRecordsNb.AutoSize = false;
            lblappsTotalRecordsNb.Location = new Point(759, 655);
            lblappsTotalRecordsNb.Name = "lblappsTotalRecordsNb";
            lblappsTotalRecordsNb.Size = new Size(71, 47);
            lblappsTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblappsTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblappsTotalRecordsNb.TabIndex = 215;
            lblappsTotalRecordsNb.TabStop = false;
            lblappsTotalRecordsNb.Values.Text = "0";
            // 
            // lblPeopleTotalRecords
            // 
            lblPeopleTotalRecords.AutoSize = false;
            lblPeopleTotalRecords.Location = new Point(575, 655);
            lblPeopleTotalRecords.Name = "lblPeopleTotalRecords";
            lblPeopleTotalRecords.Size = new Size(191, 47);
            lblPeopleTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTotalRecords.TabIndex = 214;
            lblPeopleTotalRecords.TabStop = false;
            lblPeopleTotalRecords.Values.Text = "Total Records : ";
            lblPeopleTotalRecords.Click += lblPeopleTotalRecords_Click;
            // 
            // dgvapps
            // 
            dgvapps.AllowUserToAddRows = false;
            dgvapps.AllowUserToDeleteRows = false;
            dgvapps.AllowUserToResizeColumns = false;
            dgvapps.AllowUserToResizeRows = false;
            dgvapps.AutoGenerateKryptonColumns = false;
            dgvapps.BorderStyle = BorderStyle.Fixed3D;
            dgvapps.ColumnHeadersHeight = 60;
            dgvapps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvapps.ContextMenuStrip = contextMenuStrip1;
            dgvapps.Cursor = Cursors.Hand;
            dgvapps.Dock = DockStyle.Bottom;
            dgvapps.Location = new Point(0, 708);
            dgvapps.Name = "dgvapps";
            dgvapps.ReadOnly = true;
            dgvapps.RowHeadersVisible = false;
            dgvapps.RowHeadersWidth = 100;
            dgvapps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvapps.ShowEditingIcon = false;
            dgvapps.ShowRowErrors = false;
            dgvapps.Size = new Size(1783, 379);
            dgvapps.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvapps.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvapps.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvapps.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvapps.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvapps.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvapps.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvapps.TabIndex = 213;
            dgvapps.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F);
            contextMenuStrip1.ImageScalingSize = new Size(36, 36);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editApplicationTypeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(272, 48);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            editApplicationTypeToolStripMenuItem.Image = Properties.Resources.application;
            editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            editApplicationTypeToolStripMenuItem.Size = new Size(271, 44);
            editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            editApplicationTypeToolStripMenuItem.Click += editApplicationTypeToolStripMenuItem_Click;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Cursor = Cursors.Hand;
            kryptonPictureBox1.Image = (Image)resources.GetObject("kryptonPictureBox1.Image");
            kryptonPictureBox1.Location = new Point(1410, 30);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(150, 100);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 210;
            kryptonPictureBox1.TabStop = false;
            kryptonPictureBox1.Click += btnPeopleCancel_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.AutoSize = false;
            kryptonLabel1.Location = new Point(585, 2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(384, 107);
            kryptonLabel1.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 211;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "Application Types";
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 216;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1783, 1087);
            Controls.Add(btnDocumentation);
            Controls.Add(lblappsTotalRecordsNb);
            Controls.Add(lblPeopleTotalRecords);
            Controls.Add(dgvapps);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonPictureBox1);
            Controls.Add(lblPeopleTitle);
            Controls.Add(btnPeopleCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmApplicationTypes";
            Text = "frmApplicationTypes";
            Load += frmApplicationTypes_Load;
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvapps).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTipCancel;
        private Krypton.Toolkit.KryptonPictureBox btnPeopleCancel;
        private Krypton.Toolkit.KryptonLabel lblPeopleTitle;
        private Krypton.Toolkit.KryptonLabel lblappsTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblPeopleTotalRecords;
        private Krypton.Toolkit.KryptonDataGridView dgvapps;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}