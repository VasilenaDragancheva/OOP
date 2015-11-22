using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class TestingSquareRoot
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            try
            {
                double number=double.Parse(input);
                double result=Calculator.SquareRoot(number);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch(ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}
