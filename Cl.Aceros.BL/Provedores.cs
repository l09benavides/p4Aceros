using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl.Aceros.BL
{
    public class Proveedores
    {

        //Provedor
        private string proveedor;
        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }


        //Id
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        //Telefono
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        //Ruta
        private String ruta;

        public String Ruta
        {
            get { return ruta; }
            set { ruta = value; }
        }

    }
}
