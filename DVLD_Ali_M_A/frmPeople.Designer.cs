namespace DVLD_Ali_M_A
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            toolTip1 = new ToolTip(components);
            PeopleCancel = new Krypton.Toolkit.KryptonPictureBox();
            PeopleTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)PeopleCancel).BeginInit();
            SuspendLayout();
            // 
            // PeopleCancel
            // 
            PeopleCancel.Cursor = Cursors.Hand;
            PeopleCancel.Image = (Image)resources.GetObject("PeopleCancel.Image");
            PeopleCancel.Location = new Point(1400, 30);
            PeopleCancel.Name = "PeopleCancel";
            PeopleCancel.Size = new Size(150, 100);
            PeopleCancel.SizeMode = PictureBoxSizeMode.Zoom;
            PeopleCancel.TabIndex = 203;
            PeopleCancel.TabStop = false;
            toolTip1.SetToolTip(PeopleCancel, "Close");
            PeopleCancel.Click += PeopleCancel_Click;
            // 
            // PeopleTitle
            // 
            PeopleTitle.AutoSize = false;
            PeopleTitle.Cursor = Cursors.Hand;
            PeopleTitle.Location = new Point(575, 2);
            PeopleTitle.Name = "PeopleTitle";
            PeopleTitle.Size = new Size(347, 107);
            PeopleTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            PeopleTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PeopleTitle.TabIndex = 209;
            PeopleTitle.TabStop = false;
            PeopleTitle.Values.Text = "Manage People";
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1570, 1084);
            Controls.Add(PeopleTitle);
            Controls.Add(PeopleCancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPeople";
            StartPosition = FormStartPosition.Manual;
            Text = "frmPeople";
            Load += frmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)PeopleCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonPictureBox PeopleCancel;
        private Krypton.Toolkit.KryptonLabel PeopleTitle;
    }
}