import java.util.Scanner;

public class DiziMaxMin {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int d,input;
        System.out.print("Kaç sayı gireceksiniz: ");
        input = scanner.nextInt();
        int[] array = new int[input];
        for(d = 0; d<array.length;d++) {
            System.out.print(d+1 +". Sayınızı giriniz: ");
            array[d] = scanner.nextInt();
        }
        int max = array[0];
        for(d = 0;d<array.length;d++) {
            if(max < array[d]) {
                max = array[d];
            }
        }
        int min = array[0];
        for(d = 0;d<array.length;d++) {
            if(array[0] > array[d]) {
                min = array[d];
            }
        }

        System.out.println("Dizi : " + array  );
        System.out.println("Girilen Sayı : " + input);
        System.out.println("Girilen sayıdan küçük en yakın sayı : " + min);
        System.out.println("Girilen sayıdan büyük en yakın sayı : " + max);

    }
}
