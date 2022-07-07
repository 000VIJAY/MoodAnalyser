using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
        public enum ExpType
        {
            nullval,
            Empty
        }
    public class MoodException : Exception
    {
        public ExpType Exp;
        public MoodException (string messag , ExpType Exp) : base (messag)
        {
            this.Exp = Exp;
        }
    }
}
