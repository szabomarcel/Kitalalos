namespace Kitalalos
{
    partial class formBevitel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Bevitel = new System.Windows.Forms.TextBox();
            this.button_Bevitel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Bevitel);
            this.groupBox1.Controls.Add(this.textBox_Bevitel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beviteli adat";
            // 
            // textBox_Bevitel
            // 
            this.textBox_Bevitel.Location = new System.Drawing.Point(6, 19);
            this.textBox_Bevitel.Name = "textBox_Bevitel";
            this.textBox_Bevitel.Size = new System.Drawing.Size(127, 20);
            this.textBox_Bevitel.TabIndex = 0;
            // 
            // button_Bevitel
            // 
            this.button_Bevitel.Location = new System.Drawing.Point(7, 46);
            this.button_Bevitel.Name = "button_Bevitel";
            this.button_Bevitel.Size = new System.Drawing.Size(126, 23);
            this.button_Bevitel.TabIndex = 1;
            this.button_Bevitel.Text = "Bevitel";
            this.button_Bevitel.UseVisualStyleBackColor = true;
            // 
            // Bevitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 99);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bevitel";
            this.Text = "Bevitel";
            this.Load += new System.EventHandler(this.Bevitel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Bevitel;
        private System.Windows.Forms.TextBox textBox_Bevitel;
    }
}