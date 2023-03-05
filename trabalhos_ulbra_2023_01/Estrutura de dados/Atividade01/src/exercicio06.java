import java.util.Scanner;

public class exercicio06 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        double nota[] = new double[5];
        int soma = 0;
        int i;
        double media;

        for (i=0;i<=4;i++){
            System.out.println("Digite a "+ (i+1)+" nota");
            nota [i] = sc.nextDouble();
            soma = (int) (soma + nota[i]);
        }

        for (i = 0; i<nota.length-1; i++){
            for (int j=i+1;j< nota.length;j++){
                if (nota[i] < nota[j]){
                    double aux =  nota[i];
                    nota[i] = nota[j];
                    nota[j] = aux;
                }
            }
        }

        for (i=0;i< nota.length;i++){
            System.out.println("Nota: "+nota[i]);
        }

        media  = soma / 5;
        System.out.println("A média da turma é: "+media);

    }
}
