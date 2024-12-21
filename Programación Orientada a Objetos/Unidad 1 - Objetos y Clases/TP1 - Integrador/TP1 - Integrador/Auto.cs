using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1___Integrador
{
    public class Auto
    {
        #region Propiedades
        public string Patente { get; set; }
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Año { get; set; }

        public decimal Precio { get; set; }

        public Persona Dueño { get; set; }
        #endregion

        #region Métodos
        public Persona obtenerDueño()
        {
            return Dueño;
        }
        #endregion

        #region Constructor

        public Auto(string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio /*Persona pDueño*/)
        {
            this.Patente = pPatente;
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.Año = pAño;
            this.Precio = pPrecio;
            //this.Dueño = pDueño;
        }
        #endregion

        #region Finalizador

        ~Auto()
        {
            MessageBox.Show($"Patente: {Patente}");
        }

        #endregion

    }
}
