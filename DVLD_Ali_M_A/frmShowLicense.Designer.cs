namespace DVLD_Presentation
{
    partial class frmShowLicense
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
            ctrlLicenseInfo1 = new ctrlLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            SuspendLayout();
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Title";
            // 
            // ctrlLicenseInfo1
            // 
            ctrlLicenseInfo1._LicenseID = 0;
            ctrlLicenseInfo1.BackColor = Color.Lavender;
            ctrlLicenseInfo1.Location = new Point(8, 201);
            ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            ctrlLicenseInfo1.Size = new Size(1550, 488);
            ctrlLicenseInfo1.TabIndex = 212;
            // 
            // frmShowLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(ctrlLicenseInfo1);
            Name = "frmShowLicense";
            StartPosition = FormStartPosition.Manual;
            Text = "frmShowLicense";
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(ctrlLicenseInfo1, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlLicenseInfo ctrlLicenseInfo1;
    }
}