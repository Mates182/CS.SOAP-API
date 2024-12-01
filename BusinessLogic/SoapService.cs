using System.ServiceModel;

namespace CsSoapApi.BusinessLogic
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
    }
    public class SoapService : ISoapService
    {
        public string Sum(int num1, int num2)
        {
            return $"Sum of {num1} plus {num2} is: {num1 + num2}";
        }
    }
}
