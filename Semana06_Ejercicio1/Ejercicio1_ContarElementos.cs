class Program
{
    static void Main(string[] args)
    {
        // Crear lista vacía
        ListaSimple lista = new ListaSimple();

        // Insertar elementos en la lista
        lista.InsertarInicio(5);
        lista.InsertarFinal(10);
        lista.InsertarFinal(15);

        System.Console.WriteLine("Lista actual:");
        lista.Dibujar();

        int cantidad = lista.Contar();
        System.Console.WriteLine("Total de nodos: " + cantidad);
    }
}
public class Nodo
{
    public int Dato;
    public Nodo? Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}
public class ListaSimple
{
    Nodo? inicio;

    public ListaSimple()
    {
        inicio = null;
    }

    public void InsertarInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = inicio;
        inicio = nuevo;
    }

    public void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (inicio == null)
        {
            inicio = nuevo;
        }
        else
        {
            Nodo actual = inicio;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }
}
    
        

       