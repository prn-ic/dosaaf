namespace Dosaaf.Services
{
    public interface IEncryptionService
    {
        string Base64Encode(string text);
        string Base64Decode(string text);

    }
}
