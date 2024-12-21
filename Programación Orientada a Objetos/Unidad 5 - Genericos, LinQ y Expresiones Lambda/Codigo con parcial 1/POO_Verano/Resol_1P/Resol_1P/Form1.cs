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
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            Mostrar(dataGridView2, empresa.RetornaAdelantosToArray());
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

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (!(dataGridView1.Rows.Count > 0 && dataGridView2.Rows.Count > 0)) throw new Exception("No existe empleado o Adelanto !!!");
                Empleado empaux=null;
                string tipo = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                if (tipo == "Director")
                {
                    empaux = new Director() { Legajo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value) };
                }
                else if (tipo == "Administrativo")
                {
                    empaux = new Administrativo() { Legajo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value) };

                }
                else
                {
                    empaux = new Operario() { Legajo = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value) };
                }

                Adelanto adeaux = new Adelanto() { Codigo = dataGridView2.SelectedRows[0].Cells[0].Value.ToString() };
                empresa.AsignarAdelanto(empaux, adeaux);
                Mostrar(dataGridView3, (empresa.ReotrnaEmpleado(Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value))).RetornaAdelantos());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Mostrar(dataGridView3, (empresa.ReotrnaEmpleado(Convert.ToInt16(dataGridView1.SelectedRows[0].Cells[0].Value))).RetornaAdelantos());

            }
            catch (Exception) { }
        }
    }
}
