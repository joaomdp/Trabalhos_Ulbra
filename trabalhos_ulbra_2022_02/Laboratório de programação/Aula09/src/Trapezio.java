public class Trapezio {

    double baseMaior;
    double baseMenor;
    double altura;

    public double calcularArea(){
            return ((baseMaior+baseMenor) / 2) * altura;
    }

    public void definirValores(double baseMaior, double baseMenor, double altura){
        this.baseMaior = baseMaior;
        this.baseMenor = baseMenor;
        this.altura = altura;
    }
}
