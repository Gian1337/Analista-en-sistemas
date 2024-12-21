using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2___POO___Gianluca_Carlini
{
    sealed class Club
    {
        List<Socio> lista_socios;
        List<Cuota> lista_cuota;
        List<Pago> lista_pagos;

        public Club()
        {
            lista_socios = new List<Socio>();
            lista_cuota = new List<Cuota>();
            lista_pagos = new List<Pago>();
        }

        #region Métodos Socios
        public void AgregaSocio(Socio pSocio)
        {
            try
            {
                lista_socios.Add(pSocio);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BorraSocio(Socio pSocio)
        {
            try
            {
                lista_socios.Remove(lista_socios.Find(x => x.Legajo == pSocio.Legajo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificaSocio(Socio pSocio)
        {
            Socio socio_aux = lista_socios.Find(x => x.Legajo == pSocio.Legajo);
            socio_aux.Nombre = pSocio.Nombre;
            socio_aux.Apellido = pSocio.Apellido;
        }

        public List<Socio> RetornaListaSocios()
        {
            return lista_socios;
        }
        #endregion

        #region Métodos Cuotas

        public void AgregaCuota(Cuota pCuota)
        {
            try
            {
                lista_cuota.Add(pCuota);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AsignaCuota(Cuota pCuota, Socio pSocio)
        {
            try
            {
                Socio socio = lista_socios.Find(x => x.Legajo == pSocio.Legajo);
                Cuota cuota = lista_cuota.Find(x => x.Codigo == pCuota.Codigo);

                socio.AsignaCuota(pCuota);
                cuota.AsignaCuotaSocio(pSocio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void EliminarCuota(Cuota pCuota, Socio pSocio)
        {
            Socio socio_aux = pSocio;
            socio_aux.EliminarCuota(pSocio, pCuota);
        }
        public Cuota RetornaCuota(Socio pSocio, VistaCuotasPendientes vcp)
        {
            Cuota cuota = pSocio.listacuotas.Find(x => x.Codigo == vcp.Codigo);
            return cuota;
        }
        #endregion

        #region Métodos Pagos

        public void AgregaPagos(Pago pPago)
        {
            lista_pagos.Add(pPago);
        }


        public void AsignaPagoSocio(Socio pSocio, Pago pPago)
        {
            pSocio.listapagos.Add(pPago);
        }

        public List<Pago> RetornaListaPagos(Socio pSocio)
        {
            return pSocio.listapagos;
        }

        public List<Pago> RetornaPagosTotal()
        {
            return lista_pagos;
        }

        #endregion
    }
}
