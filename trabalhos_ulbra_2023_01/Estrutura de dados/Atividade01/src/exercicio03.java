import java.util.Scanner;

public class exercicio03 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in); // Iniciar o armazenamento de dados

        int num, soma = 0; // Definição de variaveis
        int cont = 0;
        double media;

        do {
            System.out.println("Digite um numero inteiro: ");
            num = sc.nextInt(); // Insira um valor e armazeno

            if (soma >= 0) {
                soma = num + soma;
                cont++;
            }// faço a soma dos algarismos

            media = soma / cont;// faço o calculo de media

        } while (num != 99); // defino o fim do programa

        System.out.println("A soma dos valores digitados é "+soma);
        System.out.println("A média dos valores digitados é  " + media);
    }
}
