List<int> numerosImpares(List<int> lista) {
  return lista.where((numero) => numero % 2 != 0).toList();
}

void main() {
  List<int> minhaLista = [1, 2, 3, 4, 5, 6, 7, 8, 9];
  List<int> resultado = numerosImpares(minhaLista);
  print(resultado); 
}
