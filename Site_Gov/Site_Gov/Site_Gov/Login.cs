using System.Reflection.Metadata;

namespace Site_Gov
{
    internal class Login
    {
        private string UserName { get; set }
        private string Password { get; set; }

        // Métodos 

        private Validador(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
        }

    }
    
}
