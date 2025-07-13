// De claracion de pilas Torre A,B,C
Stack<int> torreA = new();
Stack<int> torreB = new();
Stack<int> torreC = new();

int discos = 3;

for (int i = discos; i >= 1; i--)
{
    torreA.Push(i);
}
// Creacion de metodo moverhanoi para para resolver el juego mediante recursividad
MoverHanoi(discos, torreA, torreC, torreB, "A", "C", "B");

void MoverHanoi(int cantidad, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar, string nomOrigen, string nomDestino, string nomAux)
{
    if (cantidad == 1)
    {
        MoverDisco(origen, destino, nomOrigen, nomDestino);
        return;
    }

    MoverHanoi(cantidad - 1, origen, auxiliar, destino, nomOrigen, nomAux, nomDestino);
    MoverDisco(origen, destino, nomOrigen, nomDestino);
    MoverHanoi(cantidad - 1, auxiliar, destino, origen, nomAux, nomDestino, nomOrigen);
}
// Metodo para mover el disco 
void MoverDisco(Stack<int> desde, Stack<int> hacia, string nomDesde, string nomHacia)
{
    int disco = desde.Pop();
    hacia.Push(disco);
    Console.WriteLine("Se movió el disco " + disco + " de torre " + nomDesde + " a torre " + nomHacia);
}