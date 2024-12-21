using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2___POO___Gianluca_Carlini
{
    abstract class Cuota
    {

        #region Propiedades
        public string Codigo { get; set; }
        public DateTime FechaEmitida { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }

        private Socio _socio;
        public Socio Socio { get { return _socio; } set { _socio = value; } }

        #endregion

        #region Constructores

        public Cuota()
        {

        }

        public Cuota(string codigo, DateTime fechaEmitida, DateTime fechaVencimiento, decimal importe)
        {
            this.Codigo = codigo;
            this.FechaEmitida = fechaEmitida;
            this.FechaVencimiento = fechaVencimiento;
            this.Importe = importe;
     
        }
        #endregion

        #region Métodos
        public void AsignaCuotaSocio(Socio pSocio)
        {

            try
            {
            if (_socio == null) _socio = pSocio;  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Socio RetornaSocio()
        {
            return _socio;
        }

        public abstract decimal ObtenerIntereses(decimal valor, int diasExcedidos);
        
        #endregion



    }
}
