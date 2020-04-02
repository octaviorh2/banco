using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTYTI;
using BLL;

namespace Pulsaciones_estructurada
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            PersonaService personaService = new PersonaService();
            string seguir;
           
            do
            {
                Console.WriteLine("diguite su nombre ");
                persona.Nombre = Console.ReadLine();
                Console.WriteLine("diguite su identificacion ");
                persona.Identificacion = Console.ReadLine();
                Console.WriteLine("diguite su edad ");
                persona.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("digite su sexo F/M");
                persona.Sexo = Console.ReadLine();
                personaService.CalcularPulsacion(persona);
                personaService.Guardar(persona);
                
                Console.WriteLine($"{persona.Nombre} sus pulsaciones son {persona.pulsacion}");
                Console.WriteLine("desea continuar calculando las pulsaciones S/N");
                seguir = Console.ReadLine();
            } while (seguir.Equals("s") );
            Console.ReadKey();
        }
    }
}
    