using System;

namespace quick_code_run
{
    public class Transaction
    {
        public int amount { get; }
        public string narration { get; }
        public DateTime date { get; }
        public Transaction(int amount, string narration)
        {
            this.amount = amount;
            this.narration = narration;
            this.date = DateTime.Now;
        }
    }
}