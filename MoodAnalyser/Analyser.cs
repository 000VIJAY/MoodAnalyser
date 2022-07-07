using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser
    {
<<<<<<< HEAD
        string message;
        public Analyser()
        {
            this.message = "";
        }
=======
       public string message;
>>>>>>> ExceptionHandling
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
<<<<<<< HEAD
          else
=======
            catch
>>>>>>> ExceptionHandling
            {
                message.Contains("Happy", StringComparison.OrdinalIgnoreCase);
                return "Happy";
            }
            return null;
        }
    }
}
