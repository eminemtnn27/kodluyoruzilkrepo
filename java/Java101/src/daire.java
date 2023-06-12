import java.util.Scanner;

public class daire {
    public static void main(String[] args) {
        int r,alfa;
        double pi=3.14;
        Scanner input=new Scanner(System.in);
        System.out.print("Dairenin yarı çapını giriniz. ");
        r=input.nextInt();
        System.out.print("Dairenin merkez açısını giriniz. ");
        alfa=input.nextInt();
        double alan=(pi * (r*r) * alfa) / 360;
        System.out.println("Dairenin alanı :"+ alan);
    }
}
