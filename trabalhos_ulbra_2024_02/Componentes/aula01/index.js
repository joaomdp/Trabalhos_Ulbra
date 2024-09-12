function soma(a, b) {
    let resultado = a + b;
    console.log("A soma é: " + resultado);
}

soma(5, 7); // Exemplo de uso

function listaNumeros() {
    for (let i = 0; i < 10; i++) {
        if (i % 2 == 0) {
            console.log("Numeros pares", i);
        }
        if (i % 2 == 1) {
            console.log("Numeros impares", i)
        }
    }
}

console.log(listaNumeros())
