 import java.util.ArrayList;
 import java.util.Scanner;

public class recursivePattern {
    /*Girilen sayı 0 veya negatif olduğu yere kadar girilen sayıdan 5 rakamını çıkarın.
    Her çıkarma işlemi sırasında ekrana son değeri yazdırın.
    Sayı negatif veya 0 olduktan sonra tekrar 5 ekleyin.
    Yine her ekleme işleminde sayının son değerini ekrana yazdırın.*/
    static ArrayList<Integer> dizi = new ArrayList<>();
    static Scanner scan = new Scanner(System.in);
    static int sayi;
    static int num;
    static ArrayList<Integer> oruntu(int num){
        dizi.add(num);
        num=num-5;if (num==0 || num<0)dizi.add(num);
        if (num>0) {
            oruntu(num);
        }
        return ters_oruntu(num,sayi);
    }
    static ArrayList<Integer> ters_oruntu(int num,int sayi){
        if (num<=sayi){
            num+=5;
            dizi.add(num);
        }
        return dizi;
    }
    public static void main(String[] args) {
        System.out.print("1den büyük bir sayı giriniz :");
        sayi = scan.nextInt();
        num=sayi;
        System.out.println(oruntu(num));
    }
}