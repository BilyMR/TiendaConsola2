namespace TiendaConsolaV1_2
{
    class MenuAdmin
    {
        private Inventario inv;
        public MenuAdmin(Inventario i)
        {
            inv = i;
        }
        private void Agregar()
        {
            Console.Write("Nombre del producto: ");
            string? nombre = Console.ReadLine();
            Console.Write("Codigo del producto: ");
            string? codigo = Console.ReadLine();
            Console.Write("Precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad del producto: ");
            int cantidad = int.Parse(Console.ReadLine());

            bool exito = inv.AgregarProducto(nombre, codigo, precio, cantidad);
            if (exito)
            {
                Console.WriteLine("Producto agregado correctamente");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void Eliminar()
        {
            Console.Write("Nombre del producto: ");
            string? nombre = Console.ReadLine();

            bool exito = inv.EliminarProducto(nombre);
            if (exito)
            {
                Console.WriteLine("Producto eliminado correctamente");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void Actualizar()
        {
            Console.Write("Nombre del producto: ");
            string? nombre = Console.ReadLine();
            Console.Write("Precio nuevo del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad nuevo del producto: ");
            int cantidad = int.Parse(Console.ReadLine());

            bool exito = inv.ActualizarProducto(nombre, precio, cantidad);
            if (exito)
            {
                Console.WriteLine("Producto actualizado correctamente correctamente");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void Iniciar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n=== Menú Admin ===");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Actualizar precio");
                Console.WriteLine("4. Ver productos");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                switch (Console.ReadLine())
                {
                    case "1": 
                        Agregar(); 
                        break;
                    case "2":
                        Eliminar();
                        break;
                    case "3":
                        Actualizar();
                        break;
                    case "4":
                        inv.ListarProductos();
                        break;
                    case "0":
                        salir = true;
                        break;
                }
            }
        }
    }
}