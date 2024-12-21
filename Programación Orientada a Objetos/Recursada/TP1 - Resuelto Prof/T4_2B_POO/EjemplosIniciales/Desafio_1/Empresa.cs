using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_1
{
    public class Empresa
    {
        List<Auto> la;
        List<Persona> lp;

        public Empresa()
        {
            la=new List<Auto>(); lp= new List<Persona>();
        }

        public void AgregarPersona(Persona pPersona)
        {
            lp.Add(new Persona(pPersona));
        }
        public void BorrarPersona(Persona pPersona)
        {

            try
            {
                Persona p = lp.Find(x => x.DNI==pPersona.DNI);
                if (p==null) throw new Exception("La persona que intenta borrar no existe !!!");
                foreach(Auto a in p.RetornaListaAutos())
                {
                    la.Find(x => x.Patente==a.Patente).AsignaDueño(null);
                }
                lp.Remove(p); 
            }
            catch (Exception ex) { throw ex; }

         
        }
        public void ModificarPersona(Persona pPersona)
        {

            try
            {
                Persona p = lp.Find(x => x.DNI==pPersona.DNI);
                if (p==null) throw new Exception("La persona que intenta modificar no existe !!!");
                p.Nombre=pPersona.Nombre;
                p.Apellido=pPersona.Apellido;
                List<Auto> laPersona = p.RetornaListaAutos();
                foreach(Auto a in laPersona) 
                {
                Auto auxAuto=la.Find(x => x.Patente==a.Patente);
                    // auxAuto.AsignaDueño(new Persona(p.DNI,p.Nombre,p.Apellido)); 
                 auxAuto.ModificarDueño(new Persona(p.DNI, p.Nombre, p.Apellido));

                }
              
            }
            catch (Exception ex) { throw ex; }


        }

        public object RetornaListaPersonas()
        {
            return (from p in lp select new {DNI=p.DNI,Apeliido_y_Nombre= $"{p.Apellido}, {p.Nombre}" }).ToArray();
           
        }
        public bool ValidaExisteDNIPersona(Persona pPersona)
        {
            return lp.Exists(x => x.DNI==pPersona.DNI);
        }

        public void AgregarAuto(Auto pAuto)
        {
            la.Add(new Auto(pAuto));
        }
        public object RetornaListaAutos()
        {
            return (from a in la select new { Patente = a.Patente, Marca = a.Marca,Modelo=a.Modelo,Año=a.Año,Precio=a.Precio }).ToArray();

        }

        public void AsignaAutoAPersona(Persona pPersona,Auto pAuto)
        {

            try
            {
                Persona p = lp.Find(x => x.DNI==pPersona.DNI);
                Auto a = la.Find(x => x.Patente==pAuto.Patente);
                if (p==null || a==null) throw new Exception("Uno o ambos de los elementos a asignar es nulo !!!");
                if (a.RetornaDueño()!=null) throw new Exception("El auto posee dueño !!!"); 
                p.AgregarAuto(new Auto(a));
                a.AsignaDueño(new Persona(p));
            }
            catch (Exception ex) { throw ex; }

        }

        public object RetornaListaAutosDePersona(Persona pPersona)
        {
            Persona p = lp.Find(x => x.DNI==pPersona.DNI);

            return (from a in p.RetornaListaAutos() select new { Patente = a.Patente, Marca = a.Marca, Modelo = a.Modelo, Año = a.Año, Precio = a.Precio }).ToArray();

        }
        public object RetornaListaAutoGrilla4()
        {
            return la.Count == 0 ? null: (from a in la select new { Patente = a.Patente, Marca = a.Marca, Modelo = a.Modelo, Año = a.Año, Precio = a.Precio,DNI_dueño = a.RetornaDueño()==null?"":a.RetornaDueño().DNI,Apellido_y_Nombre= a.RetornaDueño()==null ? "" : $"{a.RetornaDueño().Apellido}, {a.RetornaDueño().Nombre}" }).ToArray();

        }
    }
}
