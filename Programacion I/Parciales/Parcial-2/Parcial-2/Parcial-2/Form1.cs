using System.Text;
using System.IO;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Gianluca\\Desktop\\Sistemas - UAI\\Programacion I\\Parciales\\Parcial-2\\Parcial-2\\Parcial-2\\ventas.txt", true, Encoding.UTF8);
            string reg = String.Format("{0},{1},{2}",txtCodigo.Text,txtModelo.Text,txtVentas.Text);
            sw.WriteLine(reg);
            sw.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\Gianluca\\Desktop\\Sistemas - UAI\\Programacion I\\Parciales\\Parcial-2\\Parcial-2\\Parcial-2\\ventas.txt");

            String[] array = new string[0];
            String marca = String.Empty;

            int produccion = 0;
            int produccionTotal = 0;

            String salir = "no";

            array = sr.ReadLine().Split(",");

            while(salir == "no")
            {
                marca = array[0];
                produccion = 0;

                lstMostrar.Items.Add(String.Format("Marca {0}", marca));

                while(salir == "no" && marca == array[0])
                {
                    produccion += Convert.ToInt32(array[2]);

                    produccionTotal = produccionTotal + Convert.ToInt32(array[2]);

                    if (sr.Peek() == -1)
                    {
                        lstMostrar.Items.Add(String.Format("{0},{1},{2}", array[0], array[1], array[2]));
                        salir = "si";

                    }
                    else
                    {
                        lstMostrar.Items.Add(String.Format("{0},{1},{2}", array[0], array[1], array[2]));
                        array = sr.ReadLine().Split(',');

                    }
                }

                lstMostrar.Items.Add(String.Format(" Cantidad vendida por MARCA: {0}", produccion));
                lstMostrar.Items.Add("  ");

            }
            lstMostrar.Items.Add(String.Format("Total vendido en la CONCESIONARIA: {0}", produccionTotal));
            sr.Close();


        }
    }
}