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
            {
                Console.WriteLine("[1] Lägg till en ny gäst i listan");
                Console.WriteLine("[2] Visa inlagda gäster");
                Console.WriteLine("[3] Ta bort gäst från listan");
                Console.WriteLine("[4] Generera rabattkod");
                Console.WriteLine("[5] Avsluta programmet");

                Int32.TryParse(Console.ReadLine(), out int menyVal);
                switch (menyVal)
                {
                    case 1:
                        List<string> guestList = new List<string>();
                        Console.WriteLine("Skriv in gästens förnamn:");
                        string firstName = Console.ReadLine();
                        guestList.Add(firstName);

                        Console.WriteLine("Skriv in gästens efternamn:");
                        string lastName = Console.ReadLine();
                        guestList.Add(lastName);

                        Console.WriteLine("Skriv in gästens mail adress:");
                        string email = Console.ReadLine();
                        guestList.Add(email);

                        Console.WriteLine("Gästen har lagts till i listan!");
                        Console.WriteLine("\n");
                        //NewGuest(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                        break;

                    case 2:
                        guestList.ForEach(p => Console.WriteLine(p));
                        break;

                    case 3:
                        
                        break;

                    case 4:
                        
                        break;

                    case 5:
                        isOn = false;
                        break;
                }
            }
        }

        static void NewGuest(string firstName, string lastName, string email)
        {
            List<string> guestList = new List<string>();
            Console.WriteLine("Skriv in gästens förnamn:");
            firstName = Console.ReadLine();
            guestList.Add(firstName);

            Console.WriteLine("Skriv in gästens efternamn:");
            lastName = Console.ReadLine();
            guestList.Add(lastName);

            Console.WriteLine("Skriv in gästens mail adress:");
            email = Console.ReadLine();
            guestList.Add(email);

            Console.WriteLine("Gästen har lagts till i listan!");
            Console.WriteLine("\n");
        }
        
    }

    class Guest
    {
        public string firstName;
        public string lastName;
        public string email;

        public Guest(string aFirstName, string aLastName, string aEmail)
        {
            firstName = aFirstName;
            lastName = aLastName;
            email = aEmail;
        }
    }
}
