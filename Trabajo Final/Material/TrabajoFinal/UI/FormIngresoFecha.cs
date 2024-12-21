using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormIngresoFecha : Form
    {
        public FormIngresoFecha()
        {
            InitializeComponent();
            this.FormClosing += VerificarFechaAntesDeCerrar;
        }
        public DateTime fechaSeleccionada = new DateTime();
        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                fechaSeleccionada = dateTimePicker1.Value;
            }
            catch (Exception ex) { throw ex; }
        }

        private void FormIngresoFecha_Load(object sender, EventArgs e)
        {

        }
        private void VerificarFechaAntesDeCerrar(object sender, FormClosingEventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Por favor, ingrese una fecha", "Alerta fecha requerida");
                e.Cancel = true;
            }
        }
    }
}
