namespace TestApp.Model
{
    public class UserLoginInfo
    {
        //fields
        private int id;
        private string accountName;
        private string emailAddress;
        private string password;

        //Default Constructor
        public UserLoginInfo() { }

        //constructor
        public UserLoginInfo(int id, string accountName, string emailAddress, string password)
        {
            Id = id;
            AccountName = accountName;
            EmailAddress = emailAddress;
            Password = password;
        }

        //properties
        public int Id { get => id; set => id = value; }
        public string AccountName { get => accountName; set => accountName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Password { get => password; set => password = value; }
    }
}
