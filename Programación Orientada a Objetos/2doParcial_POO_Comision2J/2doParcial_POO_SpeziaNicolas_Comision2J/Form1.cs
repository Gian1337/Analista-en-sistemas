using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _2doParcial_POO_SpeziaNicolas_Comision2J
{
    public partial class Form1 : Form
    {
        Comercio comercio;
        Regex r;
        VistaCobroPendiente vistaCobros;
        Pago _pago;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _pago = new Pago();
            vistaCobros = new VistaCobroPendiente();
            comercio = new Comercio();
            //suscripcion al evento: asociado a una funcion anonima (delegado) que se dispara cuando el evento es satisfactoriamente invocado
            _pago.PagoMayor += delegate (object o, PagoMayorEventArgs ev)
            {
                MessageBox.Show($"¡¡¡El monto total del pago supera los $10000!!!\nEl valor final es de: ${ev.Pago_Total}.-"
                           , "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };

            radioButton1.Checked = true; //dejo pre-cargado el radiobutton en "encendido"

            // si no hay nada en la grilla 1, que "no existan" los botones de baja y modificacion.
            if (dataGridView1.SelectedRows.Count == 0) { btnBajaCliente.Visible = false; btnModifCliente.Visible = false; }
            ConfiguraGrilla(new List<DataGridView>() { dataGridView1, dataGridView2, dataGridView3, dataGridView4, dataGridView5 });

        }
        private void ConfiguraGrilla(List<DataGridView> _pLDGV) //CONFIGURACION VISUAL DE GRILLAS: CAMPOS AUTOAJUSTADOS Y SELECCION UNITARIA DE CELDAS
        {
            foreach (DataGridView _dataGridView in _pLDGV)
            {
                _dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //que este toda la fila seleccionada
                _dataGridView.MultiSelect = false; //para no dejar seleccionar mas de una fila.
                _dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                _dataGridView.EnableHeadersVisualStyles = false;
                _dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                _dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                _dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
                _dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
                _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //Si escribo mucho texto, la columna se ajusta automaticamente.
                _dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //los textos tengan una alineacion centrada.
            }
        }
        private void Mostrar_en_Grilla(DataGridView pDgv, Object pO) //Método que modificar valores de las grillas y devuelve valores actualizados. 
        {
            pDgv.DataSource = null;
            pDgv.DataSource = pO;
        }
        private void btnSalir_Click(object sender, EventArgs e) { Close(); }


        #region ABM CLIENTE
        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                int pLegajo = int.Parse(Interaction.InputBox("Ingresar Numero de legajo", "LEGAJO"));
                if (Information.IsNumeric(pLegajo)) //valido que el dato sea numerico
                {
                    if (!comercio.ValidarLegajoCliente(pLegajo)) 
                    { cliente.Legajo = pLegajo; } //validacion de legajo repetido
                    else 
                        throw new Exception("El legajo ya existe y su numero no puede ser tomado por otro cliente");
                }
                else
                    throw new Exception("Debe ingresar un valor numerico");

                string pNombre = Interaction.InputBox("Ingresar el nombre del cliente", "NOMBRE");

                r = new Regex(@"^[a-zA-Z]+$");

                if (!r.IsMatch(pNombre)) 
                { throw new Exception("Nombre INVALIDO!"); }
                else 
                    cliente.Nombre = pNombre;

                comercio.AgregarCliente(cliente);
                Mostrar_en_Grilla(dataGridView1, comercio.DevuelveListaClientes());
                btnBajaCliente.Visible = true; btnModifCliente.Visible = true; // Que aparezcan una vez que haya algo cargado en la grilla 1.
                dataGridView1_RowEnter(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay Clientes para borrar !!!"); //validacion de que exista algo en la grilla

                Cliente aux = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                comercio.EliminarCliente(aux);
                Mostrar_en_Grilla(dataGridView1, comercio.DevuelveListaClientes());
                if (dataGridView1.Rows.Count == 0) { btnBajaCliente.Visible = false; btnModifCliente.Visible = false; } //si ya borré todo, que vuelvan a desaparecer.
                dataGridView1_RowEnter(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModifCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) throw new Exception("No hay Clientes para modificar !!!"); //validacion de que exista algo en la grilla

                Cliente aux = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                aux.Nombre = Interaction.InputBox("Nombre: ", "Modificando...", aux.Nombre);

                comercio.ModificarCliente(aux);
                Mostrar_en_Grilla(dataGridView1, comercio.DevuelveListaClientes());
                dataGridView1_RowEnter(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        #endregion
        

        private void btnGenerarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1) //tiene que haber un cliente seleccionado
                {
                    Cobro cobro = null; //Lo pongo en null debido a la restricción de instancia en clase abstracta.
                    Cliente aux = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

                    int contador = aux.listaCobrosCliente.Count(); //Solo puedo tener como maximo 2 cobros pendientes
                    if (contador < 2)
                    {
                        int opcionCob = 0;
                        string opcionCobro = Interaction.InputBox("Ingrese el tipo de cobro\n1. Cobro Normal\n2. Cobro Especial");
                        opcionCob = int.Parse(opcionCobro);

                        if (opcionCob > 0 && opcionCob < 3) //valido que solo me deje elegir opcion 1 y 2 
                        {
                            switch (opcionCob)
                            {
                                case 1:
                                    cobro = new CobroNormal(); //Si la opcion es la "1" que cree la instancia tipo COBRO NORMAL
                                    break;
                                case 2:
                                    cobro = new CobroEspecial(); //Si la opcion es la "2" que cree la instancia tipo COBRO ESPECIAL
                                    break;
                            }
                        }
                        else
                            throw new Exception("No existe el tipo de Cobro: Solo 1 o 2!!!!");

                        int pCodigo = int.Parse(Interaction.InputBox("Ingresar un codigo de cobro", "CODIGO DE COBRO"));
                        if (Information.IsNumeric(pCodigo)) //valido el DATO NUMERICO
                        {
                            if (!comercio.ValidarCodigoCobro(pCodigo)) 
                            { cobro.Codigo = pCodigo; }
                            else
                                throw new Exception("El codigo ya existe, los mismos son unicos para cada cobro. Utilice otro número");
                        }

                        string pNombre = Interaction.InputBox("Ingresar el nombre de cobro", "NOMBRE DE COBRO");
                        r = new Regex(@"^[a-zA-Z]+$");
                        if (!r.IsMatch(pNombre)) 
                        { throw new Exception("Nombre INVALIDO!"); }
                        else 
                        { cobro.Nombre = pNombre; }

                        DateTime pFechaCobro = Convert.ToDateTime(Interaction.InputBox("Ingrese la fecha de vencimiento del cobro (DD/MM/AAAA)", "FECHA"));
                        if (Information.IsDate(pFechaCobro))  //valido que ponga una fecha el usuario y no otro tipo de dato
                        { cobro.Vencimiento = pFechaCobro; }

                        decimal pImporte = decimal.Parse(Interaction.InputBox("Ingrese el monto del cobro", "MONTO"));
                        if (Information.IsNumeric(pImporte)) 
                        { cobro.Importe = pImporte; }
                        else
                            throw new Exception("Monto INVALIDO!, solo numeros");

                        comercio.AgregarCobro(cobro);
                        comercio.AsignarCobro(aux, cobro);
                        Mostrar_en_Grilla(dataGridView2, vistaCobros.CobrosPendientesCliente(aux, comercio.DevuelveListaClientes()));
                    }
                    else
                        throw new Exception("Este cliente ya tiene asignados 2 cobros, ¡¡¡no se le puede agregar ninguno más!!!");
                }
                else
                {
                    throw new Exception("No hay ningun cliente seleccionado!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //public object MostrarGrilla2() //Hago un LINQ para que me tome todo el objeto y el nombre del cliente
        //{
        //    Cliente aux = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

        //    return (from cli in comercio.DevuelveListaCobrosAsignados(aux) //Hago un LINQ para que me tome todo el objeto y el nombre del cliente
        //            select new
        //            {
        //                Codigo = cli.Codigo,
        //                Nombre = cli.Nombre,
        //                Vencimiento = cli.Vencimiento,
        //                Importe = cli.Importe,
        //                Cliente = cli.RetornaCliente()==null?"--":cli.RetornaCliente().Nombre,
        //            }).ToList();
        //}

        private void btnPAGAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1 && dataGridView2.SelectedRows.Count == 1) //valido que el cliente tenga pagos pendientes
                {
                    Cliente aux = (Cliente)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    // retorno el cobro seleccionado para manejarlo desde el dgv2   
                    Cobro seleccionado = comercio.RetornaCobroAsignado(aux, (VistaCobroPendiente)this.dataGridView2.SelectedRows[0].DataBoundItem);

                    ////////Calculo de IMPORTE, MORATORIA E INTERESES, CON SU TOTAL////////
                    int moratoria = 0;
                    decimal interes = 0;
                    decimal importe = seleccionado.Importe;

                    DateTime pagoServicio = Convert.ToDateTime(Interaction.InputBox("Ingresar fecha de PAGO", "Fecha de PAGO DD/MM/AAAA"));
                    if (Information.IsDate(pagoServicio)) //TIENE QE SER UNA VARIABLE FECHA
                    {//verifico si paga en termino
                        if (seleccionado.Vencimiento >= pagoServicio) // pago en fecha
                        {
                            MessageBox.Show("No registra moratoria. Pago en fecha.");
                        }
                        else if (seleccionado.Vencimiento < pagoServicio) // pago fuera de termino
                        {
                            moratoria = (pagoServicio - seleccionado.Vencimiento).Days; //con .Days tomo solo los días de la moratoria  
                            MessageBox.Show($"Pagó {moratoria} días después del vencimiento. Deberá abonar intereses.");
                        }
                    }
                    interes = seleccionado.ValorInteres(importe, moratoria);
                    decimal total = importe + interes;

                    //Asigno todos estos valores al objeto PAGO y la fecha de pago seleccionada con su total
                    Pago pago = new Pago
                    {
                        Codigo = seleccionado.Codigo, Nombre = seleccionado.Nombre,
                        FechaPago = pagoServicio, Importe_Total = total, Cliente = seleccionado.Cliente
                    };

                    _pago.Codigo = pago.Codigo; _pago.Nombre = pago.Nombre;
                    _pago.FechaPago = pago.FechaPago; _pago.Importe_Total = pago.Importe_Total; _pago.Cliente = pago.Cliente;

                    string MENSAJE = $"IMPORTE SUB-TOTAL: ${importe}.-\nINTERESES POR MORATORIA: ${interes}.-\nTOTAL: ${total}.-";

                    var MSGBOX = MessageBox.Show(MENSAJE, "¿QUIERE ABONAR ESTO AHORA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (MSGBOX == DialogResult.Yes) // Si lo quiero abonar "si", que proceda a realizar la operatoria. 
                    {
                        comercio.EliminarCobro(seleccionado, aux); //elimino el cobro de la grilla 2 seleccionado
                        comercio.AsignarPagoCliente(aux, pago); //asigno el pago
                        comercio.AgregarPago(pago); //lo agrego a la lista de los pagos global
                        Mostrar_en_Grilla(dataGridView2, vistaCobros.CobrosPendientesCliente(aux, comercio.DevuelveListaClientes()));
                        Mostrar_en_Grilla(dataGridView3, MostrarGrilla3LinQ());
                        Mostrar_en_Grilla(dataGridView4, MostrarGrilla4LinQ());
                        Mostrar_en_Grilla(dataGridView5, MostrarGrilla5LinQ());
                    }
                    else
                        throw new Exception("Pago no efectuado");
                }
                else
                    throw new Exception("No hay cliente ni cobro seleccionado. No se pudo avanzar.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public object MostrarGrilla3LinQ() //Hago un LINQ para que me tome todo el objeto y EL PAGO COMPLETO
        {
            Cliente aux = (Cliente)dataGridView1.SelectedRows[0].DataBoundItem;

            return (from cli in comercio.DevuelveListaPagos(aux)  //Hago un LINQ para que me tome todo el objeto y el nombre del cliente
                    select new
                    {
                        Codigo = cli.Codigo,
                        Nombre = cli.Nombre,
                        Vencimiento = cli.FechaPago,
                        Importe = cli.Importe_Total,
                        Cliente = cli.Cliente.Nombre
                    }).ToList();
        }

        public object MostrarGrilla4LinQ() //LinQ para traer los ordenamientos de los pagos de los clientes que yo selecciono de la grilla
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Cliente aux = (Cliente)this.dataGridView1.SelectedRows[0].DataBoundItem;

                try
                {                 
                    if (aux == null) throw new Exception("No hay ningun cliente en la lista de clientes aún");                         
                    if (radioButton1.Checked == true) //compruebo si está seleccionado el radiobutton
                    {
                        aux.listaAbonados = aux.RetornaListaAbonados();
                        aux.listaAbonados.Sort(new Pago.PagoASC());
                        return (from cli in aux.RetornaListaAbonados()
                                select new
                                {
                                   Codigo = cli.Codigo,
                                   Nombre = cli.Nombre,
                                   Vencimiento = cli.FechaPago,
                                   Importe = cli.Importe_Total,
                                   Cliente = cli.Cliente.Nombre
                                }).ToList();

                    }
                    else if (radioButton2.Checked == true)
                    {
                        aux.listaAbonados = aux.RetornaListaAbonados();
                        aux.listaAbonados.Sort(new Pago.PagoDESC());
                        return (from cli in aux.RetornaListaAbonados()
                                select new
                                {
                                   Codigo = cli.Codigo,
                                   Nombre = cli.Nombre,
                                   Vencimiento = cli.FechaPago,
                                   Importe = cli.Importe_Total,
                                   Cliente = cli.Cliente.Nombre
                                }).ToList();
                    }                      
                    return aux;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }              
            }
            return null;
        }
        
        public object MostrarGrilla5LinQ() //Hago un LINQ para que me tome todo el objeto y EL PAGO COMPLETO
        {
            //Hago un LINQ para que me tome todo el objeto y el nombre del cliente
            return (from cli in comercio.DevuelveListaTodosLosPagos() 
                    select new { Cliente = cli.Cliente.Nombre, Importe = cli.Importe_Total }).ToList();
        }        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //actualización de la grilla 1 al seleccionarla. 
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Cliente aux = (Cliente)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    Mostrar_en_Grilla(dataGridView2, vistaCobros.CobrosPendientesCliente(aux, comercio.DevuelveListaClientes()));
                    Mostrar_en_Grilla(dataGridView3, MostrarGrilla3LinQ());
                    Mostrar_en_Grilla(dataGridView4, MostrarGrilla4LinQ());
                    Mostrar_en_Grilla(dataGridView5, MostrarGrilla5LinQ());
                }
            }
            catch (Exception) { }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e) //actualizacion de grilla 1 por medio de eventos de winForms.
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Cliente aux = (Cliente)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    Mostrar_en_Grilla(dataGridView2, vistaCobros.CobrosPendientesCliente(aux, comercio.DevuelveListaClientes()));
                    Mostrar_en_Grilla(dataGridView3, MostrarGrilla3LinQ());
                    Mostrar_en_Grilla(dataGridView4, MostrarGrilla4LinQ());
                    Mostrar_en_Grilla(dataGridView5, MostrarGrilla5LinQ());                   
                }
                else
                {
                    dataGridView3.DataSource = null;
                    dataGridView4.DataSource = null;
                }
            }
            catch (Exception) { }
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e) //evento para cuando se clickea sobre el radiobutton1
        {
            if (radioButton1.Checked == true)
            {
                Mostrar_en_Grilla(dataGridView4, MostrarGrilla4LinQ());
            }
        }
        private void radioButton2_MouseClick(object sender, MouseEventArgs e) //evento para cuando se clickea sobre el radiobutton2
        {
            if (radioButton2.Checked == true)
            {
                Mostrar_en_Grilla(dataGridView4, MostrarGrilla4LinQ());
            }
        }
    }
}
