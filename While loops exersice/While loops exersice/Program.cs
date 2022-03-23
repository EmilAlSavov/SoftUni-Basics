using System;

namespace While_loops_exersice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ///Book Library
            //    string searchedBook = Console.ReadLine();
            //    string input = Console.ReadLine();
            //    int counter = 0;

            //    while (input != "No More Books")
            //    {
            //        counter++;
            //        if (input == searchedBook)
            //        {
            //            counter--;
            //            Console.WriteLine($"You checked {counter} books and found it.");
            //            return;
            //        }
            //        input = Console.ReadLine();
            //    }
            //    Console.WriteLine($"The book you search is not here!");
            //    Console.WriteLine($"You checked {counter} books.");

            ///Exam preparation
            //    int numFails = int.Parse(Console.ReadLine());
            //    string lastEx = Console.ReadLine();
            //    string input = Console.ReadLine();
            //    int counter = 0;
            //    int counterFails = 0;
            //    double sum = 0;
            //    string lastLastEx = "";

            //    while (lastEx != "Enough")
            //    {
            //        counter++;
            //        double grade = double.Parse(input);
            //        sum += grade;

            //        if(grade <= 4)
            //        {
            //            counterFails++;
            //            if(counterFails == numFails)
            //            {
            //                Console.WriteLine($"You need a break, {counterFails} poor grades.");
            //                return;
            //            }
            //        }
            //        lastLastEx = lastEx;
            //        lastEx = Console.ReadLine();
            //        input = Console.ReadLine();
            //    }
            //    Console.WriteLine($"Average score: {(sum/counter):f2}");
            //    Console.WriteLine($"Number of problems: {counter}");
            //    Console.WriteLine($"Last problem: {lastLastEx}");

            ///Holiday
            //double neededMoney = double.Parse(Console.ReadLine());
            //double availableMoney = double.Parse(Console.ReadLine());
            //string input = "";
            //double money = 0;
            //int days = 0;
            //int daysInARow = 0;
            //while (availableMoney < neededMoney)
            //{
            //    input = Console.ReadLine();
            //    money = double.Parse(Console.ReadLine());
            //    days++;
            //    if (input == "save")
            //    {
            //        availableMoney += money;
            //        daysInARow = 0;
            //    }
            //    else
            //    {
            //        availableMoney -= money;
            //        daysInARow += 1;
            //        if(daysInARow == 5)
            //        {
            //            Console.WriteLine("You can't save the money.");
            //            Console.WriteLine($"{days}");
            //            return;
            //        }
            //        if (availableMoney < 0)
            //        {
            //            availableMoney = 0;
            //        }
            //    }


            //}
            //Console.WriteLine($"You saved the money for {days} days.");

            ///Healthy lifestyle
            //string input = Console.ReadLine();
            //double steps = 0;
            //while (input != "Going home")
            //{
            //    steps += double.Parse(input);
            //    if (steps >= 10000)
            //    {
            //        Console.WriteLine("Goal reached! Good job!");
            //        Console.WriteLine($"{steps - 10000} steps over the goal!");
            //        return;
            //    }
            //    input = Console.ReadLine();
            //}
            //input = Console.ReadLine();
            //steps += double.Parse(input);
            //if (steps >= 10000)
            //{
            //    Console.WriteLine("Goal reached! Good job!");
            //    Console.WriteLine($"{steps - 10000} steps over the goal!");
            //}
            //else
            //{
            //    Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            //}

            ///Money
            //double change = double.Parse(Console.ReadLine());
            //change = change * 100;
            //int counter = 0;
            //while (change > 0)
            //{
            //    if (change >= 200)
            //    {
            //        change -= 200;
            //    }
            //    else if (change >= 100)
            //    {
            //        change -= 100;
            //    }
            //    else if (change >= 50)
            //    {
            //        change -= 50;
            //    }
            //    else if (change >= 20)
            //    {
            //        change -= 20;
            //    } else if(change >= 10)
            //    {
            //        change -= 10;
            //    }
            //    else if (change >= 5)
            //    {
            //        change -= 5;
            //    }
            //    else if (change >= 2)
            //    {
            //        change -= 2;
            //    }
            //    else if(change >= 1)
            //    {
            //        change -= 1;
            //    }
            //    else
            //    {
            //        break;
            //    }

            //    counter++;
            //}
            //Console.WriteLine(counter);

            ///Cake
            //int wide = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());
            //int size = wide * length;
            //string input = Console.ReadLine();
            //int steps = 0;

            //while (input != "STOP")
            //{
            //    steps = int.Parse(input);
            //    size -= steps;
            //    if(size <= 0)
            //    {
            //        Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
            //        return;
            //    }
            //    input = Console.ReadLine();
            //}
            //if(size <= 0)
            //{
            //    Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
            //}
            //else
            //{
            //    Console.WriteLine($"{size} pieces are left.");
            //}

            ///Moving
            //int wide = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());
            //int haight = int.Parse(Console.ReadLine());
            //int size = wide * length * haight;
            //string input = Console.ReadLine();
            //int boxes = 0;
            //int sum = 0;
            //while (input != "Done")
            //{
            //    boxes = int.Parse(input);
            //    sum += boxes;
            //    size -= boxes;
            //    if(size <= 0)
            //    {
            //        Console.WriteLine($"No more free space! You need {Math.Abs(size)} Cubic meters more.");
            //        return;
            //    }
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine($"{size} Cubic meters left.");
        }
    }
}
