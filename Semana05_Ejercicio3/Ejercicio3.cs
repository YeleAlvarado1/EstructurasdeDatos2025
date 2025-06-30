class Programa {
    static void Main()
    {
        System.Collections.Generic.List<string> asignaturas = new System.Collections.Generic.List<string>();
        System.Collections.Generic.List<string> notas = new System.Collections.Generic.List<string>();

        asignaturas.Add("Matemáticas");
        asignaturas.Add("Física");
        asignaturas.Add("Química");
        asignaturas.Add("Historia");
        asignaturas.Add("Lengua");

        foreach (string asignatura in asignaturas)
        {
            System.Console.Write("¿Qué nota obtuviste en " + asignatura + "?: ");
            string nota = System.Console.ReadLine() ?? "";
            notas.Add(nota);
        }

        }
    }
}
    
    