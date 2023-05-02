using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using BE;
using System.Text.RegularExpressions;

namespace Mapper
{
    public class Controladores
    {
        Acceso_datos dao; DataSet ds; DataRelation relation;
        Regex regexAuto; Regex regexMoto;

        public Controladores() 
        {
            dao = new Acceso_datos();
            ds = dao.Retorna_Data_Set();
            regexAuto = new Regex(@"\w{2}\d{3}\w{2}");
            regexMoto = new Regex(@"\w{1}\d{3}\w{3}");
            relation = new DataRelation("Persona_vehiculos", ds.Tables["Persona"].Columns["DNI"], ds.Tables["Vehiculo"].Columns["PersonaDNI"]);
            ds.Relations.Add(relation);
        }

        public void Alta(BE_Persona pPersona)
        {
            dao.Leer();

            DataRow dr = ds.Tables["Persona"].NewRow();
            dr.ItemArray = new object[] { pPersona.DNI, pPersona.Nombre, pPersona.Apellido };
            ds.Tables["Persona"].Rows.Add(dr);

            dao.Persistir();
        }

        public void Modificar(BE_Persona pPersona_original, BE_Persona pPersona_actualizacion)
        {
            dao.Leer();

            DataRow dr = ds.Tables["Persona"].Select($"DNI = '{pPersona_original.DNI}'")[0];
            dr.SetField<int>(0, pPersona_actualizacion.DNI);
            dr.SetField<string>(1, pPersona_actualizacion.Nombre);
            dr.SetField<string>(2, pPersona_actualizacion.Apellido);

            dao.Persistir();
        }

        public void Baja(BE_Persona pPersona) 
        {
            dao.Leer();

            ds.Tables["Persona"].Select($"DNI = '{pPersona.DNI}'")[0].Delete();

            dao.Persistir();
        }

        public List<BE_Persona> Obtener_lista_personas()
        {
            dao.Leer();

            List<BE_Persona> aux = new List<BE_Persona>();
            foreach (DataRow dr in ds.Tables["Persona"].Rows)
            {
                aux.Add(new BE_Persona(dr.ItemArray));
            }
            return aux;
        }

        public void Alta(BE_Vehiculo pVehiculo)
        {
            dao.Leer();

            DataRow dr = ds.Tables["Vehiculo"].NewRow();
            dr.ItemArray = new object[] { pVehiculo.Patente, pVehiculo.Marca, pVehiculo.Nombre,
            pVehiculo.Modelo, pVehiculo.Valor, pVehiculo.Fecha_ingreso, pVehiculo.Fecha_baja,
            pVehiculo.En_uso, pVehiculo.Obtener_dueño().DNI };
            ds.Tables["Vehiculo"].Rows.Add(dr);

            dao.Persistir();
        }

        public void Modificar(BE_Vehiculo pVehiculo_original, BE_Vehiculo pVehiculo_actualizacion)
        {
            dao.Leer();

            DataRow dr = ds.Tables["Vehiculo"].Select($"Patente '{pVehiculo_original.Patente}'")[0];
            dr.SetField<string>(0, pVehiculo_actualizacion.Patente);
            dr.SetField<string>(1, pVehiculo_actualizacion.Marca);
            dr.SetField<string>(2, pVehiculo_actualizacion.Nombre);
            dr.SetField<int>(3, pVehiculo_actualizacion.Modelo);
            dr.SetField<decimal>(4, pVehiculo_actualizacion.Valor);
            dr.SetField<DateTime>(5, pVehiculo_actualizacion.Fecha_ingreso);
            dr.SetField<DateTime>(6, pVehiculo_actualizacion.Fecha_baja);
            dr.SetField<bool>(7, pVehiculo_actualizacion.En_uso);
            dr.SetField<int>(8, pVehiculo_actualizacion.Obtener_dueño().DNI);

            dao.Persistir();
        }

        public void Baja(BE_Vehiculo pVehiculo)
        {
            dao.Leer();

            ds.Tables["Patente"].Select($"Patente = '{pVehiculo.Patente}'")[0].Delete();

            dao.Persistir();
        }


        public List<BE_Vehiculo> Obtener_lista_vehiculos()
        {
            dao.Leer();
            
            List<BE_Vehiculo> aux = new List<BE_Vehiculo>();
            foreach (DataRow dr in ds.Tables["Vehiculo"].Rows)
            {
                if (regexAuto.IsMatch(dr.ItemArray[0].ToString()))
                {
                    aux.Add(new Auto(dr.ItemArray));
                }
                else if (regexMoto.IsMatch(dr.ItemArray[0].ToString()))
                {
                    aux.Add(new Moto(dr.ItemArray));
                }
            }
            return aux;

        }

        public List<BE_Vehiculo> Obtener_vehiculos_propios(int pDNI)
        {
            List<BE_Vehiculo> aux = new List<BE_Vehiculo>();
            foreach (DataRow dr in ds.Tables["Persona"].Select($"DNI = {pDNI}")[0].GetChildRows(relation))
            {
                aux.Add(new BE_Vehiculo(dr.ItemArray));
            }
            return aux;
        }
    }
}
