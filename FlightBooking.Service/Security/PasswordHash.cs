namespace FlightBooking.Service.Security;

public static class PasswordHash
{
    public static (string salt, string hash) Hasher(string password)
    {
        string salt = Guid.NewGuid().ToString();    
        string hash = BCrypt.Net.BCrypt.HashPassword(password+salt);
        return (salt, hash);
    }

    public static bool Verify(string password,string passwordHash, string salt)
    {
        return BCrypt.Net.BCrypt.Verify(password+salt,passwordHash);
    }
}
