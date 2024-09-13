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


// task 2 

(Standard numeric format)

int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");


in one (1) pdf page:
1. why the output of this Equation = $30.00?
تمام مبدئيا الناتج طلع $30 عمله الدولار عشان عندنا حاجه اسمها  format specifie دا بيكون مسؤول عن التسنيقات 
ف احنا عندنا ال :c الي مكتوب في الكود عباره عن  format specifie  الرقم بيتحول للعمله الافتراضيه ع النظام
2. what is its benefit?
طب ايه الفايده من كل دا ده بيساعدك في الابلكيشن ال فايننس عمتا والمتاجر اي تطبيق بيتعامل مع الفلوس 
3. try another example with a different specifier with a screenshot of the output
تمام انا هنا ممكن استخدم format specifie زي مثلا
:N  او :P 
:N دا بيعرض الارقام بشكل فواصل 
زي الكود دا 
int x = 70;
int y = 10;
Console.WriteLine($"mynumper: {x:N}");
طب وال 
:P : معناهه percantage بيحسبلك النسبه المئويه من الرقمين الي انت هتعملهم ع سبيل المثال

int x = 200;
int y = 5;
Console.writeline($"Percentage is : {y / (double)x:P}");
