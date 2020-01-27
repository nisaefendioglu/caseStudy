using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.OkulVeri
{
    public class OkulData
    {
        public static List<Okul> OkulList = new List<Okul>()
            {


            new Okul
            {

                Id = 1,
                Adi = "İstanbul Aydın Üniversitesi"

            },
                new Okul
                {
                    Id = 2,
                    Adi = "Uludağ Üniversitesi"

                }

            }
           ;
    }
}
