using System.Security.Principal;

namespace Projekt_Banken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(1, "Ivan", "ivan.skvortsov@chasacademy.se");
            Console.WriteLine($"User ID: {user1.UserId} User name: {user1.Name}, Email: {user1.Email}");

            Account account1 = new Account(1, 100, "Infinity");
            Console.WriteLine($"Kontonummer är: {account1.AccountNr}, Saldo är: {account1.Balance}, Transaktioner: {account1.Transaction}");

        }
    }
}
