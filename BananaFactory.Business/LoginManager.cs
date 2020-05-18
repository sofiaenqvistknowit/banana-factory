using System;
using System.Security.Cryptography;
using System.Text;

namespace BananaFactory.Business
{
    public class LoginManager
    {
        public string GetPasswordHash(string password)
        {
            using (var sha1 = new SHA1Managed())
            {
                var hash = Encoding.UTF8.GetBytes(password);
                var generatedHash = sha1.ComputeHash(hash);
                var generatedHashString = Convert.ToBase64String(generatedHash);
                return generatedHashString;
            }
        }
    }
}
