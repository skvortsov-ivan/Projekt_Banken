namespace Projekt_Banken
{
    public class Transaction
    {
        private int TransactionID { get; set; } // Every transaction needs a unique ID
        private DateTimeOffset TransactionTime { get; set; } // Timestamp of transaction - using DateTimeOffset to store date + time UTC
        private float TransactionSum { get; set; } // Amount
        private string TransactionType { get; set; } // Slightly unsure if this is needed at all. 

        public Transaction(int id, DateTimeOffset time, float sum, string type)
        {
            TransactionID = id;
            TransactionTime = time;
            TransactionSum = sum;
            TransactionType = type;
        }
    }
}
