namespace Question_3_PrimeFactors
{
    partial class Form_Question_3
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_ViewFile = new System.Windows.Forms.Button();
            this.listBox_primeFactors = new System.Windows.Forms.ListBox();
            this.button_GeneratePrimeNumbers = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button_ViewFile);
            this.groupBox3.Controls.Add(this.listBox_primeFactors);
            this.groupBox3.Controls.Add(this.button_GeneratePrimeNumbers);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 276);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question 3 Generate Prime Factors";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Prime Number Results";
            // 
            // button_ViewFile
            // 
            this.button_ViewFile.Location = new System.Drawing.Point(185, 19);
            this.button_ViewFile.Name = "button_ViewFile";
            this.button_ViewFile.Size = new System.Drawing.Size(103, 23);
            this.button_ViewFile.TabIndex = 2;
            this.button_ViewFile.Text = "View File";
            this.button_ViewFile.UseVisualStyleBackColor = true;
            this.button_ViewFile.Click += new System.EventHandler(this.button_ViewFile_Click_1);
            // 
            // listBox_primeFactors
            // 
            this.listBox_primeFactors.FormattingEnabled = true;
            this.listBox_primeFactors.Location = new System.Drawing.Point(16, 74);
            this.listBox_primeFactors.Name = "listBox_primeFactors";
            this.listBox_primeFactors.Size = new System.Drawing.Size(272, 186);
            this.listBox_primeFactors.TabIndex = 1;
            // 
            // button_GeneratePrimeNumbers
            // 
            this.button_GeneratePrimeNumbers.Location = new System.Drawing.Point(16, 22);
            this.button_GeneratePrimeNumbers.Name = "button_GeneratePrimeNumbers";
            this.button_GeneratePrimeNumbers.Size = new System.Drawing.Size(142, 23);
            this.button_GeneratePrimeNumbers.TabIndex = 0;
            this.button_GeneratePrimeNumbers.Text = "Read File and Compute";
            this.button_GeneratePrimeNumbers.UseVisualStyleBackColor = true;
            this.button_GeneratePrimeNumbers.Click += new System.EventHandler(this.button_GeneratePrimeNumbers_Click);
            // 
            // Form_Question_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 296);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form_Question_3";
            this.Text = "Question 3 Prime Factors";
            this.Load += new System.EventHandler(this.Form_Question_3_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_ViewFile;
        private System.Windows.Forms.ListBox listBox_primeFactors;
        private System.Windows.Forms.Button button_GeneratePrimeNumbers;
    }
}

