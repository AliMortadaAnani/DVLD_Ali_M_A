namespace DVLD_Presentation
{
    partial class frmLocal_DLA_AddUpdate
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
            tabLocalControl = new TabControl();
            pagePerson = new TabPage();
            ctrlPersonFilter1 = new ctrlPersonFilter();
            ctrlPeopleShowDetails1 = new ctrlPeopleShowDetails();
            pageLocal = new TabPage();
            ctrlLocaldlA_AddUpdate1 = new ctrlLocalDLA_AddUpdate();
            btnLocalBack = new Krypton.Toolkit.KryptonButton();
            btnLocalNext = new Krypton.Toolkit.KryptonButton();
            lbLocalTitle = new Krypton.Toolkit.KryptonLabel();
            toolTip2 = new ToolTip(components);
            btnDocumentation = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).BeginInit();
            tabLocalControl.SuspendLayout();
            pagePerson.SuspendLayout();
            pageLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).BeginInit();
            SuspendLayout();
            // 
            // btnGeneralCancel
            // 
            toolTipCancel.SetToolTip(btnGeneralCancel, "Close");
            // 
            // lblGeneralTitle
            // 
            lblGeneralTitle.Location = new Point(575, -7);
            lblGeneralTitle.Size = new Size(551, 54);
            lblGeneralTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lblGeneralTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGeneralTitle.Values.Text = "Add New Local DLA";
            lblGeneralTitle.Visible = false;
            // 
            // tabLocalControl
            // 
            tabLocalControl.Appearance = TabAppearance.FlatButtons;
            tabLocalControl.Controls.Add(pagePerson);
            tabLocalControl.Controls.Add(pageLocal);
            tabLocalControl.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabLocalControl.Location = new Point(2, 44);
            tabLocalControl.Name = "tabLocalControl";
            tabLocalControl.SelectedIndex = 0;
            tabLocalControl.Size = new Size(1405, 936);
            tabLocalControl.TabIndex = 215;
            tabLocalControl.Selecting += tabUserControl_Selecting;
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
            // pageLocal
            // 
            pageLocal.BackColor = Color.Gainsboro;
            pageLocal.Controls.Add(ctrlLocaldlA_AddUpdate1);
            pageLocal.Location = new Point(4, 52);
            pageLocal.Name = "pageLocal";
            pageLocal.Padding = new Padding(3);
            pageLocal.Size = new Size(1397, 880);
            pageLocal.TabIndex = 1;
            pageLocal.Text = "Local DLA Info";
            // 
            // ctrlLocaldlA_AddUpdate1
            // 
            ctrlLocaldlA_AddUpdate1.BackColor = Color.Lavender;
            ctrlLocaldlA_AddUpdate1.Location = new Point(198, 121);
            ctrlLocaldlA_AddUpdate1.Name = "ctrlLocaldlA_AddUpdate1";
            ctrlLocaldlA_AddUpdate1.Size = new Size(922, 596);
            ctrlLocaldlA_AddUpdate1.TabIndex = 0;
            // 
            // btnLocalBack
            // 
            btnLocalBack.Location = new Point(1202, 999);
            btnLocalBack.Name = "btnLocalBack";
            btnLocalBack.OverrideDefault.Back.Color1 = Color.Silver;
            btnLocalBack.OverrideDefault.Border.Rounding = 50F;
            btnLocalBack.OverrideFocus.Back.Color1 = Color.Silver;
            btnLocalBack.OverrideFocus.Border.Rounding = 50F;
            btnLocalBack.Size = new Size(205, 73);
            btnLocalBack.StateDisabled.Back.Color1 = Color.Silver;
            btnLocalBack.StateDisabled.Border.Rounding = 50F;
            btnLocalBack.StateNormal.Back.Color1 = Color.Silver;
            btnLocalBack.StateNormal.Back.Color2 = Color.Silver;
            btnLocalBack.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalBack.StateNormal.Border.Rounding = 50F;
            btnLocalBack.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnLocalBack.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalBack.StatePressed.Back.Color1 = Color.Silver;
            btnLocalBack.StatePressed.Back.Color2 = Color.Silver;
            btnLocalBack.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalBack.StatePressed.Border.Color1 = Color.Gainsboro;
            btnLocalBack.StatePressed.Border.Color2 = Color.Gainsboro;
            btnLocalBack.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalBack.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalBack.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalBack.StatePressed.Border.Rounding = 50F;
            btnLocalBack.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnLocalBack.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalBack.StateTracking.Back.Color1 = Color.Silver;
            btnLocalBack.StateTracking.Back.Color2 = Color.Silver;
            btnLocalBack.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalBack.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalBack.StateTracking.Border.Color1 = Color.Gainsboro;
            btnLocalBack.StateTracking.Border.Color2 = Color.Gainsboro;
            btnLocalBack.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalBack.StateTracking.Border.Rounding = 50F;
            btnLocalBack.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalBack.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnLocalBack.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnLocalBack.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnLocalBack.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalBack.TabIndex = 216;
            btnLocalBack.Values.DropDownArrowColor = Color.Empty;
            btnLocalBack.Values.Text = "Back";
            btnLocalBack.Click += btnLocalBack_Click;
            // 
            // btnLocalNext
            // 
            btnLocalNext.Location = new Point(1202, 999);
            btnLocalNext.Name = "btnLocalNext";
            btnLocalNext.OverrideDefault.Back.Color1 = Color.Silver;
            btnLocalNext.OverrideDefault.Border.Rounding = 50F;
            btnLocalNext.OverrideFocus.Back.Color1 = Color.Silver;
            btnLocalNext.OverrideFocus.Border.Rounding = 50F;
            btnLocalNext.Size = new Size(205, 73);
            btnLocalNext.StateDisabled.Back.Color1 = Color.Silver;
            btnLocalNext.StateDisabled.Border.Rounding = 50F;
            btnLocalNext.StateNormal.Back.Color1 = Color.Silver;
            btnLocalNext.StateNormal.Back.Color2 = Color.Silver;
            btnLocalNext.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalNext.StateNormal.Border.Rounding = 50F;
            btnLocalNext.StateNormal.Content.ShortText.Color1 = Color.DimGray;
            btnLocalNext.StateNormal.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalNext.StatePressed.Back.Color1 = Color.Silver;
            btnLocalNext.StatePressed.Back.Color2 = Color.Silver;
            btnLocalNext.StatePressed.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalNext.StatePressed.Border.Color1 = Color.Gainsboro;
            btnLocalNext.StatePressed.Border.Color2 = Color.Gainsboro;
            btnLocalNext.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalNext.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalNext.StatePressed.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalNext.StatePressed.Border.Rounding = 50F;
            btnLocalNext.StatePressed.Content.ShortText.Color1 = Color.DimGray;
            btnLocalNext.StatePressed.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalNext.StateTracking.Back.Color1 = Color.Silver;
            btnLocalNext.StateTracking.Back.Color2 = Color.Silver;
            btnLocalNext.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalNext.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            btnLocalNext.StateTracking.Border.Color1 = Color.Gainsboro;
            btnLocalNext.StateTracking.Border.Color2 = Color.Gainsboro;
            btnLocalNext.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            btnLocalNext.StateTracking.Border.Rounding = 50F;
            btnLocalNext.StateTracking.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnLocalNext.StateTracking.Content.DrawFocus = Krypton.Toolkit.InheritBool.False;
            btnLocalNext.StateTracking.Content.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            btnLocalNext.StateTracking.Content.ShortText.Color2 = Color.FromArgb(64, 64, 64);
            btnLocalNext.StateTracking.Content.ShortText.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalNext.TabIndex = 217;
            btnLocalNext.Values.DropDownArrowColor = Color.Empty;
            btnLocalNext.Values.Text = "Next";
            btnLocalNext.Click += btnLocalNext_Click;
            // 
            // lbLocalTitle
            // 
            lbLocalTitle.AutoSize = false;
            lbLocalTitle.Location = new Point(575, -11);
            lbLocalTitle.Name = "lbLocalTitle";
            lbLocalTitle.Size = new Size(551, 54);
            lbLocalTitle.StateNormal.ShortText.Color1 = SystemColors.InfoText;
            lbLocalTitle.StateNormal.ShortText.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLocalTitle.TabIndex = 218;
            lbLocalTitle.TabStop = false;
            lbLocalTitle.Values.Text = "Add New Local DLA";
            // 
            // btnDocumentation
            // 
            btnDocumentation.Cursor = Cursors.Hand;
            btnDocumentation.Image = Properties.Resources.information_8564573_1280;
            btnDocumentation.Location = new Point(2, 3);
            btnDocumentation.Name = "btnDocumentation";
            btnDocumentation.Size = new Size(78, 40);
            btnDocumentation.SizeMode = PictureBoxSizeMode.Zoom;
            btnDocumentation.TabIndex = 219;
            btnDocumentation.TabStop = false;
            toolTip2.SetToolTip(btnDocumentation, "About this form");
            btnDocumentation.Click += btnDocumentation_Click_1;
            // 
            // frmLocal_DLA_AddUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 1084);
            Controls.Add(btnDocumentation);
            Controls.Add(lbLocalTitle);
            Controls.Add(btnLocalBack);
            Controls.Add(btnLocalNext);
            Controls.Add(tabLocalControl);
            Name = "frmLocal_DLA_AddUpdate";
            StartPosition = FormStartPosition.Manual;
            Text = "frmLocal_DLA_AddUpdate";
            Load += frmLocal_DLA_AddUpdate_Load;
            Controls.SetChildIndex(btnGeneralCancel, 0);
            Controls.SetChildIndex(lblGeneralTitle, 0);
            Controls.SetChildIndex(tabLocalControl, 0);
            Controls.SetChildIndex(btnLocalNext, 0);
            Controls.SetChildIndex(btnLocalBack, 0);
            Controls.SetChildIndex(lbLocalTitle, 0);
            Controls.SetChildIndex(btnDocumentation, 0);
            ((System.ComponentModel.ISupportInitialize)btnGeneralCancel).EndInit();
            tabLocalControl.ResumeLayout(false);
            pagePerson.ResumeLayout(false);
            pageLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDocumentation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabLocalControl;
        private TabPage pagePerson;
        private ctrlPersonFilter ctrlPersonFilter1;
        private ctrlPeopleShowDetails ctrlPeopleShowDetails1;
        private TabPage pageLocal;
        private Krypton.Toolkit.KryptonButton btnLocalBack;
        private Krypton.Toolkit.KryptonButton btnLocalNext;
        private ctrlLocalDLA_AddUpdate ctrlLocaldlA_AddUpdate1;
        private ToolTip toolTip2;
        private Krypton.Toolkit.KryptonPictureBox btnDocumentation;
        public static Krypton.Toolkit.KryptonLabel lbLocalTitle;
    }
}