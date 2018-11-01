using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmqModel
{
    public class InnmeldingMessage
    {
        // { "oppdragsid": "1234M", "kundeid": "1234", "kildeid": "01117012345", "kildeidtype: "INR", "fodselsdato_YMD": "..", "navn": "....", "fornavn": "...", "mellomnavn": "..", "adresse": "..", "husnr": "..", "bokstav": ".", "postnr": "..", "poststed": "..", "kommunenr": "..", "systemdata": { "SEIL": ..., "Websak": ..., "fagsystem3": ... } }


        [JsonProperty("oppdragsid")]
        public string OppdragsId { get; set; }
       
        [JsonProperty("kundeid")]
        public string KundeId { get; set; }

        //public string KildeId { get; set; }
        //public string KildeType { get; set; }
        [JsonProperty("fodselsdato_YMD")]
        public string FodeselsDato { get; set; }

        [JsonProperty("navn")]
        public string EtterNavn { get; set; }

        [JsonProperty("fornavn")]
        public string ForNavn { get; set; }

        [JsonProperty("mellomnavn")]
        public string MellomNavn { get; set; }

        [JsonProperty("adresse")]
        public string Adresse { get; set; }

        [JsonProperty("husnr")]
        public string HusNummer { get; set; }

        [JsonProperty("bokstav")]
        public string Bokstav { get; set; }

        [JsonProperty("postnr")]
        public string PostNummer { get; set; }

        [JsonProperty("poststed")]
        public string PostSted { get; set; }

        [JsonProperty("kommunenr")]
        public string KommuneNummer { get; set; }

        [JsonProperty("systemdata")]
        public string SystemData { get; set; }

    }
}
