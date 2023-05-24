public class Exercicio03 {
    public static boolean verificarPalidromo(String palavra){
        if (palavra.length() <= 1){
            return true;
        }
        if (palavra.charAt(0) == palavra.charAt(palavra.length())-1){
            return verificarPalidromo(palavra.substring(1, palavra.length()-1));
        }

        return false;
    }
}
