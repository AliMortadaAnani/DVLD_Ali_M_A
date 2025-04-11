namespace DVLD_Presentation
{
    partial class test1
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
            ctrlPeopleShowDetails1 = new ctrlPeopleShowDetails();
            SuspendLayout();
            // 
            // ctrlPeopleShowDetails1
            // 
            ctrlPeopleShowDetails1.BackColor = Color.Gainsboro;
            ctrlPeopleShowDetails1.Location = new Point(251, 31);
            ctrlPeopleShowDetails1.myIntProperty = 0;
            ctrlPeopleShowDetails1.Name = "ctrlPeopleShowDetails1";
            ctrlPeopleShowDetails1.Size = new Size(1942, 1200);
            ctrlPeopleShowDetails1.TabIndex = 0;
            ctrlPeopleShowDetails1.myIntProperty = idd; // Set the property to 0 or any other value you want to test with
            // 
            // test1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1745, 764);
            Controls.Add(ctrlPeopleShowDetails1);
            Name = "test1";
            Text = "test1";
            ResumeLayout(false);
        }

        #endregion

        private ctrlPeopleShowDetails ctrlPeopleShowDetails1;
    }
}