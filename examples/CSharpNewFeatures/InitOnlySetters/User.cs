namespace InitOnlySetters
{
    public class User1
    {
        public readonly string UserName;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public User1(string userName)
        {
            UserName = userName;
        }

        public void DoSomeThing()
        {
            //UserName = "sss"; // error
        }
    }

    public class User2
    {
        public string UserName { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public User2(string userName)
        {
            UserName = userName;
        }

        public void DoSomeThing()
        {
            UserName = "sss";
        }
    }

    public class User3
    {
        public string UserName { get; init; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public void DoSomeThing()
        {
            //UserName = "sss"; // error
        }
    }
}
