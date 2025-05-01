namespace DVLD_Presentation
{
    partial class frmUsersAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersAddUpdate));
            toolTipCancel = new ToolTip(components);
            btnUsersCancel = new Krypton.Toolkit.KryptonPictureBox();
            tabUserControl = new TabControl();
            pagePerson = new TabPage();
            ctrlPersonFilter1 = new ctrlPersonFilter();
            ctrlPeopleShowDetails1 = new ctrlPeopleShowDetails();
            pageUser = new TabPage();
            ctrlUsersAddUpdate1 = new ctrlUsersAddUpdate();
            lblUserTitle = new Krypton.Toolkit.KryptonLabel();
            btnUserNext = new Krypton.Toolkit.KryptonButton();
            btnUserBack = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)btnUsersCancel).BeginInit();
            tabUserControl.SuspendLayout();
            pagePerson.SuspendLayout();
            pageUser.SuspendLayout();
            SuspendLayout();
            // 
            // toolTipCancel
            // 
            toolTipCancel.BackColor = Color.Gainsboro;
            toolTipCancel.ForeColor = Color.DarkSlateBlue;
            // 
            // btnUsersCancel
            // 
            btnUsersCancel.Cursor = Cursors.Hand;
            btnUsersCancel.Image = (Image)resources.GetObject("btnUsersCancel.Image");
            btnUsersCancel.Location = new Point(1400, 30);
            btnUsersCancel.Name = "btnUsersCancel";
            btnUsersCancel.Size = new Size(150, 100);
            btnUsersCancel.SizeMode = PictureBoxSizeMode.Zoom;
            btnUsersCancel.TabIndex = 213;
            btnUsersCancel.TabStop = false;
            toolTipCancel.SetToolTip(btnUsersCancel, "Close");
            btnUsersCancel.Click += btnUsersCancel_Click;
            // 
            // tabUserControl
            // 
            tabUserControl.Appearance = TabAppearance.FlatButtons;
            tabUserControl.Controls.Add(pagePerson);
            tabUserControl.Controls.Add(pageUser);
            tabUserControl.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabUserControl.Location = new Point(1, 55);
            tabUserControl.Name = "tabUserControl";
            tabUserControl.SelectedIndex = 0;
            tabUserControl.Size = new Size(1405, 936);
            tabUserControl.TabIndex = 214;
            tabUserControl.Selecting += tabUserControl_Selecting;
            // 
            // pagePerson
            // 
            pagePerson.BackColor = Color.Gainsboro;
            pagePerson.Controls.Add(ctrlPersonFilter1);
            pagePerson.Controls.Add(ctrlPeopleShowDetails1);
            pagePerson.Location = new Point(4, 52);
            pagePerson.Name = "pagePerson";
            pagePerson.Padding = new Padding(3);
            pagePerson.Size = new Size(1397, 880);
            pagePerson.TabIndex = 0;
            pagePerson.Text = "Person Info";
            // 
            // ctrlPersonFilter1
            // 
            ctrlPersonFilter1.Location = new Point(41, 19);
            ctrlPersonFilter1.Margin = new Padding(4, 3, 4, 3);
            ctrlPersonFilter1.Name = "ctrlPersonFilter1";
            ctrlPersonFilter1.Size = new Size(1312, 138);
            ctrlPersonFilter1.TabIndex = 1;
            ctrlPersonFilter1.OnPersonSearchComplete += ctrlPersonFilter1_OnPersonSearchComplete;
            // 
            // ctrlPeopleShowDetails1
            // 
            ctrlPeopleShowDetails1.BackColor = Color.Gainsboro;
            ctrlPeopleShowDetails1.Location = new Point(31, 150);
            ctrlPeopleShowDetails1.Margin = new Padding(4, 3, 4, 3);
            ctrlPeopleShowDetails1.Name = "ctrlPeopleShowDetails1";
            ctrlPeopleShowDetails1.Size = new Size(1325, 723);
            ctrlPeopleShowDetails1.TabIndex = 2;
            // 
            // pageUser
            // 
            pageUser.BackColor = Color.Gainsboro;
            pageUser.Controls.Add(ctrlUsersAddUpdate1);
            pageUser.Location = new Point(4, 52);
            pageUser.Name = "pageUser";
            pageUser.Padding = new Padding(3);
            pageUser.Size = new Size(1397, 880);
            pageUser.TabIndex = 1;
            pageUser.Text = "User Info";
            // 
            // ctrlUsersAddUpdate1
            // 
            ctrlUsersAddUpdate1.BackColor = Color.Lavender;
            ctrlUsersAddUpdate1.Location = new Point(398, 140);
            ctrlUsersAddUpdate1.Name = "ctrlUsersAddUpdate1";
            ctrlUsersAddUpdate1.Size = new Size(614, 537);
            ctrlUsersAddUpdate1.TabIndex = 5;
            // 
            // lblUserTitle
            // 
            lblUserTitle.AutoSize = false;
            lblUserTitle.Location = new Point(575, -30);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(476, 104);
            lblUserTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblUserTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserTitle.TabIndex = 211;
            lblUserTitle.TabStop = false;
            lblUserTitle.Values.Text = "Add New Person";
            // 
            // btnUserNext
            // 
            btnUserNext.Location = new Point(1156, 997);
            btnUserNext.Name = "btnUserNext";
            btnUserNext.OverrideDefault.Back.Color1 = Color.Silver;
            btnUserNext.OverrideDefault.Border.Rounding = 50F;
            btnUserNext.OverrideFocus.Back.Color1 = Color.Silver;
            btnUserNext.OverrideFocus.Border.Rounding = 50F;
            btnUserNext.Size = new Size(205, 73);
            btnUserNext.StateDisabled.Back.Color1 = Color.Silver;
            btnUserNext.StateDisabled.Border.Rounding = 50F;
            btnUserNext.StateNormal.Back.Color1 = Color.Silver;
            btnUserNext.StateNormal.Back.Color2 = Color.Silver;
            btnUserNext.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserNext.StateNormal.Border.Rounding = 50F;
            btnUserNext.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnUserNext.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserNext.StatePressed.Back.Color1 = Color.Silver;
            btnUserNext.StatePressed.Back.Color2 = Color.Silver;
            btnUserNext.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserNext.StatePressed.Border.Color1 = Color.Gainsboro;
            btnUserNext.StatePressed.Border.Color2 = Color.Gainsboro;
            btnUserNext.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserNext.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserNext.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserNext.StatePressed.Border.Rounding = 50F;
            btnUserNext.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnUserNext.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserNext.StateTracking.Back.Color1 = Color.Silver;
            btnUserNext.StateTracking.Back.Color2 = Color.Silver;
            btnUserNext.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserNext.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserNext.StateTracking.Border.Color1 = Color.Gainsboro;
            btnUserNext.StateTracking.Border.Color2 = Color.Gainsboro;
            btnUserNext.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserNext.StateTracking.Border.Rounding = 50F;
            btnUserNext.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserNext.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnUserNext.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnUserNext.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnUserNext.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserNext.TabIndex = 4;
            btnUserNext.Values.DropDownArrowColor = Color.Empty;
            btnUserNext.Values.Text = "Next";
            btnUserNext.Click += btnUserNext_Click;
            // 
            // btnUserBack
            // 
            btnUserBack.Location = new Point(1156, 997);
            btnUserBack.Name = "btnUserBack";
            btnUserBack.OverrideDefault.Back.Color1 = Color.Silver;
            btnUserBack.OverrideDefault.Border.Rounding = 50F;
            btnUserBack.OverrideFocus.Back.Color1 = Color.Silver;
            btnUserBack.OverrideFocus.Border.Rounding = 50F;
            btnUserBack.Size = new Size(205, 73);
            btnUserBack.StateDisabled.Back.Color1 = Color.Silver;
            btnUserBack.StateDisabled.Border.Rounding = 50F;
            btnUserBack.StateNormal.Back.Color1 = Color.Silver;
            btnUserBack.StateNormal.Back.Color2 = Color.Silver;
            btnUserBack.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserBack.StateNormal.Border.Rounding = 50F;
            btnUserBack.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnUserBack.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserBack.StatePressed.Back.Color1 = Color.Silver;
            btnUserBack.StatePressed.Back.Color2 = Color.Silver;
            btnUserBack.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserBack.StatePressed.Border.Color1 = Color.Gainsboro;
            btnUserBack.StatePressed.Border.Color2 = Color.Gainsboro;
            btnUserBack.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserBack.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserBack.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserBack.StatePressed.Border.Rounding = 50F;
            btnUserBack.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnUserBack.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserBack.StateTracking.Back.Color1 = Color.Silver;
            btnUserBack.StateTracking.Back.Color2 = Color.Silver;
            btnUserBack.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserBack.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnUserBack.StateTracking.Border.Color1 = Color.Gainsboro;
            btnUserBack.StateTracking.Border.Color2 = Color.Gainsboro;
            btnUserBack.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnUserBack.StateTracking.Border.Rounding = 50F;
            btnUserBack.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnUserBack.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnUserBack.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnUserBack.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnUserBack.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUserBack.TabIndex = 3;
            btnUserBack.Values.DropDownArrowColor = Color.Empty;
            btnUserBack.Values.Text = "Back";
            btnUserBack.Click += btnUserBack_Click;
            // 
            // frmUsersAddUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1575, 1084);
            Controls.Add(btnUserBack);
            Controls.Add(btnUserNext);
            Controls.Add(tabUserControl);
            Controls.Add(btnUsersCancel);
            Controls.Add(lblUserTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsersAddUpdate";
            Text = "frmUsersAddUpdate";
            Load += frmUsersAddUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)btnUsersCancel).EndInit();
            tabUserControl.ResumeLayout(false);
            pagePerson.ResumeLayout(false);
            pageUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public static Krypton.Toolkit.KryptonLabel lblUserTitle;
        private ToolTip toolTipCancel;
        private Krypton.Toolkit.KryptonPictureBox btnUsersCancel;
        private TabControl tabUserControl;
        private TabPage pagePerson;
        private TabPage pageUser;
        private ctrlPeopleShowDetails ctrlPeopleShowDetails1;
        private ctrlPersonFilter ctrlPersonFilter1;
        private Krypton.Toolkit.KryptonButton btnUserNext;
        private Krypton.Toolkit.KryptonButton btnUserBack;
        private ctrlUsersAddUpdate ctrlUsersAddUpdate1;
        
    }
}