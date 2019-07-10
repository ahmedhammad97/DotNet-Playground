using System;
using System.IO;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
              string message = Console.ReadLine();
              if(message == "end" || message == "END"){break;}

              MessageWraper msgWraper = new MessageWraper(message);
              bool successFlag = msgWraper.Parse();

              if(!successFlag){
                Console.WriteLine("Wrong format .. Message got ignored");
              }

            }
        }
    }
}
