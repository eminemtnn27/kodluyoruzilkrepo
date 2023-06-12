import java.util.Scanner;

public class vucutkitleindeksi {
    public static void main(String[] args) {
        int boy,kilo;
        double indeks;
        Scanner input=new Scanner(System.in);
        System.out.print("Lütfen boyunuzu (metre cinsinde) giriniz : ");
        boy=input.nextInt();
        System.out.print("Lütfen kilonuzu giriniz : ");
        kilo=input.nextInt();
        indeks=kilo/boy*boy;
        System.out.println("Vücut Kitle İndeksiniz :"+ indeks);
    }
}