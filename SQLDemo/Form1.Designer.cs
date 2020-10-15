namespace SQLDemo
{
    partial class Form1
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.ListPeopleLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 121);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(154, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add Person";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(12, 150);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(154, 23);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "Refresh List";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(12, 52);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(154, 20);
            this.FirstNameTB.TabIndex = 2;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(12, 95);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(154, 20);
            this.LastNameTB.TabIndex = 3;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(12, 36);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLbl.TabIndex = 4;
            this.FirstNameLbl.Text = "First Name:";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Location = new System.Drawing.Point(12, 79);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.LastNameLbl.TabIndex = 5;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // ListPeopleLB
            // 
            this.ListPeopleLB.FormattingEnabled = true;
            this.ListPeopleLB.Location = new System.Drawing.Point(172, 12);
            this.ListPeopleLB.Name = "ListPeopleLB";
            this.ListPeopleLB.Size = new System.Drawing.Size(209, 186);
            this.ListPeopleLB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 210);
            this.Controls.Add(this.ListPeopleLB);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.ListBox ListPeopleLB;
    }
}

