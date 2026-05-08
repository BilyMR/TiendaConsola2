namespace TiendaConsolaV1_2
{
    abstract class Usuario
    {
        public string nombre {get;private set;}
        public string contrasena {get;private set;}

        public Usuario(string nombre_, string contrasena_)
        {
            nombre = nombre_;
            contrasena = contrasena_;
        }

        public bool VerificarContraseña(string? contra)
        {
            return contrasena == contra;
        }
    }
}