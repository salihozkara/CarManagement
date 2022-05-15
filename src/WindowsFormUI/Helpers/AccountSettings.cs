using System.Configuration;

namespace WinFormUI.Helpers;

public sealed class AccountSettings : ApplicationSettingsBase
{
    [ApplicationScopedSetting]
    public string Username
    {
        get => (string)this[nameof(Username)];
        set => this[nameof(Username)] = value;
    }

    [ApplicationScopedSetting]
    public byte[] PasswordHash
    {
        get => (byte[])this[nameof(PasswordHash)];
        set => this[nameof(PasswordHash)] = value;
    }
    [ApplicationScopedSetting]
    public byte[] PasswordSalt
    {
        get => (byte[])this[nameof(PasswordSalt)];
        set => this[nameof(PasswordSalt)] = value;
    }
}