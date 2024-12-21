using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___Refactor
{
    public class Concesionario
    {
        private Persona _persona;
        private List<Auto> _autos;

        public Concesionario(string pDni, string pNombre, string pApellido, string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio)
        {
            _persona = new Persona(pDni, pNombre, pApellido);
            _autos = new List<Auto>();
            _autos.Add(CreaAuto(pPatente,pMarca,pModelo,pAño,pPrecio));
        }

        public void AgregarAuto(string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio)
        {
            _autos.Add(CreaAuto(pPatente, pMarca, pModelo, pAño, pPrecio));
        }
        public List<Auto> RetornarAuto()
        {
            List<Auto> autos = new List<Auto>();
            foreach(Auto car in _autos)
            {
                autos.Add(new Auto(car.Patente, car.Marca, car.Modelo, car.Año, car.Precio));
            
            }
            return autos;
        }

        public Persona RetornarPersona
        {
            get
            {
                Persona p = new Persona(_persona.DNI, _persona.Nombre, _persona.Apellido);

                return p;
            }
        }

        private Auto CreaAuto(string pPatente, string pMarca, string pModelo, string pAño, decimal pPrecio)
        {
            return new Auto(pPatente, pMarca, pModelo, pAño, pPrecio);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach(Auto car in _autos)
            {
                total += car.Precio;
            }
            return total;
        }
    }
}
