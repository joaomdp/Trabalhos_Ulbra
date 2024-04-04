void main(List<String> args) {
	List<int> numeros = [1,2,3,4,5];
	
  for (var numero in numeros) {
      if (numero % 2 == 0) {
          print(numero);
      }
  }
}