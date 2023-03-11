import java.util.Scanner;

public class atividade03 {
    static  class Aluno{
        public double nota;
        public String nome;
    }

    public static void main(String[] args) {
        Scanner tc = new Scanner(System.in);
        int quant;
        System.out.println("Insira a quatidade de alunos: ");
        quant = tc.nextInt();

        atividade01.Aluno alunos[] = new atividade01.Aluno[quant];
        double media = leitura(alunos,quant);

        for (int i=0;i<quant;i++){
            if (alunos[i].nota>media){
                System.out.println(alunos[i].nome);
            }
        }
    }
    public static double leitura(atividade01.Aluno vetor[], int tam){
        Scanner tc = new Scanner(System.in);
        double total = 0;

        for (int i=0;i<tam;i++){
            atividade01.Aluno a = new atividade01.Aluno();
            System.out.println("Digite a nota:");
            a.nota = tc.nextDouble();
            System.out.println("Digite o nome:");
            a.nome = tc.next();
            vetor[i]=a;
            total += vetor[i].nota;
        }
        return  total/tam;
    }
}
