public class Main {
    public static void main(String[] args) {
        Grafo grafo = new Grafo(5);
        grafo.adicionarAresta(0, 1);
        grafo.adicionarAresta(1, 2);
        grafo.adicionarAresta(2, 3);
        grafo.adicionarAresta(3, 4);

        grafo.imprimirGrafo();

        Graph graph = new Graph(6);
        graph.addEdge(0, 1, 2);
        graph.addEdge(0, 2, 4);
        graph.addEdge(1, 2, 1);
        graph.addEdge(1, 3, 7);
        graph.addEdge(2, 4, 3);
        graph.addEdge(3, 4, 1);
        graph.addEdge(3, 5, 5);
        graph.addEdge(4, 5, 2);

        int source = 0;
        int destination = 5;

        int shortestDistance = DijkstraAlgorithm.dijkstra(graph, source, destination);
        System.out.println("A menor distância entre a parada " + source + " e a parada " + destination + " é: " + shortestDistance);
    }
}