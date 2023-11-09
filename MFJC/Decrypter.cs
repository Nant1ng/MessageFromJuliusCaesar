namespace MFJC
{
    public class Decrypter
    {
        public static void Decryption()
        {
            var myDecrypter = new CaesarCipher();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.Write("Skriv din text du vill dekrypta: ");
                string? inputValue = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inputValue))
                {
                    Console.Write("En nyckel mellan 1-26: ");
                    bool intCheck = int.TryParse(Console.ReadLine(), out int value);

                    if (intCheck && value > 0 && value < 27)
                    {
                        string decryption = myDecrypter.DecryptedMessage(inputValue, value);

                        Console.WriteLine($"{decryption}");

                    }

                    Console.WriteLine("Vill du dekrypta ett till meddlande? y/n");
                    string? choice = Console.ReadLine();

                    //IDK???
                    if (choice != null && choice == "y")
                    {

                    }
                    else if (choice != null && choice == "n")
                    {
                        isRunning = false;
                        Console.Clear();
                    }

                }
            }
        }
    }
}
