using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Refactor
{
    public class Auto
    {
        #region Propiedades
        public string Patente { get; set; }
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Año { get; set; }

        public decimal Precio { get; set; }
        #endregion

        #region Constructor
        public Auto(string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio)
        {
            this.Patente = pPatente;
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.Año = pAño;
            this.Precio = pPrecio;
        }
        #endregion
    }
}
