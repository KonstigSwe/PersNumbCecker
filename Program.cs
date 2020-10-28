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
        { int numbtransfer = 0;
            bool numAmountOk = false;
            bool shotyearOk = false;
            bool yearOk = false;
            bool monthOk = false;
            bool dayOk = false;
            string manwom;//a play on wom man 
            string userInput;
            
            Console.WriteLine("input personal number");
            userInput =Console.ReadLine();
            int[] intArray = new int[userInput.Length];
            for (int i = 0; i < userInput.Length ; i++)
            {
                intArray[i] = int.Parse(userInput[i].ToString());
            }   
            numAmountOk = CorectNum(intArray);
            shotyearOk = shotyear(intArray);
            yearOk = year(intArray);
            monthOk = Month(intArray);
            dayOk = Days(intArray, shotyearOk);
            manwom = Gender(intArray);
            if(numAmountOk == true && yearOk  == true && monthOk == true && dayOk == true)
            {
                Console.WriteLine(" your personal number is correct");
                Console.WriteLine("your a {0}", manwom);
            }
            else { Console.WriteLine("something went wrong"); }
            Console.ReadKey();
        }


        static bool CorectNum(int[] intarray)
        {// cecks if there is corect amount off numbers
            if(intarray.Length == 12)
            {
               
                return true;
            }
            else
            {
                
                return false;
            }
        }
        static bool shotyear(int[] intarray)
        {// checks if its a skott år 
            int sum;
            sum = intarray[1] * 1000;
            sum = sum + intarray[2] * 100;
            sum = sum + intarray[3] * 10;
            sum = sum + intarray[4] * 1;

            if (sum< 2020 && sum> 1753)
            {
                if(sum % 400 == 0)
                {
                    return true;
                }
                else if( sum % 100 == 0)
                {
                    return false;
                }
               else if (sum % 4 == 0)
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }
            else
            {
                return false;
            }

        }
        static bool year(int[] intarray)
        {//cecks if the year is valid
            int sum;
            sum = intarray[0] * 1000;
            sum = sum + intarray[1] * 100;
            sum = sum + intarray[2] * 10;
            sum = sum + intarray[3] * 1;

            if (sum < 2020 && sum > 1753)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Month(int[] intarray)
        {//checks if the month is valid
            int sum;
            sum = intarray[4] * 10;
            sum = sum + intarray[5] * 1;

            if(0< sum && sum<13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Days(int[] intarray, bool shotyear)
        {//checs if the days are valid
            int daySum;
            int monthsum;
            monthsum = intarray[4] * 10;
            monthsum = monthsum + intarray[5] * 1;
            daySum = intarray[6] * 10;
            daySum = intarray[7] * 1;

            if (0 < monthsum && monthsum < 13)
            {
                switch (monthsum)
                {
                    case 1: if (0 < daySum && daySum < 32)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 2:

                        if (shotyear == true)// checks if it is shot year or not
                        {
                            if (0 < daySum && daySum < 30)
                            {
                                return true;
                            }
                            else { return false; }
                        }
                        else
                        {
                            if (0 < daySum && daySum < 29)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        break;
                    case 3:
                        if (0 < daySum && daySum < 32)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 4:
                        if (0 < daySum && daySum < 30)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 5:
                        if (0 < daySum && daySum < 31)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 6:
                        if (0 < daySum && daySum < 30)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 7:
                        if (0 < daySum && daySum < 31)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 8:
                        if (0 < daySum && daySum < 31)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 9:
                        if (0 < daySum && daySum < 30)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 10:
                        if (0 < daySum && daySum < 31)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 11:
                        if (0 < daySum && daySum < 30)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    case 12:
                        if (0 < daySum && daySum < 31)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    default:return false; break;
                }
            }
            else
            {
                return false;
            }
        }

        static string Gender(int[] intarray)
        {
            int sum;
            sum = intarray[8] * 100;
            sum = sum + intarray[9] * 10;
            sum = sum + intarray[10] * 1;

            if(sum % 2 == 0)
            {
                return "Female";
            }
            else
            {
                return "Man";
            }
        }
    }
}
