using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser
    {
       public string message;
        public Analyser(string message)
        {
           this.message = message;
        }
        public string MoodAnalyse()
        {
            try
            {
                if (message.Contains("Sad", StringComparison.OrdinalIgnoreCase))
                {
                    return "Sad";
                }
                else
                {
                    message.Contains("Happy", StringComparison.OrdinalIgnoreCase);
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }
        }
    }
}
