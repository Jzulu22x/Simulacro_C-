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
        var vehicle = Administrator.ListVehicles.FirstOrDefault(vehicle=> vehicle.Id == id);
        if(vehicle != null)
        {
            Administrator.ListVehicles.Remove(vehicle);
            Console.WriteLine($"Vehicle with ID: {id} has been deleted");
        }
        else
        {
            Console.WriteLine($"Vehicle with ID: {id} not found");
        }
    }

    public void ShowDetails()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Engine Number: {EngineNumber}");
        Console.WriteLine($"Serial Number: {SerialNumber}");
        Console.WriteLine($"People Capacity: {PeopleCapacity}");
        Console.WriteLine($"Owner Name: {Owner?.TakeName()}");
    }

}
