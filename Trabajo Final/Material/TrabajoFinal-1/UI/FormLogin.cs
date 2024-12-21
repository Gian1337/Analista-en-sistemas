using BE;
using BLL;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            oBEEmpleadoUser = new BEEmpleado();
            oBLLUsuario = new BLLEmpleado();
            oBLLBitacora = new BLLBitacora();
        }
        BEEmpleado oBEEmpleadoUser;
        BLLEmpleado oBLLUsuario;
        BLLBitacora oBLLBitacora;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxUser.Text != String.Empty && textBoxPass.Text != String.Empty)
                {
                    oBEEmpleadoUser.NombreUsuario = textBoxUser.Text;
                    oBEEmpleadoUser.Password = textBoxPass.Text;
                    if (oBLLUsuario.VerificarDatos(oBEEmpleadoUser) == true)
                    {
                        MessageBox.Show("Se ha loggeado correctamente!");
                        oBEEmpleadoUser = oBLLUsuario.ListarTodo().Find(x => x.NombreUsuario == oBEEmpleadoUser.NombreUsuario);
                        oBLLBitacora.Log(oBEEmpleadoUser, "Se ha loggeado");
                        FormMenu form = new FormMenu();
                        form.oBEEmpleadoUser = oBEEmpleadoUser;
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña son incorrectos!");
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            this.textBoxPass.Text = "";
            this.textBoxPass.PasswordChar = char.Parse("*");
        }

        private void textBoxUser_Click(object sender, EventArgs e)
        {
            this.textBoxUser.Text = "";
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            this.textBoxPass.PasswordChar = char.Parse("*");
        }
    }
}
