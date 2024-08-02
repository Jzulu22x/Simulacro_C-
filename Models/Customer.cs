using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models;
public class Customer : User
{
    public string? MembershipLevel { get; set; }
    public string? PreferredPaymentMethod { get; set; }

    public Customer(string? name, string? lastName, string? typeDocument, string? identificationNumber, DateOnly birthDate, string? email, string? phoneNumber, string? address, string? membershipLevel, string? preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
    {
        MembershipLevel = membershipLevel.ToLower();
        PreferredPaymentMethod = preferredPaymentMethod.ToLower();
    }

    public void UpdateMembershipLevel()
    {
        if(MembershipLevel == "premium")
        {
            Console.WriteLine("The membership level cannot be upgraded because it is already a premium membership"); 
        }
        else 
        {
            Console.WriteLine($"Membership level updated from: {MembershipLevel} to: premium");
            MembershipLevel = "premium";
        }
    }

    public void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine($"Membership Level: {MembershipLevel}");
        Console.WriteLine($"Preferred Payment Method: {PreferredPaymentMethod}");
    }

    public int CalculateAge()
    {
        return base.CalculateAge();
    }
}
