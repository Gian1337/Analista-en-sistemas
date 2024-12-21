using BE;
using BLL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UI
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
            this.dataGridViewEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLUsuario = new BLLEmpleado();
            oBEUsuario = new BEEmpleado();
            oBLLOrdenProduccion = new BLLOrdenProduccion();
        }
        public BEEmpleado UsuarioEmpleado { get; set; }
        BEEmpleado oBEUsuario;
        BLLEmpleado oBLLUsuario;
        BLLOrdenProduccion oBLLOrdenProduccion;
        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            CargarDataGridEmpleados();
        }
        private void CargarDataGridEmpleados()
        {
            try
            {
                // Se listan los empleados del sector de produccion
                this.dataGridViewEmpleados.DataSource = null;
                this.dataGridViewEmpleados.DataSource = oBLLUsuario.ListarTodo().FindAll(x => x.Sector == "Produccion" && x.Sector != "");
                this.dataGridViewEmpleados.Columns.Remove("NombreUsuario");
                this.dataGridViewEmpleados.Columns.Remove("Password");
            }
            catch (Exception ex) { throw ex; }
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEUsuario = (BEEmpleado)this.dataGridViewEmpleados.CurrentRow.DataBoundItem;
                this.buttonAsignar.Enabled = true;
                this.groupBoxInfo.Visible = true;

                // Se listan las ordenes asignadas al empleado seleccionado
                List<BEOrdenProduccion> ListaOrdenesEmpleado = oBLLOrdenProduccion.ListarTodo();
                if(ListaOrdenesEmpleado != null)
                {
                    ListaOrdenesEmpleado = ListaOrdenesEmpleado.FindAll(x => x.Empleado != null && x.Empleado.Id == oBEUsuario.Id);
                    this.labelCantTrabajos.Text = ListaOrdenesEmpleado.Count.ToString();
                    listBoxOrdenesEmp.Items.Clear();
                    if (ListaOrdenesEmpleado != null)
                    {

                        foreach (BEOrdenProduccion orden in ListaOrdenesEmpleado)
                        {
                            this.listBoxOrdenesEmp.Items.Add($"Orden {orden.Numero} - Fecha {orden.Fecha.ToString("dd/MM/yyyy")} - Producto: {orden.Producto.Nombre} ({orden.Cantidad} unidades)");
                        }
                    }
                }
            }
            catch (Exception) { throw; }
        }
        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioEmpleado = oBEUsuario;
            }
            catch (Exception) { throw; }
        }
    }
}
