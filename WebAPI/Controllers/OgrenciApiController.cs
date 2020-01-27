using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.ogrenciVeri;

namespace OBYS.Controllers
{
    public class OgrenciApiController : ApiController
    {
        // GET: api/OgrenciApi
        public IEnumerable<ogrenci> Get()
        {
            return OgrenciData.OgrenciList;
        }

        // GET: api/OgrenciApi/5
        public IHttpActionResult Get(int id)
        {
            var arananOgrenci = (OgrenciData.OgrenciList.Where(u => u.Id == id)).FirstOrDefault();
            if (arananOgrenci == null)
                return NotFound();
            else
                return Ok(arananOgrenci);
        }

        // POST: api/OgrenciApi
        [HttpPost]
        public IHttpActionResult Post([FromBody]ogrenci yeniOgrenci)
        {
            var ogrenciAdi = yeniOgrenci != null ? yeniOgrenci.Adi : "";
            var ogrenciSoyadi = yeniOgrenci != null ? yeniOgrenci.Soyadi : "";
            var tcNo = yeniOgrenci?.TcNo ?? 0;
            var cinsiyet = yeniOgrenci != null ? yeniOgrenci.Cinsiyeti : "";
            var dogumyili = yeniOgrenci?.DogumTarihi ?? 0;
            var bolumAdi = yeniOgrenci != null ? yeniOgrenci.BolumAdi : "";
            var okulAdi = yeniOgrenci != null ? yeniOgrenci.OkulAdi : "";
            var sinifi = yeniOgrenci?.Sinifi ?? 0;

            OgrenciData.OgrenciList.Add(yeniOgrenci);
            return Ok(ogrenciAdi);

        }

        // PUT: api/OgrenciApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OgrenciApi/5
        public void Delete(int id)
        {
        }
    }
}