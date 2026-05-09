namespace TiendaConsolaV1_2
{
    public class ProductoDigital : Producto
    {
        private string licencia;

        public override string Tipo => "Digital";

        public ProductoDigital(string nombre_, string codigo_, double precio_, string licencia_): base(nombre_, codigo_, precio_)
        {
            licencia = licencia_;
        }

        public override bool PuedeAgregar(int cantidad) 
        {
            return !string.IsNullOrEmpty(licencia);
        }
        public override bool Comprar(int cantidad)
        {
           return !string.IsNullOrEmpty(licencia);
        }

        public override void Mostrar()
        {
            Console.WriteLine($"tipo: {Tipo} | {nombre} | código: {codigo} | precio: {precio} | licencia: {licencia}");
        }
    }
}