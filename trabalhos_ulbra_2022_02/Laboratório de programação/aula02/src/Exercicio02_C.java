public class Exercicio02_C {
    public static void main(String[] args) {
        int soma=0,i=0;
        do{
            soma=soma+i;
            System.out.println("O valor da soma e: "+i);
            i++;
        }while (soma+1<100);
    }
}
