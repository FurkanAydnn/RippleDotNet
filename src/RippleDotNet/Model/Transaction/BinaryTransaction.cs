﻿using Newtonsoft.Json;

namespace RippleDotNet.Model.Transaction
{
    public class BinaryTransaction
    {
        [JsonProperty("meta")]
        public string Meta { get; set; }

        [JsonProperty("tx_blob")]
        public string TransactionBlob { get; set; }
    }
}
