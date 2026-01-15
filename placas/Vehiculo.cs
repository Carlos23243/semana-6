class Vehiculo
{
    public string Placa;
    public Vehiculo? Siguiente;

    public Vehiculo(string placa)
    {
        Placa = placa;
        Siguiente = null;
    }
}
