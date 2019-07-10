using System.IO;

namespace consoleApp
{
    class WriteToFile : IWriteToFile
    {
        string name;
        string message;

        public WriteToFile(string name, string message){
          this.name = name;
          this.message = message;
        }

        public void Write(){
          string path = GeneratePath();
          using (StreamWriter sw = new StreamWriter(path, append: true))
          {
              sw.WriteLine(this.name + " said \"" + message + "\"");
          }
        }

        private string GeneratePath(){
          string tempPath = ".";
          string fileName = "outputLog.txt";
          return Path.Combine(tempPath, fileName);
        }
    }
}
