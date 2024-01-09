using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 5, 10, 15,42, 20};
            Array.Sort(numArr);
            Array.Reverse(numArr);
            Array.Resize( ref numArr, 2);
            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine(numArr[i]);
            }


            int[] numArr2 = { 1, 56, 355, 6, 56, 89 };
            Console.WriteLine(Array.IndexOf(numArr2, 56));
            Console.WriteLine(Array.LastIndexOf(numArr2, 89));


            string text = "Fidan Heydarova";
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Replace('H', 'h'));
            Console.WriteLine(text.Replace("Fidan", "Fi"));
            Console.WriteLine(text.EndsWith("aa"));
            Console.WriteLine(text.EndsWith("a"));
            Console.WriteLine(text.Contains("an"));
            Console.WriteLine(text.Trim());

        }
    }
}
