namespace WindowsFormsGiris
{
    partial class OgrenciBilgileri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bKaydet = new System.Windows.Forms.Button();
            this.lTarih = new System.Windows.Forms.Label();
            this.dtpİslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbCaliskan = new System.Windows.Forms.CheckBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.lCinsiyet = new System.Windows.Forms.Label();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.lSehir = new System.Windows.Forms.Label();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.lYas = new System.Windows.Forms.Label();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.lSoyad = new System.Windows.Forms.Label();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.lAdi = new System.Windows.Forms.Label();
            this.rbBelirsiz = new System.Windows.Forms.RadioButton();
            this.bGoster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbOgrenci = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bGoster);
            this.panel1.Controls.Add(this.rbBelirsiz);
            this.panel1.Controls.Add(this.bKaydet);
            this.panel1.Controls.Add(this.lTarih);
            this.panel1.Controls.Add(this.dtpİslemTarihi);
            this.panel1.Controls.Add(this.cbCaliskan);
            this.panel1.Controls.Add(this.rbErkek);
            this.panel1.Controls.Add(this.rbKadın);
            this.panel1.Controls.Add(this.lCinsiyet);
            this.panel1.Controls.Add(this.cbSehir);
            this.panel1.Controls.Add(this.lSehir);
            this.panel1.Controls.Add(this.nudYas);
            this.panel1.Controls.Add(this.lYas);
            this.panel1.Controls.Add(this.tbSoyad);
            this.panel1.Controls.Add(this.lSoyad);
            this.panel1.Controls.Add(this.tbAdi);
            this.panel1.Controls.Add(this.lAdi);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 221);
            this.panel1.TabIndex = 0;
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(85, 186);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(75, 23);
            this.bKaydet.TabIndex = 14;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // lTarih
            // 
            this.lTarih.AutoSize = true;
            this.lTarih.Location = new System.Drawing.Point(19, 165);
            this.lTarih.Name = "lTarih";
            this.lTarih.Size = new System.Drawing.Size(60, 13);
            this.lTarih.TabIndex = 13;
            this.lTarih.Text = "İşlem Tarihi";
            // 
            // dtpİslemTarihi
            // 
            this.dtpİslemTarihi.Location = new System.Drawing.Point(85, 159);
            this.dtpİslemTarihi.Name = "dtpİslemTarihi";
            this.dtpİslemTarihi.Size = new System.Drawing.Size(175, 20);
            this.dtpİslemTarihi.TabIndex = 12;
            // 
            // cbCaliskan
            // 
            this.cbCaliskan.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCaliskan.Location = new System.Drawing.Point(22, 140);
            this.cbCaliskan.Name = "cbCaliskan";
            this.cbCaliskan.Size = new System.Drawing.Size(98, 22);
            this.cbCaliskan.TabIndex = 11;
            this.cbCaliskan.Text = "Çalışkan mı?";
            this.cbCaliskan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCaliskan.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(126, 117);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 10;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Location = new System.Drawing.Point(68, 117);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(52, 17);
            this.rbKadın.TabIndex = 9;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // lCinsiyet
            // 
            this.lCinsiyet.AutoSize = true;
            this.lCinsiyet.Location = new System.Drawing.Point(19, 119);
            this.lCinsiyet.Name = "lCinsiyet";
            this.lCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lCinsiyet.TabIndex = 8;
            this.lCinsiyet.Text = "Cinsiyet";
            this.lCinsiyet.Click += new System.EventHandler(this.lCinsiyet_Click);
            // 
            // cbSehir
            // 
            this.cbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(58, 85);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(158, 21);
            this.cbSehir.TabIndex = 7;
            // 
            // lSehir
            // 
            this.lSehir.AutoSize = true;
            this.lSehir.Location = new System.Drawing.Point(19, 93);
            this.lSehir.Name = "lSehir";
            this.lSehir.Size = new System.Drawing.Size(31, 13);
            this.lSehir.TabIndex = 6;
            this.lSehir.Text = "Şehir";
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(58, 60);
            this.nudYas.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudYas.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(158, 20);
            this.nudYas.TabIndex = 5;
            this.nudYas.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lYas
            // 
            this.lYas.AutoSize = true;
            this.lYas.Location = new System.Drawing.Point(19, 65);
            this.lYas.Name = "lYas";
            this.lYas.Size = new System.Drawing.Size(25, 13);
            this.lYas.TabIndex = 4;
            this.lYas.Text = "Yaş";
            this.lYas.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(58, 34);
            this.tbSoyad.MaxLength = 50;
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(158, 20);
            this.tbSoyad.TabIndex = 3;
            // 
            // lSoyad
            // 
            this.lSoyad.AutoSize = true;
            this.lSoyad.Location = new System.Drawing.Point(19, 37);
            this.lSoyad.Name = "lSoyad";
            this.lSoyad.Size = new System.Drawing.Size(39, 13);
            this.lSoyad.TabIndex = 2;
            this.lSoyad.Text = "Soyadı";
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(58, 8);
            this.tbAdi.MaxLength = 50;
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(158, 20);
            this.tbAdi.TabIndex = 1;
            // 
            // lAdi
            // 
            this.lAdi.AutoSize = true;
            this.lAdi.Location = new System.Drawing.Point(19, 11);
            this.lAdi.Name = "lAdi";
            this.lAdi.Size = new System.Drawing.Size(22, 13);
            this.lAdi.TabIndex = 0;
            this.lAdi.Text = "Adı";
            // 
            // rbBelirsiz
            // 
            this.rbBelirsiz.AutoSize = true;
            this.rbBelirsiz.Location = new System.Drawing.Point(185, 117);
            this.rbBelirsiz.Name = "rbBelirsiz";
            this.rbBelirsiz.Size = new System.Drawing.Size(112, 17);
            this.rbBelirsiz.TabIndex = 15;
            this.rbBelirsiz.TabStop = true;
            this.rbBelirsiz.Text = "Belirtmek İstemiyor";
            this.rbBelirsiz.UseVisualStyleBackColor = true;
            // 
            // bGoster
            // 
            this.bGoster.Location = new System.Drawing.Point(185, 185);
            this.bGoster.Name = "bGoster";
            this.bGoster.Size = new System.Drawing.Size(75, 23);
            this.bGoster.TabIndex = 16;
            this.bGoster.Text = "Göster";
            this.bGoster.UseVisualStyleBackColor = true;
            this.bGoster.Click += new System.EventHandler(this.bGoster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbOgrenci);
            this.groupBox1.Location = new System.Drawing.Point(2, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // rtbOgrenci
            // 
            this.rtbOgrenci.Location = new System.Drawing.Point(0, 13);
            this.rtbOgrenci.Name = "rtbOgrenci";
            this.rtbOgrenci.Size = new System.Drawing.Size(598, 176);
            this.rtbOgrenci.TabIndex = 0;
            this.rtbOgrenci.Text = "";
            // 
            // OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "OgrenciBilgileri";
            this.Text = "Öğrenci Bilgileri";
            this.Load += new System.EventHandler(this.OgrenciBilgileri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lYas;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.Label lSoyad;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label lAdi;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Label lSehir;
        private System.Windows.Forms.Label lCinsiyet;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Label lTarih;
        private System.Windows.Forms.DateTimePicker dtpİslemTarihi;
        private System.Windows.Forms.CheckBox cbCaliskan;
        private System.Windows.Forms.RadioButton rbBelirsiz;
        private System.Windows.Forms.Button bGoster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbOgrenci;
    }
}