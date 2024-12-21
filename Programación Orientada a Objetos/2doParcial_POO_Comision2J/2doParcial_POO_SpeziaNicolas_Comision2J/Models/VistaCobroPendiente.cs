using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
     class VistaCobroPendiente //Creacion de clase VISTA para mostrar los cobros pendientes
     {
        List<VistaCobroPendiente> vistaCobroPendientes;

        public VistaCobroPendiente()
        {
            vistaCobroPendientes = new List<VistaCobroPendiente>();
        }
        public VistaCobroPendiente(int pCodigo, string pNombre, DateTime pVencimiento, decimal pImporte)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Vencimiento = pVencimiento;
            Importe = pImporte;
        }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime Vencimiento { get; set; }
        public decimal Importe { get; set; }
        

        // CREACION DE METODO CLONADOR DE OBJETOS DONDE ME DEVUELVE TODOS LOS COBROS PENDIENTES DEL CLIENTE ASIGNADO AUTOMATICAMENTE
        public List<VistaCobroPendiente> CobrosPendientesCliente(Cliente pCliente, List<Cliente> ListaDeudor)
        {
            List<VistaCobroPendiente> aux = new List<VistaCobroPendiente>();
            foreach (Cobro c in ListaDeudor.Find(x => x.Legajo == pCliente.Legajo).listaCobrosCliente)
            {
                aux.Add(new VistaCobroPendiente(c.Codigo, c.Nombre, c.Vencimiento, c.Importe));
            }
            return aux;
        }
    }
}
