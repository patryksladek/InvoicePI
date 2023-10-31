using System.Security.Cryptography;
using System.Text;

namespace InvoicePI.Infrastructure.Security;

public class PasswordHasher
{

    // Method for generating a salt of a specified length in bytes.
    private static string GenerateSalt(int saltLength)
    {
        byte[] saltBytes = new byte[saltLength];
        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(saltBytes);
        }
        return Convert.ToBase64String(saltBytes);
    }

    // Method to hash the password using a salt.
    public static string HashPassword(string password, out string salt)
    {
        int saltLength = 16; 
        salt = GenerateSalt(saltLength);
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);

        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
            return Convert.ToBase64String(hashedBytes);
        }
    }

    // Method to verify password based on password and sol.
    public static bool VerifyPassword(string password, string salt, string hashedPassword)
    {
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
            string hashedPasswordToCompare = Convert.ToBase64String(hashedBytes);
            return hashedPasswordToCompare == hashedPassword;
        }
    }
}
