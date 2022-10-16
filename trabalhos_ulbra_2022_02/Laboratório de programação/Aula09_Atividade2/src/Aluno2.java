public class Aluno2 {
    double prova1;
    double prova2;

    double media;

    public void definirValores(double prova1, double prova2){
        prova1 = 7.5;
        prova2 = 9.4;
    }

    public void calcularMedia() {
        this.media = prova1 + prova2;
    }
}
