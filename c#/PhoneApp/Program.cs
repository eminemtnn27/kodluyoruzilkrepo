using System;
using System.Collections.Generic;
namespace PhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber=new Rehber();
            Run run = new Run();
            run.Work(); 

            string girilen=Console.ReadLine();
            while(true)
            {
                 switch(girilen)
                {
                    case "1":
                        rehber.Ekle();
                        break;
                    case "2":
                        rehber.Sil();
                        break;
                    case "3":
                        rehber.Guncelle();
                        break;
                    case "4":
                        rehber.Listele();
                        break;
                    case "5":
                        rehber.Ara();
                        break;
                     default:
                        Console.WriteLine("Geçersiz veri girdiniz");
                        break;
                }
            }
        }
    }

    public class Kisiler
    {
        public string ad;
        public string soyad;
        public string telefon;
        public Kisiler(string ad, string soyad, string telefon)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.telefon = telefon;
        }
    }

    public class Run
    {
        public void Work()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)" +
            "\n*******************************************" +
            "\n(1)Yeni Numara Ekle" +
            "\n(2)Varolan Numarayı Sil" +
            "\n(3)Varolan Numarayı Güncelle" +
            "\n(4)Rehberi Listele" +
            "\n(5)Rehberde Arama Yap" 
            );
        }
    }

    public class Kullanicilar 
    {
        public List<Kisiler> kisi = new List<Kisiler>();
        public void Kullanici()
        {
            kisi.Add(new Kisiler("Nebat", "Met", "05545555555"));
            kisi.Add(new Kisiler("Ümit", "Met", "05444444444")); 
            kisi.Add(new Kisiler("Zeynep", "Met", "05333333333")); 
            kisi.Add(new Kisiler("Tuba", "Met", "05222222222")); 
            kisi.Add(new Kisiler("Memet", "Met", "05111111111")); 
        }
        
    }
    public class Rehber:Kullanicilar
    {
        public void Ekle()
        {
            Console.WriteLine("Lütfen isim giriniz             :");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string telefon = Console.ReadLine();
            Kisiler kisi = new Kisiler(ad, soyad, telefon);
            Console.WriteLine("{0} telefon rehberine başarılı bir şekilde eklenmiştir.", kisi.ad);
        }
        public void Sil()
        {
            Kullanici();
            Console.WriteLine("Lütfen silmek istediğiniz kişinin adını veya soyadını yazınız:");
            var sorgu = Console.ReadLine();
            bool varMi = true;
            for (var i = 0; i < kisi.Count; i++)
            {
                if (sorgu == kisi[i].ad || sorgu == kisi[i].soyad)
                {
                    Console.WriteLine("Kullanıcı {0} silmek istediğinize emin misiniz ? E/H", kisi[i].telefon);
                    var yanit = Console.ReadLine();

                    if (yanit == "E")
                    {
                        Console.WriteLine("Kullanıcı Silme İşlemi Başarıyla Eklenmiştir.");
                    }
                }
            }
            if (!varMi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı.");
            }
        }
        public void Guncelle()
        {
            Kullanici();
            Console.WriteLine("Lütfen güncelleyeceğiniz kişinin ismini veya soyadını giriniz : ");
            var sorgu = Console.ReadLine();
            bool varMi = true;
            for (var i = 0; i < kisi.Count; i++)
            {
                if (sorgu == kisi[i].ad || sorgu == kisi[i].soyad)
                {
                    Console.WriteLine("Adı:{0}" +
                    "\nSoyadı:{1}" +
                    "\nTelefon:{2}" +
                    "\n**************", kisi[i].ad, kisi[i].soyad, kisi[i].telefon);
                }
            }
            if (!varMi)
            {
                Console.WriteLine("Böyle bir kullanıcı bulunamadı.");
            }

        }
        public void Listele()
        {
            Kullanici();
            for (var i = 0; i < kisi.Count; i++)
            {
                Console.WriteLine("Adı:{0}" +
                "\nSoyadı:{1}" +
                "\nTelefon:{2}" +
                "\n**************", kisi[i].ad, kisi[i].soyad, kisi[i].telefon);
            }
        }
        public void Ara()
        {
            Kullanici();
            Console.WriteLine("Kişi araması yapmak istediğiniz tipi seçiniz" +
                "\n**************************************" +
                "\n(1)Ad ve Soyadına göre arama" +
                "\n(2)Telefon numarasına göre arama");
            var sorgu = Console.ReadLine();
            if (sorgu == "1")
            {
                Console.WriteLine("Lütfen arayacağınız kişinin adını veya soyadını giriniz : ");
                var yanit = Console.ReadLine();
                bool varMi = true;
                for (var i = 0; i < kisi.Count; i++)
                {
                    if (yanit == kisi[i].ad || yanit == kisi[i].soyad)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nTelefon:{2}" +
                        "\n**************", kisi[i].ad, kisi[i].soyad, kisi[i].telefon);
                    }
                }
                if (!varMi)
                {
                    Console.WriteLine("Kullanıcı bulunamadı.");
                }
            }
            else if (sorgu == "2")
            {
                Console.WriteLine("Telefon no giriniz : ");
                var yanit =Console.ReadLine();
                bool varMi = true;
                for (var i = 0; i < kisi.Count; i++)
                {
                    if (yanit == kisi[i].telefon)
                    {
                        Console.WriteLine("Adı:{0}" +
                        "\nSoyadı:{1}" +
                        "\nTelefon:{2}" +
                        "\n**************", kisi[i].ad, kisi[i].soyad, kisi[i].telefon);
                    }
                }
                if (!varMi)
                {
                    Console.WriteLine("Kullanıcı bulunamadı.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz girdi");
            }
        }
    }
}