using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLedger
{
    public class Ledger<T> where T : Transaction
    {
        private List<T> transactions = new List<T>();
        public void AddEntry(T entry)
        {
            transactions.Add(entry);
        }
        public List<T> GetTransactionsByDate(DateTime date)
        {
            List<T> result = new List<T>();
            foreach (T transaction in transactions)
            {
                if (transaction.Date.Date == date.Date)
                    result.Add(transaction);
            }
            return result;
        }
        public decimal CalculateTotal()
        {
            return LedgerCalculationsUtility.CalculateTotal(transactions);
        }
    }
}
