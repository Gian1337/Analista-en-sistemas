using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            oBLLPermiso = new BLLPermiso();
            oBEEmpleadoUser = new BEEmpleado();
        }
        public BEEmpleado oBEEmpleadoUser;
        BLLPermiso oBLLPermiso;
        private void FormPruebas_Load(object sender, EventArgs e)
        {
            oBEEmpleadoUser.listaPermisos = oBLLPermiso.ListarPermisosUsuario(oBEEmpleadoUser);
            CargarToolStripPorPermisos();
        }

        public void CargarToolStripPorPermisos()
        {
            List<string> listaPermisos = new List<string>();

            foreach (BEComponente c in oBEEmpleadoUser.listaPermisos)
            {
                if (c is BERol)
                {
                    foreach (BEComponente permiso in c.ObtenerHijos())
                    {
                        listaPermisos.Add(permiso.Nombre);
                    }
                }
                else
                {
                    listaPermisos.Add(c.Nombre);
                }
            }

            // cargamos los botones de acuerdo a los permisos
            foreach (ToolStripDropDownItem i in toolStripMenu.Items)
            {
                bool tienePermisos = false;
                foreach (ToolStripMenuItem t in i.DropDownItems)
                {
                    if (t is ToolStripMenuItem)
                    {
                        if (listaPermisos.Contains(t.Text.ToString()))
                        {
                            t.Visible = true;
                            tienePermisos = true;
                        }
                        else
                        {
                            t.Visible = false;
                        }
                    }
                }
                if (!tienePermisos)
                {
                    i.Visible = false;
                }
                else
                {
                    i.Visible = true;
                }
            }

            toolStripArchivo.Visible = true;
            // Habilito para que se vean todos los items del item Archivo
            foreach (ToolStripMenuItem c in toolStripArchivo.DropDownItems)
            {
                c.Visible = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Application.Exit();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void tomarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormTomarPedido form = new FormTomarPedido();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void generarOrdenDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGenerarOrdenEntrega form = new FormGenerarOrdenEntrega();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cumplirOrdenDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCumplirOrdenEntrega form = new FormCumplirOrdenEntrega();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void gestorDePermisosDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGestorPermisos form = new FormGestorPermisos();
                form.MdiParent = this;
                form.UsuarioActual= oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void gestorDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGestorUsuariosEmpleados form = new FormGestorUsuariosEmpleados();
                form.MdiParent = this;
                form.UsuarioActual = this.oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormBackup form = new FormBackup();
                form.MdiParent = this;
                form.UsuarioActual = this.oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormLogin form = new FormLogin();
                form.Show();
                form.FormClosing += loginCerrar;
            }
            catch (Exception) { throw; }
        }

        private void loginCerrar(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormLogs form = new FormLogs();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGenerarFactura form = new FormGenerarFactura();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void generarOrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGenerarOrdenProduccion form = new FormGenerarOrdenProduccion();
                form.MdiParent = this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void cumplirOrdenDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCumplirOrdenProduccion form = new FormCumplirOrdenProduccion();
                form.MdiParent = this;
                form.Empleado = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void controlarOrdenesDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormControlarOrdenesProduccion form = new FormControlarOrdenesProduccion();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void informaciónDeNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormInfoNegocio form = new FormInfoNegocio();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void finalizarOrdenDePedidoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormFinalizarPedidoMaterial form = new FormFinalizarPedidoMaterial();
                form.MdiParent= this;
                form.UsuarioActual = oBEEmpleadoUser;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void verPedidosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormVerPedidos form = new FormVerPedidos();
                form.MdiParent = this;
                form.Show();
            }
            catch(Exception) { throw; }
        }

        private void visualizarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormVisualizarStock form = new FormVisualizarStock();
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception) { throw; }
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGestorClientes form = new FormGestorClientes();
                form.UsuarioActual = oBEEmpleadoUser;
                form.MdiParent = this;
                form.Show();
            }
            catch (Exception) { throw; }
        }
    }
}
