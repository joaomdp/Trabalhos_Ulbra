public class programa {
    public static void main(String[] args) {
        //Quadrado
        Quadrado q1 = new Quadrado();
        q1.definirValores(5);

        System.out.println("A area do quadrado e de: "+q1.calcularArea());

        //Triangulo
        Triangulo t1 = new Triangulo();
        t1.definirValores(5,2);

        System.out.println("A area do triangulo e de: "+t1.calcularArea());

        //Circunferencia
        Circunferencia c1 = new Circunferencia();
        c1.definirValores(14);

        System.out.println("A area da circunferencia e de: "+c1.calcularArea());

        //Trapézio
        Trapezio tr1 = new Trapezio();
        tr1.definirValores(3,8,9);

        System.out.println("A area do trapezio e de: "+tr1.calcularArea());
    }
}
