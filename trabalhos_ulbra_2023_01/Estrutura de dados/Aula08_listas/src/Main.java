public class Main {
    public static void main(String[] args) {

        Elemento a = new Elemento();
        a.valor=12;

        Elemento b = new Elemento();
        b.valor=14;

        Elemento c = new Elemento();
        c.valor=16;

        Lista minhaLista = new Lista();
        minhaLista.addFim(a);
        minhaLista.add(b);
        minhaLista.add(c);
        System.out.println(minhaLista.getTamanho());
    }
}