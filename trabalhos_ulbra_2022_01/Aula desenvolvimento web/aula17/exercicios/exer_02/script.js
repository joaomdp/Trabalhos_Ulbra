function calcularConta() {
    var quantidade = parseFloat(document.getElementById('quantidade').value)
    var valor = parseFloat(document.getElementById('valor').value)
    var conta

    if(quantidade<=100){
        conta = quantidade * valor 
    }else if (quantidade>100 && quantidade <=200){
        conta = (quantidade * valor) * 1.25
    }else{
        conta = (quantidade * valor) * 1.5
    }

    document.getElementById('resultado').innerHTML = "O valor da conta é: "+conta
}
