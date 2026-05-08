namespace TiendaConsolaV1_2
{
    class UsuarioCliente : Usuario
    {
        public bool esVip {get; private set;}
        public UsuarioCliente(string n, string c, bool vip = false): base(n, c)
        {
            esVip = vip;
        }
    }
}