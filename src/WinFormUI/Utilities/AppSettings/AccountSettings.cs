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
        [DefaultSettingValue("admin")]
        public string Username
        {
            get => (string)this[nameof(Username)];
            set => this[nameof(Username)] = value;
        }
        
        
        [UserScopedSetting]
        [DefaultSettingValue("yXO6F9tnfhmuz5PPzcyaiU4W75onTZC1pfPNTUyeR7I4J6xIQgP4AoKhCW2S3ReGeaeLI1WH4a1zf/IbBR6BPA==")]
        public string PasswordHash
        {
            get => (string)this[nameof(PasswordHash)];
            set => this[nameof(PasswordHash)] = value;
        }
        
        [UserScopedSetting]
        [DefaultSettingValue("qQUjVfaNBa0aZRPzB3JwJbBANmXby2ichv3eiJ8EOy/yrkmDLF35uE9cBp0/HZGeQaLbc5i/BWB4akU9ZYtsMbkBy5p+1y2X1mPM0AIaUhJnqCMFLhqNyUPvD6iJ6lWtnKs9JNbh6WXDx+exjzBzOQbR0bphvtHVyhNjv9D21D4=")]
        public string PasswordSalt
        {
            get => (string)this[nameof(PasswordSalt)];
            set => this[nameof(PasswordSalt)] = value;
        }
    }
}
