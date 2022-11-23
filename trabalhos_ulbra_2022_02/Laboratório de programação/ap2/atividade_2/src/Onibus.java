public class Onibus extends veiculo {
    public Onibus(boolean ligado) {
        super(ligado);
    }
    public  String ligar(){
        super.ligar();
        return "Onibus ligado";
    }
    public String desligar(){
        super.desligar();
        return  "Onibus desligado";
    }


}
