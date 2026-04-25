namespace TiendaConsolaV1_2
{
    class MenuAdmin
    {
        private Inventario inv;
        private Descuento desc;
        public MenuAdmin(Inventario i, Descuento d)
        {
            inv = i;
            desc = d;
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
        private void ActualizarProducto()
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
        private void ActualizarDescuento()
        {
            Console.Write("Nuevo porcentaje de descuento para cliente VIP: ");
            desc.porcentaje = double.Parse(Console.ReadLine());
            Console.Write("Compra mínima para aplicar descuento: ");
            desc.cap = double.Parse(Console.ReadLine());
            Console.WriteLine("Descuento actualizado correctamente");
        }

        public void Iniciar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n=== Menú Admin ===");
                Console.WriteLine("1. Ver producto");
                Console.WriteLine("2. Agregar producto");
                Console.WriteLine("3. Actualizar precio");
                Console.WriteLine("4. Eliminar productos");
                Console.WriteLine("5. Actualizar descuento de cliente");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                switch (Console.ReadLine())
                {
                    case "1": 
                        inv.ListarProductos(); 
                        break;
                    case "2":
                        Agregar();
                        break;
                    case "3":
                        ActualizarProducto();
                        break;
                    case "4":
                        Eliminar();
                        break;
                    case "5":
                        ActualizarDescuento();
                        break;
                    case "0":
                        salir = true;
                        break;
                }
            }
        }
    }
}