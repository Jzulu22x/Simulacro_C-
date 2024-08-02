using System.Data.Common;
using Simulacro_C_.Models;

bool run = true;

while (run)
{
    Console.Clear();
    Interface.ShowTitle("    Welcome to the TransRiwi System");

    Console.WriteLine("1. Driver");
    Console.WriteLine("2. Customer");
    Console.WriteLine("3. Vehicle");

    Interface.Separator();

    Console.Write("Choose an option: ");
    string? optionMainMenu = Console.ReadLine();



    switch (optionMainMenu)
    {
        case "1":

            Console.Clear();
            Interface.ShowTitle("          Driver Management");
            // Menu driver

            Console.WriteLine("1. Add Driver");
            Console.WriteLine("2. Update License Category");
            Console.WriteLine("3. Add Experience to a Driver");
            Console.WriteLine("4. Show All Drivers");
            Console.WriteLine("5. Order Drivers By Experience Years");
            Console.WriteLine("6. Show All Drivers Who Have A2 License");
            Console.WriteLine("7. Return To Menu");

            Interface.Separator();

            Console.Write("Choose an option: ");
            string? optionDriverMenu = Console.ReadLine();

            switch (optionDriverMenu)
            {
                case "1":
                    // Add driver
                    Console.Clear();
                    Interface.ShowTitle("              Add Driver");

                    Console.WriteLine("Enter the name of the driver: ");
                    Console.Write("=> ");
                    string? nameNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(nameNewDriver))
                    {
                        Console.WriteLine("Invalid name. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the last name of the driver: ");
                    Console.Write("=> ");
                    string? lastNameNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(lastNameNewDriver))
                    {
                        Console.WriteLine("Invalid last name. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the type document of the driver: ");
                    Console.Write("=> ");
                    string? typeDocumentNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(typeDocumentNewDriver))
                    {
                        Console.WriteLine("Invalid type document. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the number document of the driver: ");
                    Console.Write("=> ");
                    string? numberDocumentNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(numberDocumentNewDriver))
                    {
                        Console.WriteLine("Invalid number document. Please try again.");
                        Interface.WaitKay();
                        break;
                    }


                    // Console.WriteLine("Enter the BirthDate of the driver (dd/MM/yyyy): ");
                    // Console.Write("=> ");
                    // DateOnly birthDateNewDriver;
                    // if (!DateOnly.TryParse(Console.ReadLine(), out birthDateNewDriver))
                    // {
                    //     Interface.Separator();
                    //     Console.WriteLine("Invalid date. Please try again.");
                    //     Interface.WaitKay();
                    //     break;
                    // }

                    Console.WriteLine("Enter the driver's year of birth: ");
                    Console.Write("=> ");
                    int year;
                    if (!int.TryParse(Console.ReadLine(), out year))
                    {
                        Interface.Separator();
                        Console.WriteLine("Invalid year. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the driver's month of birth: ");
                    Console.Write("=> ");
                    int month;
                    if (!int.TryParse(Console.ReadLine(), out month))
                    {
                        Interface.Separator();
                        Console.WriteLine("Invalid month. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the driver's day of birth: ");
                    Console.Write("=> ");
                    int day;
                    if (!int.TryParse(Console.ReadLine(), out day))
                    {
                        Interface.Separator();
                        Console.WriteLine("Invalid day. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    DateOnly birthDateNewDriver = new DateOnly(year, month, day);

                    Interface.Separator();


                    Console.WriteLine("Enter the email of the driver: ");
                    Console.Write("=> ");
                    string? emailNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(emailNewDriver))
                    {
                        Console.WriteLine("Invalid email. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the phone number of the driver: ");
                    Console.Write("=> ");
                    string? phoneNumberNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(phoneNumberNewDriver))
                    {
                        Console.WriteLine("Invalid phone number. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the address of the driver: ");
                    Console.Write("=> ");
                    string? addressNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(addressNewDriver))
                    {
                        Console.WriteLine("Invalid address. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the license number of the driver: ");
                    Console.Write("=> ");
                    string? licenseNumberNewDriver = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(licenseNumberNewDriver))
                    {
                        Console.WriteLine("Invalid license number. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the license category of the driver: ");
                    Console.Write("=> ");
                    string? licenseCategoryNewDriver = Console.ReadLine().ToUpper();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(licenseCategoryNewDriver))
                    {
                        Console.WriteLine("Invalid license category. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    if (!string.Equals(licenseCategoryNewDriver, "A2") && !string.Equals(licenseCategoryNewDriver, "B1"))
                    {
                        Console.WriteLine("Invalid license category. It must be 'A2' or 'B1'. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the driving experience of the driver (in years): ");
                    Console.Write("=> ");
                    int drivingExperienceNewDriver;
                    if (!int.TryParse(Console.ReadLine(), out drivingExperienceNewDriver))
                    {
                        Console.WriteLine("Invalid driving experience. Please try again.");
                        Interface.WaitKay();
                        optionDriverMenu = "1";
                        break;
                    }

                    var newDriver = new Driver(nameNewDriver, lastNameNewDriver, typeDocumentNewDriver, numberDocumentNewDriver, birthDateNewDriver, emailNewDriver, phoneNumberNewDriver, addressNewDriver, licenseNumberNewDriver, licenseCategoryNewDriver, drivingExperienceNewDriver);
                    Administrator.ListDrivers.Add(newDriver);
                    break;

                case "2":
                    // Update license category
                    Console.Clear();
                    Interface.ShowTitle("Update license category");
                    Console.WriteLine("Enter the driving document");

                    Console.Write("=> ");
                    string drivingDocument = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(drivingDocument))
                    {
                        Console.WriteLine("Invalid driving document. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    if (!Administrator.ListDrivers.Any(d => d.TakeIdentificationNumber() == drivingDocument))
                    {
                        Console.WriteLine("Driver not found with this driving document.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the new license category (A2 or B2): ");
                    Console.Write("=> ");
                    string newLicenseCategory = Console.ReadLine().ToUpper();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(newLicenseCategory))
                    {
                        Console.WriteLine("Invalid license category. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    if (!string.Equals(newLicenseCategory, "A2") && !string.Equals(newLicenseCategory, "B2"))
                    {
                        Console.WriteLine("Invalid license category. It must be 'A2' or 'B2'. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    var driverToUpdate = Administrator.ListDrivers.FirstOrDefault(d => d.TakeIdentificationNumber() == drivingDocument);
                    driverToUpdate.UpdateLicenseCategory(newLicenseCategory);
                    break;


                case "3":
                    // Add experience
                    Console.Clear();
                    Interface.ShowTitle("Add experience");
                    Console.WriteLine("Enter the driving document");
                    Console.Write("=> ");
                    string drivingDocumentExperience = Console.ReadLine();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(drivingDocumentExperience))
                    {
                        Console.WriteLine("Invalid driving document. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    if (!Administrator.ListDrivers.Any(d => d.TakeIdentificationNumber() == drivingDocumentExperience))
                    {
                        Console.WriteLine("Driver not found with this driving document.");
                        Interface.WaitKay();
                        break;
                    }
                    Console.WriteLine("Enter the years of experience: ");
                    Console.Write("=> ");
                    int experienceYears;
                    if (!int.TryParse(Console.ReadLine(), out experienceYears))
                    {
                        Console.WriteLine("Invalid experience years. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    var driverToUpdateExperience = Administrator.ListDrivers.FirstOrDefault(d => d.TakeIdentificationNumber() == drivingDocumentExperience);
                    driverToUpdateExperience.AddExperience(experienceYears);

                    break;

                case "4":
                    // Show all drivers
                    Administrator.ListAllDrivers();
                    Interface.WaitKay();
                    break;

                case "5":
                    // Order drivers by experience years
                    Administrator.OrderByDrivingExperencie();
                    Interface.WaitKay();
                    break;

                case "6":
                    // Show all drivers with A2 license
                    Administrator.DriversWhitA2License();
                    Interface.WaitKay();
                    break;

                case "7":
                    // Return to menu
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    Interface.WaitKay();
                    break;
            }

            break;


        case "2":

            Console.Clear();
            Interface.ShowTitle("        Customer Management");
            // Menu customer

            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Update Membership Level");
            Console.WriteLine("3. Show customers paying by credit card");
            Console.WriteLine("4. Show All Customers");
            Console.WriteLine("5. Show customers over 30 years old");
            Console.WriteLine("6. Return To Menu");

            Interface.Separator();

            Console.Write("Choose an option: ");
            string? optionCustomerMenu = Console.ReadLine();

            switch (optionCustomerMenu)
            {
                case "1":
                    // Add customer
                    Console.Clear();
                    Interface.ShowTitle("Add Customer");
                    Console.WriteLine("Enter the customer's name: ");
                    Console.Write("=> ");
                    string nameNewCustomer = Console.ReadLine();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(nameNewCustomer))
                    {
                        Console.WriteLine("Invalid name. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    Console.WriteLine("Enter the customer's last name: ");
                    Console.Write("=> ");
                    string lastNameNewCustomer = Console.ReadLine();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(lastNameNewCustomer))
                    {
                        Console.WriteLine("Invalid last name. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    Console.WriteLine("Enter the customer's type document: ");
                    Console.Write("=> ");
                    string TypeDocumentNewCustomer = Console.ReadLine();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(TypeDocumentNewCustomer))
                    {
                        Console.WriteLine("Invalid type document. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    Console.WriteLine("Enter the customer's number document: ");
                    Console.Write("=> ");
                    string NumberDocumentNewCustomer = Console.ReadLine();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(NumberDocumentNewCustomer))
                    {
                        Console.WriteLine("Invalid number document. Please try again.");
                        Interface.WaitKay();
                        break;
                    }


                    Console.WriteLine("Enter the customer's year of birth: ");
                    Console.Write("=> ");
                    int year;
                    if (!int.TryParse(Console.ReadLine(), out year))
                    {
                        Interface.Separator();
                        Console.WriteLine("Invalid year. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the customer's month of birth: ");
                    Console.Write("=> ");
                    int month;
                    if (!int.TryParse(Console.ReadLine(), out month))
                    {
                        Interface.Separator();
                        Console.WriteLine("Invalid month. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the customer's day of birth: ");
                    Console.Write("=> ");
                    int day;
                    if (!int.TryParse(Console.ReadLine(), out day))
                    {
                        Interface.Separator();
                        Console.WriteLine("Invalid day. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    DateOnly birthDateNewCustomer = new DateOnly(year, month, day);

                    Interface.Separator();

                    Console.WriteLine("Enter the customer's email: ");
                    Console.Write("=> ");
                    string emailNewCustomer = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(emailNewCustomer))
                    {
                        Console.WriteLine("Invalid email. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the customer's phone number: ");
                    Console.Write("=> ");
                    string phoneNumberNewCustomer = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(phoneNumberNewCustomer))
                    {
                        Console.WriteLine("Invalid phone number. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the customer's address: ");
                    Console.Write("=> ");
                    string addressNewCustomer = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(addressNewCustomer))
                    {
                        Console.WriteLine("Invalid address. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the customer's membership level: ");
                    Console.Write("=> ");
                    string membershipLevelNewCustomer = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(membershipLevelNewCustomer))
                    {
                        Console.WriteLine("Invalid membership level. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the customer's preferred payment method: ");
                    Console.Write("=> ");
                    string preferredPaymentMethodNewCustomer = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(preferredPaymentMethodNewCustomer))
                    {
                        Console.WriteLine("Invalid preferred payment method. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    Customer newCustomer = new Customer(nameNewCustomer, lastNameNewCustomer, TypeDocumentNewCustomer, NumberDocumentNewCustomer, birthDateNewCustomer, emailNewCustomer, phoneNumberNewCustomer, addressNewCustomer, membershipLevelNewCustomer, preferredPaymentMethodNewCustomer);
                    Administrator.ListCustomers.Add(newCustomer);
                    break;


                case "2":
                    // Update membership level
                    Console.Clear();
                    Interface.ShowTitle("Update Membership Level");
                    Console.WriteLine("Enter the customer's identification number: ");
                    Console.Write("=> ");
                    string identificationNumberCustomerToUpdate = Console.ReadLine();
                    Interface.Separator();
                    Customer? customerToUpdate = Administrator.ListCustomers.Find(c => c.TakeIdentificationNumber() == identificationNumberCustomerToUpdate);
                    if (customerToUpdate == null)
                    {
                        Console.WriteLine("Customer not found.");
                        Interface.WaitKay();
                        break;
                    }
                    Console.WriteLine("Enter the new membership level: ");
                    Console.Write("=> ");
                    string newMembershipLevel = Console.ReadLine();
                    customerToUpdate.UpdateMembershipLevel();
                    break;

                case "3":
                    // Show customers paying by credit card
                    Administrator.CustomerWhoPreferToPayWhitCreditCard();
                    Interface.WaitKay();
                    break;

                case "4":
                    // Show all customers
                    Administrator.ListAllCustomers();
                    Interface.WaitKay();
                    break;

                case "5":
                    // Show customers over 30 years old
                    Administrator.CustomerMoreThan30Years();
                    Interface.WaitKay();
                    break;

                case "6":
                    // Return to menu
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    Interface.WaitKay();
                    break;
            }

            break;


        case "3":

            Console.Clear();
            Interface.ShowTitle("          Vehicle Management");
            // Menu driver

            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. Delete Vehicle");
            Console.WriteLine("2. Show All Vehicles");
            Console.WriteLine("3. Return To Menu");

            Interface.Separator();

            Console.Write("Choose an option: ");
            string? optionVehicleMenu = Console.ReadLine();

            switch (optionVehicleMenu)
            {
                case "1":
                    int CountId = 0;
                    // Add vehicle
                    Console.Clear();
                    Interface.ShowTitle("Add Vehicle");
                    Console.WriteLine("Enter the vehicle's Placa: ");
                    Console.Write("=> ");
                    string? optionVehicle = Console.ReadLine();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(optionVehicle))
                    {
                        Console.WriteLine("Invalid vehicle placa. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the vehicle's type: ");
                    Console.WriteLine("Permitted vehicles are: (car, motorbike, van, minibus)");
                    Console.Write("=> ");
                    string? optionVehicleType = Console.ReadLine().ToLower();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(optionVehicleType))
                    {
                        Console.WriteLine("Invalid vehicle type. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    if(!string.Equals(optionVehicleType, "car") && !string.Equals(optionVehicleType, "motorbike") && !string.Equals(optionVehicleType, "van") && !string.Equals(optionVehicleType, "minibus"))
                    {
                        Console.WriteLine("Invalid vehicle type. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the vehicle's engine number: ");
                    Console.Write("=> ");
                    string? optionVehicleEngineNumber = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(optionVehicleEngineNumber))
                    {
                        Console.WriteLine("Invalid vehicle engine number. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the vehicle's serial number: ");
                    Console.Write("=> ");
                    string? optionVehicleSerialNumber = Console.ReadLine();

                    Interface.Separator();

                    if (string.IsNullOrWhiteSpace(optionVehicleSerialNumber))
                    {
                        Console.WriteLine("Invalid vehicle serial number. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Console.WriteLine("Enter the vehicle's people capacity: ");
                    Console.Write("=> ");
                    byte vehicleCapacity;
                    if (!byte.TryParse(Console.ReadLine(), out vehicleCapacity))
                    {
                        
                        Interface.Separator();

                        Console.WriteLine("Invalid vehicle capacity. Please try again.");
                        Interface.WaitKay();
                        break;
                    }

                    Interface.Separator();

                    Console.WriteLine("Enter the vehicle's owner's identification number: ");
                    Console.Write("=> ");
                    string? optionVehicleDriverIdentificationNumber = Console.ReadLine();
                    Interface.Separator();
                    if (string.IsNullOrWhiteSpace(optionVehicleDriverIdentificationNumber))
                    {
                        Console.WriteLine("Invalid vehicle owner's identification number. Please try again.");
                        Interface.WaitKay();
                        break;
                    }
                    Driver? owner = Administrator.ListDrivers.Find(d => d.TakeIdentificationNumber() == optionVehicleDriverIdentificationNumber);
                    if (owner == null)
                    {
                        Console.WriteLine("Owner not found.");
                        Interface.WaitKay();
                        break;
                    }
                    CountId++;
                    Vehicle newVehicle = new Vehicle(CountId, optionVehicle, optionVehicleType, optionVehicleEngineNumber, optionVehicleSerialNumber, vehicleCapacity, owner);

                    break;

                case "2":
                    // Delete vehicle
                    break;

                case "3":
                    // Show all vehicles
                    Administrator.ListAllVehicles();
                    Interface.WaitKay();
                    break;

                case "4":
                    // Return to menu
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    Interface.WaitKay();
                    break;
            }

            break;


        case "4":
            run = false;
            break;


        default:
            Console.WriteLine("Invalid option. Please try again.");
            Interface.Separator();
            Interface.WaitKay();
            break;
    }


}

