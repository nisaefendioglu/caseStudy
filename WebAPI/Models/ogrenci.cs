using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class ogrenci
    {
        public int Id { get; set; }

        [DisplayName("Öğrenci Adı:")]
        public string Adi { get; set; }

        [DisplayName("Öğrenci Soyadı: ")]
        public string Soyadi { get; set; }

        [DisplayName("Tc No: ")]
        public long TcNo { get; set; }

        [DisplayName("Cinsiyeti:")]
        public string Cinsiyeti { get; set; }

        [DisplayName("Doğum Tarihi:")]
        public int DogumTarihi { get; set; }
        
        [DisplayName("Bölümü:")]
        public string BolumAdi { get; set; }
        public virtual bolum Bolumu { get; set; }


        [DisplayName("Okulu:")]
        public string OkulAdi { get; set; }
        public virtual Okul Okulu { get; set; }


        [DisplayName("Sınıfı:")]

        public int Sinifi { get; set; }

    }
}
