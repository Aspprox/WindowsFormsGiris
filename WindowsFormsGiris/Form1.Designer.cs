namespace WindowsFormsGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoyadi = new System.Windows.Forms.TextBox();
            this.bGoster = new System.Windows.Forms.Button();
            this.lAdSoyad = new System.Windows.Forms.Label();
            this.btemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbAdi
            // 
            this.tbAdi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAdi.ForeColor = System.Drawing.Color.Teal;
            this.tbAdi.Location = new System.Drawing.Point(128, 7);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(216, 37);
            this.tbAdi.TabIndex = 1;
            this.tbAdi.TextChanged += new System.EventHandler(this.tbAdi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoyadi.ForeColor = System.Drawing.Color.Teal;
            this.tbSoyadi.Location = new System.Drawing.Point(128, 50);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(216, 37);
            this.tbSoyadi.TabIndex = 3;
            this.tbSoyadi.TextChanged += new System.EventHandler(this.tbSoyadi_TextChanged);
            // 
            // bGoster
            // 
            this.bGoster.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGoster.Location = new System.Drawing.Point(128, 93);
            this.bGoster.Name = "bGoster";
            this.bGoster.Size = new System.Drawing.Size(75, 23);
            this.bGoster.TabIndex = 4;
            this.bGoster.Text = "Göster";
            this.bGoster.UseVisualStyleBackColor = true;
            this.bGoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // lAdSoyad
            // 
            this.lAdSoyad.BackColor = System.Drawing.Color.Orange;
            this.lAdSoyad.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lAdSoyad.Location = new System.Drawing.Point(12, 157);
            this.lAdSoyad.Name = "lAdSoyad";
            this.lAdSoyad.Size = new System.Drawing.Size(776, 46);
            this.lAdSoyad.TabIndex = 5;
            this.lAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btemizle
            // 
            this.btemizle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btemizle.Location = new System.Drawing.Point(269, 93);
            this.btemizle.Name = "btemizle";
            this.btemizle.Size = new System.Drawing.Size(75, 23);
            this.btemizle.TabIndex = 6;
            this.btemizle.Text = "Temizle";
            this.btemizle.UseVisualStyleBackColor = true;
            this.btemizle.Click += new System.EventHandler(this.btemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btemizle);
            this.Controls.Add(this.lAdSoyad);
            this.Controls.Add(this.bGoster);
            this.Controls.Add(this.tbSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Windows Forms Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoyadi;
        private System.Windows.Forms.Button bGoster;
        private System.Windows.Forms.Label lAdSoyad;
        private System.Windows.Forms.Button btemizle;
    }
}

