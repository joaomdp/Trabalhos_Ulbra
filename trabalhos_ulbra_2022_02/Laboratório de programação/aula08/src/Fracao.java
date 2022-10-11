public class Fracao {

    double numerador;
    double denominador;

    public double calcularValor(){
        if(denominador==0){
            return 0;
        }else {
            return numerador/denominador;
        }
    }
    public Fracao multiplicar(Fracao f){
        Fracao result = new Fracao();
        result.numerador = this.numerador * f.numerador;
        result.denominador = this.denominador * f.denominador;

        return result;
    }
    public void definirValores(double numerador, double denominador){
        this.numerador = numerador;
        this.denominador = denominador;
    }
    public String obterFracao(){
        return numerador + " / " + denominador;
    }
}
