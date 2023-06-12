import java.util.Scanner;

public class ucakBileti {
    public static void main(String[] args) {

        int km, age, road;
        Scanner data = new Scanner(System.in);
        Double perKm = 0.10, child = 0.5, young = 0.90, old = 0.70, roundTrip = 0.80;


        System.out.print("Mesafeyi km türünden giriniz : ");
        km = data.nextInt();
        System.out.print("Yaşınızı giriniz : ");
        age = data.nextInt();
        System.out.print("Yolculuk tipini giriniz (1 => Tek Yön , 2 => Gidiş Dönüş ): ");
        road = data.nextInt();

        if (age < 12) {
            if (road == 1) {
                System.out.println("Toplam tutar : " + (km * perKm * child) + " TL");
            } else if (road == 2) {
                System.out.println("Toplam tutar :" + (2 * (km * perKm * child * roundTrip)) + " TL");
            } else {
                System.out.println("Hatalı Veri Girdiniz !");
            }

        }
        if (age > 12 && age < 24) {
            if (road == 1) {
                System.out.println("Toplam tutar : " + (km * perKm * young) + " TL");
            } else if (road == 2) {
                System.out.println("Toplam tutar : " + (2 * (km * perKm * young * roundTrip)) + " TL");
            } else {
                System.out.println("Hatalı Veri Girdiniz !");
            }

        }
        if (age > 65) {
            if (road == 1) {
                System.out.println("Toplam tutar : " + (km * perKm * old) + " TL");
            } else if (road == 2) {
                System.out.println("Toplam tutar : : " + (2 * (km * perKm * old * roundTrip)) + " TL");
            } else {
                System.out.println("Hatalı Veri Girdiniz !");
            }

        }
        if (age <= 65 && age >= 24) {
            if (road == 1) {
                System.out.println("Toplam tutar : " + (km*perKm) + " TL");
            } else if (road == 2) {
                System.out.println("Toplam tutar : " + (2 * (km * perKm *  roundTrip)) + " TL");
            } else {
                System.out.println("Hatalı Veri Girdiniz !");
            }
        }

    }
}