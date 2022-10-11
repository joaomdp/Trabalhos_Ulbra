public class Circunferencia {

    double raio;

    public double calcularArea(){
            return Math.PI * Math.pow(raio,2);
    }
    public void definirValores(double raio){
        this.raio = raio;
    }
}
