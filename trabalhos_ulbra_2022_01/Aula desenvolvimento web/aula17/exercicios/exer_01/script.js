function calcular() {
    var n1 = parseFloat (document.getElementById('n1').value);
    var n2 = parseFloat (document.getElementById('n2').value);
    var operacao = document.getElementById('operacao').value;
    var resultado;

    switch (operacao) {
        case '+':
           resultado = n1 + n2 ;
        break;
        case '-':
            resultado = n1 - n2 
        break;
        case '*':
            resultado = n1 * n2 
        break;
        case '/':
            resultado = n1 / n2 
        break;
    }
    document.getElementById('resultado').innerHTML = 'O resultado é '+resultado;
}