using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in super hero name to see their nick name:");
            string userValue = Console.ReadLine();

            switch (userValue)
            {
                case "Bat Man":
                    Console.WriteLine("The Caped Crusader");
                    break;
                case "Super Man":
                    Console.WriteLine("The man of Steel");
                    break;
                case "Green Lantern":
                    Console.WriteLine("The Emrald Knight");
                    break;
                default:
                    Console.WriteLine("This entery does not compute");
                    break;                
            }

            Console.ReadLine();


        }
    }
}
