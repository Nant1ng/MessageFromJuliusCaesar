namespace MFJC
{
    public interface ICaesarCipher
    {
        string? _EncryptedMessage { get; set; }
        string? _DecryptedMessage { get; set; }
        string EncryptedMessage(string text, int key);
        string DecryptedMessage(string text, int key);
    }
}
