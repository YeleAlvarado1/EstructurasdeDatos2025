//Definciion de String de Prueba
using System.Diagnostics;

string expresion = "[2 * (4 + 1)] + {3 + [(7 - 2) * 5]}";
//Declaracion de pila 
Stack<char> simbolos = new();
// Usamos foreach para recorrer la cadena
foreach (char c in expresion)
{
    if (c == '(' || c == '[' || c == '{')
    {
        simbolos.Push(c);
    }
    else if (c == ')' || c == ']' || c == '}')
    {
        if (simbolos.Count == 0)
        {
            Console.WriteLine("Expresión Desbalanceada");
            return;
        }
        char ultimo = simbolos.Peek();
        if ((c == ')' && ultimo == '(') ||
            (c == ']' && ultimo == '[') ||
            (c == '}' && ultimo == '{'))

        {
            simbolos.Pop();
        }
        else
        {
            Console.WriteLine("EXPRESIÓN DESBALANCEADA");    
        }
    }
}

