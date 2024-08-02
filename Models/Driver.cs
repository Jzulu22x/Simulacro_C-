using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models;
public class Driver : User
{
    public string?  LicenseNumber { get; set; }
    public string?  LicenseCategory { get; set; }
    public int DrivingExperience { get; set; }

    public Driver(string? name, string? lastName, string? typeDocument, string? identificationNumber, DateOnly birthDate, string? email, string? phoneNumber, string? address, string? licenseNumber, string? licenseCategory, int drivingExperience) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
    {
        LicenseNumber = licenseNumber;
        LicenseCategory = licenseCategory;
        DrivingExperience = drivingExperience;
    }

    public void UpdateLicenseCategory(string newCategory)
    {
        Console.WriteLine($"License category updated from: {LicenseCategory} to: {newCategory}");
        LicenseCategory = newCategory;
    }

    public void AddExperience(int years)
    {
        Console.WriteLine($"Driving experience increased from: {years} to: {DrivingExperience += years}");
        DrivingExperience += years;
    }

    public void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine($"License Number: {LicenseNumber}");
        Console.WriteLine($"License Category: {LicenseCategory}");
        Console.WriteLine($"Driving Experience: {DrivingExperience} years");
    }

    public int CalculateAge()
    {
        return base.CalculateAge();
    }    
}
