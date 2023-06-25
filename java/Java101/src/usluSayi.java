import java.util.Scanner;

public class usluSayi {
    public static void main(String[] args) {
        int sayi,usVal,uslu=1,k;
        Scanner input = new Scanner(System.in);
        System.out.print("Üssünü almak istediğiniz sayıyı giriniz: ");
        sayi = input.nextInt();
        System.out.print("Üs değerini giriniz: ");
        usVal = input.nextInt();
        for(int i=1;i<=usVal;i++){
            uslu=uslu*sayi;
        }
        System.out.print("Sonuç: " + uslu);
    }
}
