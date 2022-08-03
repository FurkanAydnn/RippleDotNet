using Newtonsoft.Json;

namespace RippleDotNet.Responses.Transaction
{
    public class ChannelVerify
    {
        [JsonProperty("signature_verified")]
        public bool SignatureVerified { get; set; }
    }
}
