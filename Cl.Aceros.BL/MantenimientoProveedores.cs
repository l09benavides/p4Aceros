using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cl.Aceros.BL
{
    public class MantenimientoProveedores
    {
       
        private List<Proveedores> lista = new List<Proveedores>();

        public void Insertar (Proveedores proveedores)
        {
            lista.Add(proveedores);
        }

        public void actualizar(Proveedores proveedores)
        {
            var match = lista.FirstOrDefault(lista => lista.Proveedor == proveedores.Proveedor);
            if (match != null)
            {
                match.Proveedor = proveedores.Proveedor;
                match.Id = proveedores.Id;
                match.Telefono = proveedores.Telefono;
                match.Ruta = proveedores.Ruta;
                
                
            }

        }

        public List<Proveedores> mostrar()
        {
            if (lista.Count == 0)
            {
                Proveedores proveedor1 = new Proveedores { Proveedor = "Pedro Picapiedra",  Id = 1223, Telefono = 12345678,  Ruta = "era prehistorica" };
                Proveedores proveedor2 = new Proveedores { Proveedor = "Pedro Picapiedra1", Id = 1223, Telefono = 12345678, Ruta = "era prehistorica" };
                lista.Add(proveedor1);
                lista.Add(proveedor2);
            }
            return lista;
        }


        public void eliminar(Proveedores cliente)
        {
            try
            {
                var proveedorEliminar = lista.SingleOrDefault(remove => remove.Proveedor == cliente.Proveedor);
                if (proveedorEliminar != null)
                {
                    lista.Remove(proveedorEliminar);
                }
            }
            catch (Exception ee)
            {

                string error =  ee.ToString();
            }
            
           
        }


    }
}
