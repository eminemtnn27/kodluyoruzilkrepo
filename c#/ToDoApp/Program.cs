using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
        }
         public static int Run()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Kart Eklemek");
            Console.WriteLine("(2) Kart Guncelle");
            Console.WriteLine("(3) Kart Sil");
            Console.WriteLine("(4) Kart Taşı");
            Console.WriteLine("(5) Board Listelemek");
            Console.WriteLine("(6) Çıkış");
            return int.Parse(Console.ReadLine());
        }
    }
}
