using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAO
{
    public class Acceso_datos
    {
        SqlConnection conn; DataSet ds; bool flag = false;
        SqlCommandBuilder cb; SqlDataAdapter adapter_Vehiculo; SqlDataAdapter adapter_Persona;

        public Acceso_datos()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=Concesionaria;Integrated Security=True");
            adapter_Vehiculo = new SqlDataAdapter("Select * from Vehiculo", conn);
            adapter_Persona = new SqlDataAdapter("Select * from Persona", conn);
            ds = new DataSet();
            Comandos();
            
        }

        public void Comandos()
        {
            cb = new SqlCommandBuilder(adapter_Vehiculo);
            adapter_Vehiculo.UpdateCommand = cb.GetUpdateCommand().Clone();
            adapter_Vehiculo.DeleteCommand = cb.GetDeleteCommand().Clone();
            cb = new SqlCommandBuilder(adapter_Persona);
            adapter_Persona.UpdateCommand = cb.GetUpdateCommand();
            adapter_Persona.DeleteCommand = cb.GetDeleteCommand();

            Leer();
        }

        public DataSet Retorna_Data_Set()
        {
            return ds;
        }

        public void Leer()
        {
            if(flag == true)
            {
                if (ds.Tables["Vehiculo"].Rows.Count != 0) ds.Tables["Vehiculo"].Clear();
                if (ds.Tables["Persona"].Rows.Count != 0) ds.Tables["Persona"].Clear();
            }
            else flag = true;
            adapter_Persona.Fill(ds, "Persona");
            adapter_Vehiculo.Fill(ds, "Vehiculo");
        }

        public void Persistir()
        {
            adapter_Vehiculo.Update(ds.Tables["Vehiculo"]);
            adapter_Persona.Update(ds.Tables["Persona"]);
        }

    }
}
