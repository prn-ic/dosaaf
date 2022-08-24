namespace Dosaaf.Services
{
    public class EncryptionService: IEncryptionService
    {
        public string Base64Encode(string text = "unknown")
        {
            var textBytes = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textBytes);
        }

        public string Base64Decode(string text = "dW5rbm93bg==")
        {
            var base64TextBytes = System.Convert.FromBase64String(text);
            return System.Text.Encoding.UTF8.GetString(base64TextBytes);
        }
    }
}
