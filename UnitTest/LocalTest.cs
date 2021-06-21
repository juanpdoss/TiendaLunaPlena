using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LunaPlena;

namespace UnitTest
{
    [TestClass]
    public class LocalTest
    {
        [TestMethod]
        public void DesearilizaMarcas()
        {
            Local.listaMarcas = Serializador.ObtenerListaMarcas();
            Assert.IsNotNull(Local.listaMarcas);
        }

        [TestMethod]
        public void RetornaMarcaDesdeNombre()
        {
            Local.listaMarcas = Serializador.ObtenerListaMarcas();
            Local.AgregarMarca("prueba");

            Marca pruebaMarca = Local.RetornarMarcaDesdeNombre("prueba");
            Assert.AreEqual("prueba",pruebaMarca.Nombre);


        }

            









    }
}
