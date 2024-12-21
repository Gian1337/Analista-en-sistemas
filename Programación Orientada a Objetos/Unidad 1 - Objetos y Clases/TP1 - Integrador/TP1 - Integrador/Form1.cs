using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TP1___Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarPersonas_Click(object sender, EventArgs e)
        {
            string nombre = txtNom.Text;
            string apellido = txtAp.Text;
            string dni = txtdoc.Text;

            Persona nueva_persona = new Persona(dni, nombre, apellido);

            grillaPersona.Columns.Add("dni", "DNI");
            grillaPersona.Columns.Add("nombre", "Nombre");
            grillaPersona.Columns.Add("apellido", "Apellido");

            grillaPersona.Rows.Add(nueva_persona.DNI, nueva_persona.Nombre, nueva_persona.Apellido);
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            if (grillaPersona.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = grillaPersona.SelectedRows[0];
                grillaPersona.Rows.Remove(filaSeleccionada);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una persona");
            }
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            string patente = txtPatente.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string año = txtAño.Text;
            decimal precio = Decimal.Parse(txtPrecio.Text);

            Auto nuevo_auto = new Auto(patente, marca, modelo, año, precio);

            grillaAutos.Columns.Add("patente", "Patente");
            grillaAutos.Columns.Add("marca", "Marca");
            grillaAutos.Columns.Add("modelo", "Modelo");
            grillaAutos.Columns.Add("año", "Año");
            grillaAutos.Columns.Add("precio", "Precio - €");

            grillaAutos.Rows.Add(nuevo_auto.Patente, nuevo_auto.Marca, nuevo_auto.Modelo, nuevo_auto.Año, nuevo_auto.Precio);

        }

        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            if (grillaAutos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = grillaAutos.SelectedRows[0];
                grillaAutos.Rows.Remove(filaSeleccionada);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un auto");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //string nombre = txtNom.Text;
            //string apellido = txtAp.Text;
            //string dni = txtdoc.Text;
            //string patente = txtPatente.Text;
            //string marca = txtMarca.Text;
            //string modelo = txtModelo.Text;
            //string año = txtAño.Text;
            //decimal precio = Decimal.Parse(txtPrecio.Text);

            //Concesionario cliente = new Concesionario(dni, nombre, apellido, patente, marca, modelo, año, precio);
            //grillaAutosxPers.Columns.Add("DNI", "DNI");
            //grillaAutosxPers.Columns.Add("Nombre", "Nombre");
            //grillaAutosxPers.Columns.Add("Apellido", "Apellido");
            //grillaAutosxPers.Columns.Add("patente", "Patente");
            //grillaAutosxPers.Columns.Add("marca", "Marca");
            //grillaAutosxPers.Columns.Add("modelo", "Modelo");
            //grillaAutosxPers.Columns.Add("año", "Año");
            //grillaAutosxPers.Columns.Add("precio", "Precio - €");

            //grillaAutosxPers.Rows.Add(cliente._persona.DNI,cliente._persona.Nombre,cliente._persona.Apellido,cliente._autos.Patente,cliente._autos.Marca,cliente._autos.Modelo,cliente._autos.Año,cliente._autos.Precio);

            string nombre = txtNom.Text;
            string apellido = txtAp.Text;
            string dni = txtdoc.Text;
            string patente = txtPatente.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string año = txtAño.Text;
            decimal precio;

            if (!Decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Concesionario cliente = new Concesionario(dni, nombre, apellido, patente, marca, modelo, año, precio);
            List<Concesionario> concesionarios = new List<Concesionario>() { cliente };

            
                //grillaAutosxPers.Columns.Clear();
                //grillaAutosxPers.Rows.Clear();

            grillaAutosxPers.Columns.Add("DNI", "DNI");
            grillaAutosxPers.Columns.Add("Nombre", "Nombre");
            grillaAutosxPers.Columns.Add("Apellido", "Apellido");
            grillaAutosxPers.Columns.Add("patente", "Patente");
            grillaAutosxPers.Columns.Add("marca", "Marca");
            grillaAutosxPers.Columns.Add("modelo", "Modelo");
            grillaAutosxPers.Columns.Add("año", "Año");
            grillaAutosxPers.Columns.Add("precio", "Precio - €");

            foreach (Concesionario concesionario in concesionarios)
            {
                grillaAutosxPers.Rows.Add(concesionario._persona.DNI, concesionario._persona.Nombre, concesionario._persona.Apellido, concesionario._autos.Patente, concesionario._autos.Marca, concesionario._autos.Modelo, concesionario._autos.Año, concesionario._autos.Precio);
            }


        }


        private void btnModificarPers_Click(object sender, EventArgs e)
        {

            DataGridViewRow filaSeleccionada = grillaPersona.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();

            if (filaSeleccionada != null)
            {
                
                string dni = filaSeleccionada.Cells["DNI"].Value?.ToString() ?? string.Empty;
                string nombre = filaSeleccionada.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                string apellido = filaSeleccionada.Cells["Apellido"].Value?.ToString() ?? string.Empty;

                // Verificar que los datos tengan el formato adecuado
                if (Regex.IsMatch(txtdoc.Text, @"\d{8}") && !string.IsNullOrWhiteSpace(txtNom.Text) && !string.IsNullOrWhiteSpace(txtAp.Text))
                {
                    filaSeleccionada.Cells["DNI"].Value = txtdoc.Text;
                    filaSeleccionada.Cells["Nombre"].Value = txtNom.Text;
                    filaSeleccionada.Cells["Apellido"].Value = txtAp.Text;
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = grillaAutos.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();


            if (filaSeleccionada != null)
            {
                string patente = filaSeleccionada.Cells["Patente"].Value?.ToString() ?? string.Empty;
                string marca = filaSeleccionada.Cells["Marca"].Value?.ToString() ?? string.Empty;
                string modelo = filaSeleccionada.Cells["Modelo"].Value?.ToString() ?? string.Empty;
                string año = filaSeleccionada.Cells["Año"].Value?.ToString() ?? string.Empty;
                decimal precio = 0;
                bool esPrecioValido = filaSeleccionada.Cells["Precio"].Value != null && decimal.TryParse(filaSeleccionada.Cells["Precio"].Value.ToString(), out precio);


                if (Regex.IsMatch(txtPatente.Text, @"\d{8}") && !string.IsNullOrWhiteSpace(txtMarca.Text) && !string.IsNullOrWhiteSpace(txtModelo.Text) && !string.IsNullOrEmpty(txtAño.Text) && esPrecioValido)
                {
                    filaSeleccionada.Cells["Patente"].Value = txtPatente.Text;
                    filaSeleccionada.Cells["Marca"].Value = txtMarca.Text;
                    filaSeleccionada.Cells["Modelo"].Value = txtModelo.Text;
                    filaSeleccionada.Cells["Año"].Value = txtAño.Text;
                    filaSeleccionada.Cells["Precio"].Value = precio;
                }
                else
                {
                    MessageBox.Show("Los datos ingresados no son válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
