import java.util.Scanner;

public class taksimetre {
    public static void main(String[] args) {
    int km;
    double per=2.20,toplam,baslangic=10;
        Scanner input=new Scanner(System.in);
        System.out.print("Mesafeyi km cinsinden giriniz: ");
        km=input.nextInt();
        toplam=per*km;
        toplam+=baslangic;
        toplam=(toplam<20)?20: toplam;
        System.out.println("toplam tutar: "+toplam);

    }
}
