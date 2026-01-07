using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLedger
{
    public static class LedgerCalculationsUtility
    {
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
