class Program
{
    static void Main(string[] args)
    {
        ListaSimple lista = new ListaSimple();

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
    public int Dato;  // Valor que guarda el nodo
    public Nodo? Siguiente;

      // Constructor para inicializar el nodo con un dato
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

public class ListaSimple
{
    Nodo? inicio;  //inicio de la lista

     // Constructor para inicializar la lista vacía
    public ListaSimple()
    {
        inicio = null;
    }
     // Inserta un nodo al principio   
    public void InsertarInicio(int dato)
    {
        Nodo nuevo = new Nodo(dato);
        nuevo.Siguiente = inicio;
        inicio = nuevo;
    }
    // Inserta un nodo al final
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
     // Recorre la lista y la imprime       
    public void Dibujar()
    {
        Nodo? actual = inicio;
        System.Console.Write("head --> ");
        while (actual != null)
        {
            System.Console.Write("[ " + actual.Dato + " ]");
            if (actual.Siguiente != null)
            {
                System.Console.Write(" --> ");
            }
            actual = actual.Siguiente;
        }
        System.Console.WriteLine(" --> null");
    }

    public int Contar()
    {
        int total = 0;
        Nodo? actual = inicio;
        while (actual != null)
        {
            total++;
            actual = actual.Siguiente;
        }
        return total;
    }
    public Nodo? Buscar(int dato)
    {
        Nodo? actual = inicio;
        while (actual != null)
        {
            if (actual.Dato == dato)
            {
                return actual;
            }
            actual = actual.Siguiente;
        }
        return null;
    }
}



    
    