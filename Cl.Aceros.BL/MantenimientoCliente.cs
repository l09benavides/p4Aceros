using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl.Aceros.BL
{
    public class MantenimientoCliente
    {
       
        private List<Clientes> lista = new List<Clientes>();

        public void Insertar (Clientes clientes)
        {
            lista.Add(clientes);
        }

        public void actualizar(Clientes cliente)
        {
            var match = lista.FirstOrDefault(lista => lista.Cedula == cliente.Cedula);
            if (match != null)
            {
                match.Nombre = cliente.Nombre;
                match.Telefono = cliente.Cedula;
                match.Email = cliente.Email;
                match.Cedula = cliente.Cedula;
                
                
            }

        }

        public List<Clientes> mostrar()
        {
            if (lista.Count == 0)
            {
                Clientes persona1 = new Clientes { Cedula = 1234,  Email = "persona1@gmail.com", Telefono = 12345678,  Nombre = "Demo1" };
                Clientes persona2 = new Clientes { Cedula = 2345,  Email = "persona2@gmail.com", Telefono = 23456789,  Nombre = "Demo2" };
                lista.Add(persona1);
                lista.Add(persona2);
            }
            return lista;
        }


        public void eliminar(Clientes cliente)
        {
            try
            {
                var clienteaEliminar = lista.SingleOrDefault(remove => remove.Cedula == cliente.Cedula);
                if (clienteaEliminar != null)
                {
                    lista.Remove(clienteaEliminar);
                }
            }
            catch (Exception ee)
            {

                string error =  ee.ToString();
            }
            
           
        }


    }
}
