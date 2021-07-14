using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalculatorService1.svc or CalculatorService1.svc.cs at the Solution Explorer and start debugging.
    public class CalculatorService1 : ICalculatorService1
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
}
