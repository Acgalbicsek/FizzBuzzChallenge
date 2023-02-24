using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Whiteboard 
{
    public class Program
    {
        static void Main(string[] args)
        {
            static string FizzBuzz(int number)
            {
                var result = "";
                if (number % 3 == 0)
                {
                    return "fizz";

                }
                else if (number % 5 == 0)
                {
                    return "buzz";
                }
                if (number % 3 == 0 && number % 5 == 0)
                {
                    return "FizzBuzz";
                }
            }
          
           
        }

    }
    
}


 
