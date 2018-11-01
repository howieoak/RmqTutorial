using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmqModel
{
    public class AjourholdMessage
    {
        public string KildeId { get; set; }

        public string KundeId { get; set; }

        public string Ordrenr { get; set; }

        public string Treffkode { get; set; }

        public string OppdragsId { get; set; }

        [JsonProperty("treffnivaa")]
        public string Treffnivå { get; set; }

        public Kildedata Kildedata { get; set; }
    }
}
