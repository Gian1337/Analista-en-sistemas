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

namespace Resol_1P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            empresa = new Empresa();
        }
        Empresa empresa;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string legajo, nombre, apellido, sueldo;
                legajo = Interaction.InputBox("Legajo: ");
                if (!Information.IsNumeric(legajo)) throw new Exception("El legajo debe ser numérico !!!");
                if(empresa.RetornaEmpleadosToList().Exists(x => x.Legajo == int.Parse(legajo))) throw new Exception("El legajo ya existe !!!"); ;
                nombre = Interaction.InputBox("Nombre: ");
                apellido = Interaction.InputBox("Apellido: ");
                sueldo = Interaction.InputBox("Sueldo: ");
                if (!Information.IsNumeric(sueldo)) throw new Exception("El sueldo debe ser numérico !!!");

                Empleado auxEmpleado = null;
                if (radioButton1.Checked) { auxEmpleado = new Director() { Legajo = int.Parse(legajo), Nombre = nombre,Apellido=apellido,Sueldo=decimal.Parse(sueldo) }; }
                if (radioButton2.Checked) { auxEmpleado = new Administrativo() { Legajo = int.Parse(legajo), Nombre = nombre, Apellido = apellido, Sueldo = decimal.Parse(sueldo) }; }
                if (radioButton3.Checked) { auxEmpleado = new Operario() { Legajo = int.Parse(legajo), Nombre = nombre, Apellido = apellido, Sueldo = decimal.Parse(sueldo) }; }

                empresa.AgregaEmpleado(auxEmpleado);
                Mostrar(dataGridView1, empresa.RetornaEmpleadosToArray());


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void Mostrar(DataGridView pDGV, Object pObject)
        {
            pDGV.DataSource = null;pDGV.DataSource = pObject;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {

             
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay empleados para borrar !!!");
                var auxSel = dataGridView1.CurrentRow;
                Empleado auxEmp = null;
                
                if (auxSel.Cells[4].Value.ToString() == "Operario") { auxEmp = new Operario(); }
                if (auxSel.Cells[4].Value.ToString() == "Administrativo") { auxEmp = new Administrativo(); }
                if (auxSel.Cells[4].Value.ToString() == "Director") { auxEmp = new Director(); }

                auxEmp.Legajo = int.Parse(auxSel.Cells[0].Value.ToString());
                auxEmp.Nombre = auxSel.Cells[1].Value.ToString();
                auxEmp.Apellido = auxSel.Cells[2].Value.ToString();
                auxEmp.Sueldo = decimal.Parse(auxSel.Cells[3].Value.ToString());

                empresa.BorraEmpleado(auxEmp);

                Mostrar(dataGridView1, empresa.RetornaEmpleadosToArray());


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
            if (dataGridView1.Rows.Count == 0) throw new Exception("No hay empleados para borrar !!!");
             empresa.BorraEmpleado(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                Mostrar(dataGridView1, empresa.RetornaEmpleadosToArray());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
    }
}
