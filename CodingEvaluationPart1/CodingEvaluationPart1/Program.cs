using System;
using System.Text;

namespace CodingEvaluationPart1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var first = StructuredString("foo", "bar", "baz"); //should return [foo][bar][baz]
            Console.WriteLine(first);

            var second = StructuredString(first, "zoop"); //should return [[foo][bar][baz]][zoop]
            Console.WriteLine(second);
        }

        public static string StructuredString(params string[] str)
        {
            StringBuilder newStr = new StringBuilder();

            foreach (var s in str)
            {
                newStr.Append($"[{s}]");                
            }    
            return newStr.ToString();
        }
    }
}
