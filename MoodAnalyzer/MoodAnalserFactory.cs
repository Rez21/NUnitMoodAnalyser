using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    class MoodAnalserFactory
    {



     public static object CreateMoodAnalyse(string className,string constructorName)
        {
            // pattern to check if the class name and constructor name are same.
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(pattern, className);// will check the pattern and class name matches

            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly(); // gives out the current assemble (namespace)
                    Type moodAnalyseType = assembly.GetType(className); // using Type to check class
                    return Activator.CreateInstance(moodAnalyseType); // creates an  instance of specified type
                }
                catch(ArgumentNullException)
                {
                    throw new moodanalysecustomException(moodanalysecustomException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new moodanalysecustomException(moodanalysecustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "constrcutor not found");
            }
        }
    }
}
