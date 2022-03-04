using System;
using System.Collections.Generic;
namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Kart kart=new Kart();
            int girdi=Run();

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
            public enum Buyukluk
            {
                XS, S, M, L, XL
            }
            public Kart(string title,string content,string appointed,Buyukluk size)
            {
                baslik=title;
                icerik=content;
                atananKisi=appointed;
                buyukluk=size;
            }
        }
        public class Board{
            Dictionary<int, string> kisiListesi = new Dictionary<int, string>();
            List<Kart> TODO = new List<Kart>();
            List<Kart> INPROGRESS = new List<Kart>();
            List<Kart> DONE = new List<Kart>();
        }
    }
}
