namespace TiendaConsolaV1_2
{
    class Usuario
    {
        public string nombre {get;private set;}
        public string contrasena {get;private set;}
        public Rol rol {get;private set;}
        public bool esVip{get; private set;}

        public Usuario(string nombre_, string contrasena_, Rol rol_, bool esVip_)
        {
            nombre = nombre_;
            contrasena = contrasena_;
            rol = rol_;
            esVip = esVip_;
        }

        public bool VerificarContraseña(string? contra)
        {
            return contrasena == contra;
        }
    }
}