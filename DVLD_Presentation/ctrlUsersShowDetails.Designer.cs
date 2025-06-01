namespace DVLD_Presentation
{
    partial class ctrlUsersShowDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblusername = new Krypton.Toolkit.KryptonLabel();
            lblid = new Krypton.Toolkit.KryptonLabel();
            lblstatus = new Krypton.Toolkit.KryptonLabel();
            lblidtxt = new Krypton.Toolkit.KryptonLabel();
            lblusernametxt = new Krypton.Toolkit.KryptonLabel();
            lblstatustxt = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = false;
            lblusername.Location = new Point(372, 41);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(158, 47);
            lblusername.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblusername.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.TabIndex = 220;
            lblusername.TabStop = false;
            lblusername.Values.Text = "Username:";
            // 
            // lblid
            // 
            lblid.AutoSize = false;
            lblid.Location = new Point(53, 41);
            lblid.Name = "lblid";
            lblid.Size = new Size(158, 47);
            lblid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.TabIndex = 221;
            lblid.TabStop = false;
            lblid.Values.Text = "UserID:";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = false;
            lblstatus.Location = new Point(691, 41);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(158, 47);
            lblstatus.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblstatus.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatus.TabIndex = 222;
            lblstatus.TabStop = false;
            lblstatus.Values.Text = "Status:";
            // 
            // lblidtxt
            // 
            lblidtxt.AutoSize = false;
            lblidtxt.Location = new Point(149, 41);
            lblidtxt.Name = "lblidtxt";
            lblidtxt.Size = new Size(158, 47);
            lblidtxt.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblidtxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidtxt.TabIndex = 223;
            lblidtxt.TabStop = false;
            lblidtxt.Values.Text = "";
            // 
            // lblusernametxt
            // 
            lblusernametxt.AutoSize = false;
            lblusernametxt.Location = new Point(503, 41);
            lblusernametxt.Name = "lblusernametxt";
            lblusernametxt.Size = new Size(158, 47);
            lblusernametxt.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblusernametxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusernametxt.TabIndex = 224;
            lblusernametxt.TabStop = false;
            lblusernametxt.Values.Text = "";
            // 
            // lblstatustxt
            // 
            lblstatustxt.AutoSize = false;
            lblstatustxt.Location = new Point(783, 41);
            lblstatustxt.Name = "lblstatustxt";
            lblstatustxt.Size = new Size(158, 47);
            lblstatustxt.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblstatustxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstatustxt.TabIndex = 225;
            lblstatustxt.TabStop = false;
            lblstatustxt.Values.Text = "";
            // 
            // ctrlUsersShowDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(lblstatustxt);
            Controls.Add(lblusernametxt);
            Controls.Add(lblidtxt);
            Controls.Add(lblstatus);
            Controls.Add(lblid);
            Controls.Add(lblusername);
            Name = "ctrlUsersShowDetails";
            Size = new Size(1086, 143);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblusername;
        private Krypton.Toolkit.KryptonLabel lblid;
        private Krypton.Toolkit.KryptonLabel lblstatus;
        private Krypton.Toolkit.KryptonLabel lblidtxt;
        private Krypton.Toolkit.KryptonLabel lblusernametxt;
        private Krypton.Toolkit.KryptonLabel lblstatustxt;
    }
}
