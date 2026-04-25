namespace TiendaConsolaV1_2
{
    class Descuento
    {
        public double porcentaje { get; set;}
        public double cap { get; set;}
        public double porcentajeExtra {get; set;}

        public Descuento()
        {
            porcentaje = 10;
            cap        = 500;
            porcentajeExtra = 5;
        }
    }
}