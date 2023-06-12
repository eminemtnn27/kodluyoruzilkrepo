import java.util.Scanner;
public class SinifGecme {
    public static void main(String[] args) {
     int mat,fiz,turkce,kim,muzik;
     Scanner input=new Scanner(System.in);
        System.out.println("Matematik notunuz: ");
        mat=input.nextInt();
        if(mat < 0 || mat > 100) {
            System.out.println("Geçersiz matematik notu girdiniz. Ortalamaya katılmayacak.");
            return;
        }
        System.out.println("Fizik notunuz: ");
        fiz=input.nextInt();
        if(fiz < 0 || fiz > 100) {
            System.out.println("Geçersiz matematik notu girdiniz. Ortalamaya katılmayacak.");
            return;
        }
        System.out.println("Türkçe notunuz: ");
        turkce=input.nextInt();
        if(turkce < 0 || turkce > 100) {
            System.out.println("Geçersiz matematik notu girdiniz. Ortalamaya katılmayacak.");
            return;
        }
        System.out.println("Kimya notunuz: ");
        kim=input.nextInt();
        if(kim < 0 || kim > 100) {
            System.out.println("Geçersiz matematik notu girdiniz. Ortalamaya katılmayacak.");
            return;
        }
        System.out.println("Müzik notunuz: ");
        muzik=input.nextInt();
        if(muzik < 0 || muzik > 100) {
            System.out.println("Geçersiz matematik notu girdiniz. Ortalamaya katılmayacak.");
            return;
        }
        double ort=(mat+fiz+turkce+kim+muzik)/5;
        if(ort<=55){
            System.out.println("Sınıfta kaldınız.Seneye görüşürüz:): ");
        }else{
            System.out.println("Tebrikler! Geçtiniz: ");
        }
        System.out.println("Ortalamanız : "+ort);

    }
}