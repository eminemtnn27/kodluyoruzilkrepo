import java.util.Scanner;

public class manav {
    public static void main(String[] args) {
        double armut=2.14,elma=3.67,domates=1.11,muz=0.95,patlican=5,armutKilo,elmaKilo,domatesKilo,muzKilo,patlicanKilo;
        Scanner input=new Scanner(System.in);
        System.out.print("Armut kaç kilo? : " );
        armutKilo=input.nextDouble();
        System.out.print("Elma kaç kilo? : " );
        elmaKilo=input.nextDouble();
        System.out.print("Domates kaç kilo? : " );
        domatesKilo=input.nextDouble();
        System.out.print("Muz kaç kilo? : " );
        muzKilo=input.nextDouble();
        System.out.print("Patlıcan kaç kilo? : " );
        patlicanKilo=input.nextDouble();
        double toplam=(armutKilo*armut)+(elmaKilo*elma)+(domatesKilo*domates)+(muz*muzKilo)+(patlicanKilo*patlican);
        System.out.println("Toplam Tutar :"+ toplam);
    }
}
