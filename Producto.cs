namespace TiendaConsolaV1_2{

    public class Producto
    {
        public string nombre {get;}
        public string codigo {get; private set;}
        public double precio {get;private set;}
        public int cantidad {get;private set;}
        public Producto(string nombre_, string codigo_, double precio_, int cantidad_)
        {
            nombre = nombre_;
            codigo = codigo_;
            precio = precio_;
            cantidad = cantidad_;
        }
        public void Mostrar()
        {
            Console.WriteLine(nombre + " | codigo: " + codigo + " | precio: " + precio + " | cantidad: " + cantidad);
        }

        public void ModificarPrecio(double p)
        {
            precio = p;
        }
        public void ModificarCantidad(int c)
        {
            cantidad = c;
        }

    }
}