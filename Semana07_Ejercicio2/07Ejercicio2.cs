// De claracion de pilas Torre A,B,C
Stack<int> torreA = new();
Stack<int> torreB = new();
Stack<int> torreC = new();

int discos = 3;

for (int i = discos; i >= 1; i--)
{
    torreA.Push(i);
}
// Creacion de metodo mopverhanoi para para resolver el juego mediante recursividad
MoverHanoi(discos, torreA, torreC, torreB, "A", "C", "B");

void MoverHanoi(int cantidad, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nomOrigen, string nomDestino, string nomAux)
{
    
}