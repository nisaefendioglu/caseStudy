using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class bolum
    {
        public int Id { get; set; }

        [DisplayName("Bölüm Adı :")]
        public string Adi { get; set; }

        [DisplayName("Okulu :")]
        public string okulAdi { get; set; }
        public virtual Okul Okulu { get; set; }

        public ICollection<ogrenci> Ogrenciler { get; set; }

    }
}
