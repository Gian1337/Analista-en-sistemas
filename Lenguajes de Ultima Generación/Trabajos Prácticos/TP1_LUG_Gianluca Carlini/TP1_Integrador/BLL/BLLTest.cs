using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLTest
    {
        public string Test()
        {
            Acceso acceso = new Acceso();
            return acceso.TestConnection();
        }
    }
}
