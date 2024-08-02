using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models;
public class Vehicle
{
    public int Id { get; set; }
    public string? Placa { get; set; }
    public string? Type { get; set; }
    public string? EngineNumber { get; set; }
    public string? SerialNumber { get; set; }
    public byte PeopleCapacity { get; set; }
    public Driver? Owner { get; set; }

    public Vehicle(int id, string? placa, string? type, string? engineNumber, string? serialNumber, byte peopleCapacity, Driver? owner)
    {
        Id = id;
        Placa = placa;
        Type = type;
        EngineNumber = engineNumber;
        SerialNumber = serialNumber;
        PeopleCapacity = peopleCapacity;
        Owner = owner;
    }

    public void DeleteVehicle(int id)
    {
        var vehicle = Administrador.Vehicles.FirstOrDefault(vehicle=> vehicle.Id == id);
        if(vehicle != null)
        {
            Administrador.Vehicles.Remove(vehicle);
            Console.WriteLine($"Vehicle with ID: {id} has been deleted");
        }
        else
        {
            Console.WriteLine($"Vehicle with ID: {id} not found");
        }
    }
}
