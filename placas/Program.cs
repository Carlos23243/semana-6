using System;

ListaVehiculos lista = new ListaVehiculos();
int opcion;

do
{
    Console.WriteLine("\n--- ESTACIONAMIENTO ING. SISTEMAS ---");
    Console.WriteLine("1. Registrar vehículo");
    Console.WriteLine("2. Mostrar vehículos");
    Console.WriteLine("3. Buscar vehículo");
    Console.WriteLine("4. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("Ingrese un número válido.");
        continue;
    }

    switch (opcion)
    {
        case 1:
            lista.RegistrarVehiculo();
            break;

        case 2:
            lista.MostrarVehiculos();
            break;

        case 3:
            Console.Write("Ingrese la placa a buscar: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string placa = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            lista.BuscarVehiculo(placa);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            break;

        case 4:
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

} while (opcion != 4);
