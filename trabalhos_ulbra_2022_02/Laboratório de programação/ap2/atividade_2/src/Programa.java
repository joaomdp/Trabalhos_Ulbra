public class Programa {
    public static void main(String[] args) {
        veiculo v = new veiculo(false);
        Automovel a = new Automovel(false);
        Motocicleta m = new Motocicleta(false);
        Onibus o = new Onibus(false);
        
        System.out.println("Inicio... ");
        System.out.println(v.ligado());
        System.out.println(a.ligado());
        System.out.println(m.ligado());
        System.out.println(o.ligado());

        System.out.println("Ligando... ");
        System.out.println(v.ligar());
        System.out.println(a.ligar());
        System.out.println(m.ligar());
        System.out.println(o.ligar());

        System.out.println("Desligando... ");
        System.out.println(v.desligar());
        System.out.println(a.desligar());
        System.out.println(m.desligar());
        System.out.println(o.desligar());
    }

   
}
