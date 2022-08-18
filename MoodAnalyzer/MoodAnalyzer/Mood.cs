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

                if (message.ToLower().Contains("HAPPY"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "SAD";
                }
            }
            catch (Exception)
            {
                return "HAPPY";
            }

        }
    }
}