using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodException:Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public ExceptionType exceptionType;
        public MoodException(ExceptionType type, string message) : base(message)
        {
            this.exceptionType = type;
        }
    }
}
