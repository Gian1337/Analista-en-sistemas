using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Inter_IDisposable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            if (a is IDisposable) a.Dispose();
         
        }
    }

    public class Alumno : IDisposable
    {
        bool pasoDispose = false;
        public void Dispose()
        {
            MessageBox.Show("Aquí se liberan los recursos utilizados por programador desde el finalizador !!!");
            pasoDispose = true;
        }

        ~Alumno()
        {
            if(!pasoDispose) MessageBox.Show("Aquí se liberan los recursos utilizados por programador desde el desctructor !!!");

        }
    }
}
