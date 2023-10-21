using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calisma2
{
    internal class PersonelManage 
    {
        //Personel listesi oluşturup bunları bir listede tutucam.
        //Private tanımlayıp methodlar uzerinden ulaşıcam.
        private  List<Personel> personelList = new List<Personel>();




        /// <summary>
        /// Input olarak Personel tipinde p alıyor.Ve bunu Koleksiyona ekliyor.
        /// </summary>
        /// <param name="p"></param>
        public  void PersonelEkle(Personel p)
        {
            personelList.Add(p);
        }


        /// <summary>
        /// Burada Tüm personelleri Listeleyecektir
        /// </summary>
        public  void TumPersonelListele()
        {
            foreach (Personel p in personelList)
            {
                Console.WriteLine(p.ToString());
            }
        }

        /// <summary>
        /// Aynı ilçede oturan personelleri bir aradak gösterir.
        /// Linq kullanılarak yapılıyor.
        /// </summary>
        public  void AynıIlcePersonelListele()
        {
            var gruplanmisPersonel = personelList.GroupBy(personel => personel.Ilce)
            .Select(grup => new
            {
                PersonelAdi = grup.Key,
                Personeller = grup.ToList()
            });


            foreach (var grup in gruplanmisPersonel)
            {
                Console.WriteLine($"Personel Ilçe: {grup.PersonelAdi}");
                foreach (var personel in grup.Personeller)
                {
                    Console.WriteLine($"  Personel ID: {personel.PersonelID}, Ad: {personel.Ad} Soyad: {personel.Soyad}");
                }
            }

        }


        /// <summary>
        /// Id'ye göre sıralam ailmei yapar.
        /// </summary>
        public void IDGoreSıralanmisPersoleListesi() 
        {
            //Personel sınıfınsda Icamprable ınterface implement edildi.
            personelList.Sort();
            TumPersonelListele();

        }




        /// <summary>
        /// Id'ye göre arama yapıp.Personeli döndürür.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public  Personel PersonelIDArama(int ID) 
        {

            foreach (Personel p in personelList)
            {
                if (p.PersonelID == ID) 
                {
                    return p;
                }
            }
            return null;
        }

        /// <summary>
        /// Bu method ilgili personeli  değerlerini 0 veya boş tring hale çevirir.
        /// </summary>
        /// <param name="ID"></param>
        public  void PersonelSil(int ID)
        {
            Personel p = PersonelIDArama(ID);

            if (p != null)
            { 
                p.PersonelID = 0;
                p.Ad = "";
                p.Soyad = "";
                p.Ilce = "";
            }
        }

        /// <summary>
        /// parametrelere göre personel değerlerini değiştirir.
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="changeId"></param>
        /// <param name="Ad"></param>
        /// <param name="soyad"></param>
        /// <param name="ilce"></param>
        public void PersonelGüncelle(int ID , string Ad, string soyad,string ilce) 
        {
            Personel p = PersonelIDArama(ID);

            if (p != null)
            {
                p.Ad = Ad;
                p.Soyad = soyad;
                p.Ilce = ilce;
            }
        }
    }
}
