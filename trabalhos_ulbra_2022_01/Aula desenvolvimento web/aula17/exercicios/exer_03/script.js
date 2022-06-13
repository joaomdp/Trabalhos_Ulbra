function verificar() {
   var numeros = document.getElementById('numeros').value
   numeros = numeros.split(',')
   var maior = 0

   for(var i=0;i<numeros.length;i++){
        var valorAtual = parseFloat(numeros[i])
        if(valorAtual > maior){
            maior = valorAtual
        }
   }
   document.getElementById('maiorNumero').innerHTML = "O maior número é: "+maior
}