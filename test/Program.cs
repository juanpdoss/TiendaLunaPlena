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
            //Producto a = new Producto("kitty", 205);
            //Producto b = new Producto("aritoXD", 340);
            //Producto c = new Producto("botitas", 40);
            //Producto d = new Producto("sombra", 340);


           //obtengo datos del Xml.
            Local.ListaProductos = Serializador.ObtenerListaSerializada();

            //No se agregan (ya estan incluidos)
            //Local.AgregarProducto(a);
            //Local.AgregarProducto(b);
            //Local.AgregarProducto(a);
            //Local.AgregarProducto(c);
            //Local.AgregarProducto(d);

            //Serializador.SerializarListaProductos(Local.ListaProductos);


            //muestro el local
            //Console.WriteLine(Local.LocalToString());
            Console.WriteLine("numero de productos: " + Local.listaProductos.Count);
            //Console.WriteLine("pruebo quitar a");
            // Local.QuitarProducto(a); 
            Console.WriteLine("agrego un producto");
            Local.AgregarProducto(new Producto("nuevo", 340));
            Console.ReadKey();
            Console.WriteLine("Numero de productos:" + Local.listaProductos.Count);

            //Console.WriteLine(Local.LocalToString());

            Console.ReadKey();

                
        }
    }
}
