using System;

namespace LocalFunctions
{
    public class UserService
    {
        public void AddUser(User user)
        {
            ValidateUserBeforeAdding(user);
            SaveUser(user);
            SendEmail(user);
        }

        public void UpdateUser(User user)
        {
            ValidateUserBeforeUpdating(user);
            SaveUser(user);
        }

        private void ValidateUserBeforeAdding(User user)
        {
            if (user.UserName == "admin")
            {
            }
        }

        private void ValidateUserBeforeUpdating(User user)
        {
            if (user.UserName == "admin")
            {
            }
        }

        private void SaveUser(User user)
        {
        }

        private void SendEmail(User user)
        {
        }
    }
}
