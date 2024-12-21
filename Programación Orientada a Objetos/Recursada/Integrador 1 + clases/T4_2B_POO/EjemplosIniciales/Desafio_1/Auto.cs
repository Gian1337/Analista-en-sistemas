using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Auto
    {
        #region Propiedades
        Persona dueño;
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal Precio { get; set; }
        #endregion

        #region Constructor

        public Auto()
        {

        }
        public Auto(string patente)
        {
            Patente = patente;
        }

        public Auto(string patente, string marca, string modelo, string año, decimal precio) : this()
        {
            Patente = patente;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Precio = precio;
        }

        public Auto(Auto pAuto) : this(pAuto.Patente, pAuto.Marca, pAuto.Modelo, pAuto.Año, pAuto.Precio)
        {

        } 

        #endregion

        #region Métodos

        public Persona RetornaDueño()
        {
            return dueño == null ? null : new Persona(dueño);
        }

        public void AsignaDueño(Persona persona)
        {
            dueño = persona == null ? null : new Persona(persona);
        }
        #endregion
    }
}
