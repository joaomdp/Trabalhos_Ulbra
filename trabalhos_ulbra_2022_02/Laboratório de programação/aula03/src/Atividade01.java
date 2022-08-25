public class Atividade01 {
    public static void main(String[] args) {
        int dado1 = (int) (Math.random() * 6);
        int dado2 = (int) (Math.random() * 6);
        int dado3 = (int) (Math.random() * 6);
        int soma = 0;

        System.out.println("Valor do dado numero 1 = " +dado1);
        System.out.println("Valor do dado numero 2 = " +dado2);
        System.out.println("Valor do dado numero 3 = " +dado3);

        soma = dado1 + dado2 + dado3;

        System.out.println("A soma dos numeros sorteados e de: "+soma);
    }
}
