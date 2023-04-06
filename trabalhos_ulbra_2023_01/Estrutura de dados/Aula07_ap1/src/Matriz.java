public class Matriz {
    public static void main(String[] args) {

        int tamanho = 100;
        int [][] matriz = new int[tamanho][tamanho];

        int padrao00 = 0;
        int padrao01 = 0;
        int padrao10 = 0;
        int padrao11 = 0;

        for (int i=0; i < tamanho; i++){
            for (int k=0;k<tamanho;k++){
                matriz[i][k] = (int)(Math.random()*2);
            }
        }

        for (int i=0;i<tamanho;i++){
            for (int k=0;k<tamanho-1; k++){
                if (matriz[i][k] == 0 && matriz[i +1][k] == 0){
                    ++padrao00;
                } else if (matriz[i][k] ==0 && matriz[i+1][k]==1) {
                    ++padrao01;
                } else if (matriz[i][k] ==1 && matriz [i+1][k]==0) {
                    ++padrao10;
                }else if (matriz[i][k] == 1 && matriz[i+1][k]==1){
                    ++padrao11;
                }
            }
        }

        for (int i=0; i < 100; i++){
            for (int k=0;k<100;k++){
                System.out.println(matriz[i][k]);
            }
        }

        System.out.println();
        System.out.println(">> Padrões");
        System.out.println("Padrão OO: " + padrao00);
        System.out.println("Padrão OI: " + padrao01);
        System.out.println("Padrão IO: " + padrao10);
        System.out.println("Padrão II: " + padrao11);
    }
}
