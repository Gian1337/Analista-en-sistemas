using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___POO___Gianluca_Carlini
{
    sealed class Socio
    {
        #region Propiedades
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region Listas

        public List<Cuota> listacuotas;
        public List<Pago> listapagos;
        #endregion

        #region Constructores

        public Socio(string pLegajo, string pNombre, string pApellido)
        {
            this.Legajo = pLegajo;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }

        public Socio()
        {
            listacuotas = new List<Cuota>();
            listapagos = new List<Pago>();
        }
        #endregion

        #region Métodos
        
        public void AsignaCuota(Cuota pCuota)
        {
            listacuotas.Add(pCuota);
        }

        public void EliminarCuota(Socio pSocio, Cuota pCuota)
        {
            pSocio.listacuotas.Remove(pCuota);
        }

        public List<Pago> RetornaLPagos()
        {
            return listapagos;
        }
        #endregion


    }
}
