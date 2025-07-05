
class Program
{
    static void Main(string[] args)
    {
        // Crear una lista simple
        ListaSimple lista = new ListaSimple();

        // Insertar varios valores algunos repetidos
        lista.InsertarFinal(5);
        lista.InsertarFinal(10);
        lista.InsertarFinal(5);
        lista.InsertarFinal(20);
        lista.InsertarFinal(5);

        // Mostrar la lista actual
        System.Console.WriteLine("Lista actual:");
        lista.Dibujar();

        // Buscar cuántas veces aparece el número 5
        int valorBuscado = 5;
        int veces = lista.BuscarCantidad(valorBuscado);

        // Mostrar el resultado
        if (veces > 0)
        {
            System.Console.WriteLine("El dato " + valorBuscado + " se encontró " + veces + " veces.");
        }
        else
        {
            System.Console.WriteLine("El dato " + valorBuscado + " no fue encontrado en la lista.");
        }
    }
}

// Clase Nodo 
public class Nodo
{
    public int Dato;            // Dato almacenado en el nodo
    public Nodo? Siguiente;     

    // Constructor para asignar el valor al nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

// Clase ListaSimple (estructura principal)
public class ListaSimple
{
    Nodo? inicio;   // Nodo que representa el inicio de la lista
    // Constructor: la lista inicia vacía
    public ListaSimple()
    {
        inicio = null;
    }

    // Inserta un nodo al final de la lista
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
    // Dibuja la lista en consola
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
     // Método que busca cuántas veces aparece un valor
    public int BuscarCantidad(int valorBuscado)
    {
        Nodo? actual = inicio;
        int contador = 0;

        while (actual != null)
        {
            if (actual.Dato == valorBuscado)
            {
                contador++; // Se encontró una coincidencia
            }
            actual = actual.Siguiente;
        }

        // Retorna la cantidad (puede ser 0 si no se encontró)
        return contador;
    }
}

