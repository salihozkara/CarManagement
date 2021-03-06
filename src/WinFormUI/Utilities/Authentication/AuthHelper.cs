using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormUI.Utilities.AppSettings;
using WinFormUI.Utilities.Security;

namespace WinFormUI.Utilities.Authentication
{
    public class AuthHelper
    {
        public static bool ChangePassword(string oldPassword, string newPassword,out string message)
        {
            AccountSettings accountSettings = new();
            var result = HashingHelper.VerifyPasswordHash(oldPassword, accountSettings.PasswordHash,accountSettings.PasswordSalt);
            if (!result)
            {
                message="Old password is incorrect";
                return false;
            }
            HashingHelper.CreatePasswordHash(newPassword, out var passwordHash, out var passwordSalt);
            accountSettings.PasswordHash = passwordHash;
            accountSettings.PasswordSalt = passwordSalt;
            accountSettings.Save();
            message = "Password changed successfully";
            return true;
        }
        public static void ChangeUsername(string newUsername)
        {
            AccountSettings accountSettings = new();
            accountSettings.Username = newUsername;
            accountSettings.Save();
        }

        public static string GetUserName()
        {
            AccountSettings accountSettings = new();
            return accountSettings.Username;
        }
        public static bool Login(string username, string password,out string message)
        {
           
            AccountSettings accountSettings = new();
            
            if (username != accountSettings.Username)
            {
                message="Username is incorrect";
                return false;
            }
            if (HashingHelper.VerifyPasswordHash(password, accountSettings.PasswordHash, accountSettings.PasswordSalt))
            {
                message = "success";
                return true;
            }
            message = "Password is incorrect";
            return false;
        }
    }
}
