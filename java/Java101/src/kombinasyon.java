import java.util.Scanner;

public class kombinasyon {
    public static void main(String[] args) {
        int n,r,ndegeri=1,rdegeri=1,kdegeri=1,sonuc=1;
        Scanner input= new Scanner(System.in);
        System.out.print("N değerini giriniz: ");
        n=input.nextInt();
        System.out.print("R değerini giriniz: ");
        r=input.nextInt();
        for(int i=1;i<=n;i++){
            ndegeri=ndegeri*i;
        }
        for(int i=1;i<=r;i++){
            rdegeri=rdegeri*i;
        }
        for(int i=1;i<=(n-r);i++){
            kdegeri=kdegeri*i;
        }
        sonuc=ndegeri/(rdegeri*kdegeri);
        System.out.println("C(n,r)=n!/(r!*(n-r)!): " +"işlem Sonucu: " + sonuc);

    }
}