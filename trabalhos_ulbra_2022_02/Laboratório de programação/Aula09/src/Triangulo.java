public class Triangulo {

    double base;
    double altura;

    public double calcularArea(){
            return (base*altura)/2;
    }

    public void definirValores(double base, double altura){
        this.base = base;
        this.altura = altura;
    }
    public String obterArea(){
        return base + " / " + altura;
    }
}
