function binaryToDecimal(num){
    console.log('O num = '+num);
    var arr = num.split('');
    console.log('O array = '+arr);
    var resultadoAlgVezesBaseElePos = 0;
    var resultFinal = 0;
    var inver=[];
    var x=0;

    for(let i=arr.length-1;i>=0;i--){        
        inver[x]=(arr.length-1)-i;
        x++;
    }
    for(let i=0;i<arr.length;i++){
        x=(arr.length-1)-i;
        console.log('Numero dentro do segundo for: '+arr[i]);
        resultadoAlgVezesBaseElePos = (arr[i]*(2**inver[x]));
        resultFinal = resultFinal+resultadoAlgVezesBaseElePos;
        x--;
    }
    console.log('o inverso '+inver);
    return resultFinal;
}
  