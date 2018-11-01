using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmqModel
{
    public class MdPers
    {
        public string Husnr { get; set; }

        public string Kjonn { get; set; }

        public string Gatenr { get; set; }

        public string Postnr { get; set; }

        public string Adresse { get; set; }

        public string Bokstav { get; set; }

        public string Bolignr { get; set; }

        public string Bruksnr { get; set; }

        public string Festenr { get; set; }

        public string Fornavn { get; set; }

        public string Gaardsnr { get; set; }

        public string Objectid { get; set; }

        public string Poststed { get; set; }

        [JsonProperty("dato_doed")]
        public string DatoDoed { get; set; }

        public string Kommunenr { get; set; }

        [JsonProperty("dnr_status")]
        public string DnrStatus { get; set; }

        public string Mellomnavn { get; set; }

        public string Slektsnavn { get; set; }


        public string Statuskode { get; set; }

        public string Adressetype { get; set; }

        public string Foedselsaar { get; set; }

        [JsonProperty("fra_kommune")]
        public string FraKommune { get; set; }

        public string Kommunenavn { get; set; }

        [JsonProperty("regdato_adr")]
        public string RegdatoAdr { get; set; }

        public string Postadresse1 { get; set; }

        public string Postadresse2 { get; set; }

        public string Postadresse3 { get; set; }

        [JsonProperty("reg_dato_navn")]
        public string RegDatoNavn { get; set; }

        [JsonProperty("spes_reg_type")]
        public string SpesRegType { get; set; }

        [JsonProperty("dnr_reg_status")]
        public string DnrRegStatus { get; set; }

        [JsonProperty("flyttedato_adr")]
        public string FlyttedatoAdr { get; set; }

        [JsonProperty("forkortet_navn")]
        public string ForkortetNavn { get; set; }

        [JsonProperty("sist_oppdatert")]
        public string SistOppdatert { get; set; }

        public string Tilleggsadresse { get; set; }

        [JsonProperty("fra_komm_regdato")]
        public string FraKommRegdato { get; set; }

        [JsonProperty("fra_kommune_navn")]
        public string FraKommuneNavn { get; set; }

        [JsonProperty("postadr_landnavn")]
        public string PostadrLandnavn { get; set; }

        [JsonProperty("postadr_reg_dato")]
        public string PostadrRegDato { get; set; }

        [JsonProperty("slektsnavn_ugift")]
        public string SlektsnavnUgift { get; set; }

        [JsonProperty("utvandret_regdato")]
        public string UtvandretRegdato { get; set; }

        [JsonProperty("dato_spes_reg_type")]
        public string DatoSpesRegType { get; set; }

        [JsonProperty("innvandret_regdato")]
        public string InnvandretRegdato { get; set; }

        [JsonProperty("fra_komm_flyttedato")]
        public string FraKommFlyttedato { get; set; }

        [JsonProperty("utvandret_flyttedato")]
        public string UtvandretFlyttedato { get; set; }

        [JsonProperty("dnr_hjemlandsadresse1")]
        public string DnrHjemlandsadresse1 { get; set; }

        [JsonProperty("dnr_hjemlandsadresse2")]
        public string DnrHjemlandsadresse2 { get; set; }

        [JsonProperty("dnr_hjemlandsadresse3")]
        public string DnrHjemlandsadresse3 { get; set; }

        [JsonProperty("hjemlandsadr_landnavn")]
        public string HjemlandsadrLandnavn { get; set; }

        [JsonProperty("hjemlandsadr_reg_dato")]
        public string HjemlandsadrRegDato { get; set; }

        [JsonProperty("innvandret_flyttedato")]
        public string InnvandretFlyttedato { get; set; }

        [JsonProperty("utvandret_til_landkode")]
        public string UtvandretTilLandkode { get; set; }

        [JsonProperty("innvandret_fra_landkode")]
        public string InnvandretFraLandkode { get; set; }
    }
}
