using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona persona = new Persona();

            persona.Nombre = "Maria";
            persona.Apellido = "Sosa";
            persona.Edad = 25;
            persona.Salario = 12313.313;

            persona.ImprimirDatos();

            Console.WriteLine("--------------------");
            Persona persona2 = new Persona();  
            persona2.Nombre = "Jose";
            persona2.Apellido = "Yam";
            persona2.Edad = 35;
            persona2.Salario = 12313.313;
            
            persona2.ImprimirDatos();

        }
    }
}
