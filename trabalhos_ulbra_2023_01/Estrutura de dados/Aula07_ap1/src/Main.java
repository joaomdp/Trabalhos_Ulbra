import java.text.DecimalFormat;
import java.util.Random;

public class Main {
    public static void main(String[] args) {
        DecimalFormat df = new DecimalFormat("#.##");

        int[][] matriz = new int[100][100];

        Random random = new Random();

        for(int i = 0; i < matriz.length; i++){
            for(int j = 0; j < matriz.length; j++){
                matriz[i][j] = random.nextInt(2);
            }
        }

        for(int i = 0; i < matriz.length; i++){
            for(int j = 0; j < matriz.length; j++){
                System.out.print(matriz[i][j] + " ");
            }
            System.out.println();
        }




        int[][] padrao = {{0,0},
                {1,1},
                {0,1}};



        int contador = 0;
        long startTime = System.nanoTime();
        for (int i = 0; i < 100 - padrao.length + 1; i++) {
            for (int j = 0; j < 100 - padrao[0].length + 1; j++) {
                boolean encontrado = true;
                for (int k = 0; k < padrao.length; k++) {
                    for (int l = 0; l < padrao[0].length; l++) {
                        if (matriz[i + k][j + l] != padrao[k][l]) {
                            encontrado = false;
                            break;
                        }
                    }
                    if (!encontrado) {
                        break;
                    }
                }
                if (encontrado) {
                    contador++;
                    System.out.println("Padrão encontrado na posição [" + i + ", " + j + "]");
                }
            }
        }
        long endTime = System.nanoTime();
        long tempoDecorrido = endTime - startTime;
        double tempoDecorridoSegundos = (double) tempoDecorrido / 1000000000.0;

        df.format(tempoDecorridoSegundos);
        System.out.println("Tempo decorrido para achar todos os padrôes foi de " + tempoDecorridoSegundos + " segundos" );
        System.out.println("O padrão foi encontrado " + contador + " vezes.");

    }
}
