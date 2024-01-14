using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Security.Cryptography;

namespace OOPLab0;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        //Console.WriteLine("Enter a low number");

        //string low = Console.ReadLine();
        //int lowNum;

        //Task 2
        /*while (true)
        {
            if (int.TryParse(low, out lowNum) && lowNum >= 0)
            {
                break;
            }
            else
            {
                {
                    Console.WriteLine("Invalid input, please enter an integer");
                    low = Console.ReadLine();
                }
            }
        } */

        //Console.WriteLine("Enter a high number");

        /*string high = Console.ReadLine();
        int highNum;
        while (true)
        {
            if (int.TryParse(high, out highNum) && highNum > lowNum)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter an integer greater than the low number");
                high = Console.ReadLine();
            }
        } */

        //int difference = highNum - lowNum;
        //Console.WriteLine($"The difference between {highNum} and {lowNum} is {difference}");

        //Task 3
        //Using Array to store values

        /*int[] numbersInRange = new int[difference - 1];
        for (int i = 0; i < numbersInRange.Length; i++)
        {
            numbersInRange[i] = lowNum + 1 + i;
            Console.WriteLine($"The value at index {i} is: {numbersInRange[i]}");

        }*/
     
        //Create new file, store numbers in revers order
        //Was not able to find a way to create file without using full path
       /* using (StreamWriter sw = File.CreateText("C:\\Users\\shann\\Documents\\OOP2\\Lab 0\\OOP Lab 0\\numbers.txt"))
        {
            for (int i = numbersInRange.Length; i --> 0;) 
            {
                Console.WriteLine(numbersInRange[i]);
                sw.WriteLine(numbersInRange[i]);
            }
        } */

        //Additional Tasks
        //Use methods get, read file and sum stored numbers, use list instead of array, use double data type, print out prime numbers

        Console.WriteLine("Enter a low number");
        double lowNum = GetPositiveNumber();
        Console.WriteLine("Enter a high number");
        double highNum = GetHighNumber(lowNum);
        double difference = highNum - lowNum;
        Console.WriteLine($"The difference between {highNum} and {lowNum} is: {difference}");

        List<double> listOfNumbers = new List<double>();
        List<double> listOfPrimes = new List<double>();
        for (int i = 0; i < difference - 1; i++)
        {
            double n = lowNum + 1 + i;
            listOfNumbers.Add(n);
            bool prime = IsPrime(n);
            if (prime == true) {
                listOfPrimes.Add(n);
            }
        }
        Console.Write($"Prime numbers between {lowNum} and {highNum} are: ");
        foreach (double n in listOfPrimes)
        {
            Console.Write($"{n} ");
        }

        //Was not able to figure out how to create or read a file without using an absolute path
        int listLength = listOfNumbers.Count;
        using (StreamWriter sw = new StreamWriter("C:\\Users\\shann\\Documents\\OOP2\\Lab 0\\OOP Lab 0\\numbers.txt"))
        {
            for (int i = listLength; i-- > 0;)
            {
                sw.WriteLine(listOfNumbers[i]);
            }
        }

        //Reading file
        using (StreamReader sr = new StreamReader("C:\\Users\\shann\\Documents\\OOP2\\Lab 0\\OOP Lab 0\\numbers.txt"))
        {
            string line;
            double sum = 0;
            while ((line = sr.ReadLine()) != null)
            {
                sum += double.Parse(line);
            }
            Console.WriteLine($"\nThe sum of the integers between {lowNum} and {highNum} is: {sum}");
        }
    }

    static double GetPositiveNumber()
    {
        string low = Console.ReadLine();
        double lowNum;
        while (true)
        {
            if (double.TryParse(low, out lowNum) && lowNum >= 0)
            {
                return lowNum;
            }
            else
            {
                {
                    Console.WriteLine("Invalid input, please enter an integer");
                    low = Console.ReadLine();
                }
            }
        }
    }

    static double GetHighNumber(double low)
    {
        string high = Console.ReadLine();
        double highNum;
        while (true)
        {
            if (double.TryParse(high, out highNum) && highNum > low)
            {
                return highNum;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter an integer greater than the low number");
                high = Console.ReadLine();
            }
        }
    }
    static bool IsPrime(double n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
           
         return true;  
    }
}
