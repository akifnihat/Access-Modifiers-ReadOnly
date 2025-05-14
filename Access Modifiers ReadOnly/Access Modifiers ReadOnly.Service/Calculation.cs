
namespace Access_Modifiers_ReadOnly.Service
{
    public class Calculation
    {
        public double  Calc (double num1,double num2,char op)
        {
            double result = 0;
            switch (op)
            {

                case '+': result = num1+num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("0-a bolme yoxdur.");
                    }
                    result = num1 / num2;
                    break;
                      default:
                    break;
            }
            return result;
        }
       
    }
}
