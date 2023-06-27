import java.util.Scanner;
public class recursive {
    static int pow(int a, int b) {
        if(b==0) {
            return 1;
        }
        else {
            return a * pow(a,b-1);
        }
    }
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        boolean r=true;
        while (r) {
            System.out.print("Taban değeri giriniz :");
            int taban = input.nextInt();
            System.out.print("Üs değerini giriniz :");
            int us = input.nextInt();
            System.out.println("Sonuç :" + pow(taban, us));
        }
    }
}
