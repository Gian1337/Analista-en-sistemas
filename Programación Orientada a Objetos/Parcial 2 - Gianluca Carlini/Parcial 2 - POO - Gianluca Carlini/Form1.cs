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

namespace Parcial_2___POO___Gianluca_Carlini
{
    public partial class Form1 : Form
    {
        Club club;
        Pago _pago;
        VistaCuotasPendientes vistaCuotasPendientes;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            club = new Club();
            vistaCuotasPendientes = new VistaCuotasPendientes();
            _pago = new Pago();

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.MultiSelect = false;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.MultiSelect = false;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            radioButton1.Checked = true;

            _pago.PagoExcedente += delegate (object o, Pago.PagoExcedenteEventArgs pe)
            {
                MessageBox.Show($"El monto total a pagar es de más de $10.000. \n Valor total: ${pe.Pago_total}");
            };
        }

        public void Mostrar(DataGridView pDgv, Object pObject)
        {
            pDgv.DataSource = null;
            pDgv.DataSource = pObject;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                Socio socio = new Socio();

                string legajo = Interaction.InputBox("Ingrese un número de legajo: ", "Legajo");
                socio.Legajo = legajo;

                string nombre = Interaction.InputBox("Ingrese un nombre: ", "Nombre");
                socio.Nombre = nombre;

                string apellido = Interaction.InputBox("Ingrese un apellido: ", "Apellido");
                socio.Apellido = apellido;

                club.AgregaSocio(socio);
                Mostrar(dataGridView1, club.RetornaListaSocios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.Rows.Count == 0)
                {
                    throw new Exception("Debe seleccionar un socio");
                }
                Socio socio_aux = (Socio)dataGridView1.SelectedRows[0].DataBoundItem;
                club.BorraSocio(socio_aux);
                Mostrar(dataGridView1, club.RetornaListaSocios());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Socio saux = (Socio)dataGridView1.SelectedRows[0].DataBoundItem;

                saux.Nombre = Interaction.InputBox("Nombre:", saux.Nombre);
                saux.Apellido = Interaction.InputBox("Nombre:", saux.Apellido);

                club.ModificaSocio(saux);
                Mostrar(dataGridView1, club.RetornaListaSocios());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    Socio socio_aux = (Socio)dataGridView1.SelectedRows[0].DataBoundItem;
                    Mostrar(dataGridView2, vistaCuotasPendientes.CuotasPendientesSocios(socio_aux, club.RetornaListaSocios()));
                    Mostrar(dataGridView3, ShowGrid3LQ());
                    Mostrar(dataGridView4, ShowGrid4LQ());
                    Mostrar(dataGridView5, ShowGrid5LQ());

                }
                else
                {
                    dataGridView3.DataSource = null;
                    dataGridView4.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarCuota_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count == 1)
                { 
                    Cuota cuota = null;
                    Socio socio_aux = (Socio)dataGridView1.SelectedRows[0].DataBoundItem;

                    int cont = socio_aux.listacuotas.Count();
                    if (cont < 2)
                    {
                        int opcionCuota = 0;
                        string opcionTipoCuota = Interaction.InputBox("Ingrese el tipo de cobro\n1. Cuota Normal\n2. Cuota Especial");
                        opcionCuota = int.Parse(opcionTipoCuota);

                        if (opcionCuota > 0 && opcionCuota < 3)
                        {
                            switch (opcionCuota)
                            {
                                case 1:
                                    cuota = new CuotaNormal();
                                    break;
                                case 2:
                                    cuota = new CuotaEspecial();
                                    break;
                            }
                        }
                        else
                        {
                            throw new Exception("Sólo puede elegir la opción 1 ó 2.");
                        }


                        string codigo = Interaction.InputBox("Ingrese el código de la cuota: ", "Código de Cuota");
                        cuota.Codigo = codigo;

                        DateTime fechaemitida = Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de emisión de la cuota:", "Fecha Emisión"));
                        cuota.FechaEmitida = fechaemitida;

                        DateTime fechavencimiento = Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de vencimiento de la cuota: ", "Fecha Vencimiento"));
                        if (fechavencimiento < fechaemitida)
                        {
                            throw new Exception("La fecha de vencimiento no puede ser anterior a la fecha emitida");
                        }
                        else
                        {
                            cuota.FechaVencimiento = fechavencimiento;
                        }

                        decimal importe = decimal.Parse(Interaction.InputBox("Ingrese el importe de la cuota: ", "Monto"));
                        cuota.Importe = importe;

                        club.AgregaCuota(cuota);
                        club.AsignaCuota(cuota, socio_aux);
                        Mostrar(dataGridView2, vistaCuotasPendientes.CuotasPendientesSocios(socio_aux, club.RetornaListaSocios()));
                    }
                    else
                    {
                        throw new Exception("No se pueden asignar más de 2 cuotas");
                    }
                }
                else
                {
                    throw new Exception("Seleccione un socio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count == 1 && dataGridView2.SelectedRows.Count == 1)
                {
                    Socio socio_aux = (Socio)dataGridView1.SelectedRows[0].DataBoundItem;
                    Cuota cuota_seleccionada = club.RetornaCuota(socio_aux, (VistaCuotasPendientes)dataGridView2.SelectedRows[0].DataBoundItem);

                    int diasExcedidos = 0;
                    decimal intereses = 0;
                    decimal importe = cuota_seleccionada.Importe;

                    DateTime fechaPagoCuota = Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de pago: ", "Fecha de pago"));
                    if(cuota_seleccionada.FechaVencimiento >= fechaPagoCuota)
                    {
                        MessageBox.Show("No tiene infracción");
                    }else if(cuota_seleccionada.FechaVencimiento < fechaPagoCuota)
                    {
                        diasExcedidos = (fechaPagoCuota - cuota_seleccionada.FechaVencimiento).Days;
                        MessageBox.Show($"Se ha pagado {diasExcedidos} días post fecha de vencimiento");
                    }
                    intereses = cuota_seleccionada.ObtenerIntereses(importe, diasExcedidos);
                    decimal total = importe + intereses;

                    Pago pago = new Pago
                    {
                        Codigo = cuota_seleccionada.Codigo,
                        FechaPago = fechaPagoCuota,
                        ImporteTotal = total,
                        Socio = cuota_seleccionada.Socio
                    };

                    _pago.Codigo = pago.Codigo;
                    _pago.FechaPago = pago.FechaPago;
                    _pago.ImporteTotal = pago.ImporteTotal;
                    _pago.Socio = pago.Socio;

                    string msj = $"Importe a Pagar: ${importe}\nIntereses por Días Excedidos: ${intereses}\nTotal: ${total}";

                    var msjbox = MessageBox.Show(msj, "¿Desea abonar ahora?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(msjbox == DialogResult.Yes)
                    {
                        club.EliminarCuota(cuota_seleccionada, socio_aux);
                        club.AsignaPagoSocio(socio_aux, pago);
                        club.AgregaPagos(pago);
                        Mostrar(dataGridView2, vistaCuotasPendientes.CuotasPendientesSocios(socio_aux, club.RetornaListaSocios()));
                        Mostrar(dataGridView3, ShowGrid3LQ());
                        Mostrar(dataGridView4, ShowGrid4LQ());
                        Mostrar(dataGridView5, ShowGrid5LQ());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public object ShowGrid3LQ()
        {
            Socio socio_aux = (Socio)dataGridView1.SelectedRows[0].DataBoundItem;

            return (from pago in club.RetornaListaPagos(socio_aux)
                    select new
                    {
                        Codigo = pago.Codigo,
                        FechaPago = pago.FechaPago,
                        Importe = pago.ImporteTotal,
                        Socio = pago.Socio.Nombre
                    } 
                    ).ToList();
        }

        public object ShowGrid4LQ()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Socio socio_aux = (Socio)this.dataGridView1.SelectedRows[0].DataBoundItem;

                try
                {
                    if(radioButton1.Checked == true)
                    {
                        socio_aux.listapagos = socio_aux.RetornaLPagos();
                        socio_aux.listapagos.Sort(new Pago.PagoAscendente());
                        return (from pago in socio_aux.RetornaLPagos()
                                select new
                                {
                                    Codigo = pago.Codigo,
                                    Vencimiento = pago.FechaPago,
                                    Importe = pago.ImporteTotal,
                                    Socio = pago.Socio.Nombre
                                }).ToList();
                    }else if(radioButton2.Checked == true)
                    {
                        socio_aux.listapagos = socio_aux.RetornaLPagos();
                        socio_aux.listapagos.Sort(new Pago.PagoDescendente());
                        return (from pago in socio_aux.RetornaLPagos()
                                select new
                                {
                                    Codigo = pago.Codigo,
                                    Vencimiento = pago.FechaPago,
                                    Importe = pago.ImporteTotal,
                                    Socio = pago.Socio.Nombre
                                }).ToList();
                    }
                    return socio_aux;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return null;
        }

        public object ShowGrid5LQ()
        {
            return (from pago in club.RetornaPagosTotal()
                    select new
                    {
                        Socio = pago.Socio.Nombre,
                        Importe = pago.ImporteTotal
                    }).ToList();
        }
    }
}
