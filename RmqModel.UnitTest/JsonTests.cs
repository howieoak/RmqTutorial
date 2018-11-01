using Newtonsoft.Json;
using System;
using System.Text;
using Xunit;

namespace RmqModel.UnitTest
{
    public class JsonTests
    {
        [Fact]
        public void JsonRead_AjourholdMessage()
        {
            byte[] json = System.IO.File.ReadAllBytes(@"D:\git\howieoak\RmqTutorial\RmqModel.UnitTest\mq_ajour.json");

            var rawMessage = Encoding.UTF8.GetString(json);
            var message = JsonConvert.DeserializeObject<AjourholdMessage>(rawMessage);

        }

        [Fact]
        public void JsonWrite_AjourholdMessage()
        {
            InnmeldingMessage mes = new InnmeldingMessage
            {
                OppdragsId = "MDNSB01",
                KundeId = Guid.NewGuid().ToString(),
                FodeselsDato = "19751010",
                EtterNavn = "KLAVEN",
                ForNavn = "KARI",
                MellomNavn = "PSA",
                Adresse = "BOKS 6300, ETTERSTAD",
                PostNummer = "0603",
                PostSted = "ETTERSTAD"
            };

            string json = JsonConvert.SerializeObject(mes);
            var body = Encoding.UTF8.GetBytes(json);

        }
    }
}
