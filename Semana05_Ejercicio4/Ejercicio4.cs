class Programa
{
    static void Main()
    {
        System.Collections.Generic.List<int> numeros = new System.Collections.Generic.List<int>();

        System.Console.WriteLine("Ingrese los 6 números ganadores de la lotería:");
        for (int i = 1; i <= 6; i++)
        {
            System.Console.Write("Número " + i + ": ");
            string entrada = System.Console.ReadLine() ?? "0";
            int numero = System.Int32.Parse(entrada);
            numeros.Add(numero);
        }
    }
}    