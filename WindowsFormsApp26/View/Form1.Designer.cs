namespace WindowsFormsApp26
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
            this.ResultLB = new System.Windows.Forms.ListBox();
            this.RequestCB = new System.Windows.Forms.ComboBox();
            this.ColorLB = new System.Windows.Forms.Label();
            this.ColorTB = new System.Windows.Forms.TextBox();
            this.MinCaloriesTB = new System.Windows.Forms.TextBox();
            this.CaloriesLB = new System.Windows.Forms.Label();
            this.MaxCaloriesTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultLB
            // 
            this.ResultLB.FormattingEnabled = true;
            this.ResultLB.Location = new System.Drawing.Point(228, 68);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(242, 355);
            this.ResultLB.TabIndex = 0;
            // 
            // RequestCB
            // 
            this.RequestCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RequestCB.FormattingEnabled = true;
            this.RequestCB.Location = new System.Drawing.Point(48, 28);
            this.RequestCB.Name = "RequestCB";
            this.RequestCB.Size = new System.Drawing.Size(422, 21);
            this.RequestCB.TabIndex = 1;
            this.RequestCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ColorLB
            // 
            this.ColorLB.AutoSize = true;
            this.ColorLB.Location = new System.Drawing.Point(53, 68);
            this.ColorLB.Name = "ColorLB";
            this.ColorLB.Size = new System.Drawing.Size(31, 13);
            this.ColorLB.TabIndex = 2;
            this.ColorLB.Text = "Color";
            // 
            // ColorTB
            // 
            this.ColorTB.Location = new System.Drawing.Point(56, 84);
            this.ColorTB.Name = "ColorTB";
            this.ColorTB.ReadOnly = true;
            this.ColorTB.Size = new System.Drawing.Size(137, 20);
            this.ColorTB.TabIndex = 3;
            this.ColorTB.TextChanged += new System.EventHandler(this.ColorTB_TextChanged);
            // 
            // MinCaloriesTB
            // 
            this.MinCaloriesTB.Location = new System.Drawing.Point(56, 144);
            this.MinCaloriesTB.Name = "MinCaloriesTB";
            this.MinCaloriesTB.ReadOnly = true;
            this.MinCaloriesTB.Size = new System.Drawing.Size(137, 20);
            this.MinCaloriesTB.TabIndex = 5;
            // 
            // CaloriesLB
            // 
            this.CaloriesLB.AutoSize = true;
            this.CaloriesLB.Location = new System.Drawing.Point(53, 128);
            this.CaloriesLB.Name = "CaloriesLB";
            this.CaloriesLB.Size = new System.Drawing.Size(64, 13);
            this.CaloriesLB.TabIndex = 4;
            this.CaloriesLB.Text = "Min Calories";
            // 
            // MaxCaloriesTB
            // 
            this.MaxCaloriesTB.Location = new System.Drawing.Point(56, 200);
            this.MaxCaloriesTB.Name = "MaxCaloriesTB";
            this.MaxCaloriesTB.ReadOnly = true;
            this.MaxCaloriesTB.Size = new System.Drawing.Size(137, 20);
            this.MaxCaloriesTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max Calories";
            // 
            // FindBtn
            // 
            this.FindBtn.Enabled = false;
            this.FindBtn.Location = new System.Drawing.Point(56, 242);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(75, 23);
            this.FindBtn.TabIndex = 8;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = true;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.FindBtn);
            this.Controls.Add(this.MaxCaloriesTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinCaloriesTB);
            this.Controls.Add(this.CaloriesLB);
            this.Controls.Add(this.ColorTB);
            this.Controls.Add(this.ColorLB);
            this.Controls.Add(this.RequestCB);
            this.Controls.Add(this.ResultLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ResultLB;
        private System.Windows.Forms.ComboBox RequestCB;
        private System.Windows.Forms.Label ColorLB;
        private System.Windows.Forms.TextBox ColorTB;
        private System.Windows.Forms.TextBox MinCaloriesTB;
        private System.Windows.Forms.Label CaloriesLB;
        private System.Windows.Forms.TextBox MaxCaloriesTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindBtn;
    }
}

