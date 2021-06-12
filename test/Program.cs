using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunaPlena;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
           // Marca aux1 = new Marca("pepe");

            Local.AgregarMarca("pepe");

            Marca aux2 = Local.RetornaMarca(2);


            Producto aux3 = new Producto("ahre", 2333, aux2);

            Local.AgregarProducto(aux3);
            Local.AgregarProducto(aux3);
            Local.AgregarProducto(new Producto("ahre2", 3444, new Marca("ahreee")));


            
            Console.ReadKey();

                
        }
    }
}
