public class dizideTekrarEden {
    static boolean isFind(int[] arr, int value){
        for (int i : arr){
            if (i == value){
                return true;
            }
        }
        return false;
    }

    public static void main(String[] args) {
        int[] list = {1,84,7,3,1,11,51,74,2};
        int[] dublicate = new int[list.length];
        int startIndex = 0;
        for (int i = 0; i < list.length; i++) {
            if(list[i] % 2 == 0){
                dublicate[startIndex++] = list[i];
            }
        }
        for (int value : dublicate) {
            if (value != 0) {
                System.out.println(value);
            }

        }
    }
 }

