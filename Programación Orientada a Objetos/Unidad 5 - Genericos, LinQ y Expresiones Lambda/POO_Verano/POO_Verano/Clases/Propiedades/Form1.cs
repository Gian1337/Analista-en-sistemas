using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;





namespace Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cliente C3;
        private void Form1_Load(object sender, EventArgs e)
        {
            Cliente C = new Cliente();
            Cliente C2 = new Cliente(10,"Ana");
           
            C.Codigo = 1;
            MessageBox.Show(C.Codigo.ToString());

            C.Nombre = Interaction.InputBox("Ingrese el nombre: ");
            MessageBox.Show(C.Nombre);

            MessageBox.Show($"Código: {C.Codigo}{Environment.NewLine}" +
                            $"Nombre: {C.Nombre}{Environment.NewLine}" +
                            $"Fecha y Hora: {C.Fecha_Hora}");

            C.Nick = Interaction.InputBox("Ingrese el nick: ");
            MessageBox.Show(C.RetornaNick("Sr."));

            MessageBox.Show($"Código de C2: {C2.Codigo}{Environment.NewLine}" +
                           $"Nombre: {C2.Nombre}{Environment.NewLine}" +
                           $"Fecha y Hora: {C2.Fecha_Hora}");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            C3 = new Cliente(99,"Laura");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C3 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }

    public class Cliente
    {
        #region "Campos"
            private int codigo;
            string nick;
        #endregion
        #region "Constructores"
            public Cliente()
            { }
            public Cliente(int pCodigo, string pNombre="")
            {
                Codigo = pCodigo;Nombre = pNombre;
            }
        #endregion
        #region "Propiedades"
        #region "Propiedades de Lectura y escritura"
        // propfull +tab + tab  (fragmentos de código)

        public int Codigo
                {
                    get { return codigo; }
                    set { codigo = value; }
                }

            //prop + tab + tab
            public string Nombre { get; set; }
            #endregion
            #region "Propiedades de solo Lectura"
            public DateTime Fecha_Hora { get { return DateTime.Now; } }
            #endregion
            #region "Propiedades de solo Escritura"

            public string Nick{ set { nick=value; } }
        #endregion
        #endregion

        #region "Métodos"
            public string RetornaNick(string pPrefijo) { return $"{pPrefijo} {nick}"; }
        #endregion

        #region "Destructor"

        ~Cliente()
        {
            MessageBox.Show($"Se ejecutó el destructor !!!{Environment.NewLine}" +
                            $"Ciclo de vida finalizado para: Código -> {Codigo} // Nombre --> {Nombre}");
        }
        #endregion


    }


}
