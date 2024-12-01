using System.ServiceModel;

namespace CsSoapApi.BusinessLogic
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
        [OperationContract]
        string Subtract(int num1, int num2);

        [OperationContract]
        string Multiply(int num1, int num2);

        [OperationContract]
        string Divide(int num1, int num2);
    }
    public class SoapService : ISoapService
    {
        public string Sum(int num1, int num2)
        {
            return $"Sum of {num1} plus {num2} is: {num1 + num2}";
        }
        public string Subtract(int num1, int num2)
        {
            return $"Difference of {num1} minus {num2} is: {num1 - num2}";
        }

        public string Multiply(int num1, int num2)
        {
            return $"Product of {num1} multiplied by {num2} is: {num1 * num2}";
        }

        public string Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                return "Error: Division by zero is not allowed.";
            }
            return $"Division of {num1} divided by {num2} is: {(float) num1 / num2}";
        }
    }
}
