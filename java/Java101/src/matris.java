public class matris {
    public static void main(String[] args) {
        int [][] matris = { {2,3,4}, {5,6,4} };
        for(int[] row: matris){
            for(int col: row){
                System.out.print(col + " ");
            }
            System.out.println();
        }
        System.out.println("Matrisin transpozu : ");
        for(int i = 0; i < matris[0].length; i++){
            for(int j = 0; j < matris.length; j++){
                System.out.print(matris[j][i] + " ");
            }
            System.out.println();
        }
    }
}
