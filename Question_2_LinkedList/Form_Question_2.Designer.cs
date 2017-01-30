namespace Question_2_LinkedList
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFifthFromLastString = new System.Windows.Forms.Button();
            this.button_FithFromLast_Integer = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFifthFromLastString);
            this.groupBox2.Controls.Add(this.button_FithFromLast_Integer);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 131);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question 2 - Linked List";
            // 
            // buttonFifthFromLastString
            // 
            this.buttonFifthFromLastString.Location = new System.Drawing.Point(52, 79);
            this.buttonFifthFromLastString.Name = "buttonFifthFromLastString";
            this.buttonFifthFromLastString.Size = new System.Drawing.Size(131, 23);
            this.buttonFifthFromLastString.TabIndex = 2;
            this.buttonFifthFromLastString.Text = "Find 5th to End String";
            this.buttonFifthFromLastString.UseVisualStyleBackColor = true;
            this.buttonFifthFromLastString.Click += new System.EventHandler(this.button_FithFromLast_String_Click);
            // 
            // button_FithFromLast_Integer
            // 
            this.button_FithFromLast_Integer.Location = new System.Drawing.Point(52, 36);
            this.button_FithFromLast_Integer.Name = "button_FithFromLast_Integer";
            this.button_FithFromLast_Integer.Size = new System.Drawing.Size(131, 23);
            this.button_FithFromLast_Integer.TabIndex = 1;
            this.button_FithFromLast_Integer.Text = "Find 5th to End Integer";
            this.button_FithFromLast_Integer.UseVisualStyleBackColor = true;
            this.button_FithFromLast_Integer.Click += new System.EventHandler(this.button_FithFromLast_Integer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 168);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Question 2 : Linked List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFifthFromLastString;
        private System.Windows.Forms.Button button_FithFromLast_Integer;
    }
}

