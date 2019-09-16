namespace P04.Telephony
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine()
                .Split(" ");

            string[] sites = Console.ReadLine()
                .Split(" ");

            Smartphone smartphone = new Smartphone();

            for (int i = 0; i < numbers.Length; i++)
            {
                smartphone.AddNumber(numbers[i]);
            }

            for (int i = 0; i < sites.Length; i++)
            {
                smartphone.AddSite(sites[i]);
            }

            Console.WriteLine(smartphone.Call());
            Console.WriteLine(smartphone.Browsing());
        }
    }
}
