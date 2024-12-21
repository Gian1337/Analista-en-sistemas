using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resol_1P
{
    public class Empresa
    {
        List<Empleado> le;
        List<Adelanto> la;

        public Empresa()
        {
            le=new List<Empleado>();
            la=new List<Adelanto>();        
        }

        public void AgregaEmpleado(Empleado pEmpleado)
        {
            le.Add(pEmpleado);
        }
        public void BorraEmpleado(Empleado pEmpleado)
        {

            try
            {
                BorraEmpleado(pEmpleado.Legajo);
            }
            catch (Exception ex) { throw ex; }      
        }
        public void BorraEmpleado(int pLegajo)
        {

            try
            {
                Empleado e = le.Find(x => x.Legajo == pLegajo);
                if (e != null) { le.Remove(e); }
            }
            catch (Exception ex) { throw ex; }
        }
        public void ModificaEmpleado(Empleado pEmpleado)
        {

            try
            {
                Empleado e = le.Find(x => x.Legajo == pEmpleado.Legajo);
                if (e != null) 
                { 
                    e.Nombre=pEmpleado.Nombre;
                    e.Apellido = pEmpleado.Apellido;
                    //todo: Si permitimos modificar el sueldo debemos chequear que los adelantos impados sean inferior e el
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public Array RetornaEmpleadosToArray()
        {
          
            try {return (from emp in le select new { Legajo = emp.Legajo, Nombre = emp.Nombre, Apellido = emp.Apellido, Sueldo = emp.Sueldo, Categoría = emp.GetType().Name }).ToArray(); }
            catch (Exception ex) { throw ex; }
        }
        public List<Empleado> RetornaEmpleadosToList()
        {

            try { return (from emp in le select emp).ToList(); }
            catch (Exception ex) { throw ex; }
        }
    }
}
