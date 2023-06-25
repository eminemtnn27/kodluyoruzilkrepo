import java.util.Scanner;

public class divisiblebyfourandthree {
    public static void main(String[] args) {
        int k;
        Scanner inp = new Scanner(System.in);
        System.out.print("Bir tam sayı giriniz: ");
        k= inp.nextInt();
        int piece = 0, sum = 0;
        for(int i = 0; i<=k;i++)
        {
            if (i % 3 == 0 || i % 4 == 0) {
                sum += i;
                piece++;
            }

        }
        System.out.println("Sayıların Toplamı: "+sum );
        System.out.println("Aritmetik Ortalama: "+sum/piece);
    }
}
