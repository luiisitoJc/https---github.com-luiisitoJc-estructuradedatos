
using System;
using System.Collections.Generic;

public class VerificadorBalanceado
{
    public bool EsBalanceado(string expresion)
    {
        var pila = new Stack<char>();

        foreach (var caracter in expresion)
        {
            if (caracter == '(')
            {
                pila.Push(caracter);
            }
            else if (caracter == ')')
            {
                if (pila.Count == 0)
                {
                    return false; // No hay paréntesis abierto para cerrar
                }
                pila.Pop();
            }
        }

        return pila.Count == 0; // Si la pila está vacía, la expresión está balanceada
    }
}

class Program
{
    static void Main()
    {
        var verificador = new VerificadorBalanceado();

        Console.WriteLine(verificador.EsBalanceado("{7+(8*5)-[(9-7)+(4+1)]}")); // true
        Console.WriteLine(verificador.EsBalanceado("{7+(8*5)-[(9-7)+(4+1")); // false
    }
}


