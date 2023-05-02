using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using System.Reflection;

namespace DAO_Capas
{
    public partial class Vista : Form
    {
        BLL_Persona persona; BLL_Vehiculo vehiculo; string tipo_busqueda;
        Regex regexAuto; Regex regexMoto;

        public Vista()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio();
            Cargar_grillas();
        }

        private void Inicio()
        {
            Seleccion(dGV_ABM_Personas); Seleccion(dGV_ABM_Vehiculos);
            persona = new BLL_Persona();
            vehiculo = new BLL_Vehiculo();
            regexAuto = new Regex(@"\w{2}\d{3}\w{2}");
            regexMoto = new Regex(@"\w{1}\d{3}\w{3}");
        }

        private void Seleccion(DataGridView dGV)
        {
            dGV.MultiSelect = false;
            dGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Cargar_grillas()
        {
            dGV_ABM_Vehiculos.DataSource = null; dGV_ABM_Vehiculos.DataSource = vehiculo.Obtener_lista_vehiculos();
            dGV_ABM_Personas.DataSource = null; dGV_ABM_Personas.DataSource = persona.Obtener_lista_personas();
        }

        private void btn_Alta_vehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if(dGV_ABM_Personas.Rows.Count > 0)
                {
                    BE_Persona dueño = persona.Obtener_lista_personas().Find(
                        x => x.DNI == int.Parse(dGV_ABM_Personas.SelectedRows[0].Cells[0].Value.ToString()));
                    string patente = Interaction.InputBox($"Ingrese patente del vehículo. " +
                    $"Recuerde que:{Environment.NewLine}" +
                    $"1) La patente de un auto debe tener el formato: AB123CD.{Environment.NewLine}" +
                    $"2) La patente de una moto debe tener el formato: A123BDC.{Environment.NewLine}" +
                    $" ", "Alta de vehículo").ToUpper();

                    if (vehiculo.Obtener_lista_vehiculos().Exists(x => x.Patente == patente))
                    {
                        throw new Exception("La patente ingresada ya existe.");
                    }
                    string tipo_vehiculo = "";

                    if (regexAuto.IsMatch(patente)) tipo_vehiculo = "auto";
                    else if (regexMoto.IsMatch(patente)) tipo_vehiculo = "moto";
                    else throw new Exception("La patente ingresada no es válida ni para autos ni motos.");

                    string marca = Interaction.InputBox("Ingrese marca del vehiculo", $"Alta de {tipo_vehiculo}");
                    string nombre = Interaction.InputBox("Ingrese nombre del vehiculo", $"Alta de {tipo_vehiculo}");
                    int modelo = int.Parse(Interaction.InputBox("Ingrese modelo del vehiculo", $"Alta de {tipo_vehiculo}"));
                    decimal valor = decimal.Parse(Interaction.InputBox("Ingrese valor del vehiculo", $"Alta de {tipo_vehiculo}"));
                    DateTime fecha_ingreso = DateTime.Parse(Interaction.InputBox("Ingrese fecha de ingreso del vehiculo", $"Alta de {tipo_vehiculo}"));
                    bool en_uso = true;
                    if (MessageBox.Show("¿Se encuentra en uso el auto?", $"Alta de {tipo_vehiculo}", MessageBoxButtons.YesNo) == DialogResult.No) en_uso = false;
                    
                    vehiculo.Alta(new Auto(patente, marca, nombre, modelo, valor, fecha_ingreso, en_uso, dueño));
                    Cargar_grillas();
                }
            }
            catch (Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btn_Modificar_vehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = dGV_ABM_Vehiculos.SelectedRows[0].Cells["Patente"].Value.ToString();

                if (vehiculo.Obtener_lista_vehiculos().Exists(x => x.Patente == patente && 
                x.Patente != dGV_ABM_Vehiculos.SelectedRows[0].Cells[0].Value.ToString())) 
                { 
                    Exception ex = new Exception("La patente ingresada ya existe."); 
                }

                BE_Vehiculo vehiculo_original = vehiculo.Obtener_lista_vehiculos().Find(x => x.Patente == patente);

                string tipo_vehiculo = "";
                if (regexAuto.IsMatch(patente)) tipo_vehiculo = "auto";
                else if (regexMoto.IsMatch(patente)) tipo_vehiculo = "moto";
                else throw new Exception("La patente ingresada no es válida ni para autos ni motos.");

                string marca = Interaction.InputBox("Ingrese marca del auto", $"Modificación de {tipo_vehiculo}", vehiculo_original.Marca);
                string nombre = Interaction.InputBox("Ingrese nombre del auto", $"Modificación de {tipo_vehiculo}", vehiculo_original.Nombre);
                int modelo = int.Parse(Interaction.InputBox("Ingrese modelo del auto", $"Modificación de {tipo_vehiculo}", vehiculo_original.Modelo.ToString()));
                decimal valor = decimal.Parse(Interaction.InputBox("Ingrese valor del auto", $"Modificación de {tipo_vehiculo}", vehiculo_original.Valor.ToString()));
                DateTime fecha_ingreso = DateTime.Parse(Interaction.InputBox("Ingrese fecha de ingreso del auto", $"Modificación de {tipo_vehiculo}", vehiculo_original.Fecha_ingreso.Date.ToString()));
                bool en_uso = true;
                if (MessageBox.Show("¿Se encuentra en uso el auto?", $"Modificación de {tipo_vehiculo}", MessageBoxButtons.YesNo) == DialogResult.No) en_uso = false;

                vehiculo.Modificar(vehiculo_original, new Auto(patente, marca, nombre, modelo, valor, fecha_ingreso, en_uso, vehiculo_original.Obtener_dueño()));
                Cargar_grillas();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }

        private void btn_Baja_vehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                vehiculo.Baja(vehiculo.Obtener_lista_vehiculos().Find(x => x.Patente == dGV_ABM_Vehiculos.SelectedRows[0].Cells[0].Value.ToString()));
                Cargar_grillas();
            }
            catch (Exception) { }
        }

        private void btn_Alta_persona_Click(object sender, EventArgs e)
        {
            try
            {
                int DNI = int.Parse(Interaction.InputBox("Ingrese DNI de la persona.", "Alta de persona."));
                if (Information.IsNumeric(DNI))
                {
                    if (persona.Obtener_lista_personas().Exists(x => x.DNI == DNI)) 
                    {
                        throw new Exception("El DNI ingresado ya existe en la base de datos."); 
                    }

                    string Nombre = Interaction.InputBox("Ingrese el nombre de la persona.", "Alta de persona.");
                    string Apellido = Interaction.InputBox("Ingrese el apellido del persona.", "Alta de persona.");

                    persona.Alta(new BE_Persona(DNI, Nombre, Apellido));
                    Cargar_grillas();
                }
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); };
        }

        private void btn_Modificar_persona_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Persona persona_original = persona.Obtener_lista_personas().Find(
                    x => x.DNI == int.Parse(dGV_ABM_Personas.SelectedRows[0].Cells["DNI"].Value.ToString()));
                int dni = int.Parse(Interaction.InputBox("Ingrese el nuevo DNI de la persona.", "Modificación de persona.",
                    dGV_ABM_Personas.SelectedRows[0].Cells[0].Value.ToString()));

                if (persona.Obtener_lista_personas().Exists(x => x.DNI != persona_original.DNI 
                && x.DNI == dni ))
                { 
                    throw new Exception("El DNI ingresado ya existe en la base de datos."); 
                }

                string nombre = Interaction.InputBox("Ingrese el nuevo nombre de la persona.", "Modificación de persona.",
                    dGV_ABM_Personas.SelectedRows[0].Cells[1].Value.ToString());
                string apellido = Interaction.InputBox("Ingrese el nuevo apellido de la persona.", "Modificación de persona.",
                    dGV_ABM_Personas.SelectedRows[0].Cells[2].Value.ToString());

                persona.Modificar(persona_original, new BE_Persona(dni, nombre, apellido));
                Cargar_grillas();
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        } 

        private void btn_Baja_persona_Click(object sender, EventArgs e)
        {
            try
            {
                persona.Baja(persona.Obtener_lista_personas().Find(
                    x => x.DNI == int.Parse(dGV_ABM_Personas.SelectedRows[0].Cells[0].Value.ToString())));
                Cargar_grillas();
            }
            catch (Exception) { };

        }

        private void combo_Filtrar_ordenar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_Filtrar_ordenar.Text == "Persona")
                {
                    object[] item = new object[] { "PerDNI", "PerNombre", "PerApellido" };
                    combo_Campo_ordenar.Items.Clear();
                    combo_Campo_ordenar.Items.AddRange(item);
                }
                if (combo_Filtrar_ordenar.Text == "Vehiculo")
                {
                    object[] item = new object[] { "VePatente", "VeMarca", "VeNombre",
                        "VeModelo", "VeValor", "VeFechaIngreso", "VeFechaBaja" };
                    combo_Campo_ordenar.Items.Clear();
                    combo_Campo_ordenar.Items.AddRange(item);
                }
            }
            catch (Exception) { }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGV_ABM_Personas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object[] item = new object[] { "DNI", "Nombre", "Apellido" };
                groupBox4.Text = "Búsqueda incremental de personas según";
                tipo_busqueda = "Personas";
                combo_Busqueda_incremental.Items.Clear();
                combo_Busqueda_incremental.Items.AddRange(item);

                dGV_Vehiculos_cliente.DataSource = null;
                dGV_Vehiculos_cliente.DataSource = persona.Obtener_vehiculos_propios(int.Parse(dGV_ABM_Personas.SelectedRows[0].Cells["DNI"].Value.ToString()));
            }
            catch (Exception) { }
        }

        private void dGV_ABM_Vehiculos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            object[] item = new object[] { "Patente", "Marca", "Nombre",
                        "Modelo" };
            groupBox4.Text = "Búsqueda incremental de vehículos según";
            tipo_busqueda = "Vehiculos";
            combo_Busqueda_incremental.Items.Clear();
            combo_Busqueda_incremental.Items.AddRange(item);
        }

        private void txtBox_Busqueda_incremental_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(combo_Busqueda_incremental.Text != "")
                {
                    if (txtBox_Busqueda_incremental.Text != "")
                    {
                        Regex regexBusqueda = new Regex($"^{txtBox_Busqueda_incremental.Text}", RegexOptions.IgnoreCase);
                        dGV_Busqueda.DataSource = null;
                        if (tipo_busqueda == "Personas")
                        {
                            if (combo_Busqueda_incremental.Text == "Nombre") dGV_Busqueda.DataSource = (from p in persona.Obtener_lista_personas() where regexBusqueda.IsMatch(p.Nombre) select p).ToList();
                            else if (combo_Busqueda_incremental.Text == "Apellido") dGV_Busqueda.DataSource = (from p in persona.Obtener_lista_personas() where regexBusqueda.IsMatch(p.Apellido) select p).ToList();
                            else if (combo_Busqueda_incremental.Text == "DNI") dGV_Busqueda.DataSource = (from p in persona.Obtener_lista_personas() where regexBusqueda.IsMatch(p.DNI.ToString()) select p).ToList();
                        }
                        else if (tipo_busqueda == "Vehiculos")
                        {
                            if (combo_Busqueda_incremental.Text == "Patente") dGV_Busqueda.DataSource = (from v in vehiculo.Obtener_lista_vehiculos() where regexBusqueda.IsMatch(v.Patente) select v).ToList();
                            if (combo_Busqueda_incremental.Text == "Marca") dGV_Busqueda.DataSource = (from v in vehiculo.Obtener_lista_vehiculos() where regexBusqueda.IsMatch(v.Marca) select v).ToList();
                            if (combo_Busqueda_incremental.Text == "Nombre") dGV_Busqueda.DataSource = (from v in vehiculo.Obtener_lista_vehiculos() where regexBusqueda.IsMatch(v.Nombre) select v).ToList();
                            if (combo_Busqueda_incremental.Text == "Modelo") dGV_Busqueda.DataSource = (from v in vehiculo.Obtener_lista_vehiculos() where regexBusqueda.IsMatch(v.Modelo.ToString()) select v).ToList();
                        }
                    }
                    else dGV_Busqueda.DataSource = null;
                }
            }
            catch (Exception) { }
        }
    }
}
