namespace Kitalalos
{
    partial class formJatek
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
            this.textBox_Rejtett_Szo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Tipp = new System.Windows.Forms.TextBox();
            this.listBox_Fajl = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Valasz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Rejtett_Szo
            // 
            this.textBox_Rejtett_Szo.Location = new System.Drawing.Point(12, 75);
            this.textBox_Rejtett_Szo.Name = "textBox_Rejtett_Szo";
            this.textBox_Rejtett_Szo.Size = new System.Drawing.Size(100, 20);
            this.textBox_Rejtett_Szo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rejtett Szó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipp:";
            // 
            // textBox_Tipp
            // 
            this.textBox_Tipp.Location = new System.Drawing.Point(118, 75);
            this.textBox_Tipp.Name = "textBox_Tipp";
            this.textBox_Tipp.Size = new System.Drawing.Size(100, 20);
            this.textBox_Tipp.TabIndex = 3;
            // 
            // listBox_Fajl
            // 
            this.listBox_Fajl.FormattingEnabled = true;
            this.listBox_Fajl.Location = new System.Drawing.Point(12, 12);
            this.listBox_Fajl.Name = "listBox_Fajl";
            this.listBox_Fajl.Size = new System.Drawing.Size(412, 30);
            this.listBox_Fajl.TabIndex = 4;
            this.listBox_Fajl.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.textBox_Valasz);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(224, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiíratás";
            // 
            // textBox_Valasz
            // 
            this.textBox_Valasz.Location = new System.Drawing.Point(48, 22);
            this.textBox_Valasz.Name = "textBox_Valasz";
            this.textBox_Valasz.Size = new System.Drawing.Size(145, 20);
            this.textBox_Valasz.TabIndex = 1;
            this.textBox_Valasz.TextChanged += new System.EventHandler(this.textBox_Valasz_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Válasz:";
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Start.Location = new System.Drawing.Point(12, 102);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(100, 23);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Stop.Location = new System.Drawing.Point(118, 102);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(100, 23);
            this.button_Stop.TabIndex = 7;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Crimson;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Reset.Location = new System.Drawing.Point(12, 131);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(408, 23);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // formJatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(436, 173);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Fajl);
            this.Controls.Add(this.textBox_Tipp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Rejtett_Szo);
            this.Name = "formJatek";
            this.Text = "Kezdőoldal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Rejtett_Szo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Tipp;
        private System.Windows.Forms.ListBox listBox_Fajl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Valasz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Reset;
    }
}