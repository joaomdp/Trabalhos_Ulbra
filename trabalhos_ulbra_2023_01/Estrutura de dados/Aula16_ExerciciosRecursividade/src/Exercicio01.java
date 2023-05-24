public class Exercicio01 {
    public static int somaVetor(int[] vetor, int indice){
        if (indice >= 0 && indice < vetor.length){
            if (indice == vetor.length -1){
                return vetor[indice];
            }
            return vetor[indice] + somaVetor(vetor, indice+1);
        }
        return 0;
    }
}
