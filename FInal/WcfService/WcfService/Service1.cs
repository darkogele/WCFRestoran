using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Digitron : IDigitron
    {
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }



        public double Deli(int value1, int value2)
        {
           return value1 / value2;
        }

        public double Minus(int value1, int value2)
        {
            return value1 - value2;
        }

        public double Mnozi(int value1, int value2)
        {
            return value1 * value2;
        }

        public double Plus(int value1, int value2)
        {
            return value1 + value2;
        }

        public string OpaCupa()
        {
            return ("GLEDAS OD WEB API KON WCF WOOOT!! ");
        }
        
    }
}
