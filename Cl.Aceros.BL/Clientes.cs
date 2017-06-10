using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl.Aceros.BL
{
    public class Clientes
    {

        //Nombre
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        //Cedula
        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }


        //Telefono
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        //Email
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
