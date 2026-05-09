namespace TiendaConsolaV1_2{
    public abstract class Producto
    {
        public string nombre { get; }
        public string codigo { get; }
        public double precio { get; private set; }

        public abstract string Tipo { get; }

        public Producto(string nombre_, string codigo_, double precio_)
        {
            nombre = nombre_;
            codigo = codigo_;
            precio = precio_;
        }

        public void ModificarPrecio(double p)
        {
            precio = p;
        }

        public abstract bool PuedeAgregar(int cantidad);
        public abstract bool Comprar(int cantidad);
        public abstract void Mostrar();
    }

}