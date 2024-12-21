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

namespace Try_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0; 
            int d = 0;
            try
            {
                a = int.Parse(Interaction.InputBox("Ingrese a: "));
                b = int.Parse(Interaction.InputBox("Ingrese b: ")); ;
                if (a > 100 || b > 100) throw new AB_Mayor_100_Exception(a>100?"a":"b",a>100?a:b);
                c = a / b;
                d = b / a;

                MessageBox.Show($"A: {a}  - B: {b} - C(a/b): {c} - D(b/a): {d}");
            }
            catch (AB_Mayor_100_Exception ex) { MessageBox.Show(ex.Message); }

            catch (FormatException)
            {
                MessageBox.Show("Error en el Formato !!!!");
            }
            catch (DivideByZeroException ex) when (a == 0)
            {
                MessageBox.Show($"Mensaje Usuario: Error en la operación pues a ==0 !!!{Environment.NewLine}" +
                                $"Mensaje Sistema: {ex.Message}{Environment.NewLine}" +
                                $"Origen: { ex.Source}{Environment.NewLine}" +
                                $"Pila: {ex.StackTrace}");
            }
            catch (DivideByZeroException ex) when (b == 0)
            {

                MessageBox.Show($"Mensaje Usuario: Error en la operación pues b ==0 !!!{Environment.NewLine}" +
                                $"Mensaje Sistema: {ex.Message}{Environment.NewLine}" +
                                $"Origen: { ex.Source}{Environment.NewLine}" +
                                $"Pila: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mensaje: {ex.Message}{Environment.NewLine}" +
                                $"Origen: { ex.Source}{Environment.NewLine}" +
                                $"Pila: {ex.StackTrace}");
            }
            finally
            {
                MessageBox.Show("Siempre se pasa por el Finally !!!");
            }
        }
    }

    public class AB_Mayor_100_Exception : Exception
    {
        string nombreVariable=""; int valorVariable = 0;
        public AB_Mayor_100_Exception(string pNombreVariable, int pValorVariable)
        { nombreVariable = pNombreVariable;valorVariable = pValorVariable; }
        public override string Message => $"{nombreVariable} es mayor a 100 !!!{Environment.NewLine}" +
                                          $"El valor ingresado es: {valorVariable} ";
    }
}
