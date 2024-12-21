using BE;
using BLL;
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UI
{
    public partial class FormGestorClientes : Form
    {
        public FormGestorClientes()
        {
            InitializeComponent();
            this.dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            oBLLCliente = new BLLCliente();
            oBECliente = new BECliente();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        BECliente oBECliente;
        BLLCliente oBLLCliente;
        BLLBitacora oBLLBitacora;

        private void FormGestorClientes_Load(object sender, EventArgs e)
        {
            CargarDataGridClientes();
            TextBoxModoLectura(true);
            this.buttonModificar.Enabled = false;
            this.buttonBorrar.Enabled = false;
            this.buttonGuardar.Enabled = false;
        }
        private void CargarDataGridClientes()
        {
            this.dataGridViewClientes.DataSource = null;
            this.dataGridViewClientes.DataSource = oBLLCliente.ListarTodo();
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBECliente = (BECliente)this.dataGridViewClientes.CurrentRow.DataBoundItem;
                this.buttonNuevo.Visible = true;
                this.buttonModificar.Enabled = true;
                this.buttonGuardar.Enabled = false;
                this.buttonBorrar.Enabled = true;
                this.buttonGuardar.Text = "Guardar";
                CargarDatosCliente();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CargarDatosCliente()
        {
            try
            {
                // Se cargan los datos del cliente en los textbox en modo lectura
                TextBoxModoLectura(true);
                this.textBoxNom.Text = oBECliente.Nombre;
                this.textBoxApel.Text = oBECliente.Apellido;
                this.textBoxNdni.Text = oBECliente.NroDocumento;
                this.textBoxTdni.Text = oBECliente.TipoDocumento;
                this.textBoxDir.Text = oBECliente.Direccion;
                this.textBoxDirE.Text = oBECliente.DireccionEntrega;
                this.textBoxEmail.Text = oBECliente.Email;
                this.textBoxTel.Text = oBECliente.Telefono;
                this.textBoxRS.Text = oBECliente.RazonSocial;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void TextBoxModoLectura(bool valor)
        {
            try
            {
                // Cada control se establece para solo lectura
                foreach (Control c in groupBoxDatosC.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).ReadOnly = valor;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Registrar")
                {
                    oBECliente = new BECliente();
                }
                foreach (Control c in groupBoxDatosC.Controls)
                {
                    if (c is TextBox)
                    {
                        if (((TextBox)c).Text == "")
                        {
                            MessageBox.Show("No puede haber datos vacios en la carga");
                            return;
                        }
                    }
                }
                oBECliente.Nombre = this.textBoxNom.Text;
                oBECliente.Apellido = this.textBoxApel.Text;
                oBECliente.NroDocumento = this.textBoxNdni.Text;
                oBECliente.TipoDocumento = this.textBoxTdni.Text;
                oBECliente.Direccion = this.textBoxDir.Text;
                oBECliente.DireccionEntrega = this.textBoxDirE.Text;
                oBECliente.Telefono = this.textBoxTel.Text;
                oBECliente.RazonSocial = this.textBoxRS.Text;
                oBECliente.Email = this.textBoxEmail.Text;

                // Verifico mediante expresion regular que el email este bien ingresado
                if (!Regex.IsMatch(oBECliente.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    throw new Exception("El email ingresado es incorrecto");
                }
                if(oBLLCliente.ListarTodo().Find(x => x.NroDocumento == oBECliente.NroDocumento) != null && oBLLCliente.ListarTodo().Find(x => x.NroDocumento == oBECliente.NroDocumento).Id != oBECliente.Id)
                {
                    throw new Exception("Ya existe un cliente con el numero de documento ingresado");
                }

                if (oBLLCliente.Guardar(oBECliente) == true)
                {
                    if (oBECliente.Id == 0)
                    {
                        MessageBox.Show("Cliente registrado!");
                        oBLLBitacora.Log(UsuarioActual, $"Nuevo cliente registrado ({oBECliente.Nombre} {oBECliente.Apellido})");
                    }
                    else
                    {
                        MessageBox.Show("Cliente modificado!");
                        oBLLBitacora.Log(UsuarioActual, $"Cliente modificado ({oBECliente.Nombre} {oBECliente.Apellido})");
                        this.buttonNuevo.Visible = true;
                    }
                    CargarDataGridClientes();
                    LimpiarTxtBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarTxtBox()
        {
            try
            {
                // Limpia cada textbox luego de la carga
                foreach (Control c in groupBoxDatosC.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
                this.buttonGuardar.Text = "Registrar";
                this.buttonModificar.Enabled = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se ejecuta al querer modificar los datos de un cliente
                DialogResult dialog = MessageBox.Show("¿Seguro desea modificar el cliente?", "Info", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.buttonModificar.Enabled = false;
                    this.buttonGuardar.Enabled = true;
                    this.buttonGuardar.Text = "Guardar";
                    this.buttonNuevo.Visible = false;
                    this.buttonBorrar.Enabled = false;
                    TextBoxModoLectura(false);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarTxtBox();
                TextBoxModoLectura(false);
                this.buttonNuevo.Visible = false;
                this.buttonGuardar.Enabled = true;
                this.buttonGuardar.Text = "Registrar";
                this.buttonModificar.Enabled = false;
                this.buttonBorrar.Enabled = false;
            }
            catch (Exception) { }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("¿Seguro desea eliminar el cliente?", "Info", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    oBECliente = (BECliente)this.dataGridViewClientes.CurrentRow.DataBoundItem;
                    if (oBLLCliente.Borrar(oBECliente) == true)
                    {
                        MessageBox.Show("Cliente eliminado");
                        oBLLBitacora.Log(UsuarioActual, $"Cliente eliminado ({oBECliente.Nombre} {oBECliente.Apellido})");
                        LimpiarTxtBox();
                        CargarDataGridClientes();
                        this.buttonBorrar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("El cliente no puede ser eliminado ya que dispone de pedidos realizados");
                        LimpiarTxtBox();
                        this.buttonBorrar.Enabled = false;
                    }
                }


            }
            catch (Exception ex) { throw ex; }
        }
    }
}
