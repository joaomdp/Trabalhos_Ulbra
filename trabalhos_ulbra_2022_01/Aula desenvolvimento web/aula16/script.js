//ESCOLHA A OPÇÃO
var opcao = prompt("Digite qual a opção desejada: \n 1-Descubra se o número inteiro é maior ou menor que 10.\n 2-Faça a soma de dois números. \n 3-Use a calculadora basica. \n 4-Faça um loop do seu nome. \n 5-Digite seus dados e mostre na tela. \n");

switch (opcao) {
    case '1':
        //PARTE 01
        var numero = prompt('Digite um numero inteiro e descubra se é maior ou menor que 10');
        if (numero > 10) {
            alert('O numero digitado é maior que 10');
        } else if (numero < 10) {
            alert('O numero digitado é menor que 10');
        } else {
            alert('O numero é igual a dez');
        }
    break;
    case '2':
        //PARTE 02
        var numero1 = parseFloat(prompt('Digite o primerio numero'));

        var numero2 = parseFloat(prompt('Digite o segundo numero'));

        var soma = numero1 + numero2;

        alert('A soma dos valores é ' + soma);
    break;
    case '3':
        //PARTE 03
        var resultado;
        var operacao = prompt('Digite o codigo da operação desejada \n Soma=1 \n Subtração=2 \n Multiplicação=3 \n Divisão=4\n');

        var num1 = parseFloat(prompt('Digite o primerio numero'));

        var num2 = parseFloat(prompt('Digite o segundo numero'));

        switch (operacao) {
            case '1':
                resultado = num1 + num2;
                alert(`${num1} + ${num2} = ${resultado}`);
                break;
            case '2':
                resultado = num1 - num2;
                alert(`${num1} - ${num2} = ${resultado}`);
                break;
            case '3':
                resultado = num1 * num2;
                alert(`${num1} * ${num2} = ${resultado}`);
                break;
            case '4':
                resultado = num1 / num2;
                alert(`${num1} / ${num2} = ${resultado}`);
                break;
            default:
                alert('Operação inválida');
                break;
        }
    break;
    case '4':
        //PARTE 04
        var nome = prompt('Digite um nome')
        var numero = prompt('Digite quantas vezes esse nome será digitado');

        for (var i = 0; i < numero; i++) {
            alert('' + nome)
        }
    break;
    case '5':
        //PARTE 05
        var variavel = [];

        variavel[0] = prompt('Digite seu nome');
        variavel[1] = prompt('Digite seu endereço');
        variavel[2] = prompt('Digite seu email');

        alert(`Bem-vindo ${variavel[0]}, o seu endereço é ${variavel[1]} e seu email é ${variavel[2]}, muito obrigado pelas informações`);
    break;
}


















