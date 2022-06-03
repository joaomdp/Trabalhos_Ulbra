//EXERCICIO 1
var numero = 10;
console.log("" + numero);
console.log(typeof ('number'));


function calcular(oper,num1,num2){
    var total=0;
    switch (oper){
        case '+':
            total=num1+num2;
            break;
        case '-':
            total=num1-num2;
            break;
        case '*':
             total=num1*num2;
            break;    
        case '/':
            total=num1/num2;
            break;    
        default:
            total=undefined;
            break;
    }
    return total;
  
}

//EXERCICIO 5 
var mediaFinal = 0;

var avaliacaoParcial = 6;
console.log("Avaliação parcial " + avaliacaoParcial);

var avaliacaoParcial2 = 6;
console.log("Avaliação parcial " + avaliacaoParcial2);

var ativSemestral = 6;
console.log("Avaliação semestral " + ativSemestral);

mediaFinal = (avaliacaoParcial + avaliacaoParcial2 + ativSemestral)/3;

console.log("Media final " + mediaFinal);

//EXERCICIO 6 
var media = 0;

var ap1 = 1.5;
console.log("Valor de ap1 " + ap1);

var ap2 = 2.5;
console.log("Valor de ap2 " + ap2);

var as = 6;
console.log("Valor de avaliação semestral " + as);

media = ap1 + ap2 + as;

console.log("Media final " + media);
//EXERCICIO 8

var num1=1,num2=2,num3=3;

console.log("O valor numero " +num1);
console.log("O valor numero " +num2);
console.log("O valor numero " +num3);

if(num1>num2 && num1>num3){
    console.log("O maior valor é: " + num1);
}else if (num2>num1 && num2>num3){
    console.log("O maior valor é: " + num2);
}else if (num3>num1 && num3>num2){
    console.log("O maior valor é: " + num3);
}else{
    console.log("Os valores são iguais");
}