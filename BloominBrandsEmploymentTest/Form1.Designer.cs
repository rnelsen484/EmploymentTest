namespace BloominBrandsEmploymentTest
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
            this.numericUpDown_A = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_B = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_C = new System.Windows.Forms.NumericUpDown();
            this.Label_answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_C)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_A
            // 
            this.numericUpDown_A.Location = new System.Drawing.Point(71, 9);
            this.numericUpDown_A.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_A.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_A.Name = "numericUpDown_A";
            this.numericUpDown_A.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_A.TabIndex = 1;
            this.numericUpDown_A.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_A.ValueChanged += new System.EventHandler(this.numericUpDown_A_ValueChanged);
            // 
            // numericUpDown_B
            // 
            this.numericUpDown_B.Location = new System.Drawing.Point(71, 35);
            this.numericUpDown_B.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_B.Name = "numericUpDown_B";
            this.numericUpDown_B.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_B.TabIndex = 2;
            this.numericUpDown_B.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_B.ValueChanged += new System.EventHandler(this.numericUpDown_B_ValueChanged);
            // 
            // numericUpDown_C
            // 
            this.numericUpDown_C.Location = new System.Drawing.Point(71, 61);
            this.numericUpDown_C.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_C.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_C.Name = "numericUpDown_C";
            this.numericUpDown_C.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_C.TabIndex = 3;
            this.numericUpDown_C.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_C.ValueChanged += new System.EventHandler(this.numericUpDown_C_ValueChanged);
            // 
            // Label_answer
            // 
            this.Label_answer.AutoSize = true;
            this.Label_answer.Location = new System.Drawing.Point(185, 37);
            this.Label_answer.Name = "Label_answer";
            this.Label_answer.Size = new System.Drawing.Size(48, 13);
            this.Label_answer.TabIndex = 4;
            this.Label_answer.Text = "[Answer]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter 3 sides of triangle and determine its type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Side A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Side B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Side C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_answer);
            this.Controls.Add(this.numericUpDown_C);
            this.Controls.Add(this.numericUpDown_B);
            this.Controls.Add(this.numericUpDown_A);
            this.Name = "Form1";
            this.Text = "Question 1 Triangle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_A;
        private System.Windows.Forms.NumericUpDown numericUpDown_B;
        private System.Windows.Forms.NumericUpDown numericUpDown_C;
        private System.Windows.Forms.Label Label_answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

