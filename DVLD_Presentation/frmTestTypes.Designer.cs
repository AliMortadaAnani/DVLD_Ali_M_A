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
            toolTipClose = new ToolTip(components);
            btnClose = new Krypton.Toolkit.KryptonPictureBox();
            lblTestTypesTitle = new Krypton.Toolkit.KryptonLabel();
            lbltestsTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblTestTypesTotalRecordsText = new Krypton.Toolkit.KryptonLabel();
            dgvtests = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editTestTypeToolStripMenuItem = new ToolStripMenuItem();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvtests).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // toolTipClose
            // 
            toolTipClose.BackColor = Color.Gainsboro;
            toolTipClose.ForeColor = Color.DarkSlateBlue;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1400, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 100);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 210;
            btnClose.TabStop = false;
            toolTipClose.SetToolTip(btnClose, "Close");
            btnClose.Click += btnPeopleCancel_Click;
            // 
            // lblTestTypesTitle
            // 
            lblTestTypesTitle.AutoSize = false;
            lblTestTypesTitle.Location = new Point(575, 2);
            lblTestTypesTitle.Name = "lblTestTypesTitle";
            lblTestTypesTitle.Size = new Size(347, 107);
            lblTestTypesTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblTestTypesTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypesTitle.TabIndex = 211;
            lblTestTypesTitle.TabStop = false;
            lblTestTypesTitle.Values.Text = "Test Types";
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
            // lblTestTypesTotalRecordsText
            // 
            lblTestTypesTotalRecordsText.AutoSize = false;
            lblTestTypesTotalRecordsText.Location = new Point(575, 558);
            lblTestTypesTotalRecordsText.Name = "lblTestTypesTotalRecordsText";
            lblTestTypesTotalRecordsText.Size = new Size(191, 47);
            lblTestTypesTotalRecordsText.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblTestTypesTotalRecordsText.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypesTotalRecordsText.TabIndex = 214;
            lblTestTypesTotalRecordsText.TabStop = false;
            lblTestTypesTotalRecordsText.Values.Text = "Total Records : ";
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
            // frmTestTypes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1689, 1086);
            Controls.Add(btnDocumentation);
            Controls.Add(lbltestsTotalRecordsNb);
            Controls.Add(lblTestTypesTotalRecordsText);
            Controls.Add(dgvtests);
            Controls.Add(lblTestTypesTitle);
            Controls.Add(btnClose);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTestTypes";
            Text = "frmTestTypes";
            Load += frmTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvtests).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTipClose;
        private Krypton.Toolkit.KryptonPictureBox btnClose;
        private Krypton.Toolkit.KryptonLabel lblTestTypesTitle;
        private Krypton.Toolkit.KryptonLabel lbltestsTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblTestTypesTotalRecordsText;
        private Krypton.Toolkit.KryptonDataGridView dgvtests;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editTestTypeToolStripMenuItem;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}