using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLedger
{
    public class Ledger<T> where T : Transaction
    {
        private List<T> transactions = new List<T>();

        #region AddEntry
        /// <summary>
        /// Adds a new entry to the collection of transactions.
        /// </summary>
        /// <param name="entry">The entry to add to the transactions collection. Cannot be null.</param>
        public void AddEntry(T entry)
        {
            transactions.Add(entry);
        }
        #endregion

        #region GetTransactionByDate
        /// <summary>
        /// Retrieves a list of transactions that occurred on the specified date.
        /// </summary>
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
        #endregion

        #region CalculateTotal
        /// <summary>
        /// Calculates the total amount from all recorded transactions.
        /// </summary>
        /// <returns>The sum of all transaction amounts as a decimal value. Returns 0 if there are no transactions.</returns>
        public decimal CalculateTotal()
        {
            return LedgerCalculationsUtility.CalculateTotal(transactions);
        }
        #endregion
    }
}
