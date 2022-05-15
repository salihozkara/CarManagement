using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI.Utilities.AppSettings
{
    public class AccountSettings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        public string Username
        {
            get => (string)this[nameof(Username)];
            set => this[nameof(Username)] = value;
        }
        
        [UserScopedSetting]
        [DefaultSettingValue("false")]
        public bool IsAuthenticated
        {
            get => (bool)this[nameof(IsAuthenticated)];
            set => this[nameof(IsAuthenticated)] = value;
        }
        
        [UserScopedSetting]
        public byte[] PasswordHash
        {
            get => (byte[])this[nameof(PasswordHash)];
            set => this[nameof(PasswordHash)] = value;
        }
        
        [UserScopedSetting]
        public byte[] PasswordSalt
        {
            get => (byte[])this[nameof(PasswordSalt)];
            set => this[nameof(PasswordSalt)] = value;
        }
    }
}
