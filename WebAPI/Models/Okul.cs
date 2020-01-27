using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebAPI.Models
{
    public class Okul
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public ICollection<bolum> Bolumler { get; set; }
        public ICollection<ogrenci> Ogrenciler { get; set; }
    }
}
