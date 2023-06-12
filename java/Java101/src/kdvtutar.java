import java.util.Scanner;

public class kdvtutar {
    public static void main(String[] args) {
         double tutar,kdvTutar,kdvliTutar;
        Scanner input=new Scanner(System.in);
        System.out.print("Tutarı giriniz: " );
        tutar=input.nextDouble();
        double kdvOran=(tutar > 1000) ? 0.08 : 0.18;
        kdvTutar=tutar*kdvOran;
        kdvliTutar=tutar+kdvTutar;
        System.out.println("Kdv'siz Tutar :" + tutar);
        System.out.println("Kdv Oranı :" + kdvOran);
        System.out.println("Kdv Tutarı :" + kdvTutar);
        System.out.println("Kdv'li Tutarı :" + kdvliTutar);


    }
}