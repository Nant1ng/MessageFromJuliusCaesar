namespace MFJC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myEncrypter = new CaeserCihper();

            Console.Write("Skriv din text du vill kryptera: ");
            string? inputValue = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(inputValue))
            {
                Console.Write("En nyckel mellan 1-26: ");
                bool intCheck = int.TryParse(Console.ReadLine(), out int value);

                if (intCheck && value > 0 && value < 27)
                {
                    string encryption = myEncrypter.EncryptedMessage(inputValue, value);
                    string decryption = myEncrypter.DecryptedMessage(encryption, value);

                    Console.WriteLine($"{encryption}");
                    Console.WriteLine($"{decryption}");

                }
            }
        }
    }
}