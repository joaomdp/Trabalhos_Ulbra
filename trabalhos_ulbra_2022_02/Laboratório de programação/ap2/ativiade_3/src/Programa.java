public class Programa {
    
    public static void main(String[] args) {
        Quadrado q = new Quadrado(5);
        Circunferencia c = new Circunferencia(7);
        Retangulo r = new Retangulo(2, 8);

        System.out.println("Quadrado: " + q.calcularArea());
        System.out.println("Retangulo: " + r.calcularArea());
        System.out.println("Circunferencia: " + c.calcularArea());

    }
}
