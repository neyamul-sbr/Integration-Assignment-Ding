
using System.Xml;
using System.Xml.Serialization;


namespace IntegrationApp
{

    [XmlRoot("Message")]
    public class Response
    {
        [XmlElement("Header")]
        public Header Header { get; set; }
        [XmlElement("Body")]
        public Body Body { get; set; }
    }

    public class Header
    {
        [XmlElement("MessageDate")]
        public string MessageDate { get; set; }
        [XmlElement("MessageTime")]
        public string MessageTime { get; set; }
    }


        public class Body
    {
        [XmlElement("TransactionID")]
        public int TransactionID { get; set; }
        [XmlElement("TransactionNumber")]
        public int TransactionNumber { get; set; }
        [XmlElement("PhoneNumber")]
        public string PhoneNumber { get; set; }
        [XmlElement("Amount")]
        public string Amount { get; set; }
        [XmlElement("Result")]
        public string Result { get; set; }
    }

    public class ResponseWrap{
        private byte[] responseByte;
        private Response res;
        public ResponseWrap(byte[] responseByte){

            this.responseByte = responseByte;


        }

        public Response getResponseObject(){

            var resbyte = responseByte;

            var xmlString = System.Text.Encoding.ASCII.GetString(resbyte);

            string cleaned = cleaned_xml(xmlString);

            // Console.WriteLine(cleaned);

            XmlSerializer rserializer = new XmlSerializer(typeof(Response));
            using (StringReader stringReader = new StringReader(cleaned))
            {
                res = (Response)rserializer.Deserialize(stringReader);
            }






            return res;
        }

    private static string cleaned_xml(string s)
        {
            char delimiter = '<'; // Specify the character at which you want to stop removing

            int delimiterIndex = s.IndexOf(delimiter);

            string cleaned = s.Substring(delimiterIndex);

            return cleaned;


        }

    }



}