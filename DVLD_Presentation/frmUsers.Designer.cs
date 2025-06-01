namespace DVLD_Presentation
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            btnUsersClose = new Krypton.Toolkit.KryptonPictureBox();
            lblUsersTitle = new Krypton.Toolkit.KryptonLabel();
            toolTipClose = new ToolTip(components);
            lblUsersFilter = new Krypton.Toolkit.KryptonLabel();
            dgvUsers = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStripUsers = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            editUserToolStripMenuItem = new ToolStripMenuItem();
            changepasswordtoolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            addNewUserToolStripMenuItem = new ToolStripMenuItem();
            mtbUsersFilterInput = new MaskedTextBox();
            cbUsersFilterBox = new Krypton.Toolkit.KryptonComboBox();
            lblUsersTotalRecordsNb = new Krypton.Toolkit.KryptonLabel();
            lblUsersTotalRecords = new Krypton.Toolkit.KryptonLabel();
            btnUserAddNew = new Krypton.Toolkit.KryptonButton();
            cbUsersStatusOptions = new Krypton.Toolkit.KryptonComboBox();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnUsersClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStripUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cbUsersFilterBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbUsersStatusOptions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // btnUsersClose
            // 
            btnUsersClose.Cursor = Cursors.Hand;
            btnUsersClose.Image = (Image)resources.GetObject("btnUsersClose.Image");
            btnUsersClose.Location = new Point(1400, 30);
            btnUsersClose.Name = "btnUsersClose";
            btnUsersClose.Size = new Size(150, 100);
            btnUsersClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnUsersClose.TabIndex = 212;
            btnUsersClose.TabStop = false;
            toolTipClose.SetToolTip(btnUsersClose, "Close");
            btnUsersClose.Click += btnUsersCancel_Click;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.AutoSize = false;
            lblUsersTitle.Location = new Point(575, 2);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(301, 107);
            lblUsersTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUsersTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsersTitle.TabIndex = 213;
            lblUsersTitle.TabStop = false;
            lblUsersTitle.Values.Text = "Manage Users";
            // 
            // toolTipClose
            // 
            toolTipClose.BackColor = Color.Gainsboro;
            toolTipClose.ForeColor = Color.DarkSlateBlue;
            // 
            // lblUsersFilter
            // 
            lblUsersFilter.AutoSize = false;
            lblUsersFilter.Location = new Point(0, 405);
            lblUsersFilter.Name = "lblUsersFilter";
            lblUsersFilter.Size = new Size(123, 47);
            lblUsersFilter.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUsersFilter.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsersFilter.TabIndex = 218;
            lblUsersFilter.TabStop = false;
            lblUsersFilter.Values.Text = "Filter By:";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.AutoGenerateKryptonColumns = false;
            dgvUsers.BorderStyle = BorderStyle.Fixed3D;
            dgvUsers.ColumnHeadersHeight = 60;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.ContextMenuStrip = contextMenuStripUsers;
            dgvUsers.Cursor = Cursors.Hand;
            dgvUsers.Location = new Point(0, 484);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 100;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ShowEditingIcon = false;
            dgvUsers.ShowRowErrors = false;
            dgvUsers.Size = new Size(1569, 600);
            dgvUsers.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvUsers.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvUsers.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvUsers.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvUsers.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvUsers.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvUsers.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvUsers.TabIndex = 219;
            dgvUsers.TabStop = false;
            // 
            // contextMenuStripUsers
            // 
            contextMenuStripUsers.BackColor = Color.Gainsboro;
            contextMenuStripUsers.Font = new Font("Segoe UI", 9F);
            contextMenuStripUsers.ImageScalingSize = new Size(36, 36);
            contextMenuStripUsers.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, editUserToolStripMenuItem, changepasswordtoolStripMenuItem, deleteUserToolStripMenuItem, addNewUserToolStripMenuItem });
            contextMenuStripUsers.Name = "contextMenuStripPeople";
            contextMenuStripUsers.Size = new Size(247, 224);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = Properties.Resources.infoPerson;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(246, 44);
            showDetailsToolStripMenuItem.Text = "Show User Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Image = Properties.Resources.editPerson;
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            editUserToolStripMenuItem.Size = new Size(246, 44);
            editUserToolStripMenuItem.Text = "Edit User";
            editUserToolStripMenuItem.Click += editUserToolStripMenuItem_Click;
            // 
            // changepasswordtoolStripMenuItem
            // 
            changepasswordtoolStripMenuItem.Image = Properties.Resources.password1;
            changepasswordtoolStripMenuItem.Name = "changepasswordtoolStripMenuItem";
            changepasswordtoolStripMenuItem.Size = new Size(246, 44);
            changepasswordtoolStripMenuItem.Text = "Change Password";
            changepasswordtoolStripMenuItem.Click += changepasswordtoolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Image = Properties.Resources.deletePerson;
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(246, 44);
            deleteUserToolStripMenuItem.Text = "Delete User";
            deleteUserToolStripMenuItem.Click += deleteUserToolStripMenuItem_Click;
            // 
            // addNewUserToolStripMenuItem
            // 
            addNewUserToolStripMenuItem.Image = Properties.Resources.addPerson;
            addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            addNewUserToolStripMenuItem.Size = new Size(246, 44);
            addNewUserToolStripMenuItem.Text = "Add New User";
            addNewUserToolStripMenuItem.Click += addNewUserToolStripMenuItem_Click;
            // 
            // mtbUsersFilterInput
            // 
            mtbUsersFilterInput.BackColor = Color.Gainsboro;
            mtbUsersFilterInput.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbUsersFilterInput.ForeColor = SystemColors.InfoText;
            mtbUsersFilterInput.Location = new Point(226, 446);
            mtbUsersFilterInput.Name = "mtbUsersFilterInput";
            mtbUsersFilterInput.Size = new Size(203, 34);
            mtbUsersFilterInput.TabIndex = 221;
            mtbUsersFilterInput.TextChanged += mtbUsersFilterInput_TextChanged;
            // 
            // cbUsersFilterBox
            // 
            cbUsersFilterBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsersFilterBox.DropDownWidth = 175;
            cbUsersFilterBox.Items.AddRange(new object[] { "None", "ID", "FirstName", "LastName", "PersonID", "Username", "Status" });
            cbUsersFilterBox.Location = new Point(0, 445);
            cbUsersFilterBox.MaxDropDownItems = 12;
            cbUsersFilterBox.Name = "cbUsersFilterBox";
            cbUsersFilterBox.Size = new Size(216, 33);
            cbUsersFilterBox.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbUsersFilterBox.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersFilterBox.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersFilterBox.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbUsersFilterBox.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersFilterBox.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersFilterBox.TabIndex = 220;
            cbUsersFilterBox.Text = "None";
            cbUsersFilterBox.SelectedIndexChanged += cbUsersFilterBox_SelectedIndexChanged;
            // 
            // lblUsersTotalRecordsNb
            // 
            lblUsersTotalRecordsNb.AutoSize = false;
            lblUsersTotalRecordsNb.Location = new Point(760, 432);
            lblUsersTotalRecordsNb.Name = "lblUsersTotalRecordsNb";
            lblUsersTotalRecordsNb.Size = new Size(71, 47);
            lblUsersTotalRecordsNb.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUsersTotalRecordsNb.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsersTotalRecordsNb.TabIndex = 223;
            lblUsersTotalRecordsNb.TabStop = false;
            lblUsersTotalRecordsNb.Values.Text = "0";
            // 
            // lblUsersTotalRecords
            // 
            lblUsersTotalRecords.AutoSize = false;
            lblUsersTotalRecords.Location = new Point(585, 431);
            lblUsersTotalRecords.Name = "lblUsersTotalRecords";
            lblUsersTotalRecords.Size = new Size(191, 47);
            lblUsersTotalRecords.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUsersTotalRecords.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsersTotalRecords.TabIndex = 222;
            lblUsersTotalRecords.TabStop = false;
            lblUsersTotalRecords.Values.Text = "Total Records : ";
            // 
            // btnUserAddNew
            // 
            btnUserAddNew.Location = new Point(1337, 405);
            btnUserAddNew.Name = "btnUserAddNew";
            btnUserAddNew.OverrideDefault.Back.Color1 = Color.Silver;
            btnUserAddNew.OverrideDefault.Border.Rounding = 50F;
            btnUserAddNew.OverrideFocus.Back.Color1 = Color.Silver;
            btnUserAddNew.OverrideFocus.Border.Rounding = 50F;
            btnUserAddNew.Size = new Size(221, 63);
            btnUserAddNew.StateDisabled.Back.Color1 = Color.Silver;
            btnUserAddNew.StateDisabled.Border.Rounding = 50F;
            btnUserAddNew.StateNormal.Back.Color1 = Color.Silver;
            btnUserAddNew.StateNormal.Back.Color2 = Color.Silver;
            btnUserAddNew.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserAddNew.StateNormal.Border.Rounding = 50F;
            btnUserAddNew.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnUserAddNew.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserAddNew.StatePressed.Back.Color1 = Color.Silver;
            btnUserAddNew.StatePressed.Back.Color2 = Color.Silver;
            btnUserAddNew.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserAddNew.StatePressed.Border.Color1 = Color.Gainsboro;
            btnUserAddNew.StatePressed.Border.Color2 = Color.Gainsboro;
            btnUserAddNew.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserAddNew.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserAddNew.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserAddNew.StatePressed.Border.Rounding = 50F;
            btnUserAddNew.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnUserAddNew.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserAddNew.StateTracking.Back.Color1 = Color.Silver;
            btnUserAddNew.StateTracking.Back.Color2 = Color.Silver;
            btnUserAddNew.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserAddNew.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserAddNew.StateTracking.Border.Color1 = Color.Gainsboro;
            btnUserAddNew.StateTracking.Border.Color2 = Color.Gainsboro;
            btnUserAddNew.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserAddNew.StateTracking.Border.Rounding = 50F;
            btnUserAddNew.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserAddNew.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnUserAddNew.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnUserAddNew.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnUserAddNew.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserAddNew.TabIndex = 224;
            btnUserAddNew.Values.DropDownArrowColor = Color.Empty;
            btnUserAddNew.Values.Text = "Add New User";
            btnUserAddNew.Click += btnUserAddNew_Click;
            // 
            // cbUsersStatusOptions
            // 
            cbUsersStatusOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsersStatusOptions.DropDownWidth = 175;
            cbUsersStatusOptions.Items.AddRange(new object[] { "All", "Active", "Not Active" });
            cbUsersStatusOptions.Location = new Point(226, 446);
            cbUsersStatusOptions.MaxDropDownItems = 12;
            cbUsersStatusOptions.Name = "cbUsersStatusOptions";
            cbUsersStatusOptions.Size = new Size(203, 33);
            cbUsersStatusOptions.StateCommon.ComboBox.Back.Color1 = Color.DarkSlateBlue;
            cbUsersStatusOptions.StateCommon.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersStatusOptions.StateCommon.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersStatusOptions.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cbUsersStatusOptions.StateDisabled.ComboBox.Content.Color1 = Color.Gainsboro;
            cbUsersStatusOptions.StateDisabled.ComboBox.Content.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbUsersStatusOptions.TabIndex = 225;
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
            btnDocumentation.TabIndex = 226;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1633, 819);
            Controls.Add(btnDocumentation);
            Controls.Add(btnUserAddNew);
            Controls.Add(lblUsersTotalRecordsNb);
            Controls.Add(lblUsersTotalRecords);
            Controls.Add(cbUsersFilterBox);
            Controls.Add(dgvUsers);
            Controls.Add(lblUsersFilter);
            Controls.Add(lblUsersTitle);
            Controls.Add(btnUsersClose);
            Controls.Add(mtbUsersFilterInput);
            Controls.Add(cbUsersStatusOptions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsers";
            Text = "frmUsers";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)btnUsersClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStripUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cbUsersFilterBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbUsersStatusOptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox btnUsersClose;
        private Krypton.Toolkit.KryptonLabel lblUsersTitle;
        private ToolTip toolTipClose;
        private Krypton.Toolkit.KryptonLabel lblUsersFilter;
        private Krypton.Toolkit.KryptonDataGridView dgvUsers;
        private MaskedTextBox mtbUsersFilterInput;
        private Krypton.Toolkit.KryptonComboBox cbUsersFilterBox;
        private Krypton.Toolkit.KryptonLabel lblUsersTotalRecordsNb;
        private Krypton.Toolkit.KryptonLabel lblUsersTotalRecords;
        private Krypton.Toolkit.KryptonButton btnUserAddNew;
        private ContextMenuStrip contextMenuStripUsers;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem addNewUserToolStripMenuItem;
        private Krypton.Toolkit.KryptonComboBox cbUsersStatusOptions;
        private ToolStripMenuItem changepasswordtoolStripMenuItem;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}