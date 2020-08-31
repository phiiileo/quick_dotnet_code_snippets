using System;

namespace quick_code_run
{
    class Program
    {
        static void Main(string[] args)
        {
            // new FibonacciSequence();
            var new_wallet = new WalletSystem("Bill gate", 4000);

            new_wallet.MakeWithdrawal(500, "I need to buy o buy");
            new_wallet.MakeDeposit(100, "Saving up extra");
            Console.WriteLine($"\n\n Wallet is created with name: {new_wallet.walletName}, number:{new_wallet.walletNumber}, balance: {new_wallet.walletBalance} \n\n");
            new_wallet.GetWalletHistory();

            var new_wallet1 = new WalletSystem("Emmanuel", 1);
             Console.WriteLine($"\n\n Wallet is created with name: {new_wallet1.walletName}, number:{new_wallet1.walletNumber}, balance: {new_wallet1.walletBalance} \n\n");
            new_wallet1.GetWalletHistory();
        }
    }
}
