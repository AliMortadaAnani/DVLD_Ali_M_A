namespace DVLD_Presentation
{
    partial class frmIssueLicense
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
            ctrlApplicationShow1 = new ctrlApplicationShow();
            ctrlLocal_dlA_Details1 = new ctrlLocal_DLA_Details();
            tbnotes = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnPeopleSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            SuspendLayout();
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Title";
            // 
            // ctrlApplicationShow1
            // 
            ctrlApplicationShow1._ApplicationID = 0;
            ctrlApplicationShow1.BackColor = Color.Lavender;
            ctrlApplicationShow1.Location = new Point(12, 389);
            ctrlApplicationShow1.Name = "ctrlApplicationShow1";
            ctrlApplicationShow1.Size = new Size(1550, 350);
            ctrlApplicationShow1.TabIndex = 215;
            // 
            // ctrlLocal_dlA_Details1
            // 
            ctrlLocal_dlA_Details1._LocalDLA_ID = 0;
            ctrlLocal_dlA_Details1.BackColor = Color.Lavender;
            ctrlLocal_dlA_Details1.Location = new Point(12, 183);
            ctrlLocal_dlA_Details1.Name = "ctrlLocal_dlA_Details1";
            ctrlLocal_dlA_Details1.Size = new Size(1550, 200);
            ctrlLocal_dlA_Details1.TabIndex = 214;
            // 
            // tbnotes
            // 
            tbnotes.Location = new Point(97, 794);
            tbnotes.Multiline = true;
            tbnotes.Name = "tbnotes";
            tbnotes.Size = new Size(757, 233);
            tbnotes.StateActive.Back.Color1 = Color.LightGray;
            tbnotes.StateActive.Border.Rounding = 30F;
            tbnotes.StateActive.Content.Color1 = Color.Black;
            tbnotes.StateActive.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.StateCommon.Back.Color1 = Color.White;
            tbnotes.StateCommon.Border.Rounding = 30F;
            tbnotes.StateCommon.Content.Color1 = Color.Black;
            tbnotes.StateCommon.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.StateDisabled.Back.Color1 = Color.WhiteSmoke;
            tbnotes.StateDisabled.Border.Rounding = 30F;
            tbnotes.StateDisabled.Content.Color1 = Color.Black;
            tbnotes.StateDisabled.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.StateNormal.Back.Color1 = Color.WhiteSmoke;
            tbnotes.StateNormal.Border.Rounding = 30F;
            tbnotes.StateNormal.Content.Color1 = Color.Black;
            tbnotes.StateNormal.Content.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnotes.TabIndex = 282;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.AutoSize = false;
            kryptonLabel3.Location = new Point(12, 784);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(158, 47);
            kryptonLabel3.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            kryptonLabel3.StateNormal.ShortText.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 283;
            kryptonLabel3.TabStop = false;
            kryptonLabel3.Values.Text = "Notes:";
            // 
            // btnPeopleSave
            // 
            btnPeopleSave.Location = new Point(914, 958);
            btnPeopleSave.Name = "btnPeopleSave";
            btnPeopleSave.OverrideDefault.Back.Color1 = Color.Silver;
            btnPeopleSave.OverrideDefault.Border.Rounding = 50F;
            btnPeopleSave.OverrideFocus.Back.Color1 = Color.Silver;
            btnPeopleSave.OverrideFocus.Border.Rounding = 50F;
            btnPeopleSave.Size = new Size(636, 69);
            btnPeopleSave.StateDisabled.Back.Color1 = Color.Silver;
            btnPeopleSave.StateDisabled.Border.Rounding = 50F;
            btnPeopleSave.StateNormal.Back.Color1 = Color.Silver;
            btnPeopleSave.StateNormal.Back.Color2 = Color.Silver;
            btnPeopleSave.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSave.StateNormal.Border.Rounding = 50F;
            btnPeopleSave.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleSave.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSave.StatePressed.Back.Color1 = Color.Silver;
            btnPeopleSave.StatePressed.Back.Color2 = Color.Silver;
            btnPeopleSave.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSave.StatePressed.Border.Color1 = Color.Gainsboro;
            btnPeopleSave.StatePressed.Border.Color2 = Color.Gainsboro;
            btnPeopleSave.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSave.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSave.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSave.StatePressed.Border.Rounding = 50F;
            btnPeopleSave.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnPeopleSave.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSave.StateTracking.Back.Color1 = Color.Silver;
            btnPeopleSave.StateTracking.Back.Color2 = Color.Silver;
            btnPeopleSave.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSave.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnPeopleSave.StateTracking.Border.Color1 = Color.Gainsboro;
            btnPeopleSave.StateTracking.Border.Color2 = Color.Gainsboro;
            btnPeopleSave.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnPeopleSave.StateTracking.Border.Rounding = 50F;
            btnPeopleSave.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnPeopleSave.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnPeopleSave.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnPeopleSave.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnPeopleSave.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPeopleSave.TabIndex = 284;
            btnPeopleSave.Values.DropDownArrowColor = Color.Empty;
            btnPeopleSave.Values.Text = "Issue New Driving License (First Time)";
            btnPeopleSave.Click += btnPeopleSave_Click;
            // 
            // frmIssueLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnPeopleSave);
            Controls.Add(tbnotes);
            Controls.Add(kryptonLabel3);
            Controls.Add(ctrlApplicationShow1);
            Controls.Add(ctrlLocal_dlA_Details1);
            Name = "frmIssueLicense";
            StartPosition = FormStartPosition.Manual;
            Text = "frmIssueLicense";
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(ctrlLocal_dlA_Details1, 0);
            Controls.SetChildIndex(ctrlApplicationShow1, 0);
            Controls.SetChildIndex(kryptonLabel3, 0);
            Controls.SetChildIndex(tbnotes, 0);
            Controls.SetChildIndex(btnPeopleSave, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlApplicationShow ctrlApplicationShow1;
        private ctrlLocal_DLA_Details ctrlLocal_dlA_Details1;
        private Krypton.Toolkit.KryptonTextBox tbnotes;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnPeopleSave;
    }
}