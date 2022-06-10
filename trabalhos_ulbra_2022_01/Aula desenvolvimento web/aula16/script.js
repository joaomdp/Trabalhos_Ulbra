//PARTE 01
var numero=prompt('Digite um numero inteiro');
if(numero>10){
    alert('O numero digitado é maior que 10');
}else if(numero<10){
    alert('O numero digitado é menor que zero');
}else{
    alert('O numero é igual a dez');
}
//PARTE 02
var numero1 = parseFloat(prompt('Digite o primerio numero')); 

var numero2 = parseFloat(prompt('Digite o segundo numero'));

var soma = numero1 + numero2;

alert('A soma dos valores é '+soma);
//PARTE 03
var resultado;
var operacao = prompt('Digite o codigo da operação desejada \n Soma=1 \n Subtração=2 \n Divisão=3 \n Multiplicação=4\n');

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
        break
}
var nome = prompt('Digite um nome')
var numero=prompt('Digite quantas vezes esse nome será digitado');

for(var i=0;i<numero;i++){
    alert(''+nome)
}

let info = ['João', 'Arroio do Sal', 'joaomanoeldpereira@gmail.com'];
alert(`${info[0]}, ${info[1]}, ${info[2]}`);












