using System;

namespace SarcasticText
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a phrase: ");
            string input = Console.ReadLine();            

            var sarcasm = new ApplySarcasm(input);
            var snark = sarcasm.applySarcasm();

            System.Console.WriteLine("Your sarcastic phrase: {0}", snark);
            Console.Read();
        }
    }
}
