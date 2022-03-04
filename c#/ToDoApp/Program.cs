using System;
using System.Collections.Generic;
namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board=new Board();
            int girdi=Run();

            while(true)
            {
                switch(girdi)
                {
                    case 1: 
                        board.kartEkle();
                        girdi=Run();
                        break;
                    case 2: 
                        board.Guncelle();
                        girdi=Run();
                        break;
                    case 3: 
                        board.Sil();
                        girdi=Run();
                        break;
                    case 4: 
                        board.Tasi();
                        girdi=Run();
                        break;
                    case 5: 
                        board.BoardListele();
                        girdi=Run();
                        break;
                }
            }
        }
        public static int Run()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Kart Ekle");
            Console.WriteLine("(2) Kart Güncelle");
            Console.WriteLine("(3) Kart Sil");
            Console.WriteLine("(4) Kart Taşı");
            Console.WriteLine("(5) Board Listele");
            Console.WriteLine("(6) Çıkış");
            return int.Parse(Console.ReadLine());
        }
        public class Kart
        {
            public string baslik { get; set; }
            public string icerik { get; set; }
            public string atananKisi { get; set; }
            public Buyukluk buyukluk { get; set; }
            public enum Buyukluk { XS, S, M, L, XL}
            public Kart(string title,string content,string appointed,Buyukluk size)
            {
                baslik=title;
                icerik=content;
                atananKisi=appointed;
                buyukluk=size;
            }
        }
        public class Board
        {
            Dictionary<int, string> kisiler = new Dictionary<int, string>();
            List<Kart> TODO = new List<Kart>();
            List<Kart> INPROGRESS = new List<Kart>();
            List<Kart> DONE = new List<Kart>();

            public Board()
            {
                kisiler.Add(0,"emine metin");
                TODO.Add(new Kart("C# Pratikleri","Pratik Yapılması","emine metin",Kart.Buyukluk.S));
                INPROGRESS.Add(new Kart("C# Pratikleri","Pratik Yapılması","derya yıldız",Kart.Buyukluk.S));
            }
            public void kartEkle()
            {
                int person; string title; string content;  int size; 

                Console.WriteLine("Başlık Giriniz                                  : ");
                title = Console.ReadLine();
                Console.WriteLine("İçerik giriniz                                   : ");
                content = Console.ReadLine();
                Console.WriteLine("Büyüklük seciniz -> XS(1),S(2),M(3),L(4),XL(5)   :");
                size = int.Parse(Console.ReadLine());
                Console.WriteLine("Kişi Seçiniz                                    : ");
                person = int.Parse(Console.ReadLine());

                if (kisiler.ContainsKey(person) && size > 0 && size <= 5)
                    TODO.Add(new Kart(title,content,kisiler[person], (Kart.Buyukluk)size));
                else
                    Console.WriteLine("Hatalı!");

            }

            public void Guncelle()
            {
                Console.WriteLine("Değiştirmek istediğiniz başlığı giriniz : ");
                string title = Console.ReadLine(); 
                bool varMi=false;
                foreach(var kart in TODO)
                {
                    if(kart.baslik==title)
                    {
                        kart.baslik=title;
                        Console.WriteLine("Başarıyla güncellendi");
                        varMi=true;
                    }
                }
                if (!varMi)
                {
                    Console.WriteLine("Böyle bir kullanıcı bulunamadı.");
                }
            }

            public void Sil()
            { 
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                Console.WriteLine("Lütfen kart başlığını yazınız: ");
                string title=Console.ReadLine(); 
                bool varMi=false;
                
                foreach(var kart in TODO)
                {
                    if(kart.baslik==title)
                    {
                        TODO.Remove(kart);
                        Console.WriteLine("Başarıyla silindi");
                        varMi=true;
                    }
                }
                foreach(var kart in INPROGRESS)
                {
                    if(kart.baslik==title)
                    {
                        TODO.Remove(kart);
                        Console.WriteLine("Başarıyla silindi");
                        varMi=true;
                    }
                }
                foreach(var kart in DONE)
                {
                    if(kart.baslik==title)
                    {
                        TODO.Remove(kart);
                        Console.WriteLine("Başarıyla silindi");
                        varMi=true;
                    }
                }
                if(varMi==true)
                {                   
                    Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("\n* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("\n* Yeniden denemek için : (2)");
                     int girdi = int.Parse(Console.ReadLine());
                    if (girdi == 2)
                        Sil();
                    else
                        Console.WriteLine("Kart silme işlemi bitti.");
                    }
            }

            public void Tasi()
            {
                string baslik;  string icerik;   bool varMi = false;

                Console.WriteLine("Oncelikle taşımak istediginiz karti secmeniz gerekiyor.");
                Console.WriteLine("Lütfen kartın başlığını yazınız :    ");
                baslik = Console.ReadLine();
                Console.WriteLine("Lütfen kartın icerigi yazınız :    ");
                icerik = Console.ReadLine();

 
                if (!varMi)
                { 
                    Console.WriteLine("Aradığınız kriterlere uygun kart bulunamadı.");
                    Console.WriteLine("* Taşımayi sonlandırmak icin (1)");
                    Console.WriteLine("* Yeniden denemek icin (2)");
                    int secim = int.Parse(Console.ReadLine());
                    if (secim == 2)
                        Tasi();
                    else
                        Console.WriteLine("Kart silme işlemi sonlandı.");
                }
            }
            public void BoardListele()
            {
                Console.WriteLine();
                Console.WriteLine("TODO Line");
                Console.WriteLine("*****************************");

                foreach (var kart in  TODO)
                {
                    Console.WriteLine("Baslik       : {0}", kart.baslik);
                    Console.WriteLine("Icerik       : {0}", kart.icerik);
                    Console.WriteLine("Atanan Kisi  : {0}", kart.atananKisi);
                    Console.WriteLine("Buyukluk     : {0}", kart.buyukluk);
                    Console.WriteLine("----------------------");
                }

                Console.WriteLine();
                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("*****************************");

                foreach (var kart in INPROGRESS)
                {
                    Console.WriteLine("Baslik       : {0}", kart.baslik);
                    Console.WriteLine("Icerik       : {0}", kart.icerik);
                    Console.WriteLine("Atanan Kisi  : {0}", kart.atananKisi);
                    Console.WriteLine("Buyukluk     : {0}", kart.buyukluk);
                    Console.WriteLine("----------------------");
                }

                Console.WriteLine();
                Console.WriteLine("DONE Line");
                Console.WriteLine("*****************************");

                foreach (var kart in DONE)
                {
                    Console.WriteLine("Baslik       : {0}", kart.baslik);
                    Console.WriteLine("Icerik       : {0}", kart.icerik);
                    Console.WriteLine("Atanan Kisi  : {0}", kart.atananKisi);
                    Console.WriteLine("Buyukluk     : {0}", kart.buyukluk);
                    Console.WriteLine("----------------------");
                }
            }    
        }
    }
}
