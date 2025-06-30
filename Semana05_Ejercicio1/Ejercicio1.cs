class Programa
{
    static void Main()
    {
        System.Console.WriteLine("Ejercicio # 1");
        System.Console.WriteLine("================");

        System.Collections.Generic.List<string> asignaturas = new System.Collections.Generic.List<string>();
        asignaturas.Add("Matemáticas");
        asignaturas.Add("Física");
        asignaturas.Add("Química");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua");
        asignaturas.Sort(); //Orden Alfabetico
        foreach (string asignatura in asignaturas)
        {
            System.Console.WriteLine(asignatura);
        }
    }
}
