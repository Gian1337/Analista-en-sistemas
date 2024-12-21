using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Desafio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            empresa= new Empresa();
        }
        Regex re;
        Empresa empresa;
        private void Mostrar(DataGridView pDGV,object pO)
        {
            pDGV.DataSource=null;pDGV.DataSource=pO;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                re=new Regex(@"\d{2}.\d{3}.\d{3}");
                string dni = Interaction.InputBox("DNI: ");
                if (!(re.IsMatch(dni) && dni.Length==10)) throw new Exception("El DNI no posee el formato correcto !!!");
                Persona p = new Persona(dni, "", "");
                if (empresa.ValidaExisteDNIPersona(p)) throw new Exception("El DNI ya existe !!!");
                p.Nombre= Interaction.InputBox("Nombre: ");
                p.Apellido= Interaction.InputBox("Apellido: ");
                empresa.AgregarPersona(p);
                Mostrar(dataGridView1, empresa.RetornaListaPersonas());
            
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect=false;
            dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            empresa.AgregarAuto(new Auto("AE123FF", "Volkswagen", "Bora", "2020", 50000));
            empresa.AgregarAuto(new Auto("AF999AD", "Audi", "A1", "2022", 42000));
            empresa.AgregarAuto(new Auto("AB546GG", "BMW", "M3", "2019", 300000));

            empresa.AgregarPersona(new Persona("40.252.156", "Carlos", "Pérez"));
            empresa.AgregarPersona(new Persona("30.160.156", "Javier", "Gonzalez"));
            empresa.AgregarPersona(new Persona("39.582.848", "Lionel", "Messi"));
            
            Mostrar(dataGridView2, empresa.RetornaListaAuto());
            Mostrar(dataGridView1, empresa.RetornaListaPersonas());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count==0) throw new Exception("No hay nada para borrar !!!");
                DataGridViewRow f= dataGridView1.SelectedRows[0];
                Persona p = new Persona(f.Cells[0].Value.ToString(),"","");
                empresa.BorrarPersona(p);
                Mostrar(dataGridView1,empresa.RetornaListaPersonas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = Interaction.InputBox("Ingrese la PATENTE: ");
                Auto a = new Auto(patente, "", "", "", 0);
                if (empresa.ValidaPatente(a)) throw new Exception("La patente ya existe");

                string marca = Interaction.InputBox("Ingrese la MARCA: ");
                string modelo = Interaction.InputBox("Ingrese el MODELO: ");
                string año = Interaction.InputBox("Ingrese el AÑO: ");
                decimal precio = Convert.ToDecimal(Interaction.InputBox("Ingrese el PRECIO: "));

                Auto auto = new Auto(patente, marca, modelo, año, precio);

                empresa.AgregarAuto(auto);
                Mostrar(dataGridView2, empresa.RetornaListaAuto());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count == 0) throw new Exception("Debe seleccionar una fila para borrar");
                DataGridViewRow filaSeleccionada = dataGridView2.SelectedRows[0];
                Auto auto = new Auto(filaSeleccionada.Cells[0].Value.ToString(),"","","",0);
                empresa.BorrarAuto(auto);
                Mostrar(dataGridView2, empresa.RetornaListaAuto());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("Debe seleccionar una persona para modificar");

                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                Persona persona = new Persona(filaSeleccionada.Cells[0].Value.ToString());

                persona.Nombre = Interaction.InputBox("Nombre:");
                persona.Apellido = Interaction.InputBox("Apellido: ");
                empresa.ModificaPersona(persona);
 
                Mostrar(dataGridView1, empresa.RetornaListaPersonas());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) throw new Exception("Debe seleccionar un auto para modificar");

            DataGridViewRow filaSeleccionada = dataGridView2.SelectedRows[0];

            Auto auto = new Auto(filaSeleccionada.Cells[0].Value.ToString());

            auto.Marca = Interaction.InputBox("Marca: ");
            auto.Modelo = Interaction.InputBox("Modelo: ");
            auto.Año = Interaction.InputBox("Año: ");
            auto.Precio =Convert.ToDecimal(Interaction.InputBox("Precio: "));
            empresa.ModificaAuto(auto);

            Mostrar(dataGridView2, empresa.RetornaListaAuto());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) throw new Exception("Debe seleccionar una persona para asignar");
            if (dataGridView2.Rows.Count == 0) throw new Exception("Debe seleccionar un auto para asignar");

            empresa.AsignaAuto(
                                new Persona(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                                new Auto(dataGridView2.SelectedRows[0].Cells[0].Value.ToString())
                                );

            dataGridView1_RowEnter(null, null);
            Mostrar(dataGridView4, empresa.RetornaListaAutoG4());

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    dataGridView3.DataSource = null;
                    throw new Exception();
                    Mostrar(dataGridView3, empresa.RetornaListaAutosPersonales(new Persona(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));
                }
            }
            catch
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
