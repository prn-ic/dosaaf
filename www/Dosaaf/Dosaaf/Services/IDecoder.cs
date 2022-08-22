namespace Dosaaf.Services
{
    public interface IDecoder
    {
        string Base64Encode(string text);
        string Base64Decode(string text);

    }
}
