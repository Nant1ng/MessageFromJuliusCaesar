using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MFJC
{
    public class CaeserChiper
    {
        public string? _EncryptedMessage { get; set; }
        public string EncrpytedMessage(string text, int key)
        {
            string encryptedText = "";
            foreach (char c in text)
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
            _EncryptedMessage = encryptedText;
            return _EncryptedMessage;
        }
    }
}
