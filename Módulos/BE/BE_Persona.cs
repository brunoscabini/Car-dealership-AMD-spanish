using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public BE_Persona() { }

        public BE_Persona(object[] obj)
        {
            DNI = int.Parse(obj[0].ToString());
            Nombre = obj[1].ToString();
            Apellido = obj[2].ToString();
        }

        public BE_Persona(int dNI, string nombre, string apellido)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
