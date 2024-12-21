using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Auto
    {
        public Auto(string pPatente, string pMarca="", string pModelo="", string pAño= "" ,decimal pPrecio=0m)  
        { Patente=pPatente;Marca=pMarca;Modelo=pModelo;Año=pAño; Precio=pPrecio; }
        public Auto(Auto pAuto) : this(pAuto.Patente,pAuto.Marca,pAuto.Modelo,pAuto.Año,pAuto.Precio)
        {
            
        }
        Persona dueno;
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public decimal Precio { get; set; }

        public Persona RetornaDueño() { return dueno==null?null:new Persona(dueno); }
        public void AsignaDueño(Persona pPersona) { dueno = pPersona==null ?null: new Persona(pPersona); }       
        public void ModificarDueño(Persona pPersona)
        {
            dueno.Nombre=pPersona.Nombre;dueno.Apellido=pPersona.Apellido;
        }
    }
}
