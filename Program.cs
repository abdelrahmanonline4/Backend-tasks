//This project is a simple console application written in C# designed to calculate and estimate the cost of a carpet
//cleaning service. The program calculates the total cost, 
//including tax, based on the number of small and large carpets a customer wants to be cleaned


namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables for code 
            int persmall = 25;
            int perlarge = 35;
            double salestaxrate = 0.06;
            int smallcarpets = 3;
            int largecarpets = 1;
            int cost = (smallcarpets * persmall) + (largecarpets * perlarge);
            double Tax = cost * salestaxrate;
            double estimated = cost + Tax;
            //output for code
            Console.WriteLine($"Number of small carpets : {smallcarpets} ");
            Console.WriteLine($"Number of large carpets : {largecarpets}");
            Console.WriteLine($"price small carpets is : {persmall}");
            Console.WriteLine($"price Large carpets is : {perlarge}");
            Console.WriteLine($"cost is : {cost}");
            Console.WriteLine($"Tax is :  {Tax}");
            Console.WriteLine($"estimated is : {estimated}");
            Console.WriteLine("This estimate is valid for 30 days");




        }


    }
}
