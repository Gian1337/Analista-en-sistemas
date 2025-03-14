﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente : Entidad
    {
        #region Propiedades
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public List<BEProducto> ListaProductos;

        #endregion

        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + DNI;
        }
    }
}
