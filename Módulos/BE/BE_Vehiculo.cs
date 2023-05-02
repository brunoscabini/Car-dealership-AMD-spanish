using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Vehiculo
    {
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public int Modelo { get; set; }
        public decimal Valor { get; set; }
        private decimal _valorResidual;
        public decimal Valor_residual
        {
            get
            {
                _valorResidual = Valor;
                if (DateTime.Now.Year > Modelo)
                {
                    _valorResidual -= (Valor - 0.1M * (DateTime.Now.Year - Modelo));

                    if (_valorResidual < 0)
                    {
                        _valorResidual = 0;
                    }
                }
                return _valorResidual;

            }
        }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_baja { get; set; }
        public string Tipo { get; set; }
        public bool En_uso { get; set; }
        private int _diasEmpresa;
        public int Dias_empresa
        {
            get
            {
                _diasEmpresa = 0;
                if (DateTime.Now.Date > Fecha_ingreso.Date)
                {
                    _diasEmpresa = DateTime.Now.Date.Subtract(Fecha_ingreso.Date).Days;
                }
                return _diasEmpresa;
            }
        }
        private BE_Persona Dueño;

        public BE_Vehiculo(object[] obj)
        {
            Patente = obj[0].ToString();
            Marca = obj[1].ToString();
            Nombre = obj[2].ToString();
            Modelo = int.Parse(obj[3].ToString());
            Valor = decimal.Parse(obj[4].ToString());
            Fecha_ingreso = DateTime.Parse(obj[5].ToString());
            Fecha_baja = DateTime.Parse(obj[6].ToString());
            En_uso = bool.Parse(obj[7].ToString());
        }

        public BE_Vehiculo(string patente, string marca, string nombre, int modelo, decimal valor, 
            DateTime fecha_ingreso, bool en_uso, BE_Persona dueño)
        {
            Patente = patente;
            Marca = marca;
            Nombre = nombre;
            Modelo = modelo;
            Valor = valor;
            Fecha_ingreso = fecha_ingreso;
            En_uso = en_uso;
            Dueño = dueño;
        }

        public BE_Persona Obtener_dueño()
        {
            return Dueño;
        }

        public void Asociar_cliente(BE_Persona pPersona)
        {
            Dueño = pPersona;
        }  

    }
    public class Auto : BE_Vehiculo
    {
        public Auto(object[] obj) : base(obj)
        {
            Tipo = "Auto";
        }

        public Auto(string patente, string marca, string nombre, int modelo, decimal valor,
            DateTime fecha_ingreso, bool en_uso, BE_Persona dueño) : 
            base(patente, marca, nombre, modelo, valor, fecha_ingreso, en_uso, dueño)
        {
            Tipo = "Auto";
        }

    }

    public class Moto : BE_Vehiculo
    {
        public Moto(object[] obj) : base(obj)
        {
            Tipo = "Moto";
        }

        public Moto(string patente, string marca, string nombre, int modelo, decimal valor,
            DateTime fecha_ingreso, bool en_uso, BE_Persona dueño) :
            base(patente, marca, nombre, modelo, valor, fecha_ingreso, en_uso, dueño)
        {
            Tipo = "Moto";
        }
    }
}
