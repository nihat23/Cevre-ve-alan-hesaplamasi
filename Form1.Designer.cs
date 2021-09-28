
namespace Çevre_ve_Alan__Hesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5Alan = new System.Windows.Forms.Label();
            this.label6Cevre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1Hesapla = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5Alan
            // 
            this.label5Alan.AutoSize = true;
            this.label5Alan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5Alan.Location = new System.Drawing.Point(127, 188);
            this.label5Alan.Name = "label5Alan";
            this.label5Alan.Size = new System.Drawing.Size(27, 19);
            this.label5Alan.TabIndex = 17;
            this.label5Alan.Text = "00";
            // 
            // label6Cevre
            // 
            this.label6Cevre.AutoSize = true;
            this.label6Cevre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6Cevre.Location = new System.Drawing.Point(123, 152);
            this.label6Cevre.Name = "label6Cevre";
            this.label6Cevre.Size = new System.Drawing.Size(27, 19);
            this.label6Cevre.TabIndex = 16;
            this.label6Cevre.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alan :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Çevre :";
            // 
            // button1Hesapla
            // 
            this.button1Hesapla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1Hesapla.BackColor = System.Drawing.Color.Red;
            this.button1Hesapla.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold);
            this.button1Hesapla.ForeColor = System.Drawing.Color.White;
            this.button1Hesapla.Location = new System.Drawing.Point(126, 87);
            this.button1Hesapla.Name = "button1Hesapla";
            this.button1Hesapla.Size = new System.Drawing.Size(106, 36);
            this.button1Hesapla.TabIndex = 13;
            this.button1Hesapla.Text = "Hesapla";
            this.button1Hesapla.UseVisualStyleBackColor = false;
            this.button1Hesapla.Click += new System.EventHandler(this.button1Hesapla_Click);
            this.button1Hesapla.MouseLeave += new System.EventHandler(this.button1Hesapla_MouseLeave);
            this.button1Hesapla.MouseHover += new System.EventHandler(this.button1Hesapla_MouseHover);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(122, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 26);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(122, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 26);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kısa Kenar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Uzun Kenar :";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1Hesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 216);
            this.Controls.Add(this.label5Alan);
            this.Controls.Add(this.label6Cevre);
            this.Controls.Add(this.button1Hesapla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Çevre ve Alan Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5Alan;
        private System.Windows.Forms.Label label6Cevre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1Hesapla;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

