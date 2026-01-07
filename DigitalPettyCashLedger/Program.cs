using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLedger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
            Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

            incomeLedger.AddEntry(new IncomeTransaction(1, DateTime.Now, 500m, "Replenishment", "Main Cash"));

            expenseLedger.AddEntry(new ExpenseTransaction(1, DateTime.Now, 20m, "Stationary", "Office"));

            expenseLedger.AddEntry(new ExpenseTransaction(2, DateTime.Now, 15m, "Team Snacks", "Food"));

            decimal TotalIncome = incomeLedger.CalculateTotal();
            decimal TotalExpense = expenseLedger.CalculateTotal();
            decimal NetBalance = TotalIncome - TotalExpense;

            Console.WriteLine("Total Income: $" + TotalIncome);
            Console.WriteLine("Total Expense: $" + TotalExpense);
            Console.WriteLine("Net Balance: $" + NetBalance);

            List<Transaction> allTransaction = new List<Transaction>();
            allTransaction.AddRange(incomeLedger.GetTransactionsByDate(DateTime.Now));
            allTransaction.AddRange(expenseLedger.GetTransactionsByDate(DateTime.Now));

            foreach (Transaction transaction in allTransaction)
            {
                Console.WriteLine(transaction.GetSummary());
            }
        }
    }
}
