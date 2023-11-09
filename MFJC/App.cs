using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFJC
{
    public class App
    {
        public static void Run()
        {
            bool exitMenu = false;

            while (!exitMenu)
            {
                Console.WriteLine("1. Encrypted a Message.");
                Console.WriteLine("2. Decrypted a Message.");
                Console.WriteLine("3. Would you like to play guessing game? ");
                Console.WriteLine("0. Exit.");

                string? choice = Console.ReadLine();

                if (int.TryParse(choice, out int menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 1:
                            Encrypter.Encryption();
                            break;
                        case 2:
                            Decrypter.Decryption();
                            break;
                        case 3:
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid choice. Please enter a valid menu option. 1, 2 or 0.");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a valid integer menu option. 1, 2 or 0.");

                }
            }
        }
    }
}
