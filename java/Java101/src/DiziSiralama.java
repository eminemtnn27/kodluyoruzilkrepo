import java.util.Arrays;
import java.util.Scanner;

public class DiziSiralama {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int d,input;
        System.out.print("Dizinin boyutunu giriniz :");
        input = scanner.nextInt();
        int[] array = new int[input];

        for(d = 0; d<input;d++) {
            System.out.print(d+1 +". elemanı: ");
            array[d] = scanner.nextInt();
        }
        System.out.println("Dizinin boyutu n :" + input  );
        Arrays.sort(array);
        System.out.println("Sıralama : " );
        for(int i=0;i<array.length;i++){
            System.out.print(array[i]+ ",");
        }

    }
}
