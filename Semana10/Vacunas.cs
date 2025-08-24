public class ReporteVacunas
{
    public static void run()
    {
        Random random = new Random();

        // Generar 75 pacientes unicos para Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        while (pfizer.Count < 75)
        {
            pfizer.Add("PX " + random.Next(1, 501));
        }
        // Se genera 75 pacientes unicos para Astrazeneca diferentes de Pfizer
        HashSet<string> astrazeneca = new HashSet<string>();
        while (astrazeneca.Count < 75)
        {
            string candidato = "PX" + random.Next(1, 501);
            if (!pfizer.Contains(candidato))
            {
                astrazeneca.Add(candidato);
            }
        }
        //Se une los 2 grupos vacunados 
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astrazeneca);

        //Se genera los 500 pacientes en total 
        HashSet<string> pacientes = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            pacientes.Add("PX " + i);
        }
        //Verificar que paciente tiene ambas dosis 
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        //Verificar pacientes no vacunados 
        HashSet<string> noVacunados = new HashSet<string>(pacientes);
        noVacunados.ExceptWith(vacunados);

        //Mostrar Resultados 
        Console.WriteLine("\n===== Pacientes no vacunados =====");
        foreach (var item in noVacunados)
        {
            Console.WriteLine("• " + item);
        }
        Console.WriteLine("\nTOTAL no vacunados: " + noVacunados.Count);

        Console.WriteLine("\n===== Pacientes vacunados con ambas dosis =====");
        foreach (var item in ambasDosis)
        {
            Console.WriteLine("• " + item);
        }
        Console.WriteLine("\nTOTAL ambas dosis: " + ambasDosis.Count);

        Console.WriteLine("\n===== Pacientes vacunados con Pfizer =====");
        foreach (var item in pfizer)
        {
            Console.WriteLine("• " + item);
        }
        Console.WriteLine("\nTOTAL PFIZER: " + pfizer.Count);

        Console.WriteLine("\n===== Pacientes vacunados con Astrazeneca =====");
        foreach (var item in astrazeneca)
        {
            Console.WriteLine("• " + item);
        }
        Console.WriteLine("\nTOTAL Vacuna Astrazeneca: " + astrazeneca.Count);
    }
    
}
    
    
