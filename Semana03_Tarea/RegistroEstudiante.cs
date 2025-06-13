using System;
// Creacion de clase Resgistro de Estudiante
class RegistroEstudiante
{
    // Declaracion de variables y sus valores
    public int id = 0951824424; 
    public string nombres = "Sofia Victoria";
    public string apellidos = "Alvarado Orellana";
    public string direccion = "Daule Marianita 2";
    // Array para guardar los numeros de telefono 
    public string[] numerostelefonos = { "0963115004", "0963748436", "0963555555" };
   // Mostramos los datos del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("ID" + id);
        Console.WriteLine("Nombres" + nombres);
        Console.WriteLine("Apellidos" + apellidos);
        Console.WriteLine("Direccion" + direccion);
        Console.WriteLine("Telefonos:");
        for (int i = 0; i < numerostelefonos.Length; i++) //Usamos for para recorrer todos los elementos del array uno por uno.
        {
            Console.WriteLine("-" + numerostelefonos[i]);// Muestra en pantalla el numero de Telefono
        }
    }
}
