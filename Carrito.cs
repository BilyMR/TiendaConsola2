namespace TiendaConsolaV1_2
{
    public class Carrito
    {
        private Producto[] productos;
        private int[] cantidades;
        public int numItems{get; private set;}
        private int max = 100;

        public Carrito()
        {
            productos = new Producto[max];
            cantidades = new int[max];
            numItems = 0;
        }

        public bool AgregarItem(Producto p, int cantidad)
        {
            if(numItems >= max) return false;
            if(p.cantidad < cantidad) return false;

            productos[numItems] = p;
            cantidades[numItems] = cantidad;
            numItems++;
            return true;
        }

        public bool EliminarItem(string codigo_)
        {
            for(int i = 0; i < numItems; i++)
            {
                if(productos[i].codigo == codigo_)
                {
                    for(int j = i; j < numItems - 1; j++)
                    {
                        productos[j] = productos[j+1];
                        cantidades[j] = cantidades[j+1];
                    }
                    numItems--;
                    return true;
                }
            }
            return false;
        }

        public double CalcularTotal()
        {
            double total = 0;
            for(int i = 0; i < numItems; i++)
                total += productos[i].precio * cantidades[i];
            return total;
        }

        public bool Confirmar(Inventario inv)
        {
            for(int i = 0; i < numItems; i++)
            {
                bool exito = inv.ComprarProducto(productos[i].nombre, cantidades[i]);
                if(!exito) return false;
            }
            return true;
        }

        public void Vaciar()
        {
            for(int i = 0; i < numItems; i++)
            {
                productos[i] = null;
                cantidades[i] = 0;
            }
            numItems = 0;
        }

        public void Mostrar()
        {
            for(int i = 0; i < numItems; i++)
                Console.WriteLine($"{i+1}. {productos[i].nombre} x{cantidades[i]} - ${productos[i].precio * cantidades[i]}");
            
            Console.WriteLine($"Total: ${CalcularTotal()}");
        }
    }
}