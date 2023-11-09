using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MFJC
{
    public class GuessingGame
    {
        public static string EncryptedText = "Rikard > Richard";
        public static void GuessKey()
        {
            var myDecrypter = new CaesarCipher();
            string encryptedText = "";
            var ranKey = new Random();
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
            // Console.WriteLine(key);
            Console.WriteLine($"Guess this word: {encryptedText}");
            Console.Write("Enter a key value 1-26: ");
            bool isPlaying = true;
            while (isPlaying)
            {
                
                string? inputValue = Console.ReadLine();
                bool intCheck = int.TryParse(inputValue, out int guessedKey);
                if (intCheck)
                {
                    string decryptedMessage = myDecrypter.EncryptedMessage(encryptedText, 26 - guessedKey);
                    if (decryptedMessage == "Rikard > Richard")
                    {
                        Console.WriteLine($"Correct Guessed!: {decryptedMessage}");
                        isPlaying = false;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"{decryptedMessage}");
                        Console.Write("Wrong! Guess again: ");
                    }
                }
            }
        }
    }
}
