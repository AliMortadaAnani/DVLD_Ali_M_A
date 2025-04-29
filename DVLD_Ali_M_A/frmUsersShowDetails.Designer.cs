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
            btnPeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTipCancel = new ToolTip(components);
            lblUserTitle = new Krypton.Toolkit.KryptonLabel();
            ctrlPeopleShowDetails1 = new ctrlPeopleShowDetails();
            ctrlUsersShowDetails1 = new ctrlUsersShowDetails();
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).BeginInit();
            SuspendLayout();
            // 
            // btnPeopleCancel
            // 
            btnPeopleCancel.Cursor = Cursors.Hand;
            btnPeopleCancel.Image = (Image)resources.GetObject("btnPeopleCancel.Image");
            btnPeopleCancel.Location = new Point(1400, 30);
            btnPeopleCancel.Name = "btnPeopleCancel";
            btnPeopleCancel.Size = new Size(150, 100);
            btnPeopleCancel.SizeMode = PictureBoxSizeMode.Zoom;
            btnPeopleCancel.TabIndex = 212;
            btnPeopleCancel.TabStop = false;
            toolTipCancel.SetToolTip(btnPeopleCancel, "Close");
            btnPeopleCancel.Click += btnPeopleCancel_Click;
            // 
            // toolTipCancel
            // 
            toolTipCancel.BackColor = Color.Gainsboro;
            toolTipCancel.ForeColor = Color.DarkSlateBlue;
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
            // frmUsersShowDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1609, 1087);
            Controls.Add(ctrlUsersShowDetails1);
            Controls.Add(ctrlPeopleShowDetails1);
            Controls.Add(lblUserTitle);
            Controls.Add(btnPeopleCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsersShowDetails";
            Text = "frmUsersShowDetails";
            Load += frmUsersShowDetails_Load;
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPictureBox btnPeopleCancel;
        private ToolTip toolTipCancel;
        private Krypton.Toolkit.KryptonLabel lblUserTitle;
        private ctrlPeopleShowDetails ctrlPeopleShowDetails1;
        private ctrlUsersShowDetails ctrlUsersShowDetails1;
    }
}