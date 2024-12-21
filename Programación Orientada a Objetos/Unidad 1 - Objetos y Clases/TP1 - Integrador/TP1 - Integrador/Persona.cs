using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1___Integrador
{
    public class Persona
    {
        #region Propiedades
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Auto> Autos { get; set; }

        public int CantidadAutos { get; set; }

        #endregion

        #region Métodos
        public List<Auto> Lista_de_autos()
        {
            var autos = new List<Auto>();
               
            foreach(var item in autos)
            {
                autos.Add(new Auto(item.Patente, item.Marca, item.Modelo, item.Año, item.Precio));
            }

            return autos;
        }

        public int Cantidad_de_autos(List<Persona> listaPersonas, string nombre)
        {
           int cantidadAutos = 0;

            foreach(Persona persona in listaPersonas)
            {
                if(persona.Nombre == nombre)
                {
                   cantidadAutos = persona.CantidadAutos;
                    break;
                }
            }

            return cantidadAutos;
        }
        #endregion

        #region Constructor
        
        public Persona(string pDNI, string pNombre, string pApellido)
        {
            this.DNI = pDNI;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
        }
        #endregion

        #region Finalizador

        ~Persona()
        {
            MessageBox.Show($"DNI: {DNI}");
        }

        #endregion
    }
}
