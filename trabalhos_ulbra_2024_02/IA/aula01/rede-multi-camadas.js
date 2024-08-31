  class Entrada {
    valorEntrada = 0
    peso = 0
}

const entrada_pesos = [
    {entrada: -1, peso: 0},
    {entrada: 1, peso: -1},
    {entrada: 1, peso: 2}
]

let funcaoEscolhida = 'FS'

let y 

switch (funcaoEscolhida) {
    case 'LR':
        y = limiteRapido(soma(entrada_pesos))
        console.log("Saida: " + y + ", funcao escolhida: " + funcaoEscolhida)
        break;
    case 'FR':
        y = funcaoRampa(soma(entrada_pesos))
        console.log("Saida: " + y + ", funcao escolhida: " + funcaoEscolhida)
        break;
    case 'FS':
        y = funcaoSigmoide(soma(entrada_pesos))
        console.log("Saida: " + y + ", funcao escolhida: " + funcaoEscolhida)
        break;
    default:
        console.log('Função inválida')
        break;
}

function soma(entrada_pesos) {
    var soma = 0
    for (let i = 0; i < entrada_pesos.length; i++) {
        soma = soma + (entrada_pesos[i].entrada * entrada_pesos[i].peso)
    }
    console.log("Soma: " + soma)
    return soma
}

function limiteRapido(soma) {
   return soma <= 0 ? -1 : 1
}

function funcaoRampa(soma) {
    if (soma < 0) {
        return 0
    }
    if (soma >= 0 && soma <= 1) {
        return soma
    }
    if (soma > 1) {
        return 1
    }
}

function funcaoSigmoide(soma) {
    if (soma >= 0) {
        return 1 - 1 / (1 + soma);
    } else {
        return -1 + 1 / (1 - soma);
    }
}