namespace MFJC
{
    public class CaeserCipher
    {
        public string? _EncryptedMessage { get; set; }
        public string? _DecryptedMessage { get; set; }
        public string EncryptedMessage(string text, int key)
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

        public string DecryptedMessage(string _EncryptedMessage, int key)
        {
            _DecryptedMessage = EncryptedMessage(_EncryptedMessage, 26 - key);
            return _DecryptedMessage;
        }
    }
}
