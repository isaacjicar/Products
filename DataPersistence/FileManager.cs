using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataPersistence
{
    public class FileManager
    {
        // Metodo que retorna una lista de productos tomada del archivo de texto/.
        public List<Product> ReadProducts()
        {
            //----Desarollar por el estudiante----//
            // Leer el archivo de texto o XML y convertirlo en una lista de productos.
            var producto = new List<Product>();
            return producto;
        }

        public void SaveProducts(Product product) {

            //----Desarollar por el estudiante----//
            // Guardar el producto en un archivo de texto o XML.
        }

    }
}
