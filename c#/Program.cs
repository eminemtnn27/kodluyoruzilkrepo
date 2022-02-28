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

            Console.WriteLine();
        }
    }
}
