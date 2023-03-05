import java.util.Scanner;

public class exercicio01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int idade, soma = 0;
        int cont = 0;
        double media = 0;

        do {
            System.out.println("Digite sua idade: ");
            idade = sc.nextInt(); // usuario digita a idade

            if (soma >= 0) { // se o número digitado for MAIOR que zero, executa a conta
                soma = idade + soma; // soma o valor digitado AGORA com o digitado ANTES
                cont++; // conta quantas vezes o usuário digitou um número
            }

            media = soma / cont;

        } while (media <= 20); // se a média for MENOR que VINTE, faça o LOOP novamente

        System.out.println("A média de idades é  " + media); // soma
        System.out.println("A quantidade de idades digitadas foi " + cont); // quantidade
    }

}
