namespace TiendaConsolaV1_2
{
    class Rol
    {
        public string nombre{get;private set;}
        public bool PuedeManipular{get;private set;}
        public bool puedeComprar{get;private set;}

        public Rol(string nombre_, bool manipula, bool compra)
        {
            nombre = nombre_;
            PuedeManipular = manipula;
            puedeComprar = compra;
        }

    }
}