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
        public Analyser(string messag)
        {
           this.message = messag; 
        }
        public string MoodAnalyse()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodException("Mood should not Null", ExpType.nullval);
                }
                if (message.Length < 1 )
                {
                    throw new MoodException("Provided message is empty", ExpType.Empty);
                }
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
            catch (MoodException ex)
            {
                return ex.Message;
            }
        }
    }
}
