using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Empresa
    {
        #region Listas
        List<Auto> la; //Lista de autos
        List<Persona> lp; //Lista de personas

        #endregion

        #region Constructor
        public Empresa()
        {
            la=new List<Auto>(); 
            lp= new List<Persona>();
        }
        #endregion

        #region Métodos
        public void AgregarPersona(Persona pPersona)
        {
            lp.Add(new Persona(pPersona));
        }

        public void AgregarAuto(Auto pAuto)
        {
            la.Add(new Auto(pAuto));
        }
        public void BorrarPersona(Persona pPersona)
        {

            try
            {
                Persona p = lp.Find(x => x.DNI==pPersona.DNI);
                if (p==null) throw new Exception("La persona que intenta borrar no existe !!!");
                //todo: Verificar que la persona a borrar no posea autos. En caso que posea impedir el borrado.
                lp.Remove(p); 
            }
            catch (Exception ex) { throw ex; }

         
        }

        public void BorrarAuto(Auto pAuto)
        {
            try
            {
                Auto p = la.Find(x => x.Patente == pAuto.Patente);

                if (p == null) throw new Exception("El auto no existe");
                la.Remove(p);

            
            }
            catch (Exception ex) { throw ex; }
        }

        public void ModificaPersona(Persona pPersona)
        {
            try
            {
               Persona psn = lp.Find(x => x.DNI==pPersona.DNI);
                if (psn != null)
                {
                    psn.Nombre = pPersona.Nombre;
                    psn.Apellido = pPersona.Apellido;
                }

            }
            catch (Exception ex) { throw ex; }
        }

        public void ModificaAuto(Auto pAuto)
        {

            try
            {
            Auto auto = la.Find(x => x.Patente == pAuto.Patente);

            if(auto != null)
            {
                auto.Marca = pAuto.Marca;
                auto.Modelo = pAuto.Modelo;
                auto.Año = pAuto.Año;
                auto.Precio = pAuto.Precio;
            }
            }
            catch(Exception ex)
            {

            }
        }
        public object RetornaListaPersonas()
        {
            return (from p in lp select new {DNI=p.DNI,Nombre = p.Nombre, Apellido = p.Apellido }).ToArray();
           
        }

        public object RetornaListaAuto()
        {
            return (from a in la select new {Patente = a.Patente, Marca = a.Marca, Modelo = a.Modelo, Año = a.Año, Precio = a.Precio}).ToArray();
        }
        public bool ValidaExisteDNIPersona(Persona pPersona)
        {
            return lp.Exists(x => x.DNI==pPersona.DNI);
        }

        public bool ValidaPatente(Auto pAuto)
        {
            return la.Exists(x => x.Patente == pAuto.Patente);
        }

        public void AsignaAuto(Persona persona, Auto auto)
        {
            Persona p = lp.Find(x => x.DNI == persona.DNI);
            Auto a = la.Find(x => x.Patente == auto.Patente);

            if (a == null || p == null) throw new Exception("Ninguno de los elementos a asignar puede ser null");
            if (a.RetornaDueño() != null) throw new Exception("El auto ya posee un dueño");

            p.AgregaAuto(new Auto(a));
            a.AsignaDueño(new Persona(p));


        }

        public object RetornaListaAutosPersonales(Persona persona)
        {
            Persona p = lp.Find(x => x.DNI == persona.DNI);

            return (from auto in p.RetornaListaAutos()
                    select new
                    {
                        Patente = auto.Patente,
                        Marca = auto.Marca,
                        Modelo = auto.Modelo,
                        Año = auto.Año,
                        Precio = auto.Precio
                    }).ToArray();
        }
        public object RetornaListaAutoG4()
        {
            return la.Count == 0 ? null : (from auto in la select new { Patente = auto.Patente, Marca = auto.Marca, Modelo = auto.Modelo, Año = auto.Año, Precio = auto.Precio, DNI = auto.RetornaDueño()== null ? "":auto.RetornaDueño().DNI, NOMBRE = auto.RetornaDueño() == null ? "" : auto.RetornaDueño().Nombre, APELLIDO = auto.RetornaDueño() ==null ? "" : auto.RetornaDueño().Apellido}).ToArray();
        }
        #endregion
    }
}
