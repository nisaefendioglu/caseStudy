using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.OkulVeri;
using WebAPI.Models;

namespace WebAPI.BolumVeri
{
    public class BolumData
    {
        public static List<bolum> BolumList = new List<bolum>()
           {

           new bolum
           {
               Id = 1,
               Adi = "Yönetim Bilişim Sistemleri",
               okulAdi = OkulVeri.OkulData.OkulList[0].Adi


           },
               new bolum
               {
                   Id = 2,
                   Adi = "Eczacılık",
                   okulAdi = OkulVeri.OkulData.OkulList[1].Adi


               }


           }
            ;
    }
}
