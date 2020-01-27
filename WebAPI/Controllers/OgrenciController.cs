using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;
using WebAPI.ogrenciVeri;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult OgrenciListele()
        {


            return View(OgrenciData.OgrenciList);
        }


        // GET: Ogrenci/Create
        public ActionResult OgrenciEkle()
        {
            return View();
        }

        // POST: Ogrenci/Create
        [HttpPost]
        public ActionResult OgrenciEkle(ogrenci yeniOgrenci)
        {
            try
            {
                ogrenci eklenecekOgrenci = new ogrenci()
                {
                    Adi = yeniOgrenci.Adi,
                    Soyadi = yeniOgrenci.Soyadi,
                    TcNo = yeniOgrenci.TcNo,
                    Cinsiyeti = yeniOgrenci.Cinsiyeti,
                    DogumTarihi = yeniOgrenci.DogumTarihi,
                    BolumAdi = yeniOgrenci.BolumAdi,
                    OkulAdi = yeniOgrenci.OkulAdi,
                    Sinifi =yeniOgrenci.Sinifi


                };
                OgrenciData.OgrenciList.Add(eklenecekOgrenci);


                return View();

            }
            catch
            {
                return View();
            }
        }
    }
}