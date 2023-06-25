import java.util.Scanner;

public class ebobekok {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int i=1,ebob=1,ekok=1;
        System.out.println("n1 sayısını giriniz : ");
        int n1 = input.nextInt();
        System.out.println("n2 Sayısını Giriniz: ");
        int n2= input.nextInt();
        while (i<=n1) {
            i++;
            if (n1 % i == 0 && n2 % i == 0) {
                ebob = i;
            }
        }
        ekok=(n1*n2)/ebob;
        System.out.println("Ebob : " + ebob);
        System.out.print("Ekok : " + ekok);
    }
}