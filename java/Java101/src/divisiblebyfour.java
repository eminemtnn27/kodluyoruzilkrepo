import java.util.Scanner;

public class divisiblebyfour {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int n=0;
        int total=0;
        do {
            System.out.print( "Sayı giriniz: ");
            n=input.nextInt();
            if(n % 2== 0 || n % 4 == 0){
                total+=n;
                System.out.print("4'e bölünebilen çift sayıların toplamı: "+ total+"\n") ;
            }else{
                System.out.println("Tek sayı girdin ");
                break;
            }

        }while (n>0);
        System.out.println("Toplam: " + total );
    }
}
