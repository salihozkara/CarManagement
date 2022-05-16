using System.Text;

namespace WinFormUI.Utilities.Security;

public static class HashingHelper
{
    public static void CreatePasswordHash
        (string password, out string passwordHashBase64, out string passwordSaltBase64)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512();
        passwordSaltBase64 = Convert.ToBase64String(hmac.Key);
        passwordHashBase64 = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(password)));
    }

    public static bool VerifyPasswordHash(string password, string passwordHashBase64, string passwordSaltBase64)
    {
        var passwordHashBytes = Convert.FromBase64String(passwordHashBase64);
        var passwordSaltBytes = Convert.FromBase64String(passwordSaltBase64);
        using var hmac = new System.Security.Cryptography.HMACSHA512(passwordSaltBytes);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return !computedHash.Where((t, i) => t != passwordHashBytes[i]).Any();
    }
}