using System;
using System.Collections.Generic;

namespace quick_code_run
{
    public class WalletSystem
    {
        public string walletName { get; }
        public string walletCurrency { get; }
        public decimal walletBalance
        {
            get
            {
                var balance = 0;
                foreach (var transaction in allTransactions)
                {
                    balance += transaction.amount;
                }
                return balance;
            }
        }
        public string walletNumber { get; }

        private int seedWalletNumber = 1234567000;

        private List<Transaction> allTransactions = new List<Transaction> { };
        public WalletSystem(string name, int amount)
        {
            this.walletName = name;
            this.walletNumber = this.seedWalletNumber.ToString();
            seedWalletNumber++;
            MakeDeposit(amount, "Initial deposit");
            this.walletCurrency = "NGN";
        }

        public string MakeDeposit(int amount, string narration)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive");
            }

            var deposit = new Transaction(amount, narration);
            allTransactions.Add(deposit);
            return $"Deposit of amount {amount} made successfully";
        }

        public string MakeWithdrawal(int amount, string narration)
        {
            if (this.walletBalance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient amount");
            }
            var deposit = new Transaction(-amount, narration);
            allTransactions.Add(deposit);
            return $"Withdrawal of amount {amount} made successfully";
        }

        public void GetWalletHistory()
        {
            Console.WriteLine("Date\t\tAmount\tNarration");
            foreach (var transaction in allTransactions)
            {
                Console.WriteLine($"{transaction.date.ToShortDateString()}\t{transaction.amount}\t{transaction.narration}");
            }
        }
    }
}