public class Motocicleta extends veiculo{
    public Motocicleta(boolean ligado) {
        super(ligado);
    }
    public  String ligar(){
        super.ligar();
        return "Motocicleta ligada";
    }

    public String desligar(){
        super.desligar();
        return  "Motocicleta desligada";
    }


}
