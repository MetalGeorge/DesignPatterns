using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(new ProveedorSensoresEnergia());
            
            var proveedor = cliente.ObtieneNombreProveedor();
            var lectura = cliente.ObtieneLectura();
            var unidad  = cliente.ObtieneUnidad();
            Console.WriteLine("Lectura Energia");
            Console.WriteLine(proveedor.ToString());
            Console.WriteLine(lectura.ToString());
            Console.WriteLine(unidad.ToString());

            cliente = new Cliente(new ProveedorSensorAgua());

            proveedor = cliente.ObtieneNombreProveedor();
            lectura = cliente.ObtieneLectura();
            unidad = cliente.ObtieneUnidad();
            Console.WriteLine("Lectura Agua");
            Console.WriteLine(proveedor.ToString());
            Console.WriteLine(lectura.ToString());
            Console.WriteLine(unidad.ToString());


            Console.ReadLine();
        }
    }
}
