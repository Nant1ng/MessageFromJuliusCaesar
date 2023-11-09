namespace MFJC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myEncrypter = new CaeserChiper();
            Console.Write("Skriv din text du vill kryptera: ");
            string? inputValue = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(inputValue))
            {
                Console.Write("En nyckel mellan 1-26: ");
                bool intCheck = int.TryParse(Console.ReadLine(), out int value);
                if (intCheck && value > 0 && value < 27)
                {
                    myEncrypter.EncrpytedMessage(inputValue, value);
                    Console.WriteLine(myEncrypter._EncryptedMessage);
                }
            }
        }
    }
}