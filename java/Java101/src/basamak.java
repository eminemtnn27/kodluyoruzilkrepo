import java.util.Scanner;

public class basamak {
    public static void main(String[] args) {
        int sayi,val= 0,toplam=0;
        Scanner input = new Scanner(System.in);
        System.out.print("Bir Sayı Girin: ");
        sayi = input.nextInt();
        while(sayi != 0)
        {
            toplam=(sayi%10)+toplam;
            sayi /= 10;
            ++val;
        }
        System.out.println("Basamak Toplamı: " + toplam);
    }
}
