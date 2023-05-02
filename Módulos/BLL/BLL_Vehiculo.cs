using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapper;
using System.Data;

namespace BLL
{
    public class BLL_Vehiculo
    {
        Controladores controlador;

        public BLL_Vehiculo()
        {
            controlador = new Controladores();
        }

        public void Alta(BE_Vehiculo pVehiculo)
        {
            controlador.Alta(pVehiculo);
        }

        public void Modificar(BE_Vehiculo pVehiculo_original, BE_Vehiculo pVehiculo_actualizacion)
        {
            controlador.Modificar(pVehiculo_original, pVehiculo_actualizacion);
        }

        public void Baja(BE_Vehiculo pVehiculo)
        {
            controlador.Baja(pVehiculo);
        }

        public List<BE_Vehiculo> Obtener_lista_vehiculos()
        {
            return controlador.Obtener_lista_vehiculos();
        }
    }
}
