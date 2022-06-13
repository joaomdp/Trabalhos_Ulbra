function verificarIdades() {
    var idades = document.getElementById('idade').value
    idades = idades.split(',')
    var maiorIdade = 0
    var menorIdade = 0

    for(var i=0;i<idades.length;i++){
        var idadeAtual = parseFloat (idades[i])

        if(idadeAtual < 18){
            menorIdade++
        }else{
            maiorIdade++
        }
    }
    document.getElementById('mostrarIdades').innerHTML = menorIdade + ' pessoas menores de idade ' + maiorIdade + ' pessoas maiores de idade';
}