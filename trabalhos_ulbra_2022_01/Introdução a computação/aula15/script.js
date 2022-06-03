//ARRAYS E FOR
var carros=['fiat','gm','ttt'];
console.log(carros);
console.log(carros[1]);

for(i=0;i<carros.length;i++){
    console.log('carro é '+carros[i]);
}

//TABUADA 5

function tabuadaDo(numero){
    for(i=0;i<=10;i++){
        console.log(`${numero} + ${i} = ${numero * i};`);
    }
}

var binarios = '100110011';
var arrBinario= binarios.split('');
console.log('arrBinario');

for(i=0;i<arrBinario.length;i++){
    console.log(i);
}
