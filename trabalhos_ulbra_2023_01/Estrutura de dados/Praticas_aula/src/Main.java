public class Main {
    public static void main(String[] args) {
        listaDupla l = new listaDupla();
        System.out.println(l);

        for (int i=0; i<6; i++){
            l.inserirInicio(""+ (char) (i+97));
            System.out.println(l);
        }
    }
}