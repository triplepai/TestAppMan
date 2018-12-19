using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test_AppMan2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> formulaPart = new List<string>();
            string formula = "(22*2)+50"; //94
            Console.WriteLine("Formula = "+ formula);
          

    
            var pattern = @"\(([^)]*)\)";
            var query = "(22*2)+50";
            var matches = Regex.Matches(query, pattern);

            Console.WriteLine("Spliting formula");

            string Cutpart="";
            foreach (Match m in matches)
            {
                Cutpart = m.Groups[0].ToString();
                formulaPart.Add(m.Groups[1].ToString());
            }
            formulaPart.Add( formula.Replace(Cutpart, ""));
            foreach (var part in formulaPart)
            {
                Console.WriteLine(part);
                if(part.Contains("*"))
                {
                    if(part.Substring(0, 1) != "*" && part.Substring(part.Length - 1, 1) != "*")
                    {
          
                    }
                    
                }
            }

            Console.ReadLine();
        }
    }
}
