void main(List<String> args) {
	List<int> numeros = [1,2,3,4,5];
	
	List<int> numerosDobrados = numeros.map((numero) => numero * 2).toList();

	print(numerosDobrados);
}