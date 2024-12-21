using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
    sealed class Comercio // Clase asociativa para realizar ABM Cliente y manejo de Cobro/Pago
    {
        #region LISTAS
        List<Cliente> listaClientes;
        List<Cobro> listaCobrosCliente;
        List<Cobro> listaCobros;
        List<Pago> listaPagos;
        #endregion

        #region CONSTRUCTOR
        public Comercio()
        {
            listaPagos = new List<Pago>(); listaCobros = new List<Cobro>();    
            listaClientes = new List<Cliente>(); listaCobrosCliente = new List<Cobro>();
        }
        #endregion

        #region/////////////////////////////////////// ABM CLIENTES ////////////////////////////////////////////////////////////

        public void AgregarCliente(Cliente pCliente)
        {
            try
            {
                if (pCliente == null) throw new Exception("El cliente no existe !!!"); //Validando que no sea nulo el cliente
                listaClientes.Add(pCliente);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void EliminarCliente(Cliente pCliente)
        {
            try
            {
                if (!listaClientes.Exists(x => x.Legajo == pCliente.Legajo)) throw new Exception("El legajo que desea borrar no existe !!!");
                listaClientes.Remove(listaClientes.Find(x => x.Legajo == pCliente.Legajo));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void ModificarCliente(Cliente pCliente)
        {
            Cliente aux = listaClientes.Find(x => x.Legajo == pCliente.Legajo);
            if (aux == null) throw new Exception("El cliente que desea modificar no existe !!!");
            aux.Nombre = pCliente.Nombre;
        }

        public bool ValidarLegajoCliente(int pLegajo)
        {
            return listaClientes.Exists(x => x.Legajo == pLegajo);
        }

        public List<Cliente> DevuelveListaClientes()
        {
            return listaClientes;
        }
        #endregion

        #region /////////////////////////////////////// ALTA Y MANEJO DE COBROS /////////////////////////////////////////////////
        public void AgregarCobro(Cobro pCobro)
        {
            try
            {
                listaCobros.Add(pCobro);
            }
            catch (Exception) {  }
        }

        public void AsignarCobro(Cliente pCliente, Cobro pCobro) // asigna el cobro al cliente mediante OO
        {
            try
            {
                Cliente cliente = listaClientes.Find(x => x.Legajo == pCliente.Legajo);
                Cobro cobro = listaCobros.Find(x => x.Codigo == pCobro.Codigo);

                if (cliente == null) throw new Exception("El cliente no existe!");
                if (cobro == null) throw new Exception("El cobro no existe!");
                if (cobro.RetornaCliente() != null) throw new Exception("El cobro ya posee un cliente!");

                cliente.AsignarCobro(pCobro);
                cobro.AsignarCobroCliente(pCliente);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void EliminarCobro(Cobro pCobro, Cliente pCliente) //Le quito el cobro al cliente una vez que lo paga. 
        {
            Cliente aux = pCliente;
            aux.EliminarCobro(pCliente, pCobro);
        }

        public bool ValidarCodigoCobro(int pCodigo) //para no ingresar 2 cobros repetidos
        {
            return listaCobros.Exists(x => x.Codigo == pCodigo);
        }
        public Cobro RetornaCobroAsignado(Cliente pCliente, VistaCobroPendiente v) //toma el cobro asignado del cliente e interactua con todas sus propiedades
        {
            Cobro c = pCliente.listaCobrosCliente.Find(x => x.Codigo == v.Codigo);
            return c;
        }
        #endregion

        #region /////////////////////////////////////// MANEJO DE PAGOS /////////////////////////////////////////////////////////
        public void AgregarPago(Pago pPago)
        {
            listaPagos.Add(pPago);
        }

        public void AsignarPagoCliente(Cliente pCliente, Pago pPago)
        {
            pCliente.listaAbonados.Add(pPago);
        }

        public List<Pago> DevuelveListaPagos(Cliente pCliente)
        {
            return pCliente.listaAbonados;
        }
        public List<Pago> DevuelveListaTodosLosPagos()
        {
            return listaPagos;
        }
        #endregion
    }
}
