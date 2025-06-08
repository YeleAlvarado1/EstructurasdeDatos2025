using System;

// Creacion de la clase Circulo encapsula el radio y permite calcular el área y el perímetro
public class Circulo
{
    // Atributo privado radio
    private double radio;

    // Constructor que recibe el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve el perímetro del círculo usando la fórmula 2*π*r
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// La clase Rectangulo encapsula el largo y el ancho y permite calcular el área y el perímetro
class Rectangulo
{
    // Atributos privados
    private double largo;
    private double ancho;

    // Constructor que recibe largo y ancho
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    // CalcularArea devuelve el área multiplicando largo por ancho
    public double CalcularArea()
    {
        return largo * ancho;
    }

    // CalcularPerimetro devuelve el perímetro usando la fórmula 2(largo + ancho)
    public double CalcularPerimetro()
    {
        return 2 * (largo + ancho);
    }
}

// Esta es la clase principal que contiene el punto de entrada del programa
class Program
{
    // punto de entrada del programa
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Circulo con radio 5
        Circulo c = new Circulo(5);
        Console.WriteLine("Área del círculo: " + c.CalcularArea().ToString("F2"));
        Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro().ToString("F2"));

        // Crear un objeto de la clase Rectangulo con largo 4 y ancho 6
        Rectangulo r = new Rectangulo(4, 6);
        Console.WriteLine("Área del rectángulo: " + r.CalcularArea().ToString("F2"));
        Console.WriteLine("Perímetro del rectángulo: " + r.CalcularPerimetro().ToString("F2"));
    }
}
