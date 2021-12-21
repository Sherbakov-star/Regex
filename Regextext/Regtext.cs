using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regextext
{
    public class Regtext
    {
        public string regtext(string str)
        {
            
            Regex regex = new Regex("code");
            if (regex.IsMatch(str))
            {
                return "true";
            }
            else
            {
                return "false";
            }
            
        }
        public string regreplace(string str)
        {
            string pattern = @"\W?(а)";
            string replacement1 = "о";

            return Regex.Replace(str, pattern, replacement1);
        }
        public string regciv(string str)
        {
            Regex regex = new Regex(@"\d");
            return Convert.ToString(regex.Matches(str).Count);
        }
        public string regmail(string email)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            while (true)
            {
                if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
        }
        public int reguserid(string str)
        {
            Regex regex = new Regex(@"^user=(\d+)");
            Match match = regex.Match(str);
            int d = 0;
            while (match.Success)
            {
                d = Convert.ToInt32(match.Groups[1].Value);
                match = match.NextMatch();
            }
            return d;
        }
        public int regwcount(string str)
        {
            Regex regex = new Regex(@"(\w+\s*)");
            Match match = regex.Match(str);
            int d = 0;
            if (match.Success)
            {
                d += Convert.ToInt32(regex.Matches(str).Count);
                match = match.NextMatch();
            }
            return d;
        }

        public string regname(string str)
        {
            string pattern = @"\b(\w+)(\W)(\w+)\b";

            string replacement1 = "$3$2$1";
            return Regex.Replace(str, pattern, replacement1);
        }
        public string named_replace(string str)
        {
            string pattern = @"\b(?<surname>\w+),\s*(?<name>\w+)\b";

            string replacement1 = "${name} ${surname}";
            return Regex.Replace(str, pattern, replacement1);
        }
        public string first_tag(string str)
        {
            string pattern = @"<(\w+?)>.*?<\/\1>";
            Match match = Regex.Match(str, pattern);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return "";
        }
        public int n_count(string str)
        {
            Regex regex = new Regex(@"(?<!\-)\s*(\d+)");
            Match match = regex.Match(str);
            int d = 0;
            if (match.Success)
            {
                d += Convert.ToInt32(regex.Matches(str).Count);
                match = match.NextMatch();
            }
            return d;
        }
        public int keys_count(string str)
        {
            Regex regex = new Regex(@"""\w+""(?=:)");
            Match match = regex.Match(str);
            int d = 0;
            if (match.Success)
            {
                d += Convert.ToInt32(regex.Matches(str).Count);
                match = match.NextMatch();
            }
            return d;
        }

    }
}
