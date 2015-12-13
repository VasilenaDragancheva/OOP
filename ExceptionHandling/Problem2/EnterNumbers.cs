using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class EnterNumbers
    {
        private static int count = 10;
        static void Main(string[] args)
        {
     
            int start = 1;
            int end = 100;
            List<int> numbers = new List<int>();

            while(numbers.Count<count)
            {
                try
                {
                    int number = ReadNumber(start, end);
                    numbers.Add(number);
                    start = number;
                }
                catch(FormatException fe)
                {
                    Console.WriteLine("This is not a number!");
                }
                catch(OverflowException oe)
                {
                    Console.WriteLine("This is not an integer!");
                  
                }
                catch(ArgumentOutOfRangeException aore)
                {
                    Console.WriteLine("Number is out of range");
           
                }
                catch(NotPossibleToCompleteException npe)
                {
                    Console.WriteLine(npe.Message);
                  
                }
                
            }
            Console.Clear();
            Console.WriteLine("These are input numbers");
            numbers.ForEach(n => Console.WriteLine(n));
        }

        private static int ReadNumber(int start,int end)
        {

            Console.WriteLine("Enter number greater that {0} and less than {1}",start,end);
            string input = Console.ReadLine();
            int number = int.Parse(input);
         
            if(number>=end||number<=start)
            {
                throw new ArgumentOutOfRangeException("Number is out of range");
            }
            if (count > end - number)
            {
                throw new NotPossibleToCompleteException("There are not enough left numbers to complete task");
            } 
                return number;
                
            
            
            
        }
    }
}
