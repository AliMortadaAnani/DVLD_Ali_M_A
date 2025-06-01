namespace DVLD_Presentation
{
    partial class frmTestAppointments
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
            ctrlLocal_dlA_Details1 = new ctrlLocal_DLA_Details();
            ctrlApplicationShow1 = new ctrlApplicationShow();
            btnTestAppAddNew = new Krypton.Toolkit.KryptonButton();
            lblTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblTotalRecords = new Krypton.Toolkit.KryptonLabel();
            dgvTA = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStripLocal = new ContextMenuStrip(components);
            updateApplicationToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTA).BeginInit();
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
            // ctrlLocal_dlA_Details1
            // 
            ctrlLocal_dlA_Details1._LocalDLA_ID = 0;
            ctrlLocal_dlA_Details1.BackColor = Color.Lavender;
            ctrlLocal_dlA_Details1.Location = new Point(12, 148);
            ctrlLocal_dlA_Details1.Name = "ctrlLocal_dlA_Details1";
            ctrlLocal_dlA_Details1.Size = new Size(1550, 200);
            ctrlLocal_dlA_Details1.TabIndex = 212;
            // 
            // ctrlApplicationShow1
            // 
            ctrlApplicationShow1._ApplicationID = 0;
            ctrlApplicationShow1.BackColor = Color.Lavender;
            ctrlApplicationShow1.Location = new Point(12, 354);
            ctrlApplicationShow1.Name = "ctrlApplicationShow1";
            ctrlApplicationShow1.Size = new Size(1550, 350);
            ctrlApplicationShow1.TabIndex = 213;
            // 
            // btnTestAppAddNew
            // 
            btnTestAppAddNew.Location = new Point(1238, 758);
            btnTestAppAddNew.Name = "btnTestAppAddNew";
            btnTestAppAddNew.OverrideDefault.Back.Color1 = Color.Silver;
            btnTestAppAddNew.OverrideDefault.Border.Rounding = 50F;
            btnTestAppAddNew.OverrideFocus.Back.Color1 = Color.Silver;
            btnTestAppAddNew.OverrideFocus.Border.Rounding = 50F;
            btnTestAppAddNew.Size = new Size(330, 60);
            btnTestAppAddNew.StateDisabled.Back.Color1 = Color.Silver;
            btnTestAppAddNew.StateDisabled.Border.Rounding = 50F;
            btnTestAppAddNew.StateNormal.Back.Color1 = Color.Silver;
            btnTestAppAddNew.StateNormal.Back.Color2 = Color.Silver;
            btnTestAppAddNew.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnTestAppAddNew.StateNormal.Border.Rounding = 50F;
            btnTestAppAddNew.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnTestAppAddNew.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestAppAddNew.StatePressed.Back.Color1 = Color.Silver;
            btnTestAppAddNew.StatePressed.Back.Color2 = Color.Silver;
            btnTestAppAddNew.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnTestAppAddNew.StatePressed.Border.Color1 = Color.Gainsboro;
            btnTestAppAddNew.StatePressed.Border.Color2 = Color.Gainsboro;
            btnTestAppAddNew.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnTestAppAddNew.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnTestAppAddNew.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnTestAppAddNew.StatePressed.Border.Rounding = 50F;
            btnTestAppAddNew.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnTestAppAddNew.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestAppAddNew.StateTracking.Back.Color1 = Color.Silver;
            btnTestAppAddNew.StateTracking.Back.Color2 = Color.Silver;
            btnTestAppAddNew.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnTestAppAddNew.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnTestAppAddNew.StateTracking.Border.Color1 = Color.Gainsboro;
            btnTestAppAddNew.StateTracking.Border.Color2 = Color.Gainsboro;
            btnTestAppAddNew.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnTestAppAddNew.StateTracking.Border.Rounding = 50F;
            btnTestAppAddNew.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnTestAppAddNew.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnTestAppAddNew.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnTestAppAddNew.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnTestAppAddNew.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestAppAddNew.TabIndex = 234;
            btnTestAppAddNew.Values.DropDownArrowColor = Color.Empty;
            btnTestAppAddNew.Values.Text = "Add New Appointment";
            btnTestAppAddNew.Click += btnTestAppAddNew_Click;
            // 
            // lblTotalRecordsNb
            // 
            lblTotalRecordsNb.AutoSize = false;
            lblTotalRecordsNb.Location = new Point(771, 781);
            lblTotalRecordsNb.Name = "lblTotalRecordsNb";
            lblTotalRecordsNb.Size = new Size(71, 47);
            lblTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecordsNb.TabIndex = 233;
            lblTotalRecordsNb.TabStop = false;
            lblTotalRecordsNb.Values.Text = "0";
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = false;
            lblTotalRecords.Location = new Point(593, 781);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(191, 47);
            lblTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecords.TabIndex = 232;
            lblTotalRecords.TabStop = false;
            lblTotalRecords.Values.Text = "Total Records : ";
            // 
            // dgvTA
            // 
            dgvTA.AllowUserToAddRows = false;
            dgvTA.AllowUserToDeleteRows = false;
            dgvTA.AllowUserToResizeColumns = false;
            dgvTA.AllowUserToResizeRows = false;
            dgvTA.AutoGenerateKryptonColumns = false;
            dgvTA.BorderStyle = BorderStyle.Fixed3D;
            dgvTA.ColumnHeadersHeight = 60;
            dgvTA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTA.ContextMenuStrip = contextMenuStripLocal;
            dgvTA.Cursor = Cursors.Hand;
            dgvTA.Dock = DockStyle.Bottom;
            dgvTA.Location = new Point(0, 824);
            dgvTA.Name = "dgvTA";
            dgvTA.ReadOnly = true;
            dgvTA.RowHeadersVisible = false;
            dgvTA.RowHeadersWidth = 100;
            dgvTA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTA.ShowEditingIcon = false;
            dgvTA.ShowRowErrors = false;
            dgvTA.Size = new Size(1580, 260);
            dgvTA.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvTA.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvTA.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvTA.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvTA.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvTA.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvTA.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvTA.TabIndex = 231;
            dgvTA.TabStop = false;
            // 
            // contextMenuStripLocal
            // 
            contextMenuStripLocal.BackColor = Color.Gainsboro;
            contextMenuStripLocal.Font = new Font("Segoe UI", 9F);
            contextMenuStripLocal.ImageScalingSize = new Size(36, 36);
            contextMenuStripLocal.Items.AddRange(new ToolStripItem[] { updateApplicationToolStripMenuItem, takeTestToolStripMenuItem });
            contextMenuStripLocal.Name = "contextMenuStripPeople";
            contextMenuStripLocal.Size = new Size(288, 92);
            contextMenuStripLocal.Opening += contextMenuStripLocal_Opening;
            // 
            // updateApplicationToolStripMenuItem
            // 
            updateApplicationToolStripMenuItem.Image = Properties.Resources.editPerson;
            updateApplicationToolStripMenuItem.Name = "updateApplicationToolStripMenuItem";
            updateApplicationToolStripMenuItem.Size = new Size(287, 44);
            updateApplicationToolStripMenuItem.Text = "Edit Appointment Date";
            updateApplicationToolStripMenuItem.Click += updateApplicationToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.Image = Properties.Resources.showapp;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(287, 44);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += TakeTestToolStripMenuItem_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.AutoSize = false;
            kryptonLabel1.Location = new Point(12, 771);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(191, 47);
            kryptonLabel1.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 235;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "Appointments:";
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 236;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmTestAppointments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(kryptonLabel1);
            Controls.Add(btnTestAppAddNew);
            Controls.Add(dgvTA);
            Controls.Add(ctrlApplicationShow1);
            Controls.Add(ctrlLocal_dlA_Details1);
            Controls.Add(lblTotalRecordsNb);
            Controls.Add(lblTotalRecords);
            Name = "frmTestAppointments";
            StartPosition = FormStartPosition.Manual;
            Text = "frmTestAppointments";
            Load += frmTestAppointments_Load;
            Controls.SetChildIndex(lblTotalRecords, 0);
            Controls.SetChildIndex(lblTotalRecordsNb, 0);
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(ctrlLocal_dlA_Details1, 0);
            Controls.SetChildIndex(ctrlApplicationShow1, 0);
            Controls.SetChildIndex(dgvTA, 0);
            Controls.SetChildIndex(btnTestAppAddNew, 0);
            Controls.SetChildIndex(kryptonLabel1, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTA).EndInit();
            contextMenuStripLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlLocal_DLA_Details ctrlLocal_dlA_Details1;
        private ctrlApplicationShow ctrlApplicationShow1;
        private Krypton.Toolkit.KryptonButton btnTestAppAddNew;
        private Krypton.Toolkit.KryptonLabel lblTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblTotalRecords;
        private Krypton.Toolkit.KryptonDataGridView dgvTA;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ContextMenuStrip contextMenuStripLocal;
        private ToolStripMenuItem updateApplicationToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}