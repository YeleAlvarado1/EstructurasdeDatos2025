class Programa
{
    static void Main()
    {
        System.Collections.Generic.List<int> numeros = new System.Collections.Generic.List<int>();

        for (int i = 1; i <= 10; i++)
        {
            numeros.Add(i);
        }
        numeros.Reverse();

        for (int i = 0; i < numeros.Count; i++)
        {
            if (i < numeros.Count - 1) {
                System.Console.Write(numeros[i] + ", ");
            }
            else
            {
                System.Console.Write(numeros[i]);
            }
        }
        System.Console.WriteLine();
    }
}
        


    