using System;

namespace DigitalPettyCashLedger
{
    /// <summary>
    /// Defines a contract for objects that can provide a textual summary describing their state or contents.
    /// </summary>
    /// <remarks>Implementations of this interface should return a concise, human-readable summary that
    /// represents the object's key information. This can be used for logging, reporting, or display purposes. The
    /// format and content of the summary may vary depending on the implementation.</remarks>
    public interface IReportable
    {
        public string GetSummary();
    }
}
