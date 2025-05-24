public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Bienvenido al sistema de gestión de productos!");
        Console.WriteLine("Digite la opcion deseada:");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Listar productos");
        Console.WriteLine("3. Salir");

        var option =Int32.Parse(Console.ReadLine());
        
    

        switch (option)
        {
            case 1:
                AddProduct();
                break;
            case 2:
                ListProducts();
                break;
            case 3:
                Console.WriteLine("Saliendo del sistema...");
                return;
            default:
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                break;
        }




    
    
    }

    private static void AddProduct()
    {
        throw new NotImplementedException();
    }

    private static void ListProducts()
    {
        throw new NotImplementedException();
    }
}