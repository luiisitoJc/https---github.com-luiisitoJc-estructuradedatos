using System;
using System.Collections.Generic;

class Traductor
{
    static Dictionary<string, string> diccionario = new Dictionary<string, string>()
    {
        {"time", "tiempo"}, {"person", "persona"}, {"year", "año"},
        {"way", "camino"}, {"day", "día"}, {"thing", "cosa"},
        {"man", "hombre"}, {"world", "mundo"}, {"life", "vida"},
        {"hand", "mano"}, {"part", "parte"}, {"child", "niño/a"},
        {"eye", "ojo"}, {"woman", "mujer"}, {"place", "lugar"},
        {"work", "trabajo"}, {"week", "semana"}, {"case", "caso"},
        {"point", "punto"}, {"government", "gobierno"}, {"company", "empresa"}
    };

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese la frase: ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        string frase = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        string[] palabras = frase.Split(' ');
        
        for (int i = 0; i < palabras.Length; i++)
        {
            if (diccionario.ContainsKey(palabras[i]))
            {
                palabras[i] = diccionario[palabras[i]];
            }
        }

        Console.WriteLine("Su frase traducida es: " + string.Join(" ", palabras));
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en inglés: ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        string palabraIngles = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        Console.Write("Ingrese la traducción en español: ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
        string palabraEspanol = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

        if (!diccionario.ContainsKey(palabraIngles))
        {
            diccionario.Add(palabraIngles, palabraEspanol);
            Console.WriteLine("Palabra agregada exitosamente.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
