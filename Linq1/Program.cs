using System;
using System.Linq;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Console.WriteLine("Array of Numbers: "+string.Join(",", Numbers));
            Console.WriteLine("Output: Cube of the numbers that are greater than 100 but less than 1000");
            PrintCubeOfNumbers(Numbers);
            var ModifiedNumbers = new int[] { 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Array of Modified Numbers: " + string.Join(",", ModifiedNumbers));
            Console.WriteLine("Output: Cube of the numbers that are greater than 100 but less than 1000");
            PrintCubeOfNumbers(ModifiedNumbers);

        }

        static void PrintCubeOfNumbers(int[] numbers)
        {
            var Cubeofnumbers = (from int num in numbers
                                 let cubeNo = num * num * num
                                 where cubeNo > 100 && cubeNo < 1000
                                 select new { num, cubeNo }).ToList();
           
            Cubeofnumbers.ForEach(item =>
            {
                Console.WriteLine("Number: " + item.num + " Cube: " + item.cubeNo);
            });
            Console.ReadLine();
        }
    }
}
