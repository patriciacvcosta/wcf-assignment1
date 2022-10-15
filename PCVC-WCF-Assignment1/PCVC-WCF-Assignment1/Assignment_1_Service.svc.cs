using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PCVC_WCF_Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Assignment_1_Service : IAssignment_1_Service
    {
        public bool CheckPrimeNumber(int input) 
        {
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int SumDigits(int input)
        {
            string stringInput = input.ToString();
            int result = stringInput.Sum(c => Convert.ToInt32("" + c));

            return result;
        }

        public string ReverseString(string input)
        {
            char[] result = input.Reverse().ToArray();

            return new string(result);
        }

        public string PrintHtmlTags(string tag, string input)
        {
            string endTag = tag.Insert(1, "/");

            return tag+input+endTag;
        }

        public string SortNumbers(string sortingType, int[] numbers)
        {
            if (sortingType.ToUpper() == "A")
            {
                Array.Sort(numbers);
                return string.Join(",", numbers);
            }
            else
            {
                numbers = numbers.OrderByDescending(x => x).ToArray();
                return string.Join(",", numbers);
            }
        }

    }
}
