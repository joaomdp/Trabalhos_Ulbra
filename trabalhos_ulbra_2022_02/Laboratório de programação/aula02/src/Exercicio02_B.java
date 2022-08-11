public class Exercicio02_B {
    public static void main(String[] args) {
        int soma=0, i=1;

        do {
            soma=soma+i;
            i+=2;
            System.out.println("a soma e: "+soma);
        }while (soma<101);
    }
}
