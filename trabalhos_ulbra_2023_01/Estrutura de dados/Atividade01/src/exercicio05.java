public class exercicio05 {
    public static void main(String[] args) {
        int array[]={3,4,1,5};

        System.out.println("{");

        for (int i=0;i<4;i++){
            System.out.print(array[i]);
            if (i!=array.length-1){
                System.out.println(",");
            }else {
                System.out.println("}");
            }
        }
    }
}
