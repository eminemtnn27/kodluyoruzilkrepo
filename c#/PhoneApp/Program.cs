using System;
using System.Collections.Generic;
namespace PhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Run run = new Run();
            run.Work(); 
        }
    }

    public class Person
    {
        public string ad;
        public string soyad;
        public string telefon;
        public Person(string ad, string soyad, string telefon)
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
        public List<Person> kisi = new List<Person>();
        public void Kullanici()
        {
            kisi.Add(new Person("Nebat", "Met", "05545555555"));
            kisi.Add(new Person("Ümit", "Met", "05444444444")); 
            kisi.Add(new Person("Zeynep", "Met", "05333333333")); 
            kisi.Add(new Person("Tuba", "Met", "05222222222")); 
            kisi.Add(new Person("Memet", "Met", "05111111111")); 
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
            Person kisi = new Person(ad, soyad, telefon);
            Console.WriteLine("{0} telefon rehberine başarılı bir şekilde eklenmiştir.", kisi.ad);
        }
    }
}