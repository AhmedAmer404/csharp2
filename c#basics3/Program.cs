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
            int pages =300;
            double pagesDouble = pages;
            Console.WriteLine(pagesDouble);
            #endregion

            #region Question3
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);
            #endregion

            #region Question 4
            string pagesText = "464";
            int pagesNumber = Convert.ToInt32(pagesText);

            Console.WriteLine(pagesNumber);
            #endregion

            #region Question 5
            string yearText = "2023";
            int year = int.Parse(yearText);

            Console.WriteLine(year);

            string badText = "abc";

            if (int.TryParse(badText, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            #endregion
            
            #region Question 6
            
            int pages67 = 464;

            string pagesString = pages67.ToString();

            Console.WriteLine(pagesString);
            Console.WriteLine(pagesString.GetType());
            #endregion
            
            #region Question 7
            int copies = 100;

            object boxedCopies = copies;

            int unboxedCopies = (int)boxedCopies;

            Console.WriteLine(boxedCopies);
            Console.WriteLine(unboxedCopies);
            #endregion

            #region Question 8

            int pages8 = 464;

            if (pages8 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region Question 9
            int pages9 = 464;
            bool isAvailable = true;

            if (pages9 > 300 && isAvailable == true)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion


        }
    }
}
