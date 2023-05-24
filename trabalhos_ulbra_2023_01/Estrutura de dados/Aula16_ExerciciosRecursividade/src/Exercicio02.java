public class Exercicio02 {
    public static int calcularFatorial(int numero){
        if (numero == 0 || numero ==1){
            return 1;
        }
        return numero * calcularFatorial(numero - 1);
    }
}
