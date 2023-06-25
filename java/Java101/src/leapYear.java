import java.util.Scanner;

public class leapYear {
    public static void main(String[] args) {
        int year, century, result;
        Scanner data = new Scanner(System.in);
        System.out.print("Yıl Giriniz : ");
        year =data.nextInt();
        century = year % 400;
        result = year % 4;
        if (century == 0 || result == 0) {
            System.out.println(year + " bir artık yıldır !");
        }
        else {
            System.out.println(year +   " bir artık yıl değildir !");
        }
    }
}