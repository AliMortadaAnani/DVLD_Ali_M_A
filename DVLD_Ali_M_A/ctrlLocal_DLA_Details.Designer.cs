namespace DVLD_Presentation
{
    partial class ctrlLocal_DLA_Details
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
            lblclass = new Krypton.Toolkit.KryptonLabel();
            lbladdress = new Krypton.Toolkit.KryptonLabel();
            lblid = new Krypton.Toolkit.KryptonLabel();
            lblclasstxt = new Krypton.Toolkit.KryptonLabel();
            lblteststxt = new Krypton.Toolkit.KryptonLabel();
            lblidtxt = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // lblclass
            // 
            lblclass.AutoSize = false;
            lblclass.Location = new Point(17, 72);
            lblclass.Name = "lblclass";
            lblclass.Size = new Size(158, 47);
            lblclass.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblclass.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclass.TabIndex = 229;
            lblclass.TabStop = false;
            lblclass.Values.Text = "License:";
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = false;
            lbladdress.Location = new Point(17, 125);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(167, 47);
            lbladdress.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbladdress.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladdress.TabIndex = 228;
            lbladdress.TabStop = false;
            lbladdress.Values.Text = "Passed Tests:";
            // 
            // lblid
            // 
            lblid.AutoSize = false;
            lblid.Location = new Point(17, 19);
            lblid.Name = "lblid";
            lblid.Size = new Size(448, 47);
            lblid.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblid.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblid.TabIndex = 227;
            lblid.TabStop = false;
            lblid.Values.Text = "Local Driving License Application ID:";
            // 
            // lblclasstxt
            // 
            lblclasstxt.AutoSize = false;
            lblclasstxt.Location = new Point(130, 72);
            lblclasstxt.Name = "lblclasstxt";
            lblclasstxt.Size = new Size(1254, 47);
            lblclasstxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblclasstxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblclasstxt.TabIndex = 234;
            lblclasstxt.TabStop = false;
            lblclasstxt.Values.Text = "";
            // 
            // lblteststxt
            // 
            lblteststxt.AutoSize = false;
            lblteststxt.Location = new Point(183, 125);
            lblteststxt.Name = "lblteststxt";
            lblteststxt.Size = new Size(116, 47);
            lblteststxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblteststxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblteststxt.TabIndex = 235;
            lblteststxt.TabStop = false;
            lblteststxt.Values.Text = "";
            // 
            // lblidtxt
            // 
            lblidtxt.AutoSize = false;
            lblidtxt.Location = new Point(437, 19);
            lblidtxt.Name = "lblidtxt";
            lblidtxt.Size = new Size(116, 47);
            lblidtxt.StateNormal.ShortText.Color1 = Color.DarkSlateBlue;
            lblidtxt.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblidtxt.TabIndex = 236;
            lblidtxt.TabStop = false;
            lblidtxt.Values.Text = "";
            lblidtxt.Click += lblidtxt_Click;
            // 
            // ctrlLocal_DLA_Details
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(lblidtxt);
            Controls.Add(lblteststxt);
            Controls.Add(lblclasstxt);
            Controls.Add(lblclass);
            Controls.Add(lbladdress);
            Controls.Add(lblid);
            Name = "ctrlLocal_DLA_Details";
            Size = new Size(1400, 187);
            Load += ctrlLocal_DLA_Details_Load;
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonLabel lblclass;
        private Krypton.Toolkit.KryptonLabel lbladdress;
        private Krypton.Toolkit.KryptonLabel lblid;
        private Krypton.Toolkit.KryptonLabel lblclasstxt;
        private Krypton.Toolkit.KryptonLabel lblteststxt;
        private Krypton.Toolkit.KryptonLabel lblidtxt;
    }
}
