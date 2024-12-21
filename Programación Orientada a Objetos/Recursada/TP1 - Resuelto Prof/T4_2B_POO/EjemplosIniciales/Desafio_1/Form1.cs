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

            dataGridView2.MultiSelect=false;
            dataGridView2.SelectionMode=DataGridViewSelectionMode.FullRowSelect;

            empresa.AgregarAuto(new Auto("AE123FF", "Audi", "A3", "2020", 20000));
            empresa.AgregarAuto(new Auto("AF999AD", "Fiat", "Argo", "2022", 18000));
            empresa.AgregarAuto(new Auto("AB546GG", "BMW", "i325", "2019", 30000));

            Mostrar(dataGridView2, empresa.RetornaListaAutos());
            Mostrar(dataGridView4, empresa.RetornaListaAutoGrilla4());

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count==0) throw new Exception("No hay nada para borrar !!!");
                DataGridViewRow f= dataGridView1.SelectedRows[0];
                Persona p = new Persona(f.Cells[0].Value.ToString());
                empresa.BorrarPersona(p);
                Mostrar(dataGridView1,empresa.RetornaListaPersonas());
                dataGridView1_RowEnter(null, null);
                Mostrar(dataGridView4, empresa.RetornaListaAutoGrilla4());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count==0) throw new Exception("No hay nada para modificar !!!");
                DataGridViewRow f = dataGridView1.SelectedRows[0];
                Persona p = new Persona(f.Cells[0].Value.ToString());

                var x = f.Cells[1].Value.ToString().Split(new string[] {", "},StringSplitOptions.None);

                p.Nombre= Interaction.InputBox("Nombre: ","Modificando nombre ...", x[1]);
                p.Apellido= Interaction.InputBox("Apellido: ", "Modificando apellido ...", x[0]);
                empresa.ModificarPersona(p);
                Mostrar(dataGridView1, empresa.RetornaListaPersonas());
                Mostrar(dataGridView4, empresa.RetornaListaAutoGrilla4());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count==0) throw new Exception("No hay pesonas para asignar !!!");
                if (dataGridView2.Rows.Count==0) throw new Exception("No hay autos para asignar !!!");
                empresa.AsignaAutoAPersona(
                                            new Persona(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), 
                                            new Auto(dataGridView2.SelectedRows[0].Cells[0].Value.ToString())
                                           );

                dataGridView1_RowEnter(null,null);
                Mostrar(dataGridView4, empresa.RetornaListaAutoGrilla4());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count==0) { dataGridView3.DataSource=null; throw new Exception(); }
                Mostrar(dataGridView3, empresa.RetornaListaAutosDePersona(new Persona(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));

            }
            catch (Exception)
            {

             
            }
        }
    }
}
