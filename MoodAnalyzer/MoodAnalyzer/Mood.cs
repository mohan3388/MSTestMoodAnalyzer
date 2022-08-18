using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Mood
    {

        public string message;
        public Mood(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message == null)
                {
                    throw new MoodException(MoodException.ExceptionType.NULL_MOOD, "Message is Null");
                }
                if (message.Equals(" "))
                {
                    throw new MoodException(MoodException.ExceptionType.EMPTY_MOOD, "Message is Empty");
                }
                if (message.ToLower().Contains("happy"))
                {
                    return "Happy";
                }
                else
                {
                    return "Sad";
                }
            }
            catch (Exception)
            {
                throw new MoodException(MoodException.ExceptionType.EMPTY_MOOD, "Message is Empty");
            }

        }
    }
}