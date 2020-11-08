using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = null;
            string b = "";
            string c = " ";

            int s = b.Length;


            //if (tbAdi.Text.Trim() == "" || tbSoyadi.Text.Trim() == "")
            if (String.IsNullOrWhiteSpace(tbAdi.Text) || string.IsNullOrWhiteSpace
                (tbSoyadi.Text))
            {
                lAdSoyad.Text = "Lütfen Ad ve Soyad Giriniz.";
                lAdSoyad.ForeColor = Color.Brown;
                MessageBox.Show(lAdSoyad.Text, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lAdSoyad.Text = tbAdi.Text + " " + tbSoyadi.Text;
                lAdSoyad.ForeColor = Color.White;
            }
            
               
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btemizle_Click(object sender, EventArgs e)
        {
            tbAdi.Text = "";
            tbSoyadi.Clear();
            lAdSoyad.Text = "";
        }
    }
}
