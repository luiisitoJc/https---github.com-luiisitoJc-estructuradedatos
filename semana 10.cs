using System;
using System.Collections.Generic;

class Programa
{
    static void Main(string[] args)
    {
        // Generar conjunto ficticio de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // Generar conjuntos ficticios de vacunados
        HashSet<string> vacunadosPfizer = new HashSet<string>();
        HashSet<string> vacunadosAstrazeneca = new HashSet<string>();

        Random random = new Random();
        while (vacunadosPfizer.Count < 75)
        {
            int index = random.Next(1, 501);
            vacunadosPfizer.Add($"Ciudadano {index}");
        }

        while (vacunadosAstrazeneca.Count < 75)
        {
            int index = random.Next(1, 501);
            vacunadosAstrazeneca.Add($"Ciudadano {index}");
        }

        // Operaciones de conjuntos
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstrazeneca);

        HashSet<string> dosVacunas = new HashSet<string>(vacunadosPfizer);
        dosVacunas.IntersectWith(vacunadosAstrazeneca);

        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstrazeneca);

        HashSet<string> soloAstrazeneca = new HashSet<string>(vacunadosAstrazeneca);
        soloAstrazeneca.ExceptWith(vacunadosPfizer);

        // Mostrar resultados en consola
        Console.WriteLine("Ciudadanos no vacunados:");
        MostrarConjunto(noVacunados);

        Console.WriteLine("\nCiudadanos con dos vacunas:");
        MostrarConjunto(dosVacunas);

        Console.WriteLine("\nCiudadanos solo con Pfizer:");
        MostrarConjunto(soloPfizer);

        Console.WriteLine("\nCiudadanos solo con Astrazeneca:");
        MostrarConjunto(soloAstrazeneca);
    }

    static void MostrarConjunto(HashSet<string> conjunto)
    {
        foreach (var ciudadano in conjunto)
        {
            Console.WriteLine(ciudadano);
        }
    }
}