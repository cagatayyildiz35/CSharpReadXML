using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace CSharpReadXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //xml den çektiğin kişileri bir kişi listesine ata!

            XDocument doc = XDocument.Load("Calisanlar.xml");
            var authors = doc.Descendants("kisi");

            List<Kisi> kisiler = new List<Kisi>();

            foreach (var author in authors)
            {
                Kisi kisi = new Kisi();

                kisi.Ad = author.Descendants("ad").ToArray()[0].Value;
                kisi.Soyad = author.Descendants("soyad").ToArray()[0].Value;
                kisi.Sehir = author.Descendants("sehir").ToArray()[0].Value;

                kisiler.Add(kisi);

            }

            Console.ReadLine();







            //var ad = "Çağatay";
            //var sayi = 4;
            //var onlinedurum = false;

            //string[] isimler = { "Çağatay", "Verk", "Zerk" };

            //foreach (var x in isimler)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.ReadLine();


        }
    }
}
