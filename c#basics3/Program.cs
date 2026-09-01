using System;
namespace Assignment
{
    public class  Program 
    {
        static void Main(string[] args)
        {
            #region Question 1
            try
            {
                int zero = 0;
                int result = 5 / zero;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cant divide by zero");

            }
            finally
            {
                Console.WriteLine("done");
            }
            #endregion
        }
    }
}
