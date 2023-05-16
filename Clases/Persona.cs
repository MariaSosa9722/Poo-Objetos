using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases
{
    //clases es una plantilla 
    //Que contiene Objetos y Metodos
    public class Persona
    {
       public string Nombre { get; set; }
       public string Apellido { get; set; }
       public int Edad { get; set; }
       public double Salario { get; set; }  


        public void ImprimirDatos()
        {
            Console.WriteLine("Tu nombre es :"+this.Nombre);
            Console.WriteLine("Tu Apellido es :" + this.Apellido);
            Console.WriteLine("Tu edad es :" + this.Edad);
            Console.WriteLine("El Salario es :" + this.Salario);
        }

    }
}
