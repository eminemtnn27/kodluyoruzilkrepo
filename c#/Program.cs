using System;
using System.Collections;
using System.Collections.Generic;
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
            //         int result = 1;
            //         for (int i = 1; i < 5; i++)
            //         {
            //             result *= 3;
            //         }
            //         Console.WriteLine(result);

            //         Islemler islem1 = new();
            //         Console.WriteLine(islem1.Expo(3, 4));
            //         /*
            //         Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.
            //         */
            //         string ifade = "Emine Metin";
            //         bool sonuc = ifade.CheckSpaces();
            //         Console.WriteLine(sonuc);
            //         if (sonuc)
            //         {
            //             Console.WriteLine(ifade.RemoveWhiteBackSpaces());
            //         }

            //         Console.WriteLine(ifade.MakeUpperCase());
            //         Console.WriteLine(ifade.MakeLowerCase());

            //         int[] dizi = { 9, 3, 6, 2, 5, 0 };
            //         dizi.SortArray();
            //         dizi.EkranaYazdir();

            //         int sayi = 5;
            //         Console.WriteLine(sayi.IsEventNumber());
            //         Console.WriteLine(ifade.GetFirstCharacter());
            //     }
            // }

            // public class Islemler
            // {
            //     public int Expo(int sayi, int us)
            //     {
            //         if (us < 2)
            //         {
            //             return sayi;
            //         }
            //         return Expo(sayi, us - 1) * sayi;
            //     }
            // }

            // public static class Extension
            // {
            //     public static bool CheckSpaces(this string param)
            //     {
            //         return param.Contains(" ");
            //     }

            //     public static string RemoveWhiteBackSpaces(this string param)
            //     {
            //         string[] dizi = param.Split(" ");
            //         return string.Join("-", dizi);
            //     }

            //     public static string MakeUpperCase(this string param)
            //     {
            //         return param.ToUpper();
            //     }

            //     public static string MakeLowerCase(this string param)
            //     {
            //         return param.ToLower();
            //     }

            //     public static int[] SortArray(this int[] param)
            //     {
            //         Array.Sort(param);
            //         return param;
            //     }

            //     public static void EkranaYazdir(this int[] param)
            //     {
            //         foreach (var item in param)
            //         {
            //             Console.WriteLine(item);
            //         }
            //     }

            //     public static bool IsEventNumber(this int value)
            //     {
            //         if (value % 2 == 0)
            //             return true;
            //         else
            //             return false;
            //     }

            //     public static string GetFirstCharacter(this string param)
            //     {
            //         return param.Substring(0,1);
            //     }
            // }

        //Ödev: algoritma soruları
            //     islem l = new islem();
            //     l.soru1();
            //     l.soru2();
            //     l.soru3();
            //     l.soru4();
            //     }
            // }
            // public class islem
            // {
            //     public void soru1()
            //     {
            //         Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            //         int n = int.Parse(Console.ReadLine());
            //         int m = 0;
            //         int[] sayilar = new int[n];
            //         for (int i = 0; i < n; i++)
            //         {
            //             Console.WriteLine("Lütfen sayı giriniz: ");
            //             m = int.Parse(Console.ReadLine());
            //             sayilar[i] = m;
            //         }
            //         Console.WriteLine("Girilen çift sayılar :");
            //         foreach (var item in sayilar)
            //         {
            //             if (item % 2 == 0)
            //                 Console.WriteLine(item);
            //         }
            //     }
            //     public void soru2()
            //     {
            //         Console.WriteLine("Lüften 1. sayıyı giriniz :");
            //         int n = int.Parse(Console.ReadLine());
            //         Console.WriteLine("Lüften 2. sayıyı giriniz :");
            //         int m = int.Parse(Console.ReadLine());
            //         int k = 0;
            //         int[] sayilar = new int[n];
            //         for (int i = 0; i < n; i++)
            //         {
            //             Console.WriteLine("Lütfen sayı giriniz: ");
            //             k = int.Parse(Console.ReadLine());
            //             sayilar[i] = k;
            //         }

            //         Console.WriteLine("İkinci sayıya eşit veya tam bölünen sayılar :");
            //         foreach (var item in sayilar)
            //         {
            //             if (item % m == 0 || item == m)
            //                 Console.WriteLine(item);
            //         }

            //     }
            //     public void soru3()
            //     {
            //         Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            //         int n = int.Parse(Console.ReadLine());
            //         string m;
            //         string[] kelime = new string[n];
            //         for (int i = 0; i < n; i++)
            //         {
            //             Console.WriteLine("Lütfen kelime giriniz ");
            //             m = Console.ReadLine();
            //             kelime[i] = m;
            //         }
            //         Console.WriteLine("Girilen kelimeler sondan başa göre ");
            //         Array.Reverse(kelime);
            //         foreach (var item in kelime)
            //         {
            //             Console.WriteLine(item);
            //         }
            //     }
            //     public void soru4()
            //     {
            //         Console.WriteLine("Lütfen bir cümle yazınız : ");
            //         string m = Console.ReadLine();
            //         string[] kelime = m.Split(" ");
            //         int sayi = 0;
            //         Console.WriteLine("Toplam kelime sayısı :" + kelime.Length);
            //         for (int i = 0; i < kelime.Length; i++)
            //         {
            //             char[] harf = kelime[i].ToCharArray();
            //             sayi += harf.Length;
            //         }
            //         Console.WriteLine("Toplam harf sayısı :" + sayi);
            //     }
            // }

            //String Metotlar
            // string degisken = "Dersimiz C# , Hoşgeldiniz.";
            // string degisken2 = "Dersimiz C#.";
            // //Lenght => kaç harf olduğunu verir.
            // Console.WriteLine(degisken.Length);
            // // ToUpper() => tüm karakterleri büyük yazdırır.
            // //ToLower() => tüm karakterleri küçük yazdırır.
            // Console.WriteLine(degisken.ToLower());
            // Console.WriteLine(degisken.ToUpper());

            // //Concat(degisken,eklemek istenilen) => Verilen değerin sonuna ekleme işlemi yapar.

            // Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            // //Compare => Parametre olarak verilen iki string ifadeyi karşılaştırır ve geriye int türünde bir veri döndürür. Eğer dönüş değeri sıfır (0) ise iki metin birbirine eşittir. Aksi takdirde parametre olarak verilen metinleri ilk harflerinden itibaren tek tek karşılaştırır ve farklılığın olduğu ilk harflerin alfabedeki sıralarına göre -1 veya 1 sayı değerlerini döndürür.
            // //CompareTo =>     String Compare yöntemi ile iki tane string değer karşılaştırılır.  Karşılaştırma da büyük küçük harf kontrolü ile sıralaması kontrol edilir.
            // Console.WriteLine(degisken.CompareTo(degisken2));
            // Console.WriteLine(String.Compare(degisken,degisken2,false));
            // Console.WriteLine(String.Compare(degisken,degisken2,true));

            // //Contains
            // Console.WriteLine(degisken.Contains(degisken2));
            // Console.WriteLine(degisken.EndsWith("Hoşgeldiniz."));
            // Console.WriteLine(degisken.StartsWith("Merhaba!"));

            // //IndexOf

            // Console.WriteLine(degisken.IndexOf("C#"));
            // Console.WriteLine(degisken.IndexOf("Emine"));
            // Console.WriteLine(degisken.LastIndexOf("i"));

            // //Insert
            // Console.WriteLine(degisken.Insert(0,"Merhaba"));
            
            // //PadLeft,PadRight
            // Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            // Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            // //Remove
            // Console.WriteLine(degisken.Remove(10));
            // Console.WriteLine(degisken.Remove(5,3));
            // Console.WriteLine(degisken.Remove(0,1));

            // //Replace
            // Console.WriteLine(degisken.Replace("C#","C Sharp"));
            // Console.WriteLine(degisken.Replace(" ","*"));

            // //Split
            // Console.WriteLine(degisken.Split(" ")[1]);

            // //SubString
            // Console.WriteLine(degisken.Substring(4));
            //     Console.WriteLine(DateTime.Now); //Günün tarihini getirir.
            //     Console.WriteLine(DateTime.Now.Date);
            //     Console.WriteLine(DateTime.Now.Month);
            //     Console.WriteLine(DateTime.Now.Year);
            //     Console.WriteLine(DateTime.Now.Hour);
            //     Console.WriteLine(DateTime.Now.Minute);
            //     Console.WriteLine(DateTime.Now.Second);

            //     Console.WriteLine(DateTime.Now.DayOfWeek);// Bu haftanın hangi günü olduğunu verir.
            //     Console.WriteLine(DateTime.Now.DayOfYear);// Bu gün yılın kaçıncı günü olduğunu verir.

            //     Console.WriteLine(DateTime.Now.ToLongDateString());//1 Şubat 2022 Cuma

            //     Console.WriteLine(DateTime.Now.ToShortDateString());//11.02.2022

            //     Console.WriteLine(DateTime.Now.ToLongTimeString());
            //     Console.WriteLine(DateTime.Now.ToShortTimeString());

            //     Console.WriteLine(DateTime.Now.AddDays(2)); //Bu güne 2 gün ekle.
            //     Console.WriteLine(DateTime.Now.AddHours(3)); 
            //     Console.WriteLine(DateTime.Now.AddSeconds(30)); 
            //     Console.WriteLine(DateTime.Now.AddMonths(5)); 
            //     Console.WriteLine(DateTime.Now.AddYears(5)); 
            //     Console.WriteLine(DateTime.Now.AddMilliseconds(100)); 

            //     //DateTime Format
            //     Console.WriteLine(DateTime.Now.ToString("dd")); //11
            //     Console.WriteLine(DateTime.Now.ToString("ddd")); //Cum
            //     Console.WriteLine(DateTime.Now.ToString("dddd")); //Cuma


            //     Console.WriteLine(DateTime.Now.ToString("MM")); //02
            //     Console.WriteLine(DateTime.Now.ToString("MMM")); //Şub
            //     Console.WriteLine(DateTime.Now.ToString("MMMM")); //Şubat

            //     Console.WriteLine(DateTime.Now.ToString("yy")); //22
            //     Console.WriteLine(DateTime.Now.ToString("yyy")); //2022
                
            //     //Math Kütüphanesi
            //     Console.WriteLine(Math.Abs(-25));//25

            //     Console.WriteLine(Math.Sin(10));
            //     Console.WriteLine(Math.Cos(10));
            //     Console.WriteLine(Math.Tan(10));


            //     Console.WriteLine(Math.Ceiling(22.3));//22
            //     Console.WriteLine(Math.Round(22.3));//22
            //     Console.WriteLine(Math.Round(22.7));//26
            //     Console.WriteLine(Math.Floor(22.7));//22

            //     Console.WriteLine(Math.Max(2,3));
            //     Console.WriteLine(Math.Min(2,3));

            //     Console.WriteLine(Math.Pow(3,4));//üs alma
            //     Console.WriteLine(Math.Sqrt(9));//Kök hesaplar.

            //     Console.WriteLine(Math.Log(9));//9'un e tabanında logaritmasını verir.
            //     Console.WriteLine(Math.Log10(10)); 
            // }
        
             //List<T> class
            // T object türüdür

    //         List<int> sayiListesi = new List<int>();
    //         sayiListesi.Add(23);
    //         sayiListesi.Add(10);
    //         sayiListesi.Add(4);
    //         sayiListesi.Add(5);
    //         sayiListesi.Add(92);
    //         sayiListesi.Add(34);


    //         List<string> renkler = new List<string>();
    //         renkler.Add("Mavi");
    //         renkler.Add("Kırmızı");
    //         renkler.Add("Turuncu");
    //         renkler.Add("Sarı");
    //         renkler.Add("Yeşil");

    //         //Count
    //         Console.WriteLine(renkler.Count);
    //         Console.WriteLine(sayiListesi.Count);
            
    //         Console.WriteLine("---------- Sayı Listesi ----------");
    //         foreach (var sayi in sayiListesi)
    //         {
    //             Console.WriteLine(sayi);
    //         }

    //         Console.WriteLine("---------- Renk Listesi ----------");
    //         foreach (var renk in renkler)
    //         {
    //             Console.WriteLine(renk);
    //         }

    //         Console.WriteLine("---------- Sayı Listesi ----------");
    //         sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

    //         Console.WriteLine("---------- Renk Listesi ----------");
    //         renkler.ForEach(renk => Console.WriteLine(renk));


    //         //Listeden eleman çıkarma
    //         sayiListesi.Remove(4);
    //         renkler.Remove("Yeşil");
    //         Console.WriteLine("---------- Sayı Listesi ----------");
    //         sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

    //         Console.WriteLine("---------- Renk Listesi ----------");
    //         renkler.ForEach(renk => Console.WriteLine(renk));

    //         sayiListesi.RemoveAt(0);
    //         renkler.RemoveAt(0);

    //         Console.WriteLine("---------- Sayı Listesi ----------");
    //         sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

    //         Console.WriteLine("---------- Renk Listesi ----------");
    //         renkler.ForEach(renk => Console.WriteLine(renk));

    //         //Liste içinde arama

    //         if(sayiListesi.Contains(10)){
    //             Console.WriteLine("10 sayısı bulundu");
    //         }

    //         //Eleman ile indekse erişme

    //         Console.WriteLine(renkler.BinarySearch("Sarı"));


    //         //Diziyi listeye çevirme
    //         string[] hayvanlar = {"Kedi","Köpek","Kuş"};
    //         List<string> hayvanListesi = new List<string>(hayvanlar);


    //         //Liste temizleme
    //         hayvanListesi.Clear();

    //         //List içerisinde nesne tutma
    //         List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
    //         Kullanıcılar kullanıcı1 = new Kullanıcılar();
    //         kullanıcı1.Isim = "Emine";
    //         kullanıcı1.Soyisim="Metin";
    //         kullanıcı1.Yas = 22;

            
    //         Kullanıcılar kullanıcı2 = new Kullanıcılar();
    //         kullanıcı2.Isim="Gizem";
    //         kullanıcı2.Soyisim="Göz";
    //         kullanıcı2.Yas = 26;

    //         kullanıcıListesi.Add(kullanıcı1);
    //         kullanıcıListesi.Add(kullanıcı2);

            

    //     }
    // }

    // public class Kullanıcılar{
    //     private string isim;
    //     private string soyisim;
    //     private int yas;

    //     public string Isim { get => isim; set => isim = value; }
    //     public string Soyisim { get => soyisim; set => soyisim = value; }
    //     public int Yas { get => yas; set => yas = value; }
    // }

    // ArrayList liste = new ArrayList();
    //         liste.Add("Emine");
    //         liste.Add("Ümit");
    //         liste.Add("Zeynep");
    //         liste.Add("Derya");
    //         liste.Add(2);
    //         liste.Add(true);

    //         //Veri Erişim
    //         Console.WriteLine(liste[1]);

    //         foreach (var item in liste)
    //         {
    //             Console.WriteLine(item);
    //         }

    //         //Add Range
    //         Console.WriteLine("********* Add Range ***********");
    //         //string[] renkler = {"Kırmızı","Sarı","Yeşil"};
    //         //liste.AddRange(renkler);

    //         List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
    //         liste.AddRange(sayilar);
    //         foreach (var item in liste)
    //         {
    //             Console.WriteLine(item);
    //         }

    //         //Sort
    //         Console.WriteLine("----- Sort ------");
    //         liste.Sort();
    //         foreach (var item in liste)
    //         {
    //             Console.WriteLine(item);
    //         }

    //         Console.WriteLine("------- Binary Search -------");
    //         Console.WriteLine(liste.BinarySearch(9));

    //         Console.WriteLine("------- Reverse -------");
    //         liste.Reverse();
    //         foreach (var item in liste)
    //         {
    //             Console.WriteLine(item);
    //         }

    //         liste.Clear();
    //     }

    //Dictionary
    // Dictionary<int,string> kullanicilar = new Dictionary<int, string>();

    //         kullanicilar.Add(1,"Emine Metin");
    //         kullanicilar.Add(2,"Ümit Fener");
    //         kullanicilar.Add(3,"Zeynep Koç");
    //         kullanicilar.Add(4,"Derya Deniz");

    //         Console.WriteLine("----- Elemana Erişim -----");
    //         Console.WriteLine(kullanicilar[1]);

    //         foreach (var item in kullanicilar)
    //         {
    //             Console.WriteLine(item);
    //         }
    //         Console.WriteLine(kullanicilar.Count);

    //         Console.WriteLine(kullanicilar.ContainsKey(2));
    //         Console.WriteLine(kullanicilar.ContainsValue("Emine Metin"));

    //         kullanicilar.Remove(4);
    //         foreach (var item in kullanicilar)
    //         {
    //             Console.WriteLine(item);
    //         }
    //         foreach (var item in kullanicilar.Keys)
    //         {
    //             Console.WriteLine(item);
    //         }
    //         foreach (var item in kullanicilar.Values)
    //         {
    //             Console.WriteLine(item);
    //         }

    //SINIF KAVRAMI
    // Calisan calisan1 = new Calisan();
    //         calisan1.Ad = "Emine";
    //         calisan1.Soyad = "Metin";
    //         calisan1.No = 123;
    //         calisan1.Departman = "Yazılım";

    //         calisan1.CalisanBilgiler();

    //         Calisan calisan2 = new Calisan();
    //         calisan2.Ad = "Ümit";
    //         calisan2.Soyad = "Fener";
    //         calisan2.No = 56467;
    //         calisan2.Departman = " ";

    //         calisan2.CalisanBilgiler();
    //     }
    // }

    // class Calisan
    // {
    //     public string Ad;
    //     public string Soyad;
    //     public int No;
    //     public string Departman;

    //     public void CalisanBilgiler()
    //     {
    //         Console.WriteLine("Çalışan Adı {0}",Ad);
    //         Console.WriteLine("Çalışan Soyadı {0}",Soyad);
    //         Console.WriteLine("Çalışan Numarası {0}",No);
    //         Console.WriteLine("Çalışan Departmanı {0}",Departman);
    //     }


    //ÖDEV 2
    //  ArrayList asalSayilar = new ArrayList();
    //         ArrayList asalOlmayanlar = new ArrayList();
    //         Console.WriteLine("Lütfen 20 adet sayı giriniz :");
    //         for (int i = 1; i < 21; i++)
    //         {
    //             Console.WriteLine("{0}.sayıyı giriniz :", i + 1);
    //             int n = int.Parse(Console.ReadLine());
    //             if (negatif(n))
    //             {
    //                 int sayac = 0;
    //                 for (int k = 2; k < n; k++)
    //                 {
    //                     if (n % k == 0)
    //                     {
    //                         sayac++;
    //                     }

    //                 }

    //                 if (sayac == 0)
    //                 {
    //                     if (sayac == 1)
    //                     {
    //                         asalOlmayanlar.Add(n);
    //                     }
    //                     else
    //                         asalSayilar.Add(n);
    //                 }

    //                 else
    //                 {
    //                     asalOlmayanlar.Add(n);
    //                 }
    //             }

    //             else
    //             {
    //                 System.Console.WriteLine("Lütfen Pozitif ve Numeric Bir sayı Giriniz");
    //             }


    //         }
    //         asalSayilar.Sort();
    //         asalSayilar.Reverse();
    //         asalOlmayanlar.Sort();
    //         asalOlmayanlar.Reverse();

    //         System.Console.WriteLine("----------Asal Sayılar----------");

    //         foreach (int item in asalSayilar)
    //         {
    //             System.Console.WriteLine(item);
    //         }
    //         System.Console.WriteLine("----------Asal Olmayan Sayılar----------");
            
    //         foreach (var item in asalOlmayanlar)
    //         {
    //             System.Console.WriteLine(item);
    //         }


    //         int toplam1=0;
    //         int toplam2=0;
    //         foreach (int item in asalSayilar)
    //         {
    //             toplam1=toplam1+item;
                    
    //         }
    //         Console.WriteLine("Asal Sayıların Ortalaması=  " + toplam1/asalSayilar.Count+ "  Dizideki Eleman Sayısı= "+asalSayilar.Count );
    //         foreach (int item in asalOlmayanlar)
    //         {
    //             toplam2=toplam2+item;
                    
    //         }
    //         Console.WriteLine("Asal Olmayan Sayıların Ortalaması=  " + toplam2/asalOlmayanlar.Count+ "  Dizideki Eleman Sayısı= "+asalOlmayanlar.Count );
    //     }

    //     private static bool negatif(int s)
    //     {
    //         bool sonuc = true;
    //         if (s < 0)
    //         {
    //             sonuc = false;
    //         }

    //         return sonuc;

    //     }


    //KURUCU METOTLAR
    // Calisan calisan1 = new Calisan("Emine","Metin",123,"Yazılım");
    //         calisan1.CalisanBilgiler();

    //         Calisan calisan2 = new Calisan("Ümit","Fener",56467,"");
    //         calisan2.CalisanBilgiler();

    //         Calisan calisan3 = new Calisan("Zeynep","Koç");
    //         calisan3.CalisanBilgiler();
    //     }
    // }
    // class Calisan
    // {
    //     public string Ad;
    //     public string Soyad;
    //     public int No;
    //     public string Departman;

    //     public Calisan(string ad, string soyad, int no, string departman)
    //     {
    //         this.Ad = ad;
    //         this.Soyad = soyad;
    //         this.No = no;
    //         this.Departman = departman;
    //     }

    //     public Calisan(string ad, string soyad)
    //     {
    //         this.Ad = ad;
    //         this.Soyad = soyad;
    //     }
        
    //     public Calisan()
    //     {
    //     }
    //     public void CalisanBilgiler()
    //     {
    //         Console.WriteLine("Çalışan Adı {0}",Ad);
    //         Console.WriteLine("Çalışan Soyadı {0}",Soyad);
    //         Console.WriteLine("Çalışan Numarası {0}",No);
    //         Console.WriteLine("Çalışan Departmanı {0}",Departman);
    //     }

    //encapsulation
    // Ogrenci ogrenci = new Ogrenci();
    //             ogrenci.Isim = "Emine";
    //             ogrenci.Soyisim = "Metin";
    //             ogrenci.OgrenciNo = 526;
    //             ogrenci.Sinif = 3;
    //             ogrenci.OgrenciBilgileriniGetir();

    //             ogrenci.SinifAtlat();
    //             ogrenci.OgrenciBilgileriniGetir();

    //             Ogrenci ogrenci1 = new Ogrenci("Deniz","Derya",256,1);
    //             ogrenci1.OgrenciBilgileriniGetir();

    //             ogrenci1.SinifDusur();
    //             ogrenci1.OgrenciBilgileriniGetir();
    //         }
    //     }
    //     class Ogrenci
    //     {
    //         private string isim; //field

    //         private string soyisim;
    //         private int ogrenciNo;
    //         private int sinif;

    //         public string Isim
    //         {
    //             get { return isim; }
    //             set { isim = value; }
    //         }
    //         public string Soyisim
    //         {
    //             get => soyisim;
    //             set => soyisim = value;
    //         }
    //         public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    //         public int Sinif
    //         {
    //             get => sinif;
    //             set
    //             {
    //                 if (value >= 1)
    //                 {
    //                     Console.WriteLine("Sınıf en az 1 olabilir.");
    //                     sinif = 1;
    //                 }
    //                 else
    //                 {
    //                     sinif = value;
    //                 }
    //             }
    //         }

    //         public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
    //         {
    //             Isim = ısim;
    //             Soyisim = soyisim;
    //             OgrenciNo = ogrenciNo;
    //             Sinif = sinif;
    //         }

    //         public Ogrenci()
    //         {

    //         }

    //         public void OgrenciBilgileriniGetir()
    //         {
    //             Console.WriteLine("***** Öğrenci Bilgileri *****");
    //             Console.WriteLine("Öğrenci Adı : {0}", this.Isim);
    //             Console.WriteLine("Öğrenci Soyadı : {0}", this.Soyisim);
    //             Console.WriteLine("Öğrenci Numarası : {0}", this.OgrenciNo);
    //             Console.WriteLine("Öğrenci Sınıfı : {0}", this.Sinif);

    //         }
    //         public void SinifAtlat()
    //         {
    //             this.Sinif = this.Sinif + 1;
    //         }
    //         public void SinifDusur()
    //         {
    //             this.Sinif = this.Sinif - 1;
    //         }

    //static sınıf
    //  Console.WriteLine("Çalışan Sayısı : {0}",Calisan.CalisanSayisi);
    //         Calisan calisan = new Calisan("Emine","Metin","Yazılım");
    //         Calisan calisan1 = new Calisan("Ali","Kaya","Yazılım");
    //         Calisan calisan3 = new Calisan("Dean","Winchester","Yazılım");
    //         Console.WriteLine("Çalışan Sayısı : {0}",Calisan.CalisanSayisi);
            
    //         Console.WriteLine("Toplama işleminin sonucu : {0}",Islemler.Topla(100,200));

    //         Console.WriteLine("Çıkarma işleminin sonucu : {0}",Islemler.Cikar(200,100));
    //     }
    // }

    // class Calisan
    // {
    //     private static int calisanSayisi;

    //     public static int CalisanSayisi { get => calisanSayisi;}

    //     private string Isim;
    //     private string SoyIsim;
    //     private string Departman;

    //     static Calisan()
    //     {
    //         calisanSayisi = 0;
    //     }
    //     public Calisan(string isim, string soyIsim, string departman)
    //     {
    //         this.Isim = isim;
    //         this.SoyIsim = soyIsim;
    //         this.Departman = departman;
    //         calisanSayisi ++;
    //     }
    // }
    // static class Islemler
    // {
    //     public static long Topla(int sayi1 , int sayi2)
    //     {
    //         return sayi1 + sayi2;
    //     }

    //     public static long Cikar(int sayi1 , int sayi2)
    //     {
    //         return sayi1 - sayi2;
    //     }

    //struct
    // Dikdortgen dikdortgen = new Dikdortgen();
    //         dikdortgen.kisaKenar = 3;
    //         dikdortgen.uzunKenar = 4;
    //         Console.WriteLine("Class Dikdörtgen Alanı {0}",dikdortgen.AlanHesapla());

    //         Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
    //         dikdortgen_Struct.kisaKenar = 3;
    //         dikdortgen_Struct.uzunKenar = 4;
    //         Console.WriteLine("Struct Dikdörtgen Alanı {0}",dikdortgen_Struct.AlanHesapla());
    //     }
    // }

    // class Dikdortgen
    // {
    //     public int kisaKenar;
    //     public int uzunKenar;

    //     public Dikdortgen()
    //     {
    //         kisaKenar = 3;
    //         uzunKenar = 4;
    //     }
    //     public long AlanHesapla()
    //     {
    //         return this.kisaKenar * this.uzunKenar;
    //     }
    // }

    // struct Dikdortgen_Struct
    // {
    //     public int kisaKenar;
    //     public int uzunKenar;

    //     public Dikdortgen_Struct(int KisaKenar , int UzunKenar)
    //     {
    //         uzunKenar = UzunKenar;
    //         kisaKenar = KisaKenar;
    //     }
    //     public long AlanHesapla()
    //     {
    //         return this.kisaKenar * this.uzunKenar;
    //     }

    //enum
    // Console.WriteLine(Gunler.Pazar);
    //         Console.WriteLine((int)Gunler.Cumartesi);
    //         int sicaklik = 32;
    //         if (sicaklik <= (int)HavaDurumu.Normal)
    //         {
    //             Console.WriteLine("Dışarı çıkmak için havanın ısınmasını bekleyin.");
    //         }
    //         else if (sicaklik >= (int)HavaDurumu.Sicak)
    //         {
    //             Console.WriteLine("Çok sıcak bir gün.");
    //         }
    //         else if ( sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.CokSicak)
    //         {
    //             Console.WriteLine("Hadi dışarı çıkalım");
    //         }
    //     }
    // }

    // enum Gunler
    // {
    //     Pazartesi,
    //     Sali,
    //     Carsamba,
    //     Persembe,
    //     Cuma,
    //     Cumartesi=23,
    //     Pazar
    // };

    // enum HavaDurumu
    // {
    //     Soguk = 5,
    //     Normal = 20,
    //     Sicak = 25,
    //     CokSicak = 30

    // };

    //inheritance
    TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("***************");
            Kus marti = new Kus();
            marti.Ucmak();
    }
    }
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilirler");

        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki(); 
            Console.WriteLine("Hayvanlar güneşe tepki verir.");
        }
    }

    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Bosaltim();
            base.Beslenme();
            base.Solunum();
        }
        public void SurunerekHareketEtme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class Kus : Hayvanlar
    {
        public Kus()
        {
            base.Adaptasyon();
            base.Bosaltim();
            base.Beslenme();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
     public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım Yapar.");
        }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
    public class Bitkiler : Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");

        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki(); // üst sınıftaki komutları çalıştırır.
            Console.WriteLine("Bitkiler güneşe tepki verir.");

        }

    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Bosaltim();
            base.Beslenme();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Bosaltim();
            base.Beslenme();
            base.Solunum();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }


    }

    
}