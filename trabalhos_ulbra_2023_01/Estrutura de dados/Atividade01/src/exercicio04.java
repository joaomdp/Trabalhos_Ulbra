import java.util.Scanner;

public class exercicio04 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int num, soma = 0;
        int cont = 0;
        double media = 0;

        do {
            System.out.println("Digite um valor inteiro: ");
            num = sc.nextInt();

            if (num%3==0){
                soma = soma + num;
                cont++;
            }

        } while (num != 0);

        media = soma / cont;
        System.out.println("A média dos numeros é  " + media);
    }
}
