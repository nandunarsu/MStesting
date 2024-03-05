using System;
using System.Text.RegularExpressions;
using System.Collections;

namespace RegularExpression
{
    public class Program
    {
       static void Main()
        {
            //string pattern  = @"\b[M]{1}[A-Za-z0-1]{5,15}";
            //Regex r = new Regex(pattern, RegexOptions.IgnoreCase);

            //string[] str = { "Mandini", "Gourish", "prem", "Sourab", "Mtesting123" };
            //ArrayList authors = new ArrayList()
            //{
            //    "Nandini is in office", "She went to school", "prem","Sourab", "Mtesting123"
            //};
            //Valid(r, authors);
            //Valid(authors);
            //string str = "I am in office";
            //string clear = Valid(str);
            //Console.Write(clear);
            Regex r = new Regex(@"^[a-zA-z0-9]{4,20}@\w+\.+com$");
            string str = "nandinink1947@gmail.com";
            bool result = Valid(r, str);
            Console.WriteLine(result);

        }

        public static bool Valid(Regex r, string s1)
        {
            //foreach (string s in writers)
            //{
            //    string clearstring = Regex.Replace(s, "\\s+", "");
            //    Console.WriteLine(clearstring);
            //}
            return r.IsMatch(s1);

            
        }
    }
}

