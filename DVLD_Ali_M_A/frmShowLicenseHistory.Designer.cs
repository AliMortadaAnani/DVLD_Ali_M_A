namespace DVLD_Presentation
{
    partial class frmShowLicenseHistory
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
            ctrlPeopleShowDetails1 = new ctrlPeopleShowDetails();
            rbint = new Krypton.Toolkit.KryptonRadioButton();
            rblocal = new Krypton.Toolkit.KryptonRadioButton();
            lblgender = new Krypton.Toolkit.KryptonLabel();
            dgvlicense = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvlicense).BeginInit();
            SuspendLayout();
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Title";
            // 
            // ctrlPeopleShowDetails1
            // 
            ctrlPeopleShowDetails1.BackColor = Color.Gainsboro;
            ctrlPeopleShowDetails1.Location = new Point(-2, 69);
            ctrlPeopleShowDetails1.Name = "ctrlPeopleShowDetails1";
            ctrlPeopleShowDetails1.Size = new Size(1298, 705);
            ctrlPeopleShowDetails1.TabIndex = 212;
            // 
            // rbint
            // 
            rbint.Location = new Point(322, 780);
            rbint.Name = "rbint";
            rbint.Size = new Size(198, 34);
            rbint.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            rbint.StateNormal.ShortText.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbint.TabIndex = 223;
            rbint.Values.Text = "International";
            rbint.CheckedChanged += rbint_CheckedChanged;
            // 
            // rblocal
            // 
            rblocal.Location = new Point(189, 780);
            rblocal.Name = "rblocal";
            rblocal.Size = new Size(97, 34);
            rblocal.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            rblocal.StateNormal.ShortText.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rblocal.TabIndex = 222;
            rblocal.Values.Text = "Local";
            rblocal.CheckedChanged += rblocal_CheckedChanged;
            // 
            // lblgender
            // 
            lblgender.AutoSize = false;
            lblgender.Location = new Point(10, 780);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(173, 34);
            lblgender.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblgender.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgender.TabIndex = 224;
            lblgender.TabStop = false;
            lblgender.Values.Text = "License Type:";
            // 
            // dgvlicense
            // 
            dgvlicense.AllowUserToAddRows = false;
            dgvlicense.AllowUserToDeleteRows = false;
            dgvlicense.AllowUserToResizeColumns = false;
            dgvlicense.AllowUserToResizeRows = false;
            dgvlicense.AutoGenerateKryptonColumns = false;
            dgvlicense.BorderStyle = BorderStyle.Fixed3D;
            dgvlicense.ColumnHeadersHeight = 60;
            dgvlicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvlicense.Cursor = Cursors.Hand;
            dgvlicense.Dock = DockStyle.Bottom;
            dgvlicense.Location = new Point(0, 814);
            dgvlicense.Name = "dgvlicense";
            dgvlicense.ReadOnly = true;
            dgvlicense.RowHeadersVisible = false;
            dgvlicense.RowHeadersWidth = 100;
            dgvlicense.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlicense.ShowEditingIcon = false;
            dgvlicense.ShowRowErrors = false;
            dgvlicense.Size = new Size(1570, 270);
            dgvlicense.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvlicense.StateCommon.DataCell.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvlicense.StateCommon.HeaderColumn.Back.Color1 = SystemColors.ControlText;
            dgvlicense.StateCommon.HeaderColumn.Back.Color2 = Color.DarkSlateBlue;
            dgvlicense.StateCommon.HeaderColumn.Content.Color1 = Color.Gainsboro;
            dgvlicense.StateCommon.HeaderColumn.Content.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dgvlicense.StateNormal.Background.Color1 = Color.Gainsboro;
            dgvlicense.TabIndex = 225;
            dgvlicense.TabStop = false;
            // 
            // frmShowLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(dgvlicense);
            Controls.Add(rbint);
            Controls.Add(rblocal);
            Controls.Add(lblgender);
            Controls.Add(ctrlPeopleShowDetails1);
            Name = "frmShowLicenseHistory";
            StartPosition = FormStartPosition.Manual;
            Text = "frmShowLicenseHistory";
            Load += frmShowLicenseHistory_Load;
            Controls.SetChildIndex(ctrlPeopleShowDetails1, 0);
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(lblgender, 0);
            Controls.SetChildIndex(rblocal, 0);
            Controls.SetChildIndex(rbint, 0);
            Controls.SetChildIndex(dgvlicense, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvlicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPeopleShowDetails ctrlPeopleShowDetails1;
        private Krypton.Toolkit.KryptonRadioButton rbint;
        private Krypton.Toolkit.KryptonRadioButton rblocal;
        private Krypton.Toolkit.KryptonLabel lblgender;
        private Krypton.Toolkit.KryptonDataGridView dgvlicense;
    }
}