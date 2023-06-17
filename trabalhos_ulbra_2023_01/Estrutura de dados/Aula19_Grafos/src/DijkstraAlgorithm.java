import java.util.*;

public class DijkstraAlgorithm {

    public static int dijkstra(Graph graph, int source, int destination) {
        int numVertices = graph.getNumVertices();
        int[] distanciasMinimas = new int[numVertices];
        boolean[] visitados = new boolean[numVertices];
        int[] antecessores = new int[numVertices];

        // Inicializa as distâncias mínimas com infinito e os antecessores como -1
        Arrays.fill(distanciasMinimas, Integer.MAX_VALUE);
        Arrays.fill(antecessores, -1);

        // A distância da parada de origem para ela mesma é 0
        distanciasMinimas[source] = 0;

        for (int i = 0; i < numVertices - 1; i++) {
            int verticeMinimo = encontrarVerticeMinimo(distanciasMinimas, visitados);
            visitados[verticeMinimo] = true;

            for (int vertice = 0; vertice < numVertices; vertice++) {
                int pesoAresta = graph.getWeight(verticeMinimo, vertice);

                if (pesoAresta > 0 && !visitados[vertice]) {
                    int novaDistancia = distanciasMinimas[verticeMinimo] + pesoAresta;

                    if (novaDistancia < distanciasMinimas[vertice]) {
                        distanciasMinimas[vertice] = novaDistancia;
                        antecessores[vertice] = verticeMinimo;
                    }
                }
            }
        }

        return distanciasMinimas[destination];
    }

    private static int encontrarVerticeMinimo(int[] distanciasMinimas, boolean[] visitados) {
        int minDistancia = Integer.MAX_VALUE;
        int minVertice = -1;

        for (int vertice = 0; vertice < distanciasMinimas.length; vertice++) {
            if (!visitados[vertice] && distanciasMinimas[vertice] < minDistancia) {
                minDistancia = distanciasMinimas[vertice];
                minVertice = vertice;
            }
        }

        return minVertice;
    }
}