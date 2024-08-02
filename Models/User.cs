using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models;
public class User
{
    protected Guid Id   { get; set; }
    protected string? Name { get; set; }
    protected string? LastName { get; set; }
    protected string? TypeDocument { get; set; }
    protected string?  IdentificationNumber { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string? Email { get; set; }
    protected string? PhoneNumber { get; set; }
    protected string? Adress { get; set; }

    protected User(string? name, string? lastName, string? typeDocument, string? identificationNumber, DateOnly birthDate, string? email, string? phoneNumber, string? adress)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        TypeDocument = typeDocument;
        IdentificationNumber = identificationNumber;
        BirthDate = birthDate;
        Email = email;
        PhoneNumber = phoneNumber;
        Adress = adress;
    }

    protected virtual void ShowDetails()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Type Document: {TypeDocument}");
        Console.WriteLine($"Identification Number: {IdentificationNumber}");
        Console.WriteLine($"Birth Date: {BirthDate:dd/MM/yyyy}");
        ShowAge();
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
        Console.WriteLine($"Adress: {Adress}");
    }

    protected int CalculateAge()
    {
        int age = DateTime.Now.Year - BirthDate.Year;
        return age;
    }

    protected void ShowAge()
    {
        Console.WriteLine($"Age: {CalculateAge()}");
    }
}
