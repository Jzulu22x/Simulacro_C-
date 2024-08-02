using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models;
public static class Interface
{
    public static void ShowTitle(string title)
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }

    public static void Separator()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }

    public static void WaitKay()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
