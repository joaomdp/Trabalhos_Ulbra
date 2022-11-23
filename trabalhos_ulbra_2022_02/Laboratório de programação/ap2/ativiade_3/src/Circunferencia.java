public class Circunferencia extends AreaCalculavel{
    double raio;
    double pi = 3.14;

    public Circunferencia(double raio){
        super();
        this.setRaio(raio);
    }

    public double getRaio(){
        return raio;
    }

    public void setRaio(double raio){
        this.raio = raio;
    }

    public double calcularArea(){
       return pi * Math.pow(this.getRaio(),2);
    }
}
