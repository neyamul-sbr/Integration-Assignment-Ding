


namespace IntegrationApp
{
    public class ReqWrap{

        private Request R;
        private string Identifier;
        private string MessageDate;
        private string MessageTime;
        private int MessageID;
        private string Amount;

        private string PhoneNumber;
        

        public ReqWrap(string Identifier, string MessageDate, string MessageTime, int MessageID, string PhoneNumber, string Amount ){
          
          this.Identifier = Identifier;
          this.MessageDate = MessageDate;
          this.MessageTime = MessageTime;
          this.MessageID = MessageID;
          this.Amount = Amount;
          this.PhoneNumber = PhoneNumber;


        }

        public Request getRequestObject(){

            R = new Request{
                ReqHeader = new ReqHeader
                {
                    Identifier = this.Identifier,
                    MessageDate = this.MessageDate,
                    MessageTime = this.MessageTime,
                    


                },
                ReqBody = new ReqBody
                {
                    MessageID = this.MessageID,
                    PhoneNumber = this.PhoneNumber,
                    Amount = this.Amount
                }
            };


            return R; 

        }





    }
    public class Request
    {

        public ReqHeader ReqHeader { get; set; }
        public ReqBody ReqBody { get; set; }


    }

    public class ReqHeader
    {
        public string Identifier { get; set; }
        public string MessageDate { get; set; }
        public string MessageTime { get; set; }
    }


    public class ReqBody
    {
        public int MessageID { get; set; }
        public string PhoneNumber { get; set; }
        public string Amount { get; set; }
      
    }







}