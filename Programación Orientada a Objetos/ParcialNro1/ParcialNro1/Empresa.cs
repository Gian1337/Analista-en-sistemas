using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ParcialNro1
{
    public class Empresa
    {
        List<Empleado> le;
        List<Adelanto> la;

        public Empresa()
        {
            le = new List<Empleado>();
            la = new List<Adelanto>();
        }

        public void AgregarEmp(Empleado pEmpleado)
        {
            try
            {
                le.Add(pEmpleado);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AgregarAdelanto(Adelanto pAdelanto)
        {
            try
            {
                la.Add(pAdelanto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void BorrarEmpleado(Empleado pEmpleado)
        {
            try
            {
                le.Remove(pEmpleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ModificarEmpleado(Empleado pEmpleado)
        {
            try
            {
                Empleado emp = le.Find(x => x.Legajo == pEmpleado.Legajo);

                if(emp != null)
                {
                    emp.Nombre = pEmpleado.Legajo;
                    emp.Apellido = pEmpleado.Apellido;
                    emp.Sueldo = pEmpleado.Sueldo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Empleado> RetornaEmpleado() { return le; }

        public List<Adelanto> RetornaAdelanto() { return la; }
    }
}
