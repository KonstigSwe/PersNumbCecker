using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersNumbCecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] persNumb;
            Console.Write("input your personal number: ");
            while (!int.TryParse(Console.ReadLine(), out persNumb))
            {
                Console.WriteLine("Please enter numbers only");
                Console.Write("input your personal number: ");
            }
            CorectNum(persNumb);
        }


        static bool CorectNum(int[] persNumb)
        { 
            
            if (persNumb.Length == 12)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        static bool SkottAr()
        {
            // if year is skottAr
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
