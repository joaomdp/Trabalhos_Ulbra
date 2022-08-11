import java.util.Scanner;

public class Exercicio07 {
    public static void main(String[] args) {
        String nome = new String();
        float nota1, nota2, nota3, media;

        Scanner tc = new Scanner(System.in);
        System.out.println("Digite seu nome(sem caracter especial): ");
        nome = tc.next();
        System.out.println("Digite a nota da primeira prova: ");
        nota1 = tc.nextFloat();
        System.out.println("Digite a nota da segunda prova: ");
        nota2 = tc.nextFloat();
        System.out.println("Digite a nota da terceira prova: ");
        nota3 = tc.nextFloat();

        media = (nota1+nota2+nota3)/3;

        System.out.println("O aluno "+nome+" ficou com a media "+media+" no final do semestre");
    }
}
