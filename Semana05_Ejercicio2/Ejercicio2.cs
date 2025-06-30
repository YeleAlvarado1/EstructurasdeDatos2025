class Programa
 {
    static void Main()
    {
        System.Collections.Generic.List<string> asignaturas = new System.Collections.Generic.List<string>();
        asignaturas.Add("Matemáticas");
        asignaturas.Add("Física");
        asignaturas.Add("Química");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua");
        asignaturas.Sort();
        foreach (string asignatura in asignaturas)
        {
            System.Console.WriteLine("Yo estudio " + asignatura);
        }
    }
}
    
    
