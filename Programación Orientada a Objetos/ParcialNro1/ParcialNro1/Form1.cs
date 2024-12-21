using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ParcialNro1
{
    public partial class Form1 : Form
    {
        Empresa empresa;
        List<Adelanto> listaAdelantos;
        public Form1()
        {
            InitializeComponent();
            empresa = new Empresa();
            listaAdelantos = new List<Adelanto>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Empleado> lista_empleados = new List<Empleado>();

        private void Mostrar(DataGridView pDGV, object pO)
        {
            pDGV.DataSource = null; pDGV.DataSource = pO;
            if (pDGV.Name == "dgvAdel")
            {
                pDGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                pDGV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
        }

        private void btnAddBen_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = Interaction.InputBox("Ingrese Legajo: ");
                //Validación de LEGAJO. Ejemplo: ABCD123a
                var re = new Regex(@"[A-Z]\d{3}[a-z]");
                if (!re.IsMatch(legajo)) throw new Exception("El legajo no posee el formato correcto");

                string nombre = Interaction.InputBox("Ingrese Nombre: ");
                string apellido = Interaction.InputBox("Ingrese Apellido: ");
                string sueldo = Interaction.InputBox("Ingrese sueldo: ");
                int.Parse(sueldo);

                Empleado emp = null;

                switch (true)
                {
                    case bool isChecked when radioButton1.Checked:
                        emp = new Operario();
                        break;
                    case bool isChecked when radioButton2.Checked:
                        emp = new Administrativo();
                        break;
                    case bool isChecked when radioButton3.Checked:
                        emp = new Ejecutivo();
                        break;
                    default:
                        emp = null;
                        break;
                }

                //Carga del estado al empleado
                emp.Legajo = legajo;
                emp.Nombre = nombre;
                emp.Apellido = apellido;
                emp.Sueldo = int.Parse(sueldo);

                lista_empleados.Add(emp);

                dgvBen.DataSource = null;
                dgvBen.DataSource = lista_empleados;
                
            }

 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBen.Rows.Count == 0) throw new Exception("Debe seleccionar un empleado para su modificación");

                Empleado emp = dgvBen.SelectedRows[0].DataBoundItem as Empleado;

                emp.Nombre = Interaction.InputBox("Nombre: ", emp.Nombre);
                emp.Apellido = Interaction.InputBox("Apellido: ", emp.Apellido);
                string sueldo = Interaction.InputBox("Sueldo: ");
                emp.Sueldo = int.Parse(sueldo);

                empresa.ModificarEmpleado(emp);

                dgvBen.DataSource = null;
                dgvBen.DataSource = lista_empleados;


            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            try
            {
            if (dgvBen.Rows.Count == 0) throw new Exception("No hay socios para eliminar");
            empresa.BorrarEmpleado(dgvBen.SelectedRows[0].DataBoundItem as Empleado);
            Mostrar(dgvBen, empresa.RetornaEmpleado());
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddAdel_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = Interaction.InputBox("Ingrese el código del adelanto: ");
                if (empresa.RetornaAdelanto().Exists(x => x.Codigo == codigo)) throw new Exception("No puede ingresar un código ya existente.");

                string fechaOtorgamiento = Interaction.InputBox("Ingrese la fecha del adelanto: ");
                if (!Information.IsDate(fechaOtorgamiento)) throw new Exception("Fecha de ingreso inválida.");

                string fechaDevolucion = Interaction.InputBox("Ingresa la fecha de cancelación del adelanto: ");
                if (!Information.IsDate(fechaDevolucion)) throw new Exception("Fecha de ingreso inválida.");

                string importe = Interaction.InputBox("Ingrese el importe del adelanto: ");

                string importeAbonado = Interaction.InputBox("Ingrese el importe abonado del adelanto: ");

              


                Adelanto adelanto = null;
                

                switch (true)
                {
                    case bool isChecked when radioButton1.Checked:
                        adelanto = new AdelantoOperario();
                        adelanto.CalcularBeneficio(decimal.Parse(importe));
                        break;
                    case bool isChecked when radioButton2.Checked:
                        adelanto = new AdelantoAdministrativo();
                        adelanto.CalcularBeneficio(decimal.Parse(importe));
                        break;
                    case bool isChecked when radioButton3.Checked:
                        adelanto = new AdelantoEjecutivo();
                        adelanto.CalcularBeneficio(decimal.Parse(importe));
                        break;
                    default:
                        adelanto = null;
                        break;
                }

                adelanto.Codigo = codigo;
                adelanto.FechaOtorgamiento = DateTime.Parse(fechaOtorgamiento);
                adelanto.FechaDevolucion = DateTime.Parse(fechaDevolucion);
                adelanto.Importe = decimal.Parse(importe);
                adelanto.ImporteAbonado = decimal.Parse(importeAbonado);
                adelanto.Beneficio = adelanto.CalcularBeneficio(adelanto.Importe);
                adelanto.SaldoAdeudado = decimal.Parse(importe) - decimal.Parse(importeAbonado);
                

               empresa.AgregarAdelanto(adelanto);


                listaAdelantos = empresa.RetornaAdelanto();
                dgvAdel.DataSource = null;
                dgvAdel.DataSource = listaAdelantos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {

            try
            {
                Empleado empleado = (Empleado)dgvBen.CurrentRow.DataBoundItem;
                Adelanto adelanto = (Adelanto)dgvAdel.CurrentRow.DataBoundItem;

                empleado.AsignarAdelanto(adelanto);

                dgvBenAdel.DataSource = null;
                dgvBenAdel.DataSource = empleado.lista_adelantos;
               
                
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
