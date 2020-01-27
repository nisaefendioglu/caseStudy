using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;


namespace WebAPI.ogrenciVeri
{
    public class OgrenciData
    {
        public static List<ogrenci> OgrenciList = new List<ogrenci>()
        {

            new ogrenci
            {
                Id = 1,
                Adi = "Nisa",
                Soyadi = "Efendioğlu",
                TcNo = 45571478541,
                Cinsiyeti = "Kadın",
                DogumTarihi = 1999,
                BolumAdi = BolumVeri.BolumData.BolumList[0].Adi,
                OkulAdi = BolumVeri.BolumData.BolumList[0].okulAdi,
                Sinifi = 3

            }



        };
    }
}
