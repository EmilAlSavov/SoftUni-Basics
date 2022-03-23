using System;

namespace Nested_Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Piramide
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;

            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(num + " ");
            //        num++;
            //        if (num > n)
            //        {
            //            return;
            //        }
            //    }
            //    Console.WriteLine();
            //}


            //int start = int.Parse(Console.ReadLine());
            //int finish = int.Parse(Console.ReadLine());

            //int sum1 = 0;
            //int sum2 = 0;

            //for (int num = start; num <= finish; num++)
            //{
            //    sum1 = 0;
            //    sum2 = 0;
            //    string currentNum = num.ToString();
            //    for (int i = 0; i < currentNum.Length; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            sum1 += currentNum[i];
            //        }
            //        else
            //        {
            //            sum2 += currentNum[i];
            //        }
            //    }
            //    if (sum1 == sum2)
            //    {
            //        Console.Write(currentNum + " ");
            //    }
            //    else
            //    {

            //    }
            //}

            ///Prime and NonPrime Sums
            //    string input = Console.ReadLine();
            //    int sum1 = 0;
            //    int sum2 = 0;
            //    bool isPrime = true;

            //    while (input!="stop")
            //    {
            //        int num = int.Parse(input);
            //        if (num < 0)
            //        {
            //            Console.WriteLine("Number is negative.");
            //        }
            //        else
            //        {
            //            for (int i = 2; i < num; i++)
            //            {
            //                if (num % i == 0)
            //                {
            //                    sum1 += num;
            //                    isPrime = false;
            //                    break;
            //                }
            //            }
            //            if (isPrime)
            //            {
            //                sum2 += num;
            //            }
            //        }
            //        input = Console.ReadLine();
            //        isPrime = true;
            //    }
            //    Console.WriteLine($"Sum of all prime numbers is: {sum2}");
            //    Console.WriteLine($"Sum of all non prime numbers is: {sum1}");


            ///Train Course
            //int n = int.Parse(Console.ReadLine());

            //double grades = 0;
            //int counterEntryes = 0;
            //double gradeSum = 0;
            //string presentationName = Console.ReadLine();
            //while (presentationName != "Finish")
            //{
            //    grades = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        grades += double.Parse(Console.ReadLine());
            //    }
            //    double avarageGradePerStudent = grades / n;
            //    Console.WriteLine($"{presentationName} - {avarageGradePerStudent:F2}.");
            //    counterEntryes++;
            //    gradeSum += avarageGradePerStudent;
            //    presentationName = Console.ReadLine();
            //}
            //Console.WriteLine($"Student's final assessment is {(gradeSum / counterEntryes):F2}.");


            ///Special Numbers
            //int num = int.Parse(Console.ReadLine());
            //for (int u = 1; u < 10; u++)
            //{
            //    for (int y = 1; y < 10; y++)
            //    {
            //        for (int t = 1; t < 10; t++)
            //        {
            //            for (int i = 1; i < 10; i++)
            //            {
            //                if (num % i == 0 && num%t==0 && num%y==0 && num%u==00)
            //                {
            //                    Console.Write($"{u}{y}{t}{i} ");
            //                }
            //            }
            //        }
            //    }
            //}

            ///Cinema
            //string MovieName = Console.ReadLine();
            //double ticketsPerMovie = 0;
            //double totalTicketsSum = 0;
            //int studentTicketsSum = 0;
            //int standartTicketsSum = 0;
            //int kidTicketsSum = 0;
            //while (MovieName!= "Finish")
            //{
            //    ticketsPerMovie = 0;
            //    double freePlaces = double.Parse(Console.ReadLine());
            //    string typeOfTicket = Console.ReadLine();
            //    while (typeOfTicket != "End" && typeOfTicket != "Finish")
            //    {
                    
            //        if (typeOfTicket == "student")
            //        {
            //            studentTicketsSum++;
            //        }
            //        else if (typeOfTicket == "standard")
            //        {
            //            standartTicketsSum++;
            //        }
            //        else if (typeOfTicket == "kid")
            //        {
            //            kidTicketsSum++;
            //        }
            //        totalTicketsSum++;
            //        ticketsPerMovie++;
            //        if (ticketsPerMovie >= freePlaces)
            //        {
            //            break;
            //        }
            //        typeOfTicket = Console.ReadLine();
            //    }
                
            //    Console.WriteLine($"{MovieName} - {((ticketsPerMovie / freePlaces) * 100):F2}% full.");
            //    if (typeOfTicket == "Finish")
            //    {
            //        MovieName = typeOfTicket;
            //        continue;
            //    }
            //    MovieName = Console.ReadLine();
            //}
            //Console.WriteLine($"Total tickets: {totalTicketsSum}");
            //Console.WriteLine($"{((studentTicketsSum / totalTicketsSum) * 100):F2}% student tickets.");
            //Console.WriteLine($"{((standartTicketsSum / totalTicketsSum) * 100):F2}% standard tickets.");
            //Console.WriteLine($"{((kidTicketsSum / totalTicketsSum) * 100):F2}% kids tickets.");
        }
    }
}
