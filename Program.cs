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
            bool shotyearOk = false;
            bool yearOk = false;
            bool monthOk = false;
            bool dayOk = false;
            string userInput = "200008144131";
            int[] intArray = new int[12];
            Console.WriteLine("input personal number");
            for (int i = 0; i < userInput.Length; i++)
            {
                
                intArray[i] = Console.Read();
            }
            numAmountOk = CorectNum(intArray);
            shotyearOk = shotyear(intArray);
            yearOk = year(intArray);
            monthOk = Month(intArray);
            dayOk = Days(intArray, shotyearOk);

            if(numAmountOk == true && yearOk  == true && monthOk == true && dayOk == true)
            {
                Console.WriteLine(" your personal number is correct");
            }
            else { Console.WriteLine("something went wrong"); }
            Console.ReadKey();
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
        static bool shotyear(int[] intarray)
        {
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
                else { return false; 
                }
            }
            else
            {
                return false;
            }

        }
        static bool year(int[] intarray)
        {
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
        {
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
        {
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

                        if (shotyear == true)
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


    }
}
