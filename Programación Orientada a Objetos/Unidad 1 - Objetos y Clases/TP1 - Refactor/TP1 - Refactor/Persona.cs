using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Refactor
{
    public class Persona
    {
        #region Propiedades
        public string DNI { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        #endregion

        #region Constructor

        public Persona(string pDni, string pNombre, string pApellido)
        {
            this.DNI = pDni;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }
        #endregion

    }
}
