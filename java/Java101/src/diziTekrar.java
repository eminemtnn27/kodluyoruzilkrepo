import java.util.Scanner;

public class diziTekrar {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Dizide Aratmak İstediğiniz Sayıyı Giriniz");
        int d=input.nextInt(); //aranılan
        int tekrar=0;
        int[] array={7,5,7,8,1,9,4,5,78,4};
        for(int i=0;i<array.length;i++){
            if(d==array[i]){
                tekrar=tekrar+1;
            }
        }
        System.out.println("Tekrar Sayıları\n ");
        System.out.println(d+" sayısı "+tekrar+" kere tekrar edildi.");
    }
}
