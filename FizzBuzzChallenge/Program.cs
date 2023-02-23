using System;
using System.Reflection;


namespace Whiteboard 
{
    public static class FizzBuzz
    {
        public static string FizzOrBuzz(int number)
        {
            var result = "";
            if (number % 3 == 0)
            {
                result = "fizz";
            }
            if (number % 5 == 0)
            {
                result += "buzz";
            }
            return result;
            //var num = 0;
            //if(num % 3 == 0)
            //{
            //    return "fizz";

            //}
            //else if(num % 5 == 0)
            //{
            //    return "buzz";
            //}
            //if(num % 3 == 0 && num % 5 == 0)
            //{
            //    return "FizzBuzz";
            //}
        }

    }
    
}


 
