namespace TiendaConsolaV1_2 {
    public class Inventario
    {
        private Producto[] productos;
        private int numProductos;
        private int max = 1000;

        public Inventario()
        {
            productos = new Producto[max];
            numProductos = 0;
        }

        public bool AgregarProducto(string n, string c, double p, int q)
        {
            if(numProductos >= max) return false;
            productos[numProductos++] = new Producto(n, c, p, q);
            return true;
        }

        public bool EliminarProducto(string nombre_)
        {
            for(int i = 0; i < numProductos; i++)
            {
                if(productos[i].nombre == nombre_)
                {
                    for(int j = i; j < numProductos-1; j++)
                    {
                        productos[j] = productos[j+1];
                    }
                    numProductos--;
                    return true;
                }
            }
            return false;
        }
        public bool ActualizarProducto(string nombre_, double precio_, int cantidad_)
        {
            for(int i = 0; i < numProductos; i++)
            {
                if(productos[i].nombre == nombre_)
                {
                    productos[i].ModificarPrecio(precio_);
                    productos[i].ModificarCantidad(cantidad_);
                    return true;
                }
            }
            return false;
        }
        public void ListarProductos()
        {
            for(int i = 0; i < numProductos; i++)
            {
                productos[i].Mostrar();
            }
        }

        public bool ComprarProducto(string n, int c)
        {
            for(int i =0; i < numProductos; i++)
            {
                if(productos[i].nombre == n)
                {
                    if(productos[i].cantidad < c)
                    {
                        return false;
                    }
                    productos[i].ModificarCantidad(productos[i].cantidad - c);
                    return true;
                }
            }
            return false;
        }

        public Producto? BuscarProducto(string nombre_)
        {
            for(int i = 0; i < numProductos; i++)
            {
                if(productos[i].nombre == nombre_)
                {
                    return productos[i];
                }
            }
            return null;
        }
    }
}