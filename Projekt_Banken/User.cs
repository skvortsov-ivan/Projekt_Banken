namespace Projekt_Banken
{
    public class User
    {
        //Incapsulation
        private int userId;
        private string name;
        private string email;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //Constructor
        public User(int userId, string name, string email)
        {
            UserId = userId;
            Name = name;
            Email = email;
        }
    }
}