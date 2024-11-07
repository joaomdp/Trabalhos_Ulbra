const objetivo = "HELLO WORLD";
const caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";

const tamanhoPopulacao = 200;
const mutationRate = 0.01;
const geracoes = 500;

//Função para criar um novo elemento
function criarIndividuo()
{
    let individuo = "";
    for (let i = 0; i < objetivo.length; i++) {
        individuo += caracteres.charAt(Math.floor(Math.random() * caracteres.length));
    }

    return individuo;
}

//Função para criar um conjunto de elementos
function criarPopulacao(tamanho)
{
    const populacao = [];
    for (let i = 0; i < tamanho; i++) {
        populacao.push(criarIndividuo());
    }

    return populacao;
}

//Função fitness
function aptidao(individuo)
{
    let pontos = 0;

    for (let i = 0; i < objetivo.length; i++) {
        if(individuo[i] === objetivo[i]) {
            pontos++;
        }
    }
    return pontos;
}

function selecao(populacao)
{
    const selecionados = [];

    populacao.forEach(individuo => {
        const pontos = aptidao(individuo);
        for (let i = 0; i < pontos; i++) {
            selecionados.push(individuo);
        }
    });

    return [escolhaAleatoria(selecionados), escolhaAleatoria(selecionados)];
}

function cruzamento(individuo1, individuo2)
{
    const pontoDeCorte = Math.floor(Math.random() * objetivo.length);
    const filho = individuo1.slice(0, pontoDeCorte) + individuo2.slice(pontoDeCorte);
    return filho;
}

function mutacao(individuo)
{
    let individuoMutante = "";
    for (let i = 0; i < individuo.length; i++) {
        if(Math.random < mutationRate) {
            individuoMutante += caracteres.charAt(Math.floor(Math.random() * caracteres.length));
        } else {
            individuoMutante += individuo[i];
        }
    }

    return individuoMutante;
}

function escolhaAleatoria(array)
{
    return array[Math.floor(Math.random() * array.length)];
}

function algoritmoGenetico()
{
    let populacao = criarPopulacao(tamanhoPopulacao);

    for (let geracao = 0; geracao < geracoes; geracao++) {
        populacao.sort((a, b) => aptidao(b) - aptidao(a));

        console.log(`Geracao atual: ${geracao}, Melhor individuo: ${populacao[0]}`);

        if(aptidao(populacao[0]) === objetivo.length) {
            console.log("Solução encontrada!");
            break;
        }

        //criar uma nova população
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


