using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınızı Girin");
            string name= Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin");
            string surname= Console.ReadLine();
            Console.WriteLine("merhaba " +name+" "+surname);

        }
    }
}
