public class atividade05 {
    public static void main(String[] args) {
        int vetor[], valor = 101;
        String aux;
        vetor = new int[50];

        for (int i=0;i<50;i++){
            vetor[i]=valor;
            valor++;
        }

        for (int x=0;x<50;x++){
            aux = "";
            if (x<50){
                aux = "0";
                System.out.println("O valor "+ (aux+x) +" :"+(vetor[x]));
            }
        }
    }
}
