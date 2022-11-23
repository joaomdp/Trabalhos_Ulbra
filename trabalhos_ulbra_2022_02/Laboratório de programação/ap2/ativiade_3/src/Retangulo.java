public class Retangulo extends AreaCalculavel{
    double base;
    double altura;

    public Retangulo(double base, double altura){
        super();
        this.setBase(base);
        this.setAltura(altura);
    }

    public double getBase(){
        return base;
    }

    public void setBase(double base){
        this.base = base;
    }

    public double getAltura(){
        return altura;
    }

    public void setAltura(double altura){
        this.altura = altura;
    }

    public double calcularArea(){
        return ((this.getBase() * this.getAltura()));
    }
}
