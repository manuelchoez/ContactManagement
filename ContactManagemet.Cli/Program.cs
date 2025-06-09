

using ContactManagemet.Cli.Composition;
using ContactManagemet.Cli.Models;
using ContactManagemet.Cli.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddContactManagementServices();
    })
    .Build();

var servicio = host.Services.GetRequiredService<IContactService>();

while (true)
{
    Console.Clear();
    Console.WriteLine("AGENDA DE CONTACTOS");
    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Listar");
    Console.WriteLine("3. Buscar");
    Console.WriteLine("4. Editar");
    Console.WriteLine("5. Eliminar");
    Console.WriteLine("0. Salir");
    Console.Write("Opción: ");
    var opcion = Console.ReadLine()!;
    Console.Clear();
    switch (opcion)
    {
        case "1":
            Console.Write("Nombre: ");
            var name = Console.ReadLine()!;
            Console.Write("Teléfono: ");
            var phone = Console.ReadLine()!;
            Console.Write("Email: ");
            var email = Console.ReadLine()!;
            servicio.AddContact(name, phone, email);
            Console.WriteLine("Contacto agregado.");
            break;
        case "2":
            var result = servicio.GetAll();
            foreach (var resultItem in result)
                Console.WriteLine($"{resultItem.Id} : {resultItem.Name}| {resultItem.Phone}| {resultItem.Email}");
            break;
        case "3":
            Console.Write("Buscar por nombre: ");
            var buscado = servicio.SearchByName(Console.ReadLine()!);
            Console.WriteLine( buscado is not null ? $"{buscado.Id}: {buscado.Name}| {buscado.Phone}| {buscado.Email}" : "No existe contacto");
            break;
        case "4":
            Console.Write("Id del contacto");
            if (int.TryParse(Console.ReadLine(), out var idEditar))
            {
                Console.Write("Nuevo nombre: ");
                var nuevoNombre = Console.ReadLine()!;
                Console.Write("Nuevo teléfono: ");
                var nuevoTel = Console.ReadLine()!;
                Console.Write("Nuevo email: ");
                var nuevoEmail = Console.ReadLine()!;
                Console.WriteLine(servicio.ModifyContact(idEditar, nuevoNombre, nuevoTel, nuevoEmail)
                    ? "Contacto actualizado."
                    : "No encontrado.");
            }
            break;
        case "5":
            Console.Write("Id del contacto: ");
            if (int.TryParse(Console.ReadLine(), out var idEliminar))
            {
                Console.WriteLine(servicio.DeleteContact(idEliminar)
                    ? "Contacto eliminado."
                    : "No encontrado.");
            }
            break;            
        case "0":
            return;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine("\nPresione una tecla para continuar...");
    Console.ReadKey();
}