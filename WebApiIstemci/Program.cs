using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApiIstemci
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44344/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response;
                response = client.GetAsync("Ogrenci/OgrenciApi").Result;
                if (response.IsSuccessStatusCode)
                {
                    var ogrenciler = response.Content.ReadAsAsync<IEnumerable<ogrenci>>().Result;
                    foreach (var ogrenci in ogrenciler)
                    {
                        Console.WriteLine("Ogrenci ID : {0} - Öğrencinin Adı: {1}- Soyadı : {2} - Bölümü : {3} - Okulu : {4} - Cinsiyeti: {5} - Doğum Tarihi: {6} - Sınıfı: {7}", ogrenci.Id, ogrenci.Adi, ogrenci.Soyadi, ogrenci.BolumAdi, ogrenci.OkulAdi, ogrenci.Cinsiyeti, ogrenci.DogumTarihi,ogrenci.Sinifi);
                    }



                }
                Console.ReadKey();


            }

        }
    }


    class ogrenci
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public long TcNo { get; set; }

        public string Cinsiyeti { get; set; }

        public int DogumTarihi { get; set; }

        public int Sinifi { get; set; }

        public string BolumAdi { get; set; }
        public string OkulAdi { get; set; }

    }
}
    