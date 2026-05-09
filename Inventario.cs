namespace TiendaConsolaV1_2
{
    public class Inventario
    {
        private Producto[] productos;
        private int numProductos;
        private int max = 1000;

        public Inventario()
        {
            productos    = new Producto[max];
            numProductos = 0;
        }

        public bool AgregarProductoFisico(string n, string c, double p, int stock)
        {
            if (numProductos >= max) return false;
            productos[numProductos++] = new ProductoFisico(n, c, p, stock);
            return true;
        }

        public bool AgregarProductoDigital(string n, string c, double p, string licencia)
        {
            if (numProductos >= max) return false;
            productos[numProductos++] = new ProductoDigital(n, c, p, licencia);
            return true;
        }

        public bool EliminarProducto(string nombre_)
        {
            for (int i = 0; i < numProductos; i++)
            {
                if (productos[i].nombre == nombre_)
                {
                    for (int j = i; j < numProductos - 1; j++)
                        productos[j] = productos[j + 1];
                    numProductos--;
                    return true;
                }
            }
            return false;
        }

        public bool ActualizarPrecio(string nombre_, double precio_)
        {
            for (int i = 0; i < numProductos; i++)
            {
                if (productos[i].nombre == nombre_)
                {
                    productos[i].ModificarPrecio(precio_);
                    return true;
                }
            }
            return false;
        }

        public bool ActualizarStock(string nombre_, int stock_)
        {
            for (int i = 0; i < numProductos; i++)
            {
                if (productos[i].nombre == nombre_ && productos[i] is ProductoFisico f)
                {
                    f.ModificarStock(stock_);
                    return true;
                }
            }
            return false;
        }

        public bool ComprarProducto(string n, int c)
        {
            for (int i = 0; i < numProductos; i++)
            {
                if (productos[i].nombre == n)
                    return productos[i].Comprar(c);
            }
            return false;
        }

        public void ListarProductos()
        {
            for (int i = 0; i < numProductos; i++)
                productos[i].Mostrar();
        }

        public Producto? BuscarProducto(string nombre_)
        {
            for (int i = 0; i < numProductos; i++)
            {
                if (productos[i].nombre == nombre_)
                    return productos[i];
            }
            return null;
        }
    }
}