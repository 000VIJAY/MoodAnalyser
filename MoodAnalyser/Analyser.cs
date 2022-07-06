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
            return null;
        }
        public string Analyse()
        {
            if (message.Contains("I am in any Mood"));
            {
                return "Happy";
            }
        }
    }
}
