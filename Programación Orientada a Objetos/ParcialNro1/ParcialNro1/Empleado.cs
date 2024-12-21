using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialNro1
{
    public class Empleado
    {
        
        public string Legajo { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Sueldo { get; set; }

        public List<Adelanto> lista_adelantos;

        public Empleado()
        {
            lista_adelantos = new List<Adelanto>();
        }

        public void AsignarAdelanto (Adelanto pAdelanto)
        {
            try
            {
                lista_adelantos.Add(pAdelanto);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


    }
}
