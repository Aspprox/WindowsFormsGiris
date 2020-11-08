using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsGiris.Classes;

namespace WindowsFormsGiris
{
    public partial class OgrenciBilgileri : Form
    {
        Ogrenci ogrenci;
        //global değişken atadık. Bu sayede istediğimiz scopeda kullanabiliriz.
        string[] sehirler = new string[3]
        {
            "Ankara",
            "İstanbul",
            "İzmir"
        };

        public OgrenciBilgileri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lCinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void bKaydet_Click(object sender, EventArgs e) //kaydet
        {
            if (String.IsNullOrWhiteSpace(tbAdi.Text) || string.IsNullOrWhiteSpace(tbSoyad.Text)
                || cbSehir.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ogrenci = new Ogrenci(); //local değişken
                ogrenci.Adi = tbAdi.Text;
                ogrenci.Soyadi = tbSoyad.Text;
                ogrenci.Yas = Convert.ToInt32(nudYas.Value);
                ogrenci.Sehir = cbSehir.Text;
                if (rbKadın.Checked)
                {
                    ogrenci.Cinsiyet = CinsiyetEnum.Kadın;
                }
                else if (rbErkek.Checked)
                {
                    ogrenci.Cinsiyet = CinsiyetEnum.Erkek;
                }
                else
                {
                    ogrenci.Cinsiyet = CinsiyetEnum.Belirsiz;
                }
                ogrenci.CaliskanMi = cbCaliskan.Checked;
                ogrenci.IslemTarihi = dtpİslemTarihi.Value;
                MessageBox.Show("Öğrenci objesi oluşturuldu.");
            }     
            
        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            if (ogrenci != null)
            {
               string line = "Adı: " + ogrenci.Adi + ", ";
               line += "Soyadı: " + ogrenci.Soyadi + ", ";
               line += "Yaş: " + ogrenci.Yas + ", ";
               line += "Şehir: " + ogrenci.Sehir + ", ";
               line += "Cinsiyet: " + ogrenci.Cinsiyet + ", ";
               //if (ogrenci.CaliskanMi)
               //{
               //    line += "Çalışkan: Evet, ";
               //}
               //else
               //{
               //    line += "Çalışkan: Hayır, ";
               //}
               line += "Çalışkan: " + (ogrenci.CaliskanMi ? "Evet" : "Hayır") + ", "; // ternary operator
               line += "İşlem Tarihi: " + ogrenci.IslemTarihi.ToShortDateString();
               rtbOgrenci.Text = line;
            }
            else
            {
                MessageBox.Show("Lütfen önce öğrenciyi kaydedin. ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void OgrenciBilgileri_Load(object sender, EventArgs e)
        {
            //cbSehir.Items.Clear();  
            //foreach (var sehir in sehirler)
            //{
            //    cbSehir.Items.Add(sehir);
            //}
            cbSehir.Items.AddRange(sehirler);
            cbSehir.Items.Insert(0, "-- Seçiniz --");
            cbSehir.SelectedIndex = 0;
            dtpİslemTarihi.Value = DateTime.Now;
        }
    }
}
