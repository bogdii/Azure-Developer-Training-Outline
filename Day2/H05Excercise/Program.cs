using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Password Strength Checker");

                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                int score = CalculatePasswordStrength(password);
                string suggestions = GetPasswordSuggestions(score);

                Console.WriteLine($"Password Strength Score: {score}/10");
                Console.WriteLine(suggestions);

                Console.ReadLine();
            }

             int CalculatePasswordStrength(string password)
            {
                int length = password.Length;
                int uppercaseCount = 0;
                int lowercaseCount = 0;
                int numberCount = 0;
                int specialCharCount = 0;

                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                    {
                        uppercaseCount++;
                    }
                    else if (char.IsLower(c))
                    {
                        lowercaseCount++;
                    }
                    else if (char.IsDigit(c))
                    {
                        numberCount++;
                    }
                    else if (char.IsSymbol(c) || char.IsPunctuation(c))
                    {
                        specialCharCount++;
                    }
                }

                int score = 0;

                if (length >= 8)
                {
                    score += 2;
                }

                if (uppercaseCount > 0 && lowercaseCount > 0)
                {
                    score += 2;
                }

                if (numberCount > 0)
                {
                    score += 2;
                }

                if (specialCharCount > 0)
                {
                    score += 2;
                }

                return score;
            }

             string GetPasswordSuggestions(int score)
            {
                if (score < 4)
                {
                    return "Suggestions: Use a longer password, mix uppercase and lowercase letters, add numbers and special characters.";
                }
                else if (score < 8)
                {
                    return "Suggestions: Use a longer password, mix uppercase and lowercase letters, add more numbers and special characters.";
                }
                else
                {
                    return "Suggestions: Your password is strong! Make sure to update it regularly.";
                }
            }
        }
    }
}
