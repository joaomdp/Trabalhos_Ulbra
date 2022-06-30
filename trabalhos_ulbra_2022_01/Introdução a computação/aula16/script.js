//QUALQUER BASE PARA DECIMAL
function numeroToDecimal(num, base){
    var algarismo = 0;
    var arr = num.split('');
    var resultadoAlgVezesBaseElePos = 0;
    var resultadoFinal = 0;
    var posicao = arr.length-1;
    
    for(i=0;i<arr.length;i++){
        if (base==16){
            algarismo = hexaToDecimal(arr[i]);
        }else{
            algarismo = arr[i];
        }
        resultadoAlgVezesBaseElePos = (algarismo * (base**posicao));
        resultadoFinal = resultadoFinal + resultadoAlgVezesBaseElePos;
        posicao--;
    
        
    }

    return resultadoFinal;
}

function hexaToDecimal(letra){
    var numero=0;
    
    switch (letra) {
        case "A":
            numero=10;
            break;
        case "B":
            numero =11;
            break;
        case "C":
            numero = 12;
            break;
        case "D":
            numero = 13;
            break;
        case "E":
            numero = 14;
            break;
        case "F":
            numero = 15;
            break;
        default:
            numero = letra;
            break;
    }
    return numero;
}

function decimalQualquerBase(base,numero){
    switch (base) {
        case 2:
            return decimalToBinary(numero)
        break;
        case 8:
            return decimalToOctal(numero)
        break;
        case 16:
            return decimalToHexa(numero)
        break;
    }
}

function decimalToBinary(numero) {
    var arr1=[]
    var i=0
    var binario=0
    while (numero>0) {
        arr1[i]=(numero%2)
        numero=parseInt(numero/2)
        i++
    }
    for(let x=arr1.length-1;x>=0;x--){
        binario= new String(binario+arr1[x])
    }
    return(`O binário é ${binario}`)
}

function decimalToOctal(numero) {
    var x=0
    var arr2=[]
    var octal=0
    while (numero>0) {
        arr2[x]=(numero%8)
        numero=parseInt(numero/8)
        x++
    }
    for(let x=arr2.length-1;x>=0;x--){
        octal=new String(octal+arr2[x])
    }
    return(`O octal é ${octal}`)
}

function decimalToHexa(numero) {
    var hexa=0
    var arr3=[]
    var y=0
    while (numero>0) {
        arr3[y]=(numero%16)
        numero=parseInt(numero/16)
        switch (arr3[y]) {
            case 10:
                arr3[y]="A"
                break;
            case 11:
                arr3[y]="B"
                break;
            case 12:
                arr3[y]="C"
                break;
            case 13:
                arr3[y]="D"
                break;
            case 14:
                arr3[y]="E"
                break;
            case 15:
                arr3[y]="F"
                break;
        }
        y++
    }
    for(let x=arr3.length-1;x>=0;x--){
        hexa=new String(hexa+arr3[x])
    }
    return(`O hexadecimal é ${hexa}`)
}

function binarioOctal(binario) {
    var decimal=numeroToDecimal(binario,"2")
    var oct=decimalToOctal(decimal)
    return(`${oct}`)
}

function octalBinary (octal) {
    var decim=numeroToDecimal(octal,"8")
    var bina=decimalToBinary(decim)
    return(`${bina}`)
}

function binarioHexa(binari) {
    var decima=numeroToDecimal(binari,"2")
    var hex=decimalToHexa(decima)
    return(`${hex}`)
}

function hexaBinary(hexa) {
    var deci=numeroToDecimal(hexa,"16")
    var bin=decimalToBinary(deci)
    return(`${bin}`)
}


