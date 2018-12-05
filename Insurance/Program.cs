using System;


namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval. Press Enter to continue");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int userAge = Convert.ToInt32(age);

            Console.WriteLine("Have you ever had a DUI? Please answer True Or False");
            string duiTrueOrFalase = Console.ReadLine();
            bool trueORFalse = duiTrueOrFalase == "true";
            Console.WriteLine(trueORFalse);
        

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int userTickets = Convert.ToInt32(tickets);

            Console.WriteLine("Approved?");
            bool isApproved = userAge > 15 && trueORFalse == false && userTickets < 3;
            Console.WriteLine(isApproved);
            Console.ReadLine();

        }
    }
}
