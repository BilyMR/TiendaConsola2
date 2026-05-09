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
        private void AgregarProductoFisico()
        {
            Console.Write("Nombre del producto: ");
            string? nombre = Console.ReadLine();
            Console.Write("Codigo del producto: ");
            string? codigo = Console.ReadLine();
            Console.Write("Precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Cantidad del producto: ");
            int cantidad = int.Parse(Console.ReadLine());

            bool exito = inv.AgregarProductoFisico(nombre, codigo, precio, cantidad);
            if (exito)
            {
                Console.WriteLine("Producto fisico agregado correctamente");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void AgregarProductoDigital()
        {
            Console.Write("Nombre del producto: ");
            string? nombre = Console.ReadLine();
            Console.Write("Codigo del producto: ");
            string? codigo = Console.ReadLine();
            Console.Write("Precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.Write("Licencia del producto: ");
            string? licencia_ = Console.ReadLine();

            bool exito = inv.AgregarProductoDigital(nombre, codigo, precio, licencia_);
            if (exito)
            {
                Console.WriteLine("Producto digital agregado correctamente");
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
        private void ActualizarPrecio()
        {
            Console.Write("Nombre del producto: ");
            string? nombre = Console.ReadLine();
            Console.Write("Precio nuevo del producto: ");
            double precio = double.Parse(Console.ReadLine());

            bool exito = inv.ActualizarPrecio(nombre, precio);
            if (exito)
            {
                Console.WriteLine("Precio actualizado correctamente correctamente");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void ActualizarStock()
        {
            Console.Write("Nombre del producto: ");
            string? nombre = Console.ReadLine();
            Console.Write("Precio nuevo del producto: ");
            int stock = int.Parse(Console.ReadLine());

            bool exito = inv.ActualizarStock(nombre, stock);
            if (exito)
            {
                Console.WriteLine("Stock actualizado correctamente correctamente");
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
                Console.WriteLine("\n=== Menu Admin ===");
                Console.WriteLine("1. Ver productos");
                Console.WriteLine("2. Agregar producto fisico");
                Console.WriteLine("3. Agregar producto Digital");
                Console.WriteLine("4. Actualizar precio");
                Console.WriteLine("5. Actualizar stock");
                Console.WriteLine("6. Eliminar productos");
                Console.WriteLine("7. Actualizar descuento de cliente");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                switch (Console.ReadLine())
                {
                    case "1": 
                        inv.ListarProductos(); 
                        break;
                    case "2":
                        AgregarProductoFisico();
                        break;
                    case "3":
                        AgregarProductoDigital();
                        break;
                    case "4":
                        ActualizarPrecio();
                        break;
                    case "5":
                        ActualizarStock();
                        break;
                    case "6":
                        Eliminar();
                        break;
                    case "7":
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