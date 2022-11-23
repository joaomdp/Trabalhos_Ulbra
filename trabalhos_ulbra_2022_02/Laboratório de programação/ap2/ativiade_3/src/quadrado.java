public class Quadrado extends AreaCalculavel {
    double lado;

    public Quadrado(double lado){
        super();
        this.setLado(lado);
    }

    public double getLado(){
        return lado;
    }

    public void setLado(double lado){
        this.lado = lado;
    }
    public double calcularArea(){
        return Math.pow(this.getLado(),2);
    }
    
}
