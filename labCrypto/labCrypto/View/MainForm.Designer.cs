namespace labCrypto
{
    partial class MainForm
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
            this.btLab1 = new System.Windows.Forms.Button();
            this.btLab2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLab1
            // 
            this.btLab1.Location = new System.Drawing.Point(168, 42);
            this.btLab1.Name = "btLab1";
            this.btLab1.Size = new System.Drawing.Size(112, 31);
            this.btLab1.TabIndex = 0;
            this.btLab1.Text = "button1";
            this.btLab1.UseVisualStyleBackColor = true;
            this.btLab1.Click += new System.EventHandler(this.btLab1_Click);
            // 
            // btLab2
            // 
            this.btLab2.Location = new System.Drawing.Point(168, 94);
            this.btLab2.Name = "btLab2";
            this.btLab2.Size = new System.Drawing.Size(112, 31);
            this.btLab2.TabIndex = 1;
            this.btLab2.Text = "Lab 2";
            this.btLab2.UseVisualStyleBackColor = true;
            this.btLab2.Click += new System.EventHandler(this.btLab2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 331);
            this.Controls.Add(this.btLab2);
            this.Controls.Add(this.btLab1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLab1;
        private System.Windows.Forms.Button btLab2;
    }
}