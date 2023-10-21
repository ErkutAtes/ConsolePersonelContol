using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Calisma2
{
    internal class Personel : IComparable
    {
        public int PersonelID { get; set; } = 0;
        public string Ad { get; set; } = "Kayıt Girilmedi";
        public string Soyad { get; set; } = "Kayıt Girilmedi";
        public string Ilce { get; set; } = "Kayıt Girilmedi";

        public Personel()
        {
                
        }
        public Personel(int personelID, string Ad,string Soyad,string Ilce)
        {
            this.PersonelID = personelID;
            this.Ad = Ad;
            this.Soyad = Soyad; 
            this.Ilce = Ilce;
        }

        public int CompareTo(object? o)
        {
            return this.PersonelID.CompareTo(((Personel)o).PersonelID);
        }

        public override string ToString()
        {
            return $"ID ==> {PersonelID} Ad ==> {Ad} Soyad ==> {Soyad} Ilce ==> {Ilce}";
        }

    }
}
