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

namespace Abstracto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Clase abstracta es aquella que se puede heredar pero no instanciar
            // Clase Sellada es aquella que no se puede heredar pero si instanciar
            // Clase Común o Concreta que se puede instanciar o heredar
            // Método abstracto es aquel que solo se puede definir en una clase abstracta u no posee implementación.
            //     Cuando se hereda un método abstracto a otra clase abstarcta se puede dejar como abstracto
            //     Cuando se hereda un método abstracto a otra clase común o sellada existe la obligación de colocarle una implementación.

            Producto p = new Producto();
        }

        private void FuncionEjecutar(Operacion pOperacion)
        {
            textBox3.Text = pOperacion.Ejecutar(decimal.Parse(textBox1.Text),
                                                decimal.Parse(textBox2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionEjecutar(new Suma());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FuncionEjecutar(new Resta());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FuncionEjecutar(new Producto());
        }
    }

    public abstract class Operacion
    {
        public abstract decimal Ejecutar(decimal n1, decimal n2); 
    }
    public abstract class OperacionEspecial : Operacion 
    {
      
    }
    public class Suma : Operacion
    {
        public override decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1+n2;
        }
    }
    public class Resta : Operacion
    {
        public override decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1-n2;
        }
    }
    public sealed class Producto : Operacion
    {
        public override decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
    }


}

