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

namespace FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //Creo una instancia de StreamWriter y paso por parametro donde se crea el archivo y su codificación
            StreamWriter sw = new StreamWriter("C:\\Users\\Gianluca\\Desktop\\FINAL\\FINAL\\ventas.txt", true, Encoding.UTF8);
            //Creo una variable donde guardo codigo, modelo y ventas para luego formatear a STRING
            string linea = String.Format("{0},{1},{2}", txtCodigo.Text, txtModelo.Text, txtVentas.Text);
            if (txtCodigo.Text == null)  btnAlta.Enabled = false; //Si codigo está vacio, no se puede dar de alta.
            sw.WriteLine(linea); //Utilizo método heredado de StreamWriter y escribo la linea
            sw.Close(); //Cierro el streamwriter al llamar al método .close()

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Creo una instancia de StreamReader y leo archivo ventas.txt
            StreamReader sr = new StreamReader("C:\\Users\\Gianluca\\Desktop\\FINAL\\FINAL\\ventas.txt");

            String[] array = new string[0]; //Creo un array de tipo string de 0 posiciones
            String marca = String.Empty;

            int produccion = 0;
            int produccionTotal = 0;

            String salir = "no"; //Flag

            array = sr.ReadLine().Split(','); //Leo linea por linea el texto y lo separo con metodo split ","

            while (salir == "no")
            {
                marca = array[0];
                produccion = 0;

                lstMostrar.Items.Add(String.Format("Marca {0}", marca)); //CORTE DE CONTROL POR MARCA

                while (salir == "no" && marca == array[0])
                {
                    produccion += Convert.ToInt32(array[2]); //Se guardan los valores producidos por MARCA

                    produccionTotal = produccionTotal + Convert.ToInt32(array[2]); //Se guardan los valores totales producidos

                    if (sr.Peek() == -1) //Tope del archivo es = a -1
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
