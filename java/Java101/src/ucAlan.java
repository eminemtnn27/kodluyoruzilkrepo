import java.util.Scanner;

public class ucAlan {
    public static void main(String[] args){
        int a,b,c;
        double d,e,alan;
        Scanner data=new Scanner(System.in);
        System.out.print("1.kenarı giriniz: ");
        a=data.nextInt();
        System.out.print("2.kenara girin ");
        b=data.nextInt();
        System.out.print("3.kenara girin ");
        c=data.nextInt();
        d= (a+b+c)/2;
        e=2*d;
        System.out.println("Üçgenin çevresi :"+e);
        alan= Math.sqrt(d*(d-a)*(d-b)*(d-c));
        System.out.println("Üçgenin alanı :"+alan);

    }

}

