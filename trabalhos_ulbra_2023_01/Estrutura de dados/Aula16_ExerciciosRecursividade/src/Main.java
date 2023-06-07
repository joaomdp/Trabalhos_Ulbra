
public class Main {
    public static void main(String[] args) {
        //Exercicio01
//        int [] vetor = {1,2,3,4,5};
//        int resultado = Exercicio01.somaVetor(vetor, 0);
//        System.out.println("A soma dos elementos do vetor é: " + resultado);

        //Exercicio02
//        int numero = 5;
//        int resultado = Exercicio02.calcularFatorial(numero);
//        System.out.println("O fatorial de " + numero + " é: " + resultado);

        //Exercicio03
        String palavra1 = "Radar";
        String palavra2 = "Reconhecer";

        boolean resultado1 = Exercicio03.verificarPalidromo(palavra1);
        boolean resultado2 = Exercicio03.verificarPalidromo(palavra2);

        System.out.println("A palavra \"" + palavra1 + "\" é um palidromo? " +resultado1);
        System.out.println("A palavra \"" + palavra2 + "\" é um palidromo? " +resultado2);

    }
}


