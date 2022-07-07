using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser
    {
        string message;
        public Analyser()
        {
            this.message = "";
        }
        public Analyser(string message)
        {
           this.message = message;
        }
        public string MoodAnalyse()
        {
            if(message.Contains("Sad",StringComparison.OrdinalIgnoreCase))
            {
                return "Sad";
            }
          else
            {
                message.Contains("Happy", StringComparison.OrdinalIgnoreCase);
                return "Happy";
            }
            return null;
        }
    }
}
