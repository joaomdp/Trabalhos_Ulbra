import java.util.Random;

public class Estatistica {
    public static void main(String[] args) {
        int [][] matriz = new int[5][5];
        int l, c;
        int[] vetor = new int[25];
        int media, total =0;
        for (l=0;l<5;l++){
            for (c=0;c<5;c++){
                Random rand = new Random();
                matriz[l][c] = rand.nextInt(35);
                total+=matriz[l][c];
            }
        }
        media = total/25;

        int i=0;
        for (l=0;l<5;l++){
            for (c=0;c<5;c++){
                vetor[i]=matriz[l][c];
                i++;
            }
        }

        for (i=0;i<25;i++){
            for (int j=i+1;j<25;j++){
                if (vetor[i]>vetor[j]){
                    int temp = vetor[j];
                    vetor[j] = vetor[i];
                    vetor[i]=temp;
                }
            }
        }
        for (i=0;i<25;i++){
            System.out.println(vetor[i]);
        }
        int qtdmoda = 0;
        int moda=vetor[0];
        for (int j=0;j<25;j++){
            int previoesModa=contar(vetor, vetor[j]);
            if (previoesModa>qtdmoda){
                moda=vetor[j];
                qtdmoda=previoesModa;
            }
        }
        System.out.println("MEDIANA: "+vetor[24/2]);
        System.out.println("MEDIA: "+media);
        System.out.println("MODA: "+moda);
    }

    public static int contar(int vetor[], int x) {
        int cont = 0;
        for (int i=0;i< vetor.length;i++){
            if (x==vetor[i]){
                cont++;
            }
        }
        return cont;
    }
}
