import java.util.Scanner;
public class KullaniciGiris {
    public static void main(String[] args) {
        String userName,password,newPass,data;
        Scanner input = new Scanner(System.in);
        System.out.print("Kullanıcı adını giriniz: ");
        userName = input.nextLine();
        System.out.print("Şifrenizi giriniz: ");
        password = input.nextLine();
        if(userName.equals("emine") && password.equals("123")){
            System.out.println("Giriş yaptınız,bekleyiniz....");
        }
        else {
            System.out.println("Kullanıcı adınız veya şifreniz yanlış.");
            System.out.print("Şifrenizi resetlemek ister misiniz? [E/H]: ");
            data = input.nextLine();
            switch (data){
                case "E" :
                    System.out.print("Yeni şifreniz : ");
                    newPass = input.nextLine();
                    if (newPass.equals(password)){
                        System.out.print("Yeni şifreniz eski şifrenizle aynı olamaz..");
                    }
                    else {
                        System.out.print("Şifreniz başarıyla değiştirildi.");
                    }
                case "H":
                    System.out.print("Yeniden deneyiniz");
            }

        }
    }
}
