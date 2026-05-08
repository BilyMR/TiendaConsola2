using TiendaConsolaV1_2;
Inventario inv = new Inventario();
GestionUsuarios gestor = new GestionUsuarios();
//usuarios para poder hacer login
gestor.AgregarAdmin("Manuel", "123");
gestor.AgregarCliente("Paco", "paco", false);
gestor.AgregarCliente("SuperPaco", "paco123", true);
//
Descuento desc = new Descuento();;
inv.AgregarProducto("Chubasquero para peces", "asd", 120.00, 50);
inv.AgregarProducto("Zapatos para tortugas", "qwe", 300.50, 20);
inv.AgregarProducto("Colonia matamosquitos", "zxc", 500.01, 10);
inv.AgregarProducto("Oreja de mono", "ewq", 10.99, 100);

MenuLogin menuLogin = new MenuLogin(gestor);
bool corriendo = true;
while(corriendo)
{
    Usuario? usuario = menuLogin.Iniciar();

    if(usuario != null)
    {
        if(usuario is UsuarioAdmin)
            new MenuAdmin(inv, desc).Iniciar();
        else if(usuario is UsuarioCliente cliente1)
            new MenuCliente(inv, cliente1, desc).Iniciar();

        Console.WriteLine("Sesión cerrada");
    }
    else
    {
        Console.WriteLine("Acceso denegado");
        Console.Write("¿Desea intentar de nuevo? (s/n): ");
        if(Console.ReadLine() != "s")
            corriendo = false;
    }
}