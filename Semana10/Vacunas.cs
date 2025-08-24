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

    }
}
    
    
