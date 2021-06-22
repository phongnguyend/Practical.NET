/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#static-local-functions
/// </summary>

namespace LocalFunctions
{
    public class UserServiceUsingStaticLocalFunctions
    {
        public void AddUser(User user)
        {
            static void ValidateUser(User user)
            {
                if (user.UserName == "admin")
                {
                }
            }

            static void SaveUser(User user)
            {
            }

            static void SendEmail(User user)
            {
            }

            ValidateUser(user);
            SaveUser(user);
            SendEmail(user);
        }

        public void UpdateUser(User user)
        {
            static void ValidateUser(User user)
            {
                if (user.UserName == "admin")
                {
                }
            }

            ValidateUser(user);
            SaveUser(user);
        }

        private void SaveUser(User user)
        {
        }
    }
}
