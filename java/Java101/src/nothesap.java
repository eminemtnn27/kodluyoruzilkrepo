import java.util.Scanner;

public class nothesap {
    public static void main(String[] args) {
        int mat,fiz,kim,turkce,tarih,muzik;

        Scanner inp=new Scanner(System.in);
        System.out.println("Matematik notunuz: ");
        mat=inp.nextInt();

        System.out.println("Türkçe notunuz: ");
        turkce=inp.nextInt();

        System.out.println("Fizik notunuz: ");
        fiz=inp.nextInt();

        System.out.println("Kimya notunuz: ");
        kim=inp.nextInt();

        System.out.println("Tarih notunuz: ");
        tarih=inp.nextInt();

        System.out.println("Müzik notunuz: ");
        muzik=inp.nextInt();

        int toplam=(mat+fiz+kim+turkce+tarih+muzik);
        double sonuc=toplam/6.0;
        System.out.println("Ortalamanız: "+sonuc);
        System.out.println(sonuc > 60.0 ? "Sınıfı Geçtiniz" : "Sınıfta kaldınız" );

    }
}
