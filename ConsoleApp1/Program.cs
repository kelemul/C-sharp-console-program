using System;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            var inpput1 = 20;
            var input2 = 30;
            var input3 = 40;

            
            
            Console.WriteLine("enough for today");
            Another_1 a = new Another_1();
            var sum = a.Add(inpput1, input2);
            var diff = a.Diff(sum, input3);
            float div = a.Div(input2, input3);
            Console.WriteLine("The Sum of  " + inpput1 + " and " + input2 + " is = " + sum);
            Console.WriteLine("The difference between " + sum + " and " + input3 + " is = " + diff);
            Console.WriteLine("The division of " + input2 + " and " + input3 + " is = " + div);
            Console.WriteLine("====================  THIS IS THE END =====================");

            int ii= Console.Read();
          
            if (ii <= 50)
            {
                Console.WriteLine(ii+" is less than 50");
            }
            else
            {
                Console.Write(ii + " is greater than 50");
            }
           


        }
    }
}
