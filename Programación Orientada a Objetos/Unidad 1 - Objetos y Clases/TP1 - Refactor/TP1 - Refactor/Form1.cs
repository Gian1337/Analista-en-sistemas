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

namespace TP1___Refactor
{
    public partial class Form1 : Form
    {
        List<Concesionario> _concesionarios;
        public Form1()
        {
            InitializeComponent();
            _concesionarios = new List<Concesionario>();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = Interaction.InputBox("Ingrese el DNI: ");
                string nombre = Interaction.InputBox("Ingrese el nombre: ");
                string apellido = Interaction.InputBox("Ingrese el apellido: ");
                string patente, marca, modelo, año, precio;
                GetDataAuto(out patente, out marca, out modelo,out año, out precio);


                _concesionarios.Add(new Concesionario(dni, nombre, apellido, patente, marca, modelo, año, decimal.Parse(precio)));

                List<Persona> lp = new List<Persona>();
                foreach (Concesionario c in _concesionarios)
                {
                    lp.Add(c.RetornarPersona);
                }

                dgvP.DataSource = null;
                dgvP.DataSource = lp;
                dgvP_RowEnter(null, null);


            }
            catch (Exception error)
            {
                 MessageBox.Show(error.Message);
            }
        }

        private void GetDataAuto(out string patente, out string marca, out string modelo, out string año, out string precio)
        {
             patente = Interaction.InputBox("Ingrese la patente: ");
             marca = Interaction.InputBox("Ingrese la marca: ");
             modelo = Interaction.InputBox("Ingrese el modelo: ");
             año = Interaction.InputBox("Ingrese el año: ");
            precio = Interaction.InputBox("Ingrese el precio - €: ");
             
        }

        private void dgvP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Concesionario c = RecuperarConsGrilla1();
                dgvA.DataSource = null;
                dgvA.DataSource = c.RetornarAuto();
                GetTotal(c);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private Concesionario RecuperarConsGrilla1()
        {
            Persona p = (dgvP.SelectedRows[0].DataBoundItem as Persona);
            var c = _concesionarios.Find(x => x.RetornarPersona.DNI == p.DNI && x.RetornarPersona.Nombre == p.Nombre && x.RetornarPersona.Apellido == p.Apellido);
            return c;
        }

        private void GetTotal(Concesionario c)
        {
            txtTotal.Text = c.Total().ToString();
        }
        private void btnAddA_Click(object sender, EventArgs e)
        {
            try
            {
                Concesionario c = RecuperarConsGrilla1();
                string patente, marca, modelo, año, precio;

                GetDataAuto(out patente, out marca, out modelo, out año, out precio);

                c.AgregarAuto(patente, marca, modelo, año, decimal.Parse(precio));
                dgvA.DataSource = null;
                dgvA.DataSource = c.RetornarAuto();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvP.MultiSelect = false;
            dgvP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  
        }

        private void btnRemoveP_Click(object sender, EventArgs e)
        {
            if(dgvP.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvP.SelectedRows[0];
                Persona persona = (Persona)filaSeleccionada.DataBoundItem;

                List<Persona> lp = new List<Persona>();
                lp.Remove(persona);

                dgvP.DataSource = null;
                dgvP.DataSource = lp;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnRemoveA_Click(object sender, EventArgs e)
        {
            if(dgvA.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvA.SelectedRows[0];
                Auto auto = (Auto)filaSeleccionada.DataBoundItem;

                List<Auto> la = new List<Auto>();
                la.Remove(auto);

                dgvA.DataSource = null;
                dgvA.DataSource = la;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un auto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
