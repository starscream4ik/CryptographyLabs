namespace labCrypto
{
    partial class DESform
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 201);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Привет мир!! Сегодня хороший день для сдачи лабораторной работы!!\nТак давайте же " +
    "ее и сдадим!=)";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(479, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(304, 201);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(343, 101);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(95, 20);
            this.txtKey.TabIndex = 2;
            this.txtKey.Text = "ABCD";
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(343, 144);
            this.txtIV.Name = "txtIV";
            this.txtIV.Size = new System.Drawing.Size(95, 20);
            this.txtIV.TabIndex = 3;
            this.txtIV.Text = "ABCD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Crypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DESform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DESform";
            this.Text = "DESform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}