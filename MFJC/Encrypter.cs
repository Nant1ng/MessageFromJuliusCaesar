namespace MFJC
{
    public class Encrypter
    {
        public static void Encryption()
        {
            var myEncrypter = new CaesarCipher();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Write("Skriv din text du vill kryptera: ");
                string? inputValue = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(inputValue))
                {
                    Console.Write("En nyckel mellan 1-26: ");
                    bool intCheck = int.TryParse(Console.ReadLine(), out int key);

                    if (intCheck && key > 0 && key < 27)
                    {
                        string encryption = myEncrypter.EncryptedMessage(inputValue, key);

                        Console.WriteLine($"{encryption}");

                    }

                    Console.WriteLine("Vill du dekrypta ett till meddlande? y/n");
                    string? choice = Console.ReadLine();

                    if (choice != null && choice == "y")
                    {
                        Console.Clear();
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
