using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            while (isOn == true)

            Console.WriteLine("Välkommen!");
            Console.WriteLine("\n");

            int menyVal = 1;
            switch (menyVal)
            {
                case 1:
                    Console.WriteLine("Lägg till en ny gäst i listan");
                    break;

                case 2:
                    Console.WriteLine("Visa inlagda gäster");
                    break;

                case 3:
                    Console.WriteLine("Ta bort gäst från listan");
                    break;

                case 4:
                    Console.WriteLine("Generera rabattkod");
                    break;

                case 5:
                    Console.WriteLine("Avsluta programmet");
                    isOn = false;
                    break;
            }
        }
    }
}
