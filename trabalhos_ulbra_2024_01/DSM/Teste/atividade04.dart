void main() {
    List<double> listaNumeros = [1,2,3,4,5,6];
    double media = calcularMedia(listaNumeros);
    print(media);
}

double calcularMedia(List<double> numeros) {
    double soma = 0.0;

    for (var numero in numeros) {
        soma += numero;
    }

    return soma / numeros.length;
}