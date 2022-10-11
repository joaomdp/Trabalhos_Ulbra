public class Quadrado {

    double lado;

    public double calcularArea(){
        if(lado==0){
            return 0;
        }else {
            return Math.pow(lado,2);
        }
    }
    public void definirValores(double lado){
        this.lado = lado;
    }
    public String obterArea(){
        return lado + " ";
    }
}
