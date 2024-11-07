const tamanhoPopulacao = 500;
const mutationRate = 0.01; 
const geracoes = 1000;

let cidades = [
    [-5, -5], 
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

// Cálculo da distância entre pontos
function calculoDistanciaEntrPontos(cidadeA, cidadeB) {
    return Math.sqrt(Math.pow((cidadeB[0] - cidadeA[0]), 2) + Math.pow((cidadeB[1] - cidadeA[1]), 2));
}

// Criação de um novo indivíduo
function criarIndividuo() {
    let individuo = [];
    let listaCidades = JSON.parse(JSON.stringify(cidades));
    while (listaCidades.length > 0) {
        let cidadeEscolhida = Math.floor(Math.random() * listaCidades.length);
        individuo.push(listaCidades[cidadeEscolhida]);
        listaCidades.splice(cidadeEscolhida, 1);
    }
    return individuo;
}

// Criação de uma população inicial
function criarPopulacao(tamanho) {
    const populacao = [];
    for (let i = 0; i < tamanho; i++) {
        populacao.push(criarIndividuo());
    }
    return populacao;
}

// Função fitness (aptidão)
function aptidao(individuo) {
    let distancia = 0.0;
    for (let i = 0; i < individuo.length; i++) {
        let proximoIndice = (i + 1) % individuo.length;
        distancia += calculoDistanciaEntrPontos(individuo[i], individuo[proximoIndice]);
    }
    return 100 / distancia; 
}

// Seleção por torneio
function selecionarIndividuo(populacao) {
    const torneio = [];
    for (let i = 0; i < 5; i++) {
        const aleatorio = Math.floor(Math.random() * populacao.length);
        torneio.push(populacao[aleatorio]);
    }
    return torneio.reduce((melhor, individuo) => (aptidao(individuo) > aptidao(melhor) ? individuo : melhor));
}

// Cruzamento entre dois indivíduos sem duplicação de cidades
function cruzamento(pai, mae) {
    const inicio = Math.floor(Math.random() * pai.length);
    const fim = Math.floor(Math.random() * pai.length);
    let filho = pai.slice(Math.min(inicio, fim), Math.max(inicio, fim));

    mae.forEach(cidade => {
        if (!filho.some(c => c[0] === cidade[0] && c[1] === cidade[1])) {
            filho.push(cidade);
        }
    });
    return filho;
}

// Função de mutação
function mutacao(individuo) {
    for (let i = 0; i < individuo.length; i++) {
        if (Math.random() < mutationRate) {
            let j = Math.floor(Math.random() * individuo.length);
            [individuo[i], individuo[j]] = [individuo[j], individuo[i]]; 
        }
    }
}

// Evolução das gerações
function evoluir(populacao) {
    const novaPopulacao = [];
    for (let i = 0; i < populacao.length; i++) {
        const pai = selecionarIndividuo(populacao);
        const mae = selecionarIndividuo(populacao);
        let filho = cruzamento(pai, mae);
        mutacao(filho);
        novaPopulacao.push(filho);
    }
    return novaPopulacao;
}

// Função principal do algoritmo genético
function algoritmoGenetico() {
    let populacao = criarPopulacao(tamanhoPopulacao);
    for (let geracao = 0; geracao < geracoes; geracao++) {
        populacao = evoluir(populacao);
        let melhorIndividuo = populacao.reduce((melhor, individuo) => 
            (aptidao(individuo) > aptidao(melhor) ? individuo : melhor));
        
        console.log(`Geração ${geracao + 1} | Melhor Aptidão: ${aptidao(melhorIndividuo).toFixed(2)} | Melhor Rota: ${JSON.stringify(melhorIndividuo)}`);
    }
}

// Executa o algoritmo genético
algoritmoGenetico();
