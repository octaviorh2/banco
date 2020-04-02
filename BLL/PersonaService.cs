using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTYTI;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository ;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public void CalcularPulsacion(Persona persona)
        {
            if (persona.Sexo.Equals("f"))
            {
                persona.pulsacion = (220 - persona.Edad) / 10;
            }
            else if(persona.Sexo.Equals("m"))
            {
                persona.pulsacion = (210 - persona.Edad) / 10;
            }
        }
        public void Guardar(Persona persona) 
        {
            personaRepository.Guardar(persona);
        
        }
    }
}
