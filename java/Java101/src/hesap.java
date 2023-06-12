import java.util.Scanner;
public class hesap {
    public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
        System.out.print("1. Sayıyı giriniz: ");
    int sayi1 = scan.nextInt();
        System.out.print("2. Sayıyı giriniz: ");
    int sayi2 = scan.nextInt();
        System.out.println("Yapmak istediğiniz işlemi seçiniz");
        System.out.println("1. TOPLAMA");
        System.out.println("2. ÇIKARMA");
        System.out.println("3. ÇARPMA");
        System.out.println("4. BÖLME");
        System.out.print("Secimininiz : ");
     int secim = scan.nextInt();
        switch(secim) {
        case 1:
            System.out.println("Toplama   = " + (sayi1 + sayi2));
            break;
        case 2:
            System.out.println("Çıkarma  =" + (sayi1 - sayi2));
            break;
        case 3:
            System.out.println("Carpma  = " + (sayi1 * sayi2));
            break;
        case 4:
            System.out.println("Bölme  = " + (float)sayi1 / sayi2);
    }
}

}
