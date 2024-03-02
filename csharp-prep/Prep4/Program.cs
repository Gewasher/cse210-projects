using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter A list of numbers, type 0 when finished.");
        int number = -1;
        List<int> numbers = new List<int>();
        int sum=0;
        int lnumber=0;
        
        while (number!=0)
        {
            Console.Write("Enter number: ");
            number=int.Parse(Console.ReadLine());
            if (number!=0)
            {
                sum+=number;
                numbers.Add(number);
            }
            if (number>lnumber)
            {
                lnumber=number;
            }

        }
        float avg=((float)sum)/numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average number is: {avg}");
        Console.WriteLine($"The largest number is: {lnumber}");
        


    }
}