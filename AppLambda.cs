using System;
using System.Collections.Generic;
using AppLambda;


class Program
{
    static void Main()
    {
        
        var estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Ana", Edad = 20, Nota = 8.5 },
            new Estudiante { Nombre = "Mario", Edad = 22, Nota = 7.0 },
            new Estudiante { Nombre = "María", Edad = 19, Nota = 9.2 },
            new Estudiante { Nombre = "Pedro", Edad = 21, Nota = 6.8 },
            new Estudiante { Nombre = "Alex", Edad = 23, Nota = 8.0 }
        };

        
        var estudiantesMayoresDeEdad = new List<Estudiante>();
        foreach (var estudiante in estudiantes)
        {
            if (estudiante.Edad > 18)
            {
                estudiantesMayoresDeEdad.Add(estudiante);
            }
        }

        
        Estudiante estudianteConNotaMasAlta = null;
        foreach (var estudiante in estudiantes)
        {
            if (estudianteConNotaMasAlta == null || estudiante.Nota > estudianteConNotaMasAlta.Nota)
            {
                estudianteConNotaMasAlta = estudiante;
            }
        }

        double sumaNotas = 0;
        foreach (var estudiante in estudiantes)
        {
            sumaNotas += estudiante.Nota;
        }
        double promedioNotas = sumaNotas / estudiantes.Count;

        
        Console.WriteLine("Estudiantes mayores de 18 años:");
        foreach (var estudiante in estudiantesMayoresDeEdad)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Nota: {estudiante.Nota}");
        }

        Console.WriteLine($"Estudiante con la nota más alta: {estudianteConNotaMasAlta.Nombre} ({estudianteConNotaMasAlta.Nota})");
        Console.WriteLine($"Promedio de notas: {promedioNotas}");
    }
}
