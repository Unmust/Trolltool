using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

//Trolltool V3.0, @Fr0nt 2024, NO COPYRIGHT LOLOLOL

Console.Title = "Trolltool - EULA";
Console.WriteLine("Trolltool V3.0 EULA");
Console.WriteLine("");
Console.WriteLine("You as the user of Trolltool, has to accept this EULA to use the tool Trolltool.\r\nI'm not responsible for any harm caused on any computer, yours or not.\r\nYou will take all responsibility of using my tool.\r\nBy pressing [Q] TWICE, you will accept this EULA automatically and accept this EULA's contents\r\neven if you didn't to read it. ");
Console.WriteLine("");
Console.WriteLine("Press [Q] TWICE to accept and continue.");
ConsoleKeyInfo keyPressed = Console.ReadKey();
if (Console.ReadKey(true).Key != ConsoleKey.Q)
{
    Console.Clear();
    Console.WriteLine("You didn't accept the EULA, you can't use Trolltool without accepting it!");
    Console.ReadKey();
}
else
{
    Console.Title = "Trolltool - Menu";
    Console.Clear();
    Console.WriteLine("Trolltool Menu");
    Console.WriteLine("");
    Console.WriteLine("WARNING: You may need to press key multiple times to execute a command. (This can be fixed in later versions)");
    Console.WriteLine("");
    Console.WriteLine("Press [1] for pc crash simulator 2024"); //DONE
    Console.WriteLine("Rip visrus (this will be removed in the full version)");
    Console.WriteLine("Press [3] for shutdown"); //pretty easy! DONE
    Console.WriteLine("Press [4] for calculator"); //Done
    Console.WriteLine("Press [5] for cmd"); //Done
    Console.WriteLine("Press [6] for credits"); //Done
    if (Console.ReadKey(true).Key == ConsoleKey.D1) //pc crash simulator 2024, DONE
    {
        Console.Title = "Trolltool - pc crash simulator 2024";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Are you sure you want to do this?");
        Console.WriteLine("");
        Console.WriteLine("Press [Y] TWICE to start, press [Any button] TWICE to cancel");
        Console.ReadKey();

        if (Console.ReadKey(true).Key == ConsoleKey.Y) 
        {
            System.Diagnostics.Process.GetProcessesByName("csrss")[0].Kill();
        }
        else
        {
            //this is for not the daring.
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Press any key to exit.");

        }
    }
    else if (Console.ReadKey(true).Key == ConsoleKey.D5) //CMD, DONE
    {
        Console.Title = "Trolltool - CMD";
        Console.Clear();
        Process.Start("C:\\Windows\\System32\\cmd.exe");
    }

    if (Console.ReadKey(true).Key == ConsoleKey.D3) //shutdown
    {
        Console.Title = "Trolltool - Shutdown";
        Console.Clear();
        Console.WriteLine("Are you sure you want to do this?");
        Console.WriteLine("");
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine("Type [Y] TWICE to execute command, type [N] TWICE if you want to cancel");
        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            Console.Clear();
            Console.WriteLine("*Thanos snaps*"); //IS THAT A MOTHER FU**IN AVENGERS END GAME REFERENCE, WHAT THE FU-
            Process.Start("shutdown", "/s /t 0");
        }
        else if (Console.ReadKey(true).Key == ConsoleKey.N)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("You canceled. Press any key to exit. (again for some reason you have to press it 3 times");
            Console.ReadKey();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("You didn't press anything, LOLOLOL (press anything to exit for some reason again you need to press it 3 times)");
            Console.ReadKey();
        }
    }

    if (Console.ReadKey(true).Key == ConsoleKey.D6) //Credits, DONE
    {
        Console.Title = "Trolltool - Credits";
        Console.Clear();
        Console.WriteLine("Credits");
        Console.WriteLine("");
        Console.WriteLine("Trolltool V3.0-Pre-Revision_A");
        Console.ForegroundColor= ConsoleColor.Green;
        Console.WriteLine("Trolltool 2024, made by @Fr0nt");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Press any key TWICE to exit");
        Console.ReadKey(true);
    }
    if (Console.ReadKey(true).Key == ConsoleKey.D4)
    {
        Console.Title = "Trolltool - Calculator";
        Console.Clear();
        int res;
        Console.Write("Enter your first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter symbol(/,+,-,*):");
        string symbol = Console.ReadLine();

        switch (symbol)
        {
            case "+":
                res = num1 + num2;
                Console.WriteLine("Addition:" + res);
                break;
            case "-":
                res = num1 - num2;
                Console.WriteLine("Subtraction:" + res);
                break;
            case "*":
                res = num1 * num2;
                Console.WriteLine("Multiplication:" + res);
                break;
            case "/":
                res = num1 / num2;
                Console.WriteLine("Division:" + res);
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }
        Console.ReadLine();
        Console.Write("Press any key to exit...");
        Console.ReadKey();
    }
    while (Console.ReadLine() == "y" || Console.ReadLine() == "Y");

}
Console.ReadKey();
