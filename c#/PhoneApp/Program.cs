using System;
using System.Collections.Generic;
namespace PhoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            run run = new run();
            run.Process();
            string number = Console.ReadLine();
        }
    }

    public class Person
    {
        public string name;
        public string lastname;
        public string phone;
        public Person(string name, string lastname, string phone)
        {
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
        }
    }

    public class run
    {
        public void Process()
        {
            Console.WriteLine("Lütfen yapmak istedğiniz işlemi seçiniz :)" +
            "\n*******************************************" +
            "\n(1)Yeni Numara Ekle" +
            "\n(2)Varolan Numarayı Sil" +
            "\n(3)Varolan Numarayı Güncelle" +
            "\n(4)Rehberi Listele" +
            "\n(5)Rehberde Arama Yap" 
            );
        }
    }

    public class Users
    {
        public List<Person> person = new List<Person>();
        public void User()
        {
            person.Add(new Person("Emine", "Metin", "05545555555"));
            person.Add(new Person("Ümit", "Met", "05444444444")); 

        }
    }
 
}