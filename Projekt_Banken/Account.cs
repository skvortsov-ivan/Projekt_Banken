namespace Projekt_Banken
{
    public class Account
    {
        private int accountNr;
        private float balance;
        private string transaction;

        public int AccountNr
        {
            get { return accountNr; }
            set { accountNr = value; }
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string Transaction
        {
            get { return transaction; }
            set { transaction = value; }
        }

        public Account(int accountNr, float balance, string transaction)
        {
            AccountNr = accountNr;
            Balance = balance;
            Transaction = transaction;
        }
    }
}
