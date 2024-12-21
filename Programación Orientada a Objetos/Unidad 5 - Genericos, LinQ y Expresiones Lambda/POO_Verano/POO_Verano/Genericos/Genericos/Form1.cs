using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genericos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Animal1 a=new Animal1();
            a.Alta(new Perro());
            a.Alta(new Caniche());
            a.Alta(new Gato());


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Alumno<Asignatura> a = new Alumno<Asignatura>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvierteValores sni = new InvierteValores();
            int n1 = 10;
            int n2 = 20;
            MessageBox.Show($" Al entrar n1 =  {n1}   n2 = {n2}");
            sni.Swap<int>(ref n1, ref n2);
            MessageBox.Show($" Al salir n1 =  {n1}   n2 = {n2}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            InvierteValores sni = new InvierteValores();
            decimal n1 = 10;
            decimal n2 = 20;
            MessageBox.Show($" Al entrar n1 =  {n1}   n2 = {n2}");
            sni.Swap<decimal>(ref n1, ref n2);
            MessageBox.Show($" Al salir n1 =  {n1}   n2 = {n2}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InvierteValores sni = new InvierteValores();
          
            string n1 = "Hola";
            string n2 = "Chau";
            MessageBox.Show($" Al entrar n1 =  {n1}   n2 = {n2}");
            sni.Swap<string>(ref n1, ref n2);
            MessageBox.Show($" Al salir n1 =  {n1}   n2 = {n2}");
            
        }
    }
    public class InvierteValores
    {
        public void Swap<T>(ref T n1,ref T n2) 
        {   
            T variable = n1;
            n1 = n2;
            n2 = variable;        
        } 
    }


    public class Alumno<T> where T: new()
    { }

    public class Asignatura 
    { 
        public Asignatura() { } 
        public Asignatura(int pNumero) { }
    }
 
   public interface IABMC<T>    
    {
        void Alta(T pPerro);
        void Baja(T pPerro);
        void Modificacion(T pPerro);
        T Consulta(int pLegajo);
    }

    public class Animal { }
    public class Perro : Animal, IABMC<Perro>
    {
        public void Alta(Perro pPerro)
        {
            throw new NotImplementedException();
        }

        public void Baja(Perro pPerro)
        {
            throw new NotImplementedException();
        }

        public Perro Consulta(int pLegajo)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Perro pPerro)
        {
            throw new NotImplementedException();
        }
    }

    public class Caniche : Perro { }

    public class Gato : Animal { }

    public class Animal1 : IABMC<Animal>
    {
        public void Alta(Animal pPerro)
        {
            throw new NotImplementedException();
        }

        public void Baja(Animal pPerro)
        {
            throw new NotImplementedException();
        }

        public Animal Consulta(int pLegajo)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Animal pPerro)
        {
            throw new NotImplementedException();
        }
    }

  


}
