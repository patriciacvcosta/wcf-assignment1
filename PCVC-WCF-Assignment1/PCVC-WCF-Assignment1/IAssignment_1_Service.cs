using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PCVC_WCF_Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAssignment_1_Service
    {
        [OperationContract]
        bool CheckPrimeNumber(int input);

        [OperationContract]
        int SumDigits(int input);

        [OperationContract]
        string ReverseString(string input);

        [OperationContract]
        string PrintHtmlTags(string tag, string input);

        [OperationContract]
        string SortNumbers(string sortingType, int[] numbers);

    }

}
