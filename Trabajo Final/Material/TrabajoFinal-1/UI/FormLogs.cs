using BE;
using BLL;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace UI
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
            oBLLBitacora = new BLLBitacora();
        }
        BLLBitacora oBLLBitacora;

        private void FormLogs_Load(object sender, EventArgs e)
        {
            CargarLogs();
        }
        private void CargarLogs()
        {
            try
            {
                foreach (BEBitacora b in oBLLBitacora.ListarTodo().OrderByDescending(x => x.Fecha).ToList())
                {
                    if(b.UsuarioEmpleado != null)
                    {
                        listBoxLogs.Items.Add($"{b.Fecha} - {b.Evento} - Actor: {b.UsuarioEmpleado.NombreUsuario}");
                    }
                    else
                    {
                        listBoxLogs.Items.Add($"{b.Fecha} - {b.Evento} - Actor: Usuario eliminado");
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
