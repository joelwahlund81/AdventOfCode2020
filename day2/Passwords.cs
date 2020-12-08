using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace day2
{
    public static class Passwords
    {
        public class PolicyPassword
        {
            public PolicyPassword(string[] policies, char policyLetter, string password)
            {
                PolicyMin = int.Parse(policies[0]);
                PolicyMax = int.Parse(policies[1]);
                PolicyLetter = policyLetter;
                Password = password;
            }

            public int PolicyMin { get; set; }
            public int PolicyMax { get; set; }
            public char PolicyLetter { get; set; }
            public string Password { get; set; }
        }

        public static string[] GetPasswords() => System.IO.File.ReadAllLines(@"C:\Users\admin\source\repos\AdventOfCode2020\day2\passwords.txt");
        
        public static List<PolicyPassword> ConvertPasswords(string[] passwords)
        {
            var list = new List<PolicyPassword>();
            
            foreach (string pass in passwords)
            {
                var policies = Regex.Split(pass, @"\D+");
                var indexOfComma = pass.IndexOf(":");
                var policyLetter = pass.Substring(indexOfComma - 1, 1);
                var password = pass.Split(" ")[2];
                var pp = new PolicyPassword(policies, policyLetter.ToCharArray()[0], password);
                list.Add(pp);
            }

            return list;
        }

        public static int ValidPasswords(List<PolicyPassword> policyPasswords)
        {
            var validPasswords = 0;

            foreach (var pass in policyPasswords)
            {
                var s = pass.Password.Count(s => s == pass.PolicyLetter);

                if (s >= pass.PolicyMin && s <= pass.PolicyMax)
                {
                    validPasswords += 1;
                }
            }

            return validPasswords;
        }

        public static int ValidPasswordsPolicy(List<PolicyPassword> policyPasswords)
        {
            var validPasswords = 0;

            foreach (var pass in policyPasswords)
            {
                if (pass.Password[pass.PolicyMin - 1] == pass.PolicyLetter || pass.Password[pass.PolicyMax - 1] == pass.PolicyLetter)
                {
                    if (!(pass.Password[pass.PolicyMin - 1] == pass.PolicyLetter && pass.Password[pass.PolicyMax - 1] == pass.PolicyLetter))
                    {
                        validPasswords += 1;
                    }
                }
            }

            return validPasswords;
        }
    }
}
