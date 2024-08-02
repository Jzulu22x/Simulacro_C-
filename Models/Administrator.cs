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

    public static void ListAllCustomers()
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

    public static void ListAllVehicles()
    {
        Console.WriteLine("List of Vehicles:");
        foreach (var vehicle in ListVehicles)
        {
            vehicle.ShowDetails();
        }
    }

    public static void CustomerMoreThan30Years()
    {
        List<Customer> customersMore30Years = ListCustomers.Where(e => e.CalculateAge() > 30).ToList();
        if (customersMore30Years.Count > 0)
        {
            Console.WriteLine("Customers older than 30 years:");
            foreach (var customer in ListCustomers)
            {
                if (customer.CalculateAge() > 30)
                {
                    Interface.Separator();
                    customer.ShowDetails();
                    Interface.Separator();
                }
            }
        }
        else
        {
            Console.WriteLine("No customers found over 30 years old");
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

    public static void DriversWhitA2License()
    {
        List<Driver> A2License = ListDrivers.Where(e => e.LicenseCategory == "A2").ToList();
        if (A2License.Count > 0)
        {
            Console.WriteLine("\nDrivers with A2 license:");
            foreach (var item in A2License)
            {
                Interface.Separator();
                item.ShowDetails();
                Interface.Separator();
            }
        }
        else
        {
            Console.WriteLine("No drivers found with A2 license");
        }
    }
}
