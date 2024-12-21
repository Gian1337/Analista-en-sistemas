using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormGestorUsuariosEmpleados : Form
    {
        public FormGestorUsuariosEmpleados()
        {
            InitializeComponent();
            this.dataGridViewUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            oBLLEmpleado = new BLLEmpleado();
            oBEEmpleado = new BEEmpleado();
            oBLLBitacora = new BLLBitacora();
        }
        public BEEmpleado UsuarioActual;
        BLLEmpleado oBLLEmpleado;
        BEEmpleado oBEEmpleado;
        BLLBitacora oBLLBitacora;

        private void FormGestorUsuarios_Load(object sender, EventArgs e)
        {
            this.buttonVerPass.Enabled = false;
            this.Shown += Form_Shown;   
        }

        private void Form_Shown(object sender, EventArgs e)
        {
            CargarDataGridUsuarios();
        }

        private void CargarDataGridUsuarios()
        {
            try
            {
                List<BEEmpleado> listaUsuarios = oBLLEmpleado.ListarTodo();

                // borro el usuario con el que estoy loggeado
                listaUsuarios.Remove(listaUsuarios.Find(x => x.Id == UsuarioActual.Id));
                this.dataGridViewUsuarios.DataSource = null;
                this.dataGridViewUsuarios.DataSource = listaUsuarios;
                this.dataGridViewUsuarios.Columns.Remove("Password");
            }
            catch (Exception ex) { throw ex; }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarTextBoxVacios())
                {
                    if(buttonRegistrar.Text == "Registrar")
                    {
                        oBEEmpleado = new BEEmpleado();
                        oBEEmpleado.Nombre = textBoxNombre.Text;
                        oBEEmpleado.Apellido = textBoxApellido.Text;
                        oBEEmpleado.Sector = textBoxSector.Text;
                        if (oBLLEmpleado.ListarTodo().Find(x => x.NombreUsuario == textBoxNomUser.Text) == null)
                        {
                            oBEEmpleado.NombreUsuario = textBoxNomUser.Text;
                            if (textBoxPass.Text == textBoxPass2.Text)
                            {
                                oBEEmpleado.Password = textBoxPass.Text;
                                if (oBLLEmpleado.Guardar(oBEEmpleado) == true)
                                {
                                    MessageBox.Show("Se ha registrado correctamente el usuario");
                                    oBLLBitacora.Log(UsuarioActual, $"Registró un nuevo usuario ({oBLLEmpleado.ListarTodo().Last().NombreUsuario})");
                                    CargarDataGridUsuarios();
                                    LimpiarTxt();
                                }
                            }
                            else
                            {
                                throw new Exception("Las contraseñas ingresadas no coinciden");
                            }
                        }
                        else
                        {
                            throw new Exception("El nombre de usuario ingresado ya existe!");
                        }

                    }
                    else
                    {
                        oBEEmpleado.Nombre = textBoxNombre.Text;
                        oBEEmpleado.Apellido = textBoxApellido.Text;
                        oBEEmpleado.Sector = textBoxSector.Text;
                        string nombreAnterior = string.Empty;
                        bool cambioNombreUsuario = false;
                        if (oBEEmpleado.NombreUsuario != textBoxNomUser.Text)
                        {
                            if (oBLLEmpleado.ListarTodo().Exists(x => x.NombreUsuario == textBoxNomUser.Text) == false)
                            {
                                cambioNombreUsuario = true;
                                nombreAnterior = oBEEmpleado.NombreUsuario;
                                oBEEmpleado.NombreUsuario = textBoxNomUser.Text;
                            }
                            else
                            {
                                throw new Exception("El nombre de usuario ingresado ya existe!");
                            }
                        }
                        oBEEmpleado.NombreUsuario = textBoxNomUser.Text;
                        if (textBoxPass.Enabled == true && textBoxPass2.Enabled == true)
                        {
                            if (textBoxPass.Text == textBoxPass2.Text)
                            {
                                oBEEmpleado.Password = textBoxPass.Text;
                            }
                            else
                            {
                                throw new Exception("Las contraseñas ingresadas no coinciden");
                            }
                        }
                        if (oBLLEmpleado.Guardar(oBEEmpleado) == true)
                        {
                            MessageBox.Show("Se ha modificado correctamente el usuario");
                            oBLLBitacora.Log(UsuarioActual, $"Modifico al usuario ({oBEEmpleado.NombreUsuario})");
                            if (cambioNombreUsuario == true)
                            {
                                oBLLBitacora.Log(UsuarioActual, $"Cambio de nombre de usuario ({nombreAnterior} -> {oBEEmpleado.NombreUsuario})");
                            }
                            CargarDataGridUsuarios();
                            LimpiarTxt();
                            this.textBoxPass.Enabled = true;
                            this.textBoxPass2.Enabled = true;
                            this.textBoxPass.PasswordChar = '\0';
                            this.textBoxPass2.PasswordChar = '\0';
                            this.buttonNuevo.Enabled = false;
                            this.buttonBorrar.Enabled = false;
                            this.buttonRegistrar.Enabled = true;
                            this.buttonVerPass.Visible = false;
                            this.buttonModificar.Enabled = false;
                            this.buttonRegistrar.Enabled = true;
                            this.buttonRegistrar.Text = "Registrar";
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private bool VerificarTextBoxVacios()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (((TextBox)c).Text == "")
                    {
                        MessageBox.Show("No puede haber datos vacios en la carga");
                        return false;
                    }
                }
            }
            return true;
        }
        private void LimpiarTxt()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
            }
        }
        private void TextBoxModoLectura(bool valor)
        {
            try
            {
                // Cada control se establece para solo lectura
                foreach (Control c in groupBox1.Controls)
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

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oBEEmpleado = (BEEmpleado)this.dataGridViewUsuarios.CurrentRow.DataBoundItem;
                TextBoxModoLectura(true);
                this.textBoxNombre.Text = oBEEmpleado.Nombre;
                this.textBoxApellido.Text = oBEEmpleado.Apellido;
                this.textBoxNomUser.Text = oBEEmpleado.NombreUsuario;
                this.textBoxPass.Text = oBEEmpleado.Password;
                this.textBoxPass2.Text = oBEEmpleado.Password;
                this.textBoxSector.Text = oBEEmpleado.Sector;
                this.textBoxPass.PasswordChar = char.Parse("*");
                this.textBoxPass2.PasswordChar = char.Parse("*");
                this.textBoxPass.Enabled = false;
                this.textBoxPass2.Enabled = false;
                this.buttonModificar.Enabled = true;
                this.buttonVerPass.Enabled = true;
                this.buttonVerPass.Visible = true;
                this.buttonRegistrar.Enabled = false;
                this.buttonBorrar.Enabled = true;
                this.buttonNuevo.Enabled = true;

            }
            catch (Exception) { throw; }
        }

        private void buttonVerPass_Click(object sender, EventArgs e)
        {
            try
            {
                // Metodo para observar la contraseña del usuario del empleado
                this.textBoxPass.PasswordChar = '\0';
                this.textBoxPass2.PasswordChar = '\0';
                
                string password = oBLLEmpleado.DesenscriptarPassword(oBEEmpleado);
                this.textBoxPass.Text = password;
                this.textBoxPass2.Text = password;
            }
            catch (Exception) { throw; }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("¿Desea modificar el usuario seleccionado?", "Alerta", MessageBoxButtons.YesNo);

                if(dialog == DialogResult.Yes)
                {
                    TextBoxModoLectura(false);
                    this.buttonRegistrar.Enabled = true;
                    this.buttonRegistrar.Text = "Guardar";
                    this.buttonModificar.Enabled = false;
                    this.buttonNuevo.Enabled = false;
                    this.textBoxPass.Enabled = true;
                    this.textBoxPass2.Enabled = true;
                }
            }
            catch (Exception) { throw; }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("¿Desea eliminar el usuario?", "Alerta", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (oBLLEmpleado.Borrar(oBEEmpleado) == true)
                    {
                        MessageBox.Show("Usuario eliminado correctamente");
                        LimpiarTxt();
                        CargarDataGridUsuarios();
                        this.buttonModificar.Enabled = false;
                        this.buttonBorrar.Enabled = false;
                        this.textBoxPass.Enabled = true;
                        this.textBoxPass2.Enabled = true;
                        this.textBoxPass.PasswordChar = '\0';
                        this.textBoxPass2.PasswordChar = '\0';
                        this.buttonNuevo.Enabled = true;
                    }
                }
            }
            catch (Exception) { throw; }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarTxt();
                TextBoxModoLectura(false);
                this.textBoxPass.Enabled = true;
                this.textBoxPass2.Enabled = true;
                this.textBoxPass.PasswordChar = '\0';
                this.textBoxPass2.PasswordChar = '\0';
                this.buttonNuevo.Enabled = false;
                this.buttonBorrar.Enabled = false;
                this.buttonRegistrar.Enabled = true;
                this.buttonVerPass.Visible = false;
                this.buttonModificar.Enabled = false;
                this.textBoxSector.Enabled = true;
                this.buttonRegistrar.Text = "Registrar";
            }
            catch (Exception) { throw; }
        }
    }
}
