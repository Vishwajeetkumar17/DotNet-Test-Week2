using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLedger
{
    public static class LedgerCalculationsUtility
    {
        /// <summary>
        /// Calculates the total amount from a collection of transactions.
        /// </summary>
        /// <typeparam name="T">The type of transaction contained in the list. Must inherit from <see cref="Transaction"/>.</typeparam>
        /// <param name="transactions">A list of transactions whose amounts will be summed. Cannot be null.</param>
        /// <returns>The sum of the <c>Amount</c> property for all transactions in the list. Returns 0 if the list is empty.</returns>
        public static decimal CalculateTotal<T>(List<T> transactions) where T : Transaction
        {
            decimal total = 0m;

            foreach (T transaction in transactions)
            {
                total += transaction.Amount;
            }
            return total;
        }
    }
}
