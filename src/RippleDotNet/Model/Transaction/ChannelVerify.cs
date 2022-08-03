using Newtonsoft.Json;

namespace RippleDotNet.Model.Transaction
{
    public class ChannelVerify
    {
        [JsonProperty("signature_verified")]
        public bool SignatureVerified { get; set; }
    }
}
