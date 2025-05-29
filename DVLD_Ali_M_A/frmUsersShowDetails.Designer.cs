namespace DVLD_Presentation
{
    partial class frmUsersShowDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersShowDetails));
            btnClose = new Krypton.Toolkit.KryptonPictureBox();
            toolTipClose = new ToolTip(components);
            lblUserTitle = new Krypton.Toolkit.KryptonLabel();
            ctrlPeopleShowDetails1 = new ctrlPeopleShowDetails();
            ctrlUsersShowDetails1 = new ctrlUsersShowDetails();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1400, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 100);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 212;
            btnClose.TabStop = false;
            toolTipClose.SetToolTip(btnClose, "Close");
            btnClose.Click += btnPeopleCancel_Click;
            // 
            // toolTipClose
            // 
            toolTipClose.BackColor = Color.Gainsboro;
            toolTipClose.ForeColor = Color.DarkSlateBlue;
            // 
            // lblUserTitle
            // 
            lblUserTitle.AutoSize = false;
            lblUserTitle.Location = new Point(575, 2);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(347, 107);
            lblUserTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUserTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserTitle.TabIndex = 213;
            lblUserTitle.TabStop = false;
            lblUserTitle.Values.Text = "User Details";
            // 
            // ctrlPeopleShowDetails1
            // 
            ctrlPeopleShowDetails1.BackColor = Color.Gainsboro;
            ctrlPeopleShowDetails1.Location = new Point(82, 115);
            ctrlPeopleShowDetails1.Name = "ctrlPeopleShowDetails1";
            ctrlPeopleShowDetails1.Size = new Size(1324, 724);
            ctrlPeopleShowDetails1.TabIndex = 214;
            // 
            // ctrlUsersShowDetails1
            // 
            ctrlUsersShowDetails1.BackColor = Color.Lavender;
            ctrlUsersShowDetails1.Location = new Point(95, 861);
            ctrlUsersShowDetails1.Name = "ctrlUsersShowDetails1";
            ctrlUsersShowDetails1.Size = new Size(988, 130);
            ctrlUsersShowDetails1.TabIndex = 215;
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
            // frmUsersShowDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1609, 1087);
            Controls.Add(btnDocumentation);
            Controls.Add(ctrlUsersShowDetails1);
            Controls.Add(ctrlPeopleShowDetails1);
            Controls.Add(lblUserTitle);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsersShowDetails";
            Text = "frmUsersShowDetails";
            Load += frmUsersShowDetails_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox btnClose;
        private ToolTip toolTipClose;
        private Krypton.Toolkit.KryptonLabel lblUserTitle;
        private ctrlPeopleShowDetails ctrlPeopleShowDetails1;
        private ctrlUsersShowDetails ctrlUsersShowDetails1;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
    }
}