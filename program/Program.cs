using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //create a list of integers
            List<int> nums = new List<int>() { 20, 48, 60 };
            //ask user a number to divide each number in the list by
            Console.WriteLine("Type a number to divide the items by.");
            int div = Convert.ToInt32(Console.ReadLine());

            //write a loop that takes each number in the list and divides it by the number the user enters
            for (int n = 0; n < nums.Count; n++)
            {
                int totals = nums[n] / div;
                Console.WriteLine(totals);
            }
            Console.ReadLine();

        }
        //display message when writing letters
        catch (FormatException ex)
        {
            Console.WriteLine("Please type numbers only");
            return;
        }
        //display message when trying to divide by zero
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("please don't use 0");
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
