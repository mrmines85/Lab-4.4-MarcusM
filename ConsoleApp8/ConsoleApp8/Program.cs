using System;
using System.Collections;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList blackListWords = new ArrayList();
            blackListWords.Add("buy");
            blackListWords.Add("viagra");
            blackListWords.Add("xxx");
            blackListWords.Add("free money");
            blackListWords.Add("lifetime offer");
            blackListWords.Add("send money");
            blackListWords.Add("bank account");
            blackListWords.Add("nigeria");
            blackListWords.Add("online");
            blackListWords.Add("pharmacy");
            blackListWords.Add("h8te");
            blackListWords.Add("meet girls");

            string message = Console.ReadLine();

            foreach (string item in blackListWords)
            {
                bool isSpam = false;
               
                if (message.Contains(item))
                {
                    isSpam = true;
                    Console.WriteLine("The message is spam");
                }
                else
                {
                    isSpam = false;
                    Console.WriteLine("The message is not spam.");
                }
            }
        }
    }
}
