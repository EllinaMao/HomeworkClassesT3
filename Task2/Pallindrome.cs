using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal static class Pallindrome
    {
        internal static bool IsPallindrome(int num)
        {
            try
            {

                string strNumber = Convert.ToString(num);
                if (strNumber.Reverse().SequenceEqual(strNumber)) 
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
        }

        internal static void Result(bool result)
        {
            
            Console.WriteLine(result ? "Паллиндром" : "Не паллиндром");
        }
    }
}
