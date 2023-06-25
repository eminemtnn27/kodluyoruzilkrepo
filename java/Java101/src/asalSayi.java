public class asalSayi {
    public static void main(String[] args) {
        System.out.println("1-100 arasindaki asal sayilar: ");
        int d = 0;
        for(int sayi=2;sayi<=100;sayi++)
        {
           int asalMi = 0;
           for (int i = 2; i < sayi; i++)
           {
                if (sayi % i == 0)
                {
                    asalMi = 1;
                    break;
                }
            }
         if(asalMi==0)
         {
            System.out.print(sayi+" ");
            d++;
         }
    }
}
}

