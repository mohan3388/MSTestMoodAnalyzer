using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzeFactory
    {
        public static object CreateMoodAnalysis(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzeType = executing.GetType(className);
                    return Activator.CreateInstance(MoodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodException(MoodException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
                }
            }
            else
            {
                throw new MoodException(MoodException.ExceptionType.NO_SUCH_METHOD, "No Constructor is Found");
            }
        }

        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(Mood);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodException(MoodException.ExceptionType.NO_SUCH_METHOD, "Class not Found");
                }
            }
            else
            {
                throw new MoodException(MoodException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
        public static string InvokeAnalyzerMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzer.Mood");
                object moodAnalyzeObject = AnalyzeFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzer.Mood", "MoodAnalyzer", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object mood = methodInfo.Invoke(moodAnalyzeObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodException(MoodException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
    }
}
