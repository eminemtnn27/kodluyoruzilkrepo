import java.util.Scanner;

public class kuvvetler {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int sayi,i=1;
        System.out.print("Sayı Girin: ");
        sayi=input.nextInt();
        boolean four=true,five=true;
        while(four||five) {
            if (Math.pow(4, i) < sayi && four) {
                System.out.print("4'ün kuvveti: " + Math.pow(4, i));
            }else{
                four=false;
            }
            if (Math.pow(5, i)<sayi && five){
                System.out.print(" 5'in Kuvveti: " + Math.pow(5, i));
            }else{
                five=false;
            }
            i++;
            System.out.println();
        }
    }
}