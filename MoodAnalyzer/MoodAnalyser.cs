using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalysar
    {
        public string Message;
        public MoodAnalysar() 
        { 
        }

        public MoodAnalysar(string Message)
        {
            this.Message = Message.ToUpper();
        }
        public string MoodAnalyzerWithConstructor(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";
            else return "HAPPY";
        }
        public string MoodAnalyzerWithParameterisedConstructor(string Message)
        {
            if (Message.ToLower().Contains("sad"))
                return "SAD";
            else return "HAPPY";
        }
       public string MoodAnalyzerWithParameterisedConstructor()
        {
            throw new NotImplementedException;
        }
    }
}
