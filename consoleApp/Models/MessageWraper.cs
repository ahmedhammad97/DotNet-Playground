namespace consoleApp
{
    class MessageWraper : IMessageWraper
    {
        string rawMessage;
        string name;
        string message;

        public MessageWraper(string rawMessage){
          this.rawMessage = rawMessage;
        }

        public bool Parse(){
          string[] tokens = this.rawMessage.Split(':');
          if(tokens.Length != 2) return false;
          this.name = tokens[0].Trim();
          this.message = tokens[1].Trim();
          return true;
        }

        public string GetName(){
          return this.name;
        }

        public string GetMessage(){
          return this.message;
        }
    }
}
