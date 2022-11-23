public class Automovel extends veiculo {
    public Automovel(boolean ligado){
        super(ligado);
    }

    public  String ligar(){
        super.ligar();
        return "Automovel ligado";
    }
    public String desligar(){
        super.desligar();
        return  "Automovel desligado";
    }

}
