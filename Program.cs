using TiendaConsolaV1_2;
Inventario inv = new Inventario();
Rol admin = new Rol("admin", manipula: true, compra: false);
Rol cliente = new Rol("cliente", manipula: false, compra: true);
GestionUsuarios gestor = new GestionUsuarios();
gestor.AgregarUsuario("Manuel", "123", admin);
gestor.AgregarUsuario("Paco", "paco", cliente);
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
        if(usuario.rol.PuedeManipular)
            new MenuAdmin(inv).Iniciar();
        else if(usuario.rol.puedeComprar)
            new MenuCliente(inv).Iniciar();

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