using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
             // try
            //    {
            //        //int a = int.Parse(null);
            //        //int a = int.Parse("test");
            //        int a = int.Parse("-20000000000");
            //    }
            //    catch (ArgumentNullException ex)
            //    {
            //        Console.WriteLine("boş değer girdiniz");
            //        Console.WriteLine(ex);
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("veri tipi uygun degil");
            //        Console.WriteLine(ex);
            //    }    
            //    catch (OverflowException ex)
            //    {
            //        Console.WriteLine("çok kücük veya cok büyük deger girdiniz");
            //        Console.WriteLine(ex);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("işlem başarı ile tamamlandı");
            //    }
            
           //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
            //    Console.WriteLine("Lütfen bir sayı giriniz. ");
            //    int sayac=int.Parse(Console.ReadLine());
            //    for(int i=1; i<=sayac; i++)
            //    {
            //        if(i%2 == 1)
            //         Console.WriteLine(i);
            //    }

           //1 ile 100 arasındaki tek ve çift sayıların toplamlarını ekrana yazdır
            //    int tek=0;
            //    int cift=0;
            //    for(int i=1; i<=1000; i++)
            //    {
            //        if(i%2==1)
            //         tek +=i;
            //        else
            //         cift +=i;
            //    }
            //    Console.WriteLine("Tek sayıların toplamı: " +tek);
            //    Console.WriteLine("Çift sayıların toplamı: " +cift);
        
            //break-continue
            // for(int i=1;i<10;i++)
            // {
            //     if(i==4)
            //         break;
            //     Console.WriteLine(i);
            // }
            // for(int i=1;i<10;i++)
            // {
            //     if(i==4)
            //         continue;
            //     Console.WriteLine(i);
            // }

            //while
            //1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console a yazdıran program
            // Console.WriteLine("Lütfen bir sayı giriniz.");
            // int sayi=int.Parse(Console.ReadLine());
            // int sayac=1;
            // int toplam=0;
            // while(sayac<=sayi)
            // {
            //     toplam+=sayac;
            //     sayac++;
            // }
            // Console.WriteLine(toplam/sayi);

            // //'a' dan 'z' ye kadar tüm harfleri consola yazdır
            // char character='a';
            // while(character< 'z')
            // {
            //     Console.Write(character);
            //     character++;
            // }

            // Console.Write("***** Foreach *****");
            // string[] arabalar=["BMW","Ford","Toyota","Nissan"];

            // foreach(var araba in arabalar)
            // {
            //     Console.WriteLine(araba);
            // }

            //dizi tanımlama
            // string[] renk=new string[5];
            // string[] hayvan={"kedi","köpek","kuş","tilki"};

            // int[] dizi=new int[5];

            // //dizilere değer atama ve erişim
            // renk[0]="mavi";
            // dizi[3]=10;

            // Console.WriteLine(hayvan[1]);
            // Console.WriteLine(dizi[3]);
            // Console.WriteLine(renk[0]);

            // //döngülerle dizi kullanımı
            // //klavyeden girilen n tane sayının 

            // Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            // int diziUzunlugu=int.Parse(Console.ReadLine());
            // int[] sayiDizisi=new int[diziUzunlugu];
            // for(int i=0;i<diziUzunlugu;i++)
            // {
            //     Console.Write("Lütfen {0}.sayıyı giriniz: ",i+1);
            //     sayiDizisi[i]=int.Parse(Console.ReadLine());
            // }

            // int toplam=0;
            // foreach(var sayi in sayiDizisi)
            //     toplam+=sayi;

            // Console.WriteLine("Ortalama : " +toplam/diziUzunlugu);

            //sort (sıralama işlemi yapar)

            // int[] sayiDizisi={23,11,6,86,49,7,22,32};
            // Console.WriteLine("*** Sırasız Dizi ***");
            // foreach(var sayi in sayiDizisi)
            //     Console.WriteLine(sayi);

            // Console.WriteLine("*** Sıralı Dizi ***");
            // Array.Sort(sayiDizisi);

            // foreach(var sayi in sayiDizisi)
            //     Console.WriteLine(sayi);

            // //clear (Dizinin belirtilen elemanlarını varsayılan değerine getirir)
            // Console.WriteLine("*** Array Clear ***");

            // //sayı dizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı sıfırlar
            // Array.Clear(sayiDizisi,2,2);

            // foreach(var sayi in sayiDizisi)
            //     Console.WriteLine(sayi);

            // //reverse(dizinin ilk elemanı ile son elemanını yer değiştirir)
            // Console.WriteLine("*** Array Reverse ***");
            // Array.Reverse(sayiDizisi);

            // foreach(var sayi in sayiDizisi)
            //     Console.WriteLine(sayi);

            // //indexof
            // Console.WriteLine("*** Array indexOf  ***");
            // Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            // //resize(Dizileri yeniden boyutlandırır)
            // Console.WriteLine("*** Array resize  ***");
            // Array.Resize<int>(ref sayiDizisi,9);
            // sayiDizisi[8]=99;

            // foreach(var sayi in sayiDizisi)
            //     Console.WriteLine(sayi);


            //erişim_belirteci    geri_dönüş_tipi    metot_adı(parametre listesi / argüman)
            //{
                //komutlar;
                //return;
            //}

            //   int a = 2;
            //  int b = 3;
            //   Console.WriteLine(a + b);

            //   int sonuc = Topla(a, b);
            //    Console.WriteLine(sonuc);

            //    Metotlar ornek = new Metotlar();
            //    ornek.EkranaYazdir(Convert.ToString(sonuc));

            //    int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
            //     ornek.EkranaYazdir(Convert.ToString(sonuc2));
            //     ornek.EkranaYazdir(Convert.ToString(a + b));
            //    }

            //   static int Topla(int deger1, int deger2)
            //   {
            //      return (deger1 + deger2);
            //   }
            // }

            // class Metotlar
            // {
            //     public void EkranaYazdir(string veri)
            //     {
            //         Console.WriteLine(veri);
            //     }

            //     public int ArttirVeTopla(ref int deger1, ref int deger2)
            //     {
            //         deger1 += 1;
            //         deger2 += 1;
            //         return deger1 + deger2;     

            //     }
            //}

            //Out Parametreler
            //         string sayi = "999";

            //         bool sonuc = int.TryParse(sayi, out int outSayi);
            //         if (sonuc)
            //         {
            //             Console.WriteLine("Başarılı!");
            //             Console.WriteLine(outSayi);
            //         }
            //         else
            //         {
            //             Console.WriteLine("Başarısız!");
            //         }

            //         Metotlar instance = new Metotlar();
            //         instance.Topla(4, 5, out int toplamSonucu);
            //         Console.WriteLine(toplamSonucu);

            //         //Metot Aşırı Yükleme - Overloading
            //         int ifade = 999;
            //         instance.EkranaYazdir(Convert.ToString(ifade));
            //         instance.EkranaYazdir(ifade);
            //         instance.EkranaYazdir("Emine", "Metin");

            //         //Metot İmzası
            //         //metot adı + parametre sayısı + parametre
            //     }
            // }

            //     class Metotlar
            //     {
            //         public void Topla(int a, int b, out int toplam)
            //         {
            //             toplam = a + b;
            //         }

            //         public void EkranaYazdir(string veri)
            //         {
            //             Console.WriteLine(veri);
            //         }

            //         public void EkranaYazdir(int veri)
            //         {
            //             Console.WriteLine(veri);
            //         }
            //         public void EkranaYazdir(string veri1, string veri2)
            //         {
            //             Console.WriteLine(veri1 + veri2);
            //         }
            //     } 

           
            // Rekürsif(Yinelemeli) Fonksiyonlar :Kendi kendini çağırabilirler.
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);

            Islemler islem1 = new();
            Console.WriteLine(islem1.Expo(3, 4));
            /*
            Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.
            */
            string ifade = "Berkcan Gümüşışık";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteBackSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEventNumber());
            Console.WriteLine(ifade.GetFirstCharacter());
        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us < 2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteBackSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("-", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEventNumber(this int value)
        {
            if (value % 2 == 0)
                return true;
            else
                return false;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }

}

