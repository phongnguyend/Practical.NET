/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#local-functions
/// </summary>

namespace LocalFunctions
{
    public class UserServiceUsingLocalFunctions
    {
        public void AddUser(User user)
        {
            void ValidateUser()
            {
                if (user.UserName == "admin")
                {
                }
            }

            void SaveUser(User user)
            {
            }

            void SendEmail()
            {
            }

            ValidateUser();
            SaveUser(user);
            SendEmail();
        }

        public void UpdateUser(User user)
        {
            void ValidateUser()
            {
                if (user.UserName == "admin")
                {
                }
            }

            ValidateUser();
            SaveUser(user);
        }

        private void SaveUser(User user)
        {
        }
    }
}
