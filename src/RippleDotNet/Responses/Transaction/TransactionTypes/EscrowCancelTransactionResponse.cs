﻿using RippleDotNet.Model.Transaction.Interfaces;

namespace RippleDotNet.Responses.Transaction.TransactionTypes
{
    public class EscrowCancelTransactionResponse : TransactionResponseCommon, IEscrowCancelTransaction
    {
        public uint OfferSequence { get; set; }
        public string Owner { get; set; }
    }
}
