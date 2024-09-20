const perguntas = [
    {
        pergunta: "É Homem?",
        subElemento: {
            sim: {
                pergunta: "Ele joga futebol?",
                subElemento: {
                    sim: "Neymar",
                    nao: "Ayrton Senna"
                }
            },
            nao: {
                pergunta: "Ela é uma mulher?",
                subElemento: {
                    sim: {
                        pergunta: "Ela é modelo?",
                        subElemento: {
                            sim: "Gisele Bündchen",
                            nao: "Margot Robbie"
                        }
                    },
                    nao: {
                        pergunta: "É um personagem animado?",
                        subElemento: {
                            sim: {
                                pergunta: "Ele é do Dragon Ball?",
                                subElemento: {
                                    sim: "Goku",
                                    nao: "Naruto"
                                }
                            },
                            nao: {
                                pergunta: "É um animal?",
                                subElemento: {
                                    sim: {
                                        pergunta: "Ele é o melhor amigo do homem?",
                                        subElemento: {
                                            sim: "Cachorro",
                                            nao: "Vaca"
                                        }
                                    },
                                    nao: "Desculpe, não consigo adivinhar!"
                                }
                            }
                        }
                    }
                }
            }
        }
    }
];

arrayDeRespostasPossiveis = ["Neymar", "Ayrton Senna", "Gisele Bündchen", "Margot Robbie", "Goku", "Naruto", "Cachorro", "Vaca"];

// Informa ao usuário para ele pensar em uma das opções válidas
console.log("Pense em uma das opções abaixo para eu tentar adivinhar");
arrayDeRespostasPossiveis.forEach(resposta => {
    console.log(resposta);
});

const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

async function fazPergunta(pergunta) {
    return new Promise(resolve => {
        rl.question(pergunta + " (1 para SIM, 2 para NÃO)\n", (resposta) => {
            resolve(resposta);
        });
    });
}

async function processarPerguntas(elemento) {
    // Se o elemento for uma string, significa que chegamos a uma resposta final
    if (typeof elemento === 'string') {
        console.log("Minha resposta é: " + elemento);
        rl.close(); // Encerra o readline após a última pergunta
        return;
    }

    let resposta = await fazPergunta(elemento.pergunta);

    if (resposta == 1 && elemento.subElemento?.sim) {
        await processarPerguntas(elemento.subElemento.sim); // Chama recursivamente o próximo elemento
    } else if (resposta == 2 && elemento.subElemento?.nao) {
        await processarPerguntas(elemento.subElemento.nao); // Chama recursivamente o próximo elemento
    } else {
        console.log("Resposta inválida ou não esperada.");
        rl.close(); // Fecha em caso de erro
    }
}

async function iniciarPerguntas(perguntas) {
    for (const pergunta of perguntas) {
        await processarPerguntas(pergunta);
        break; // Finaliza após encontrar a resposta
    }
}

iniciarPerguntas(perguntas);
