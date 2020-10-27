using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersNumbCecker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numAmountOk = false;
            bool yearOk = false;
            string userInput = "200008144131";
            int[] intArray = new int[12];
            for (int i = 0; i < userInput.Length; i++)
            {
                intArray[i] = userInput[i];
            }
            numAmountOk = CorectNum(intArray);
            yearOk = Year(intArray);

        }


        static bool CorectNum(int[] intarray)
        {
            if(intarray.Length == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Year(int[] intarray)
        {
            
        }
        static bool Month()
        {
            // if month is correct
        }
        static bool Days()
        {
            //i9f day in month is corect
        }


    }
}
