namespace TiendaConsolaV1_2
{
    public class ProductoFisico : Producto
    {
        public int stock { get; private set; }

        public override string Tipo => "Físico";

        public ProductoFisico(string nombre_, string codigo_, double precio_, int stock_) : base(nombre_, codigo_, precio_)
        {
            stock = stock_;
        }

        public override bool PuedeAgregar(int cantidad)
        {
            return stock >= cantidad;
        }

        public override bool Comprar(int cantidad)
        {
            if (stock < cantidad) return false;
            stock -= cantidad;
            return true;
        }

        public void ModificarStock(int s)
        {
            stock = s;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"tipo: {Tipo} | {nombre} | código: {codigo} | precio: {precio} | stock: {stock}");
        }
    }
}