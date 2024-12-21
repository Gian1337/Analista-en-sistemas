using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    public class Cabecera
    {
       
        
        public Cabecera(string pTipo,int pPuntoVenta,int pNumero,string pCliente) 
        { Tipo = pTipo;PuntoVenta = pPuntoVenta;Numero = pNumero;Cliente = pCliente;}
        public string Tipo { get; set; }
        public int PuntoVenta { get; set; }
        public int Numero { get; set; }
        public string Cliente { get; set; }
    }

  }
