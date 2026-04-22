using System.Net.Http.Headers;

namespace TiendaConsolaV1_2
{
    class MenuLogin
    {
        private GestionUsuarios gestor;
        public MenuLogin(GestionUsuarios g)
        {
            gestor = g;
        }

        public Usuario? Iniciar()
        {
            Console.WriteLine("Inicio de sesión: ");
            Console.Write("Usuario: ");
            string? nombre = Console.ReadLine();
            Console.Write("Contrasena: ");
            string? contra = Console.ReadLine();

            Usuario? usuario = gestor.Login(nombre, contra);

            if(usuario == null)
            {
                Console.WriteLine("Credenciales incorrectas");
            }

            return usuario;
        }
    }
}