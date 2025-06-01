namespace DVLD_Presentation
{
    partial class frmDocumentation
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
            rtbDocumentation = new Krypton.Toolkit.KryptonRichTextBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            SuspendLayout();
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Title";
            // 
            // rtbDocumentation
            // 
            rtbDocumentation.Location = new Point(61, 136);
            rtbDocumentation.Name = "rtbDocumentation";
            rtbDocumentation.ReadOnly = true;
            rtbDocumentation.Size = new Size(1342, 904);
            rtbDocumentation.StateCommon.Back.Color1 = Color.Lavender;
            rtbDocumentation.StateCommon.Content.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbDocumentation.TabIndex = 212;
            rtbDocumentation.Text = "kryptonRichTextBox1";
            // 
            // frmDocumentation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(rtbDocumentation);
            Name = "frmDocumentation";
            StartPosition = FormStartPosition.Manual;
            Text = "frmDocumentation";
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(rtbDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonRichTextBox rtbDocumentation;
    }
}