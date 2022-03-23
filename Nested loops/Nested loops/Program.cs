using System;

namespace Nested_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Clock
            //for (int h = 0; h < 24; h++)
            //{
            //    for (int m = 0; m < 60; m++)
            //    {
            //        Console.WriteLine(h + ":" + m);
            //    }
            //}

            ///Multibly
            //for (int a = 1; a < 11; a++)
            //{
            //    for (int b = 1; b < 11; b++)
            //    {
            //        Console.WriteLine(a + " * " + b + " = " + (a * b));
            //    }
            //}

            ///Solutions
            //int n = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int a = 0; a <= n; a++)
            //{
            //    for (int b = 0; b <= n; b++)
            //    {
            //        for (int c = 0; c <= n; c++)
            //        {
            //            if ((a + b + c) == n)
            //            {
            //                counter++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(counter);


            ///Sum 2 nums
            //int start = int.Parse(Console.ReadLine());
            //int finish = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int a = start; a <= finish; a++)
            //{
            //    for (int b = start; b <= finish; b++)
            //    {
            //        counter++;
            //        if ((a + b) == n)
            //        {
            //            Console.Write($"Combination N:{counter} ");
            //            Console.WriteLine($"({a} + {b} = {a + b})");
            //            return;
            //        }
            //    }
            //}
            //Console.WriteLine($"{counter} combinations - neither equals {n}");


            ///Holiday
            //string input = Console.ReadLine();
            //string place = input;
            //double minBudget = 0;
            //double sum = 0;
            //while (input != "End")
            //{
            //    minBudget = double.Parse(Console.ReadLine());
            //    sum = 0;
            //    while (input != "End")
            //    {
            //        input = Console.ReadLine();
            //       double money = double.Parse(input);
            //        sum += money;
            //        if (sum >= minBudget)
            //        {
            //            Console.WriteLine("Going to " + place + "!");
            //            break;
            //        }
            //    }

            //    input = Console.ReadLine();
            //    if (input == "End")
            //    {
            //        return;
            //    }
            //    place = input;


            ///Building
            //int floor = int.Parse(Console.ReadLine());
            //int room = int.Parse(Console.ReadLine());

            //for (int floorNum = floor; floorNum > 0; floorNum--)
            //{
            //    for (int roomNum = 0; roomNum < room; roomNum++)
            //    {
            //        if (floorNum == floor)
            //        {
            //            Console.Write("L" + floorNum);
            //            Console.Write(roomNum + " ");
            //        }
            //        else
            //        {
            //            if (floorNum % 2 == 0)
            //            {
            //                Console.Write("O" + floorNum);
            //                Console.Write(roomNum + " ");
            //            }
            //            else
            //            {
            //                Console.Write("A" + floorNum);
            //                Console.Write(roomNum + " ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}

            Class1 myObj = new Class1();

            Console.WriteLine(myObj.colour);

        }
    }
}
    

