using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Mood
    {




        string message;
        public Mood(string message)
        {
            this.message = message;
        }
        public string MoodAnalyze()
        {
            if (message.ToLower().Contains("HAPPY"))
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
            return message;
        }
    }
}