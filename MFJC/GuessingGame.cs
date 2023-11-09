namespace MFJC
{
    public class GuessingGame
    {
        public static string EncryptedText = "Rikard > Richard";
        public static void GuessKey()
        {
            CaesarCipher myDecrypter = new CaesarCipher();
            string encryptedText = "";
            Random ranKey = new Random();
            int key = (int)(ranKey.Next(26));
            foreach (char c in EncryptedText)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    encryptedText += (char)(((c + key - offset) % 26) + offset);
                }
                else
                {
                    encryptedText += c;
                }

            }
            Console.Clear();
            Console.WriteLine(key);
            Console.WriteLine($"Guess this word: {encryptedText}");
            Console.Write("Enter a key value 1-26: ");

            bool isPlaying = true;

            while (isPlaying)
            {

                string? inputValue = Console.ReadLine();
                bool intCheck = int.TryParse(inputValue, out int guessedKey);
                if (intCheck && guessedKey > 0 && guessedKey < 27)
                {
                    string decryptedMessage = myDecrypter.EncryptedMessage(encryptedText, 26 - guessedKey);
                    if (decryptedMessage == "Rikard > Richard")
                    {
                        Console.Clear();
                        Console.WriteLine($"Correct Guessed!: {encryptedText} = {decryptedMessage}");
                        isPlaying = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Your guess: {decryptedMessage}");
                        Console.Write("Wrong! Guess again: ");
                    }
                }
            }
        }
    }
}
