using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_Persona
    {
        Controladores controlador;

        public BLL_Persona()
        {
            controlador = new Controladores();
        }

        public void Alta(BE_Persona pPersona)
        {
            controlador.Alta(pPersona);
        }

        public void Modificar(BE_Persona pPersona_original, BE_Persona pPersona_actualizacion)
        {
            controlador.Modificar(pPersona_original, pPersona_actualizacion);
        }

        public void Baja(BE_Persona pPersona) 
        {
            controlador.Baja(pPersona);
        }

        public List<BE_Persona> Obtener_lista_personas()
        {
            return controlador.Obtener_lista_personas();
        }

        public List<BE_Vehiculo> Obtener_vehiculos_propios(int pDNI)
        {
            return controlador.Obtener_vehiculos_propios(pDNI);
        }
    }
}
