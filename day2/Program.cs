using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var passes = Passwords.GetPasswords();
            var pps = Passwords.ConvertPasswords(passes);
            var validPasswords = Passwords.ValidPasswords(pps);
            var validPasswordsPolicy2 = Passwords.ValidPasswordsPolicy(pps);

            Console.WriteLine($"Number of valid passwords: {validPasswords}");
            Console.WriteLine($"Number of valid passwords with new policy: {validPasswordsPolicy2}");
            Console.ReadLine();
        }
    }
}
