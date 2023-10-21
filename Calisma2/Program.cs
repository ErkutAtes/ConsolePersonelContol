
using Calisma2;
using System.Reflection;

PersonelManage pm = new PersonelManage();

Personel p1 = new Personel() { PersonelID = 1, Ad = "Erkut", Soyad = "Ateş", Ilce = "Sakarya" };
pm.PersonelEkle(p1);
Personel p2 = new Personel() { PersonelID = 22, Ad = "Mehmet", Soyad = "Demir", Ilce = "İstanbul" };
pm.PersonelEkle(p2);
Personel p3 = new Personel() { PersonelID = 3, Ad = "Dilara", Soyad = "Bakır", Ilce = "İzmir" };
pm.PersonelEkle(p3);
Personel p4 = new Personel() { PersonelID = 6, Ad = "Metin", Soyad = "Taş", Ilce = "Erzincan" };
pm.PersonelEkle(p4);
Personel p5 = new Personel() { PersonelID = 51, Ad = "Cezmi", Soyad = "Över", Ilce = "Erzincan" };
pm.PersonelEkle(p5);
Personel p6 = new Personel() { PersonelID = 6, Ad = "Betül", Soyad = "Lamba", Ilce = "Erzincan" };
pm.PersonelEkle(p6);
Personel p7 = new Personel() { PersonelID = 7, Ad = "Ecem", Soyad = "Kuzu", Ilce = "İzmir" };
pm.PersonelEkle(p7);





Console.WriteLine("                                        Personel Yönetim Sistemine Hoş Geldiniz");

Console.WriteLine();

int mainDesicion = 0;
do 
{
    MenuSecenekleri();
    Console.Write("Menü numarası girerek seçim yapın => ");
    mainDesicion = Convert.ToInt32(Console.ReadLine());
    switch (mainDesicion)
    {
        case 1:
            //Personel Listeleme Seçenekleri
            Console.Clear();

            Console.WriteLine();
            
            Console.WriteLine("1 => Tüm personel Listele");
            Console.WriteLine("2 => İlçelere göre Personel Listele");
            Console.WriteLine("3 => Id sıralamasınba göre Personel Listele");
            Console.WriteLine("Seçmek istedğiniz Listeleme türü");
            int reportDEsicion = Convert.ToInt32(Console.ReadLine());

            switch (reportDEsicion)
            {

                case 1:
                    pm.TumPersonelListele();
                break;

                case 2:
                    pm.AynıIlcePersonelListele();
                break;

                case 3:
                    pm.IDGoreSıralanmisPersoleListesi();
                break;
                  
                default:
                    Console.WriteLine("Geçersiz Seçim!!!!!");
                break;
            }
            break;

        //Personel ekle
        case 2:
            Console.WriteLine("Yeni personel ID: ");
            int newPersonelID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yani ad gir:");
            string newPersonelAD = Console.ReadLine();
            Console.WriteLine("Yani soyad gir:");
            string newPersonelSoyad = Console.ReadLine();
            Console.WriteLine("Yani ilçe gir:");
            string newPersonelIlce = Console.ReadLine();
            pm.PersonelEkle(new Personel(newPersonelID,newPersonelAD,newPersonelSoyad,newPersonelIlce));
            break;


        //Silme İşlemi
        case 3:
            string areYouSure;
            pm.TumPersonelListele();
            Console.WriteLine("Personel ID gir => ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{id} nolu personeli silmek istediğine emin misim? (y/n)=> ");
            areYouSure = Console.ReadLine();
            if (areYouSure.ToLower() == "y")
            {
                pm.PersonelSil(id);
            }
            else 
            {
                Console.WriteLine("Silme İşlemi yapılmadı.");
                break;
            }
                 
        break;



            //personel Arama işlemi
        case 4:
            int serachID;
            Console.WriteLine("Personel ID gir => ");
            int searchID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pm.PersonelIDArama(searchID).ToString());
        break;


            //Personel Güncellme
        case 5:
            Console.WriteLine("Hangi personel güncellemek isteniyor.");
            int changeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yani ad gir:");
            string yeniAD = Console.ReadLine();
            Console.WriteLine("Yani soyad gir:");
            string yeniSoyad = Console.ReadLine();
            Console.WriteLine("Yani ilçe gir:");
            string yeniIlce = Console.ReadLine();
            pm.PersonelGüncelle(changeID,yeniAD,yeniSoyad,yeniIlce);
        break;


            //Çıkış işlmeleri
        case 6:
            Console.WriteLine("Çıkış yapılıyor");
            Thread.Sleep(1000);
            Console.WriteLine("Çıkış yapıldı.");
            Environment.Exit(0);
        break;


            //Geçersiz işlemler için
        default:
            Console.WriteLine("Geçersiz Giriş Takrar Dene!");
        break;
    }
}while (mainDesicion != 6);












void MenuSecenekleri() 
{
    Console.WriteLine("1 => Personelleri listele seçenekleri\n" +
    "2 => Personel ekle\n" +
    "3 => Personel Silme\n" +
    "4 => Personel Arama\n" +
    "5 => Personel Güncelleme\n" +
    "6 => Çıkış");

}




Console.ReadKey();




