namespace DVLD_Presentation
{
    partial class frmPeopleAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleAddUpdate));
            lblPeopleTitle = new Krypton.Toolkit.KryptonLabel();
            btnPeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            toolTipCancel = new ToolTip(components);
            ctrlPeopleAddUpdate1 = new ctrlPeopleAddUpdate();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // lblPeopleTitle
            // 
            lblPeopleTitle.AutoSize = false;
            lblPeopleTitle.Location = new Point(575, 2);
            lblPeopleTitle.Name = "lblPeopleTitle";
            lblPeopleTitle.Size = new Size(476, 107);
            lblPeopleTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblPeopleTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeopleTitle.TabIndex = 210;
            lblPeopleTitle.TabStop = false;
            lblPeopleTitle.Values.Text = "Add New Person";
            // 
            // btnPeopleCancel
            // 
            btnPeopleCancel.Cursor = Cursors.Hand;
            btnPeopleCancel.Image = (Image)resources.GetObject("btnPeopleCancel.Image");
            btnPeopleCancel.Location = new Point(1400, 30);
            btnPeopleCancel.Name = "btnPeopleCancel";
            btnPeopleCancel.Size = new Size(150, 100);
            btnPeopleCancel.SizeMode = PictureBoxSizeMode.Zoom;
            btnPeopleCancel.TabIndex = 211;
            btnPeopleCancel.TabStop = false;
            toolTipCancel.SetToolTip(btnPeopleCancel, "Close");
            btnPeopleCancel.Click += btnPeopleCancel_Click;
            // 
            // toolTipCancel
            // 
            toolTipCancel.BackColor = Color.Gainsboro;
            toolTipCancel.ForeColor = Color.DarkSlateBlue;
            // 
            // ctrlPeopleAddUpdate1
            // 
            ctrlPeopleAddUpdate1.BackColor = Color.Gainsboro;
            ctrlPeopleAddUpdate1.Location = new Point(67, 149);
            ctrlPeopleAddUpdate1.Name = "ctrlPeopleAddUpdate1";
            ctrlPeopleAddUpdate1.Size = new Size(1400, 1000);
            ctrlPeopleAddUpdate1.TabIndex = 212;
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 61);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 213;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click;
            // 
            // frmPeopleAddUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(ctrlPeopleAddUpdate1);
            Controls.Add(btnPeopleCancel);
            Controls.Add(lblPeopleTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPeopleAddUpdate";
            Text = "frmPeopleAddUpdate";
            FormClosing += frmPeopleAddUpdate_FormClosing;
            Load += frmPeopleAddUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)btnPeopleCancel).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPictureBox btnPeopleCancel;
        private ToolTip toolTipCancel;
        private ctrlPeopleAddUpdate ctrlPeopleAddUpdate1;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
        public static Krypton.Toolkit.KryptonLabel lblPeopleTitle;
    }
}