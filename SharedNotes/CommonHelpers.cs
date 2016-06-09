using System.Text;
using System.Security.Cryptography;

namespace SharedNotes
{
    public static class CommonHelpers
    {
        public static string GetMd5Hash(this string input)
        {
            var md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (byte t in hash) sb.Append(t.ToString("X2"));

            return sb.ToString();
        }
    }
}
