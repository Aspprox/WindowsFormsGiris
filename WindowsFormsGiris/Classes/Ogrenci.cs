using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGiris.Classes
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yas { get; set; }
        public string Sehir { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public bool CaliskanMi { get; set; }
        public DateTime IslemTarihi { get; set; }

        
    }
}
