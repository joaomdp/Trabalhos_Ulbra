public class Aluno3 {
    double prova1;
    double prova2;

    double media;

    public void definirValores(double prova1, double prova2){
        prova1 = 5.5;
        prova2 = 3.4;
    }

    public void calcularMedia() {
        this.media = prova1 + prova2;
    }
}
