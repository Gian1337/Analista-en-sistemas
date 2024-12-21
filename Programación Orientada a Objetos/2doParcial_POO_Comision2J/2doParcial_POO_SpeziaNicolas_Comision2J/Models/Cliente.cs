using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
    sealed class Cliente
    {

        public List<Cobro> listaCobrosCliente; //LISTA DE LOS COBROS ASIGNADOS AL CLIENTE
        public List<Pago> listaAbonados; //Lista de pagos del cliente

        #region Propiedades
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        #endregion

        #region Constructores
        public Cliente() 
        {
            listaCobrosCliente = new List<Cobro>();
            listaAbonados = new List<Pago>();   
        }

        public Cliente(int plegajo, string pNombre) { Legajo = plegajo; Nombre = pNombre; }
        #endregion

        public void AsignarCobro(Cobro pCobro) //asignacion automatica del cobro al cliente
        {
            listaCobrosCliente.Add(pCobro);
        }
      
        public void EliminarCobro(Cliente pCliente, Cobro pCobro) //Este metodo es para cuando el cliente ya pagó, que se elimine el cobro de la lista de cobros del cliente
        {
            pCliente.listaCobrosCliente.Remove(pCobro);
        }

        public List<Pago> RetornaListaAbonados() //lista de pagos efectuados por cliente seleccionado
        {
            return listaAbonados;
        }

    }
}
