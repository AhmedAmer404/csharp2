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

            #region Question2
            int pages =100;
            double pagesDouble = pages;
            Console.WriteLine(pagesDouble);
            #endregion

            #region Question3
            double price = 30.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);
            #endregion

            #region Question 4
            string pagesText = "464";
            int pagesNumber = Convert.ToInt32(pagesText);

            Console.WriteLine(pagesNumber);
            #endregion

        }
    }
}
