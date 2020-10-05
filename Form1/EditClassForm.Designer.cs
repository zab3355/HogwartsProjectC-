namespace Form1
{
    partial class EditClassForm
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
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.SubjectBox = new System.Windows.Forms.ComboBox();
            this.GradeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YearBox
            // 
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.YearBox.Location = new System.Drawing.Point(146, 144);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(214, 24);
            this.YearBox.TabIndex = 0;
            // 
            // SubjectBox
            // 
            this.SubjectBox.FormattingEnabled = true;
            this.SubjectBox.Items.AddRange(new object[] {
            "Astronomy",
            "Charms",
            "DefenceAgainstTheDarkArts",
            "Flying",
            "Herbology",
            "HistoryOfMagic",
            "MuggleStudies",
            "Potions",
            "Transfiguration",
            "Alchemy",
            "Apparition",
            "Arithmancy",
            "CareOfMagicalCreatures",
            "Divination",
            "StudyOfAncientRunes",
            "AncientStudies",
            "Art",
            "FrogChoir",
            "GhoulStudies",
            "MagicalTheory",
            "MuggleArt",
            "Music",
            "MuggleMusic",
            "Orchestra",
            "Xylomancy"});
            this.SubjectBox.Location = new System.Drawing.Point(146, 225);
            this.SubjectBox.Name = "SubjectBox";
            this.SubjectBox.Size = new System.Drawing.Size(214, 24);
            this.SubjectBox.TabIndex = 1;
            // 
            // GradeBox
            // 
            this.GradeBox.FormattingEnabled = true;
            this.GradeBox.Items.AddRange(new object[] {
            "None",
            "Outstanding",
            "ExceedsExpectations",
            "Acceptable",
            "Poor",
            "Dreadful",
            "Troll"});
            this.GradeBox.Location = new System.Drawing.Point(146, 303);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(214, 24);
            this.GradeBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Parry Hotter", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 112);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edit - Class Form";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("TT Masters DEMO Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(67, 406);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(135, 69);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("TT Masters DEMO Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(238, 406);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(144, 69);
            this.Close.TabIndex = 8;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 512);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.SubjectBox);
            this.Controls.Add(this.YearBox);
            this.Name = "EditClassForm";
            this.Text = "EditClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.ComboBox SubjectBox;
        private System.Windows.Forms.ComboBox GradeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Close;
    }
}