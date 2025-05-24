using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class ProductoManager
    {

        public void AddProduct(Product product)
        {
            //----Desarollar por el estudiante----//
            // Llamar al FileManager para guardar el producto.
            var fileManager = new DataPersistence.FileManager();
            fileManager.SaveProducts(product);
        }

        public List<Product> GetProducts()
        {
            //----Desarollar por el estudiante----//
            // Llamar al FileManager para obtener la lista de productos.
            var fileManager = new DataPersistence.FileManager();
            return fileManager.ReadProducts();
        }
    }
}
