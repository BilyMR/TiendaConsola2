namespace TiendaConsolaV1_2
{
    class MenuCliente
    {
        private Inventario inv;
        private Carrito car;
        private Usuario usuario;
        private Descuento desc;
        public MenuCliente(Inventario i, Usuario u, Descuento d)
        {
            inv = i;
            usuario = u;
            desc = d;
            car = new Carrito();
        }

        private void AgregarToCarrito()
        {
            Console.Write("Ingrese el producto que quiere comprar: ");
            string? producto = Console.ReadLine();

            Producto? producto1 = inv.BuscarProducto(producto);
            if(producto1== null)
            {
                Console.WriteLine("Producto no encontrado");
            }

            Console.Write("Ingrese la cantidad de el producto que quiere comprar: ");
            int cantidad = int.Parse(Console.ReadLine());

            bool exito = car.AgregarItem(producto1, cantidad);

            if (exito)
            {
                Console.WriteLine("Producto agregado correctamente");
            } else
            {
                Console.WriteLine("No hay sufuciente stock");
            }
        }

        public void Confirmar()
        {
            if (car.numItems == 0)
            {
                Console.WriteLine("El carrito está vacío");
                return;
            }

            double total      = car.CalcularTotal();
            double porcentaje = 0;

            if (usuario.esVip)
            {
                porcentaje = desc.porcentaje;
                if (total > desc.cap)
                    porcentaje += desc.porcentajeExtra;
            }


            Console.WriteLine("\n=== Resumen de compra ===");
            car.Mostrar(desc.porcentaje);

            Console.Write("¿Confirmar compra? (s/n): ");
            string respuesta = Console.ReadLine();

            if (respuesta == "s")
            {
                bool exito = car.Confirmar(inv);
                if (exito)
                {
                    Console.WriteLine("Compra realizada con éxito");
                    Console.WriteLine("Factura:");
                    car.Mostrar(porcentaje);
                    car.Vaciar();
                }
                else
                    Console.WriteLine("Error al confirmar, puede que el stock haya cambiado");
            }
            else
            {
                Console.WriteLine("Compra cancelada");
            }
        }

        public void Iniciar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n=== Menú Comprador ===");
                Console.WriteLine("1. Ver productos");
                Console.WriteLine("2. Agregar al carrito");
                Console.WriteLine("3. Ver carrito");
                Console.WriteLine("4. Confirmar compra");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                switch(Console.ReadLine())
                {
                    case "1": 
                        inv.ListarProductos(); 
                        break;
                    case "2": 
                        AgregarToCarrito(); 
                        break;
                    case "3": 
                        car.Mostrar(); 
                        break;
                    case "4": 
                        Confirmar(); 
                        break;
                    case "0": 
                        salir = true; 
                        break;
                }
            }
        }
    }
}