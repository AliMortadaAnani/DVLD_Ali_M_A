namespace DVLD_Presentation
{
    partial class frmLocal_DLA_ShowDetails
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
            ctrlLocal_dlA_Details1 = new ctrlLocal_DLA_Details();
            ctrlApplicationShow1 = new ctrlApplicationShow();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            SuspendLayout();
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
            ctrlLocal_dlA_Details1.Location = new Point(8, 176);
            ctrlLocal_dlA_Details1.Name = "ctrlLocal_dlA_Details1";
            ctrlLocal_dlA_Details1.Size = new Size(1550, 200);
            ctrlLocal_dlA_Details1.TabIndex = 212;
            // 
            // ctrlApplicationShow1
            // 
            ctrlApplicationShow1._ApplicationID = 0;
            ctrlApplicationShow1.BackColor = Color.Lavender;
            ctrlApplicationShow1.Location = new Point(8, 403);
            ctrlApplicationShow1.Name = "ctrlApplicationShow1";
            ctrlApplicationShow1.Size = new Size(1550, 323);
            ctrlApplicationShow1.TabIndex = 213;
            // 
            // frmLocal_DLA_ShowDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(ctrlApplicationShow1);
            Controls.Add(ctrlLocal_dlA_Details1);
            Name = "frmLocal_DLA_ShowDetails";
            StartPosition = FormStartPosition.Manual;
            Text = "frmLocal_DLA_ShowDetails";
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(ctrlLocal_dlA_Details1, 0);
            Controls.SetChildIndex(ctrlApplicationShow1, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlLocal_DLA_Details ctrlLocal_dlA_Details1;
        private ctrlApplicationShow ctrlApplicationShow1;
    }
}