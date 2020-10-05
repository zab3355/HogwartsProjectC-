namespace Form1
{
    partial class EditDetentionForm
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
            this.reason = new System.Windows.Forms.TextBox();
            this.punishment = new System.Windows.Forms.TextBox();
            this.issuedby = new System.Windows.Forms.TextBox();
            this.pointstaken = new System.Windows.Forms.NumericUpDown();
            this.dateissued = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointstaken)).BeginInit();
            this.SuspendLayout();
            // 
            // reason
            // 
            this.reason.Location = new System.Drawing.Point(129, 117);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(210, 22);
            this.reason.TabIndex = 0;
            this.reason.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // punishment
            // 
            this.punishment.Location = new System.Drawing.Point(129, 169);
            this.punishment.Name = "punishment";
            this.punishment.Size = new System.Drawing.Size(183, 22);
            this.punishment.TabIndex = 1;
            // 
            // issuedby
            // 
            this.issuedby.Location = new System.Drawing.Point(129, 221);
            this.issuedby.Name = "issuedby";
            this.issuedby.Size = new System.Drawing.Size(210, 22);
            this.issuedby.TabIndex = 2;
            // 
            // pointstaken
            // 
            this.pointstaken.Location = new System.Drawing.Point(151, 273);
            this.pointstaken.Name = "pointstaken";
            this.pointstaken.Size = new System.Drawing.Size(66, 22);
            this.pointstaken.TabIndex = 3;
            // 
            // dateissued
            // 
            this.dateissued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateissued.Location = new System.Drawing.Point(141, 324);
            this.dateissued.Name = "dateissued";
            this.dateissued.Size = new System.Drawing.Size(189, 22);
            this.dateissued.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reason:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Punishment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Issued By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Points Taken:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Issued:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Parry Hotter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 95);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edit - Detention Form";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("TT Masters DEMO Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(66, 380);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 48);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("TT Masters DEMO Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(242, 377);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(146, 51);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditDetentionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 454);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateissued);
            this.Controls.Add(this.pointstaken);
            this.Controls.Add(this.issuedby);
            this.Controls.Add(this.punishment);
            this.Controls.Add(this.reason);
            this.Name = "EditDetentionForm";
            this.Text = "EditDetentionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pointstaken)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reason;
        private System.Windows.Forms.TextBox punishment;
        private System.Windows.Forms.TextBox issuedby;
        private System.Windows.Forms.NumericUpDown pointstaken;
        private System.Windows.Forms.DateTimePicker dateissued;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
    }
}