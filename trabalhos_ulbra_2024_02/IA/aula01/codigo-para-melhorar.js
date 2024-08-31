class RedeNeural {
    constructor(tamanhoEntrada, tamanhoOculto, tamanhoSaida) {
        this.tamanhoEntrada = tamanhoEntrada;
        this.tamanhoOculto = tamanhoOculto;
        this.tamanhoSaida = tamanhoSaida;

        // Inicializando pesos aleatórios para as camadas oculta e de saída
        this.pesosEntradaOculto = this.inicializarPesos(tamanhoEntrada, tamanhoOculto);
        this.pesosOcultoSaida = this.inicializarPesos(tamanhoOculto, tamanhoSaida);
    }

    inicializarPesos(linhas, colunas) {
        return Array.from({ length: linhas }, () =>
            Array.from({ length: colunas }, () => Math.random() * 2 - 1)
        );
    }

    sigmoide(x) {
        return 1 / (1 + Math.exp(-x));
    }

    derivadaSigmoide(x) {
        return x * (1 - x);
    }

    feedforward(entrada) {
        this.entrada = entrada;

        // Camada oculta
        this.saidaOculta = this.multiplicarMatriz(entrada, this.pesosEntradaOculto).map(this.sigmoide);

        // Camada de saída
        this.saidaFinal = this.multiplicarMatriz(this.saidaOculta, this.pesosOcultoSaida).map(this.sigmoide);

        return this.saidaFinal;
    }

    treinar(entrada, saidaEsperada, taxaAprendizagem) {
        this.feedforward(entrada);

        const erroSaida = saidaEsperada.map((esperado, i) => esperado - this.saidaFinal[i]);
        const ajustesSaida = erroSaida.map((erro, i) => erro * this.derivadaSigmoide(this.saidaFinal[i]));

        // Ajuste dos pesos da camada oculta para a camada de saída
        this.pesosOcultoSaida = this.pesosOcultoSaida.map((linha, i) =>
            linha.map((peso, j) => peso + taxaAprendizagem * ajustesSaida[j] * this.saidaOculta[i])
        );

        const erroOculto = this.pesosOcultoSaida.map((linha, i) =>
            linha.reduce((soma, peso, j) => soma + peso * ajustesSaida[j], 0)
        );
        const ajustesOculto = erroOculto.map((erro, i) => erro * this.derivadaSigmoide(this.saidaOculta[i]));

        // Ajuste dos pesos da camada de entrada para a camada oculta
        this.pesosEntradaOculto = this.pesosEntradaOculto.map((linha, i) =>
            linha.map((peso, j) => peso + taxaAprendizagem * ajustesOculto[j] * entrada[i])
        );
    }

    multiplicarMatriz(vetor, matriz) {
        return matriz[0].map((_, j) =>
            vetor.reduce((soma, valor, i) => soma + valor * matriz[i][j], 0)
        );
    }
}

// Exemplo de uso
let rede = new RedeNeural(3, 4, 1);

// Dados de treinamento
let treinamento = [
    { entrada: [0, 0, 0], saida: [0] },
    { entrada: [0, 0, 1], saida: [0] },
    { entrada: [0, 1, 0], saida: [0] },
    { entrada: [0, 1, 1], saida: [0] },
    { entrada: [1, 0, 0], saida: [1] },
    { entrada: [1, 0, 1], saida: [1] },
    { entrada: [1, 1, 0], saida: [1] },
    { entrada: [1, 1, 1], saida: [1] }
];

// Treinamento da rede
for (let i = 0; i < 10000; i++) {
    treinamento.forEach(dados => rede.treinar(dados.entrada, dados.saida, 0.1));
}

// Testando a rede
console.log(rede.feedforward([0, 0, 0]));  // Espera-se saída próxima de 0
console.log(rede.feedforward([1, 1, 1]));  // Espera-se saída próxima de 1
