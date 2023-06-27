import java.util.Scanner;
public class recursivePrime {
    static boolean asalMi(int d, int i){
        if(d==0 || d==1){
            return false;
        }
        if(d==2){
            return true;
        }
        else{
             if(d%i==0){
                if(i==1){
                    return asalMi(d,i+1);
                }else if(d==i){
                    return true;
                }else{
                    return false;
                }
            } else{
                return asalMi(d,i+1);
            }
        }
    }
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int d;
        System.out.print("Sayıyı giriniz : ");
        d=input.nextInt();
        if(asalMi(d,1)){
            System.out.println(d + " sayısı asal sayıdır\n");
        }else {
            System.out.println(d + " sayısı asal sayı değildir");
        }
    }
}