using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceFirst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCalculator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCalculator.svc or ServiceCalculator.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCalculator : IServiceCalculator
    {
        public double AddNumbers(double number1, double number2)
        {
            return number1 + number2;
        }

        public double DivisionNumber(double number1, double number2)
        {
            //throw new NotImplementedException();

            return number1 / number2;
        }

        public void DoWork()
        {

        }

        public double MultiplyNumbers(double number1, double number2)
        {
            return number1 * number2;
        }

        public double SubstractNumbers(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}


//-- reference link
//http://www.c-sharpcorner.com/UploadFile/dhananjaycoder/four-steps-to-create-first-wcf-service-for-beginners/