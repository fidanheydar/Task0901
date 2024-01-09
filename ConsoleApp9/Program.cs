using System;
using System.Text;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "elchin@code.edu.az";
            Console.WriteLine(domain(email));


            string text = "Salam necesen 1";
            Console.WriteLine(checkLetter(text));

            string textt = "sAlAm nEcEseN";
            Console.WriteLine(FormatText(textt));

            string[] fullNames = { "Fidan Heydarova", "Lamiya Guliyeva", "Salam Salamov" };
            string[] names = ArrayofNames(fullNames);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


            Console.Write("Doguldugunuz tarixi daxil edin:");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                int age = CalculateAge(birthDate);
                Console.WriteLine("Yash: " + age);
            }
            else
            {
                Console.WriteLine("Duzgun formatda daxil edin");
            }

        }

        static string domain(string email)
        {
            return email.Substring(email.IndexOf('@') + 1);

        }

        static bool checkLetter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetter(text[i]))
                    return false;
            }
            return true;
        }

        static string FormatText(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            StringBuilder result = new StringBuilder(text);
            result[0] = char.ToUpper(result[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    result[i] = char.ToLower(text[i]);
                }
            }
            return result.ToString();
        }

        static string[] ArrayofNames(string[] fullNames)
        {
            string[] namesArray = new string[fullNames.Length];

            for (int i = 0; i < fullNames.Length; i++)
            {
                namesArray[i] = fullNames[i].Split(' ')[0];
            }

            return namesArray;
        }
        static int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (DateTime.Today < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }


    }

}

