namespace Kitalalos
{
    partial class formKezdooldal
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
            this.button_Jatek = new System.Windows.Forms.Button();
            this.button_Bevitel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Jatek);
            this.groupBox1.Controls.Add(this.button_Bevitel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Választési lehetőségek";
            // 
            // button_Jatek
            // 
            this.button_Jatek.BackColor = System.Drawing.Color.Cornsilk;
            this.button_Jatek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Jatek.Location = new System.Drawing.Point(87, 19);
            this.button_Jatek.Name = "button_Jatek";
            this.button_Jatek.Size = new System.Drawing.Size(75, 23);
            this.button_Jatek.TabIndex = 1;
            this.button_Jatek.Text = "Játék";
            this.button_Jatek.UseVisualStyleBackColor = false;
            // 
            // button_Bevitel
            // 
            this.button_Bevitel.BackColor = System.Drawing.Color.SandyBrown;
            this.button_Bevitel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Bevitel.Location = new System.Drawing.Point(6, 19);
            this.button_Bevitel.Name = "button_Bevitel";
            this.button_Bevitel.Size = new System.Drawing.Size(75, 23);
            this.button_Bevitel.TabIndex = 0;
            this.button_Bevitel.Text = "Adatbevitel";
            this.button_Bevitel.UseVisualStyleBackColor = false;
            this.button_Bevitel.Click += new System.EventHandler(this.button_Bevitel_Click);
            // 
            // Kezdooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(208, 82);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Kezdooldal";
            this.Text = "Kezdőoldal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Jatek;
        private System.Windows.Forms.Button button_Bevitel;
    }
}

