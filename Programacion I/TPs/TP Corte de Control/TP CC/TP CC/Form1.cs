using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Gianluca\\Desktop\\TP CC\\TP CC\\TP CC\\empleados.txt");
            String[] array = new String[0];
            String empleado = String.Empty;
            int produccion = 0;
            int produccionTotal = 0;
            int acumulador = 0;
            String salir = "no";

            array = sr.ReadLine().Split('-');

            while (salir == "no")
            {
                empleado = array[0];
                produccion = 0;
                //produccionTotal = 0;

                lstShow.Items.Add(String.Format("Empleado{0}", empleado));
                
                while (salir == "no" && empleado == array[0])
                {
                    produccion += Convert.ToInt32(array[2]);
                    
                    produccionTotal = produccionTotal + Convert.ToInt32(array[2]);

                    if (sr.Peek() == -1)
                    {
                        lstShow.Items.Add(String.Format("{0}-{1}-{2}", array[0], array[1], array[2]));
                        salir = "si";
                        
                    }
                    else
                    {
                        lstShow.Items.Add(String.Format("{0}-{1}-{2}", array[0], array[1], array[2]));
                        array = sr.ReadLine().Split('-');
                        
                    }
                    
                }
                
                lstShow.Items.Add(String.Format(" Cantidad total {0}", produccion));
                lstShow.Items.Add("  ");
                 
            }
            lstShow.Items.Add(String.Format("Total producido: {0}", produccionTotal));
            sr.Close();
        }
    }
}
