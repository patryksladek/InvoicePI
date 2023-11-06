using System.Security.Cryptography;
using System.Text;

namespace InvoicePI.Infrastructure.Security;

public class PasswordEncryptor
{
    private static readonly string Key = "E30560FF659244F3AB932105302BE4FB";
    private static readonly string IV = "232379B0DE9F4264";

    public static string EncryptPassword(string password)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(Key);
            aesAlg.IV = Encoding.UTF8.GetBytes(IV);

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    csEncrypt.Write(passwordBytes, 0, passwordBytes.Length);
                    csEncrypt.FlushFinalBlock();
                }

                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }

    public static string DecryptPassword(string encryptedPassword)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(Key);
            aesAlg.IV = Encoding.UTF8.GetBytes(IV);

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            byte[] encryptedPasswordBytes = Convert.FromBase64String(encryptedPassword);

            using (MemoryStream msDecrypt = new MemoryStream(encryptedPasswordBytes))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    byte[] decryptedBytes = new byte[encryptedPasswordBytes.Length];
                    int decryptedByteCount = csDecrypt.Read(decryptedBytes, 0, decryptedBytes.Length);
                    return Encoding.UTF8.GetString(decryptedBytes, 0, decryptedByteCount);
                }
            }
        }
    }
}
