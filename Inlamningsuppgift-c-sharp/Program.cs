using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inlamningsuppgift_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            List<Guest> guestList = new List<Guest>();
            while (isOn == true)
            {
                Console.WriteLine("[1] Lägg till en ny gäst i listan");
                Console.WriteLine("[2] Visa inlagda gäster");
                Console.WriteLine("[3] Ta bort gäst från listan");
                Console.WriteLine("[4] Spara deltagarlista");
                Console.WriteLine("[5] Avsluta programmet");

                Int32.TryParse(Console.ReadLine(), out int menyVal);
                switch (menyVal)
                {
                    case 1:
                        Console.WriteLine("Skriv in förnamn:");
                        string firstName = Console.ReadLine();

                        Console.WriteLine("Skriv in efternamn:");
                        string lastName = Console.ReadLine();

                        Console.WriteLine("Skriv in email adress:");
                        string email = Console.ReadLine();

                        Guest newGuest = new Guest(firstName, lastName, email);
                        guestList.Add(newGuest);
                        Console.WriteLine($"Gästens ID-nummer: {guestList.IndexOf(newGuest)}");
                        Console.WriteLine($"Gästens rabattkod: {newGuest.Rabattkod}");

                        Console.WriteLine("Gästen har lagts till i listan!");
                        Console.WriteLine("\n");
                        break;

                    case 2:
                        foreach(Guest guest in guestList)
                        {
                            Console.WriteLine($"Namn: {guest.FirstName} {guest.LastName}");
                            Console.WriteLine($"Email: {guest.Email}");
                            Console.WriteLine($"ID-nummer: {guestList.IndexOf(guest)}");
                            Console.WriteLine($"Rabattkod: {guest.Rabattkod}");
                            Console.WriteLine("\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Skriv in gästens ID-nummer för att avboka:");
                        Int32.TryParse(Console.ReadLine(), out int guestIndex);
                        if(guestList.Count > guestIndex)
                        {
                            guestList.RemoveAt(guestIndex);
                            Console.WriteLine("Gästen har avbokats!");
                        }
                        else
                        {
                            Console.WriteLine("Gästen fanns inte i listan");
                        }
                        break;

                    case 4:
                      
                        Console.WriteLine("Ange sökväg och filnamn:");
                        string path = Console.ReadLine(); // Användaren skriver in filnamn och sökväg där filen ska sparas.
                        if (path == String.Empty)
                        {
                            path = $@"{AppContext.BaseDirectory}MyTest.txt";
                        }

                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                                using (StreamWriter sw = File.CreateText(path))
                                {
                                    foreach (Guest guest in guestList)
                                    {
                                        sw.WriteLine($"ID-nummer: {guestList.IndexOf(guest)}");
                                        sw.WriteLine($"Namn: {guest.FirstName} {guest.LastName}");
                                        sw.WriteLine($"E-mail: {guest.Email}");
                                    }
                                }
                        break;
                        
                    case 5:
                        isOn = false;
                        break;
                }
            }
        }
    }
}
