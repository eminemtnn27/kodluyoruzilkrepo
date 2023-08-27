package MyList;

public class Main {
    public static void main(String[] args) {
        MyList<Integer> list = new MyList<>();
        System.out.println("Liste Durumu : " + (list.isEmpty() ? "Boş" : "Dolu"));
        list.add(10);
        list.add(20);
        list.add(30);
        list.add(40);
        list.add(20);
        list.add(50);
        list.add(60);
        list.add(70);

        System.out.println("Liste Durumu :" + (list.isEmpty() ? "Boş" : "Dolu"));
        // Bulduğu ilk indeksi verir
        System.out.println("Indeks : " + list.indexOf(20));

        // Bulamazsa -1 döndürür
        System.out.println("Indeks :" + list.indexOf(100));

        // Bulduğu son indeksi verir
        System.out.println("Indeks : " + list.lastIndexOf(20));

        // Listeyi Object[] dizisi olarak geri verir.
        Object[] dizi = list.toArray();
        System.out.println("Object dizisinin ilk elemanı :" + dizi[0]);

        // Liste veri türünde alt bir liste oluşturdu
        MyList<Integer> altListem = list.sublist(0, 3);
        System.out.println(altListem.toString());

        // Değerim listedeki olup olmadığını sorguladı
        System.out.println("Listemde 20 değeri : " + list.contains(20));
        System.out.println("Listemde 120 değeri : " + list.contains(120));

        // Listeyi tamamen boşaltır ve varsayılan boyutuna çevirir
        list.clear();
        System.out.println(list.toString());

    }
}