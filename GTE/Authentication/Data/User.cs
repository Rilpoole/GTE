using Fido2NetLib.Development;

namespace Authentication.Data
{
    public class User
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public byte[] UserId { get; set; }
        public List<StoredCredential> Credentials { get; set; } = new();
    }
}
