namespace DVLD_Presentation
{
    partial class frmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            toolTipCancel = new ToolTip(components);
            btnGeneralCancel = new Krypton.Toolkit.KryptonPictureBox();
            lblGeneralTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            SuspendLayout();
            // 
            // toolTipCancel
            // 
            toolTipCancel.BackColor = Color.Gainsboro;
            toolTipCancel.ForeColor = Color.DarkSlateBlue;
            // 
            // btnPeopleCancel
            // 
            btnGeneralCancel.Cursor = Cursors.Hand;
            btnGeneralCancel.Image = (Image)resources.GetObject("btnPeopleCancel.Image");
            btnGeneralCancel.Location = new Point(1400, 30);
            btnGeneralCancel.Name = "btnPeopleCancel";
            btnGeneralCancel.Size = new Size(150, 100);
            btnGeneralCancel.SizeMode = PictureBoxSizeMode.Zoom;
            btnGeneralCancel.TabIndex = 210;
            btnGeneralCancel.TabStop = false;
            toolTipCancel.SetToolTip(btnGeneralCancel, "Close");
            btnGeneralCancel.Click += btnGeneralCancel_Click;
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.AutoSize = false;
            lblGeneralTitle.Location = new Point(575, 2);
            lblGeneralTitle.Name = "lblGeneralTitle";
            lblGeneralTitle.Size = new Size(398, 107);
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.TabIndex = 211;
            lblGeneralTitle.TabStop = false;
            lblGeneralTitle.Values.Text = "Title";
            // 
            // frmGeneral
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1548, 1028);
            Controls.Add(lblGeneralTitle);
            Controls.Add(btnGeneralCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGeneral";
            Text = "frmGeneral";
            Load += frmGeneral_Load;
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public ToolTip toolTipCancel;
        public Krypton.Toolkit.KryptonPictureBox btnGeneralCancel;
        public Krypton.Toolkit.KryptonLabel lblGeneralTitle;
    }
}