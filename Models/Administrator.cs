using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models;
public static class Administrator
{
    public static List<Driver> ListDrivers = [];
    public static List<Customer> ListCustomers = [];
    public static List<Vehicle> ListVehicles = [];

    public static void ListAllClients()
    {
        Console.WriteLine("List of Customers:");
        foreach (var customer in ListCustomers)
        {
            customer.ShowDetails();
        }
    }

    public static void ListAllDrivers()
    {
        Console.WriteLine("List of Drivers:");
        foreach (var driver in ListDrivers)
        {
            driver.ShowDetails();
        }
    }

    public static void CustomerMoreThan30Years()
    {
        Console.WriteLine("Customers older than 30 years:");
        foreach (var customer in ListCustomers)
        {
            if(customer.CalculateAge() > 30)
            {
                customer.ShowDetails();
            }
        }
    }

    public static void OrderByDrivingExperencie()
    {
        Console.WriteLine("Drivers ordered by driving experience:");
        ListDrivers = ListDrivers.OrderByDescending(e => e.CalculateAge()).ToList();
    }

    public static List<Customer> CustomerWhoPreferToPayWhitCreditCard()
    {
        Console.WriteLine("Customers who prefer to pay with credit card:");
        return ListCustomers.Where(e => e.PreferredPaymentMethod == "credit card").ToList();
    }

    public static List<Driver> DriversWhitA2License()
    {
        Console.WriteLine("Drivers with A2 license:");
        return ListDrivers.Where(e => e.LicenseCategory == "a2").ToList();
    }
}
