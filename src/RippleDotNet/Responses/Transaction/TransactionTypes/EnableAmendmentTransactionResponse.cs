using RippleDotNet.Model.Transaction.Interfaces;

namespace RippleDotNet.Responses.Transaction.TransactionTypes
{
    public class EnableAmendmentTransactionResponse : TransactionResponseCommon, IEnableAmendmentTransaction
    {
        public string Amendment { get; set; }
        public uint LedgerSequence { get; set; }
    }
}
