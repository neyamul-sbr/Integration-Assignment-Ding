///Md. Neyamul Islam Shibbir
/// CSE, SUST
using System.Text;

using System.Xml.Serialization;



namespace IntegrationApp
{

    public class Program
    {

        public static void Main(string[] args)
        {


            //Part 1. Exercise : 


            //1. Build an XML request (please use the samples request 1 and request 2) and convert it to a byte array for sending *
            //request 1


            ReqWrap wrap = new ReqWrap("EZE", DateTime.Now.Date.ToString(), DateTime.Now.TimeOfDay.ToString(), 332526, "630000000000", "25");

            Request R1 = wrap.getRequestObject();

            SerializerReq(R1);


            //request 2

            ReqWrap wrap2 = new ReqWrap("EZE", DateTime.Now.Date.ToString(), DateTime.Now.TimeOfDay.ToString(), 332527, "639999999999", "25");

            Request R2 = wrap2.getRequestObject();

            SerializerReq(R2);





            // 2. Accept a response (please use the samples response 1 and response 2) and parse it intoa response message object
            //response 1

            Console.WriteLine("Response");

            var resByte1 = new byte[] { 69, 90, 69, 45, 88, 77, 76, 45, 77, 115, 103, 48, 50, 60, 77, 101, 115, 115, 97, 103, 101, 62, 13, 10, 32, 32, 60, 72, 101, 97, 100, 101, 114, 62, 13, 10, 32, 32, 32, 32, 60, 77, 101, 115, 115, 97, 103, 101, 68, 97, 116, 101, 62, 50, 48, 49, 48, 48, 51, 50, 52, 60, 47, 77, 101, 115, 115, 97, 103, 101, 68, 97, 116, 101, 62, 13, 10, 32, 32, 32, 32, 60, 77, 101, 115, 115, 97, 103, 101, 84, 105, 109, 101, 62, 49, 57, 50, 54, 48, 50, 60, 47, 77, 101, 115, 115, 97, 103, 101, 84, 105, 109, 101, 62, 13, 10, 32, 32, 60, 47, 72, 101, 97, 100, 101, 114, 62, 13, 10, 32, 32, 60, 66, 111, 100, 121, 62, 13, 10, 32, 32, 32, 32, 60, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 73, 68, 62, 51, 51, 50, 53, 50, 54, 60, 47, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 73, 68, 62, 13, 10, 32, 32, 32, 32, 60, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 78, 117, 109, 98, 101, 114, 62, 49, 50, 49, 48, 52, 53, 50, 60, 47, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 78, 117, 109, 98, 101, 114, 62, 13, 10, 32, 32, 32, 32, 60, 80, 104, 111, 110, 101, 78, 117, 109, 98, 101, 114, 62, 54, 51, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 60, 47, 80, 104, 111, 110, 101, 78, 117, 109, 98, 101, 114, 62, 13, 10, 32, 32, 32, 32, 60, 65, 109, 111, 117, 110, 116, 62, 48, 48, 48, 48, 48, 48, 50, 53, 48, 48, 60, 47, 65, 109, 111, 117, 110, 116, 62, 13, 10, 32, 32, 32, 32, 60, 82, 101, 115, 117, 108, 116, 62, 48, 49, 60, 47, 82, 101, 115, 117, 108, 116, 62, 13, 10, 32, 32, 60, 47, 66, 111, 100, 121, 62, 13, 10, 60, 47, 77, 101, 115, 115, 97, 103, 101, 62 };

            ResponseWrap resWrap1 = new ResponseWrap(resByte1);

            Response res1 = resWrap1.getResponseObject();

            printResponseObject(res1);


            //response 2
            //response Byte Array 2
            var resByte2 = new byte[] { 69, 90, 69, 45, 88, 77, 76, 45, 77, 115, 103, 48, 50, 60, 77, 101, 115, 115, 97, 103, 101, 62, 13, 10, 32, 32, 60, 72, 101, 97, 100, 101, 114, 62, 13, 10, 32, 32, 32, 32, 60, 77, 101, 115, 115, 97, 103, 101, 68, 97, 116, 101, 62, 50, 48, 49, 48, 48, 51, 50, 52, 60, 47, 77, 101, 115, 115, 97, 103, 101, 68, 97, 116, 101, 62, 13, 10, 32, 32, 32, 32, 60, 77, 101, 115, 115, 97, 103, 101, 84, 105, 109, 101, 62, 49, 57, 50, 56, 48, 54, 60, 47, 77, 101, 115, 115, 97, 103, 101, 84, 105, 109, 101, 62, 13, 10, 32, 32, 60, 47, 72, 101, 97, 100, 101, 114, 62, 13, 10, 32, 32, 60, 66, 111, 100, 121, 62, 13, 10, 32, 32, 32, 32, 60, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 73, 68, 62, 51, 51, 50, 53, 50, 55, 60, 47, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 73, 68, 62, 13, 10, 32, 32, 32, 32, 60, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 78, 117, 109, 98, 101, 114, 62, 49, 50, 49, 48, 52, 55, 48, 60, 47, 84, 114, 97, 110, 115, 97, 99, 116, 105, 111, 110, 78, 117, 109, 98, 101, 114, 62, 13, 10, 32, 32, 32, 32, 60, 80, 104, 111, 110, 101, 78, 117, 109, 98, 101, 114, 62, 54, 51, 57, 57, 57, 57, 57, 57, 57, 57, 57, 57, 60, 47, 80, 104, 111, 110, 101, 78, 117, 109, 98, 101, 114, 62, 13, 10, 32, 32, 32, 32, 60, 65, 109, 111, 117, 110, 116, 62, 48, 48, 48, 48, 48, 48, 50, 53, 48, 48, 60, 47, 65, 109, 111, 117, 110, 116, 62, 13, 10, 32, 32, 32, 32, 60, 82, 101, 115, 117, 108, 116, 62, 48, 51, 60, 47, 82, 101, 115, 117, 108, 116, 62, 13, 10, 32, 32, 60, 47, 66, 111, 100, 121, 62, 13, 10, 60, 47, 77, 101, 115, 115, 97, 103, 101, 62 };

            ResponseWrap resWrap2 = new ResponseWrap(resByte2);

            // Response Byte Array 2 parsed into Response Message res2 object.

            Response res2 = resWrap2.getResponseObject();


            printResponseObject(res2);

            //Here are the Results of various response object elemetns






            //Part2 : Response Codes

            //Response Code for respose 1
            Console.WriteLine("Response Code for response 1");
            Console.WriteLine(res1.Body.Result.ToString());


            //Response Code for respose 2
            Console.WriteLine("Response Code for response 2");
            Console.WriteLine(res2.Body.Result.ToString());






            /*Part3: Based on the above exercise, please list any relevant / meaningful questions that you would
                     ask the partner we are integrating with before AND after trying to carry out the integration
                     according to their API */

            /*
              Ans:
                    Before Integration:

                      1 Authentication: In order to access your API, which authentication mechanism should we use?
                      2.Error Handeling: What kind of error handling should we implement for responses from your API? Can I expect any kinds of error from your API?
                      3.Encoding Decoding: Are there any perticular encoding/decoding requirements for your API's given data?
                      4.Request Rate: Is there any limit on number of request than your API can take per second?
                      5.Response Time: How long genenally your API takes to provide a response?
                      6.Testing Tool: Are there any acceptable testing tool for your API?
                      7.Header: Are there any specific Header for your API?
                      8.Charge: Do I need to provide any extra charge or credit to access your API?
                      9.Noise: Are there any noises in your responsed byte array that we will convert to XML files?

                    After Integration:

                     1. Improvement by Changing/Adding Endpoint: Do you have or updated or added new endpoinds that can improve the integration?
                     2. API availability: Are there any perticular uptime, downtime mamtaintance time on your API?
                     3. API update : Are there will be any future update that can be a problem with our integration?
                     4. Feedback: Can you update your api for some kinds of problem. Example: The response is sending xml file with noise. Can you update it?
                     5. Multiple Operation in Single API call: Is there a way to process multiple mobile top-ups in a single API call? If so, what are the options?
                     6. Detailed Transaction History of a user/ a day/ month /year: Are there any options to get a report or history of the mobile top-up transactions that have already been done?
                     7. Human Service: Are there any operator or Engineer in your end that can give us human support and assistance for troubleshooting any problems?







            */
















        }

        public static void SerializerReq(Request R)
        {
            var serializer = new XmlSerializer(typeof(Request));
            var xmlString1 = string.Empty;

            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, R);
                xmlString1 = writer.ToString();

            }

            Console.WriteLine("XML Request with Message ID -->" + R.ReqBody.MessageID.ToString());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine(xmlString1);
            Console.WriteLine("\n\n");




            Console.WriteLine("Byte array for sending the Request with Message ID --> " + R.ReqBody.MessageID.ToString());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            byte[] byteArray = Encoding.UTF8.GetBytes(xmlString1);

            // Console.WriteLine(Encoding.UTF8.GetString(byteArray));
            foreach (byte b in byteArray)
            {
                Console.Write(b + " ");
            }




            Console.WriteLine("\n\n\n");







        }

        public static void printResponseObject(Response res)
        {

            Console.WriteLine("Accessing And Printing the Contents of the Object parsed from the byte array to XML to Object of Transaction ID: " + res.Body.TransactionID.ToString());
            Console.WriteLine("---------------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("Header: ");
            Console.WriteLine("MessageDate --> " + res.Header.MessageDate.ToString());
            Console.WriteLine("MessageTime --> " + res.Header.MessageTime.ToString());
            Console.WriteLine("Body: ");
            Console.WriteLine("Transaction Id --> " + res.Body.TransactionID.ToString());
            Console.WriteLine("TransactionNumber --> " + res.Body.TransactionNumber.ToString());
            Console.WriteLine("PhoneNumber --> " + res.Body.PhoneNumber.ToString());
            Console.WriteLine("Amount --> " + res.Body.Amount.ToString());
            Console.WriteLine("Result --> " + res.Body.Result.ToString());

            Console.WriteLine("\n\n\n");






        }


    }





}
