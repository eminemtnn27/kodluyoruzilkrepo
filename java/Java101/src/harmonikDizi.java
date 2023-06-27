import java.util.Scanner;

public class harmonikDizi {
    public static void main(String[] args) {
        double[] array = {1,6,7,8};
        int sonuc=0;
        for (int i = 0; i < array.length; i++){
             sonuc+=1/(array[i]);
        }

        System.out.println("Harmonik ortalama :" + array.length / sonuc);
    }
}
