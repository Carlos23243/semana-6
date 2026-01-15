class ListaVehiculos
{
    private Vehiculo? cabeza;

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
    public ListaVehiculos()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de agregar el modificador "required" o declararlo como un valor que acepta valores NULL.
    {
        cabeza = null;
    }

    // Registrar vehículo
    public void RegistrarVehiculo()
    {
        Console.Write("Ingrese la placa del vehículo: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        string placa = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

#pragma warning disable CS8604 // Posible argumento de referencia nulo
        Vehiculo nuevo = new Vehiculo(placa);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8601 // Posible asignación de referencia nula
        nuevo.Siguiente = cabeza;
#pragma warning restore CS8601 // Posible asignación de referencia nula
        cabeza = nuevo;

        Console.WriteLine("Vehículo registrado correctamente.");
    }

    // Mostrar vehículos
    public void MostrarVehiculos()
    {
        if (cabeza == null)
        {
            Console.WriteLine("No hay vehículos registrados.");
            return;
        }

        Vehiculo actual = cabeza;
        Console.WriteLine("\nVehículos en el estacionamiento:");

        while (actual != null)
        {
            Console.WriteLine("- Placa: " + actual.Placa);
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            actual = actual.Siguiente;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        }
    }

    // Buscar vehículo por placa
    public void BuscarVehiculo(string placa)
    {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        Vehiculo actual = cabeza;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

        while (actual != null)
        {
            if (actual.Placa.Equals(placa))
            {
                Console.WriteLine("Vehículo encontrado.");
                return;
            }
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            actual = actual.Siguiente;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
        }

        Console.WriteLine("Vehículo no encontrado.");
    }
}
