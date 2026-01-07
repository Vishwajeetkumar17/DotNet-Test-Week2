using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPettyCashLedger
{
    public abstract class Transaction : IReportable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Transaction(int id, DateTime date, decimal amount, string description)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Description = description;
        }
        public abstract string GetSummary();
    }
    public class ExpenseTransaction : Transaction
    {
        public string Category { get; set; }

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
    public class IncomeTransaction : Transaction
    {
        public string Source { get; set; }

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
}
