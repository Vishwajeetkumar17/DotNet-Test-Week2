using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLedger
{
    #region Transaction
    /// <summary>
    /// Represents a financial transaction with associated details such as identifier, date, amount, and description.
    /// </summary>
    public abstract class Transaction : IReportable
    {
        public int Id { get; set; }              // Unique identifier for the transaction
        public DateTime Date { get; set; }       // Date and time when the transaction occurred
        public decimal Amount { get; set; }      // Monetary amount of the transaction
        public string Description { get; set; }  // Brief description of the transaction

        public Transaction(int id, DateTime date, decimal amount, string description)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Description = description;
        }

        public abstract string GetSummary();
    }
    #endregion

    #region ExpenseTransaction
    /// <summary>
    /// Represents a financial transaction that records an expense.
    /// </summary>
    public class ExpenseTransaction : Transaction
    {
        public string Category { get; set; }     // Category of the expense (e.g., Food, Travel, Stationery)

        public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string category)
            : base(id, date, amount, description)
        {
            Category = category;
        }

        public override string GetSummary()
        {
            return $"[EXPENSE] : {Date.ToLocalTime()}, Amount: ${Amount}, Description: {Description}, Category: {Category}";
        }
    }
    #endregion

    #region IncomeTransaction
    /// <summary>
    /// Represents a financial transaction that records income.
    /// </summary>
    public class IncomeTransaction : Transaction
    {
        public string Source { get; set; }       // Source of income (e.g., Main Cash, Bank Transfer)

        public IncomeTransaction(int id, DateTime date, decimal amount, string description, string source)
            : base(id, date, amount, description)
        {
            Source = source;
        }

        public override string GetSummary()
        {
            return $"[INCOME] : {Date.ToLocalTime()}, Amount: ${Amount}, Description: {Description}, Source: {Source}";
        }
    }
    #endregion
}
