using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
              // Console.WriteLine("Hello World!");
            // Console.WriteLine("Adınızı Girin");
            // string name= Console.ReadLine();
            // Console.WriteLine("Soyadınızı Girin");
            // string surname= Console.ReadLine();
            // Console.WriteLine("merhaba " +name+" "+surname);

        try
           {
               //int a = int.Parse(null);
               //int a = int.Parse("test");
               int a = int.Parse("-20000000000");
           }
           catch (ArgumentNullException ex)
           {
               Console.WriteLine("boş değer girdiniz");
               Console.WriteLine(ex);
           }
           catch (FormatException ex)
           {
               Console.WriteLine("veri tipi uygun degil");
               Console.WriteLine(ex);
           }    
           catch (OverflowException ex)
           {
               Console.WriteLine("çok kücük veya cok büyük deger girdiniz");
               Console.WriteLine(ex);
           }
           finally
           {
               Console.WriteLine("işlem başarı ile tamamlandı");
           }

        }
    }
}
