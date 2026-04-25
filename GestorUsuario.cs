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

        public bool AgregarUsuario(string n, string c, Rol r, bool t)
        {
            if(numUsuarios >= max) return false;
            usuarios[numUsuarios++] = new Usuario(n, c, r, t);
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