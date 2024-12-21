using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Integrador
{
    public class Concesionario
    {
        #region Propiedades
        public Persona _persona;
        public Auto _autos;
        #endregion

        #region Constructor
        public Concesionario(string pDni, string pNombre, string pApellido, string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio)
        {
            _persona = new Persona(pDni, pNombre, pApellido);
            _autos = new Auto(pPatente, pMarca, pModelo, pAño, pPrecio);
            //_autos.Add(CreaAuto(pPatente,pMarca,pModelo,pAño,pPrecio));
        }
        #endregion

        #region Métodos

        //public void AgregarAuto(string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio)
        //{
        //    _autos.Add(CreaAuto(pPatente, pMarca, pModelo, pAño, pPrecio));
        //}

        //public List<Auto> RetornaAutos()
        //{
        //    List<Auto> _aux = new List<Auto>();
        //    foreach(Auto auto in _autos)
        //    {
        //        _aux.Add(new Auto(auto.Patente, auto.Marca, auto.Modelo, auto.Año, auto.Precio));
        //    }
        //    return _aux;
        //}

        //private Auto CreaAuto(string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio)
        //{
        //    return new Auto(pPatente, pMarca, pModelo, pAño, pPrecio);
        //}

        //public decimal Total()
        //{
        //    decimal _total = 0;
        //    foreach (Auto auto in _autos)
        //    {
        //        _total += auto.Precio;
        //    }

        //    return _total;
        //}

        #endregion
    }
}
