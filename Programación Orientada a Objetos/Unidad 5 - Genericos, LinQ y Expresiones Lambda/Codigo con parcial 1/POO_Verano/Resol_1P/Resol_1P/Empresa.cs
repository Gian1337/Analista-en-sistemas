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

            la.AddRange(new Adelanto[] { new Adelanto() { Codigo = "1111AAAA", FechaOtorgado = DateTime.Parse("01/03/2023"),Importe=1000m },
                                          new Adelanto() { Codigo = "1112AAAA", FechaOtorgado = DateTime.Parse("01/03/2023"),Importe=2000m },
                                           new Adelanto() { Codigo = "1113AAAA", FechaOtorgado = DateTime.Parse("01/03/2023"),Importe=3000m },
                                            new Adelanto() { Codigo = "1114AAAA", FechaOtorgado = DateTime.Parse("01/03/2023"),Importe=4000m} });

        }

        public void AgregaEmpleado(Empleado pEmpleado)
        {
            le.Add(pEmpleado);
        }
        public void BorraEmpleado(Empleado pEmpleado)
        {

            try
            {
                if(pEmpleado.RetornaAdelantos().Exists(x => x.Importe-x.Beneficio!=x.Pago))
                {
                    throw new Exception("Existen adelantos sin pagar !!!");
                }
                else
                {
                    //todo: se deben borrar los adelantos de la lista de adelantos de la empresa que corresponden a este Empleado
                    BorraEmpleado(pEmpleado.Legajo);
                }
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
        public Array RetornaAdelantosToArray()
        {

            try { return (from ade in la select new { Codigo = ade.Codigo, Fecha_Otorgado = ade.FechaOtorgado, Importe = ade.Importe }).ToArray(); }
            catch (Exception ex) { throw ex; }
        }
        public void AsignarAdelanto(Empleado pEmpleado, Adelanto pAdelanto)
        {

            try
            {
                Empleado empaux= le.Find(x => x.Legajo == pEmpleado.Legajo);
                Adelanto adeaux = la.Find(x => x.Codigo == pAdelanto.Codigo);
                if (adeaux.RetornaBeneficiario() != null) throw new Exception("El adelanto ya está asignado !!!");
                adeaux.CargaBeneficiario(empaux);
                empaux.AgregaAdelanto(adeaux);

            }
            catch (Exception ex) {throw ex; }


        }
        public Empleado ReotrnaEmpleado(int pLegajoEmpleado)
        {
            return le.Find(x => x.Legajo == pLegajoEmpleado);
        }
    }
}
