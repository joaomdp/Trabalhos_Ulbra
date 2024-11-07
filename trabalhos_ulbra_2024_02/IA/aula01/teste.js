const tamanhoPopulacao = 500;
const mutationRate = 0.01;
const geracoes = 1000;

let cidades = [
    [-5, -5], // Curitiba
    [-2, -3],
    [3, -3],
    [-3, -2],
    [1, 0],
    [4, 2],
    [5, 5],
    [2, 4],
    [-1, 4],
    [-5, 5]
];

// Função para criar um novo indivíduo (rota aleatória)
function criarIndividuo() {
    let individuo = [];
    let listaCidades = [...cidades];
    while (listaCidades.length > 0) {
        const indiceAleatorio = Math.floor(Math.random() * listaCidades.length);
        individuo.push(listaCidades.splice(indiceAleatorio, 1)[0]);
    }
    return individuo;
}

// Função para criar uma população inicial
function criarPopulacao(tamanho) {
    const populacao = [];
    for (let i = 0; i < tamanho; i++) {
        populacao.push(criarIndividuo());
    }
    return populacao;
}

// Função de aptidão para avaliar a rota
function aptidao(individuo) {
    let distanciaTotal = 0.0;
    for (let i = 0; i < individuo.length; i++) {
        const proximoIndice = (i + 1) % individuo.length;
        distanciaTotal += calculoDistanciaEntrPontos(individuo[i], individuo[proximoIndice]);
    }
    return 100 / distanciaTotal;
}

// Cálculo da distância entre duas cidades
function calculoDistanciaEntrPontos(cidadeA, cidadeB) {
    return Math.sqrt(Math.pow(cidadeB[0] - cidadeA[0], 2) + Math.pow(cidadeB[1] - cidadeA[1], 2));
}

// Função de seleção (escolha de indivíduos com base na aptidão)
function selecao(populacao) {
    const selecionados = [];
    populacao.forEach(individuo => {
        const pontos = Math.floor(aptidao(individuo) * 100);
        for (let i = 0; i < pontos; i++) {
            selecionados.push(individuo);
        }
    });
    return [escolhaAleatoria(selecionados), escolhaAleatoria(selecionados)];
}

// Função de cruzamento para combinar dois indivíduos
function cruzamento(individuo1, individuo2) {
    const pontoDeCorte = Math.floor(Math.random() * individuo1.length);
    const filho = individuo1.slice(0, pontoDeCorte).concat(
        individuo2.filter(cidade => !individuo1.slice(0, pontoDeCorte).includes(cidade))
    );
    return filho;
}

// Função de mutação para gerar variabilidade na população
function mutacao(individuo) {
    for (let i = 0; i < individuo.length; i++) {
        if (Math.random() < mutationRate) {
            const j = Math.floor(Math.random() * individuo.length);
            [individuo[i], individuo[j]] = [individuo[j], individuo[i]]; // Troca as posições
        }
    }
}

// Função para escolher um elemento aleatório de um array
function escolhaAleatoria(array) {
    return array[Math.floor(Math.random() * array.length)];
}

// Algoritmo genético principal
function algoritmoGenetico() {
    let populacao = criarPopulacao(tamanhoPopulacao);

    for (let geracao = 0; geracao < geracoes; geracao++) {
        populacao.sort((a, b) => aptidao(b) - aptidao(a));
        console.log(`Geração atual: ${geracao}, Melhor aptidão: ${aptidao(populacao[0]).toFixed(2)}`);

        if (aptidao(populacao[0]) === objetivo.length) {
            console.log("Solução encontrada!");
            break;
        }

        const novaPopulacao = [];
        while (novaPopulacao.length < tamanhoPopulacao) {
            const [individuo1, individuo2] = selecao(populacao);
            let filho = cruzamento(individuo1, individuo2);
            filho = mutacao(filho);
            novaPopulacao.push(filho);
        }
        populacao = novaPopulacao;
    }
}

algoritmoGenetico();
