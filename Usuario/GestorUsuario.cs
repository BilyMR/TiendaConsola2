using System.Net.Http.Headers;

namespace TiendaConsolaV1_2
{
    class GestionUsuarios
    {
        private Usuario[] usuarios;
        private int numUsuarios;
        private int max = 100;

        public GestionUsuarios()
        {
            usuarios = new Usuario[max];
            numUsuarios = 0;
        }

        public bool AgregarAdmin(string n, string c)
        {
            if(numUsuarios >= max) return false;
            usuarios[numUsuarios++] = new UsuarioAdmin(n, c);
            return true;
        }

        public bool AgregarCliente(string n, string c, bool v)
        {
            if(numUsuarios >= max) return false;
            usuarios[numUsuarios++] = new UsuarioCliente(n, c, v);
            return true;
        }

        public Usuario? Login(string? nombre_, string? contra)
        {
            for(int i = 0; i < numUsuarios; i++)
            {
                if(usuarios[i].nombre == nombre_ && usuarios[i].VerificarContraseña(contra))
                {
                    return usuarios[i];
                }
            }

            return null;
        }

    }
}