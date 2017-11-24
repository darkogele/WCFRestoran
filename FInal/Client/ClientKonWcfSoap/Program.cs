using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientKonWcfSoap.ServiceReference1;

namespace ClientKonWcfSoap
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeServiceClient client = new EmployeeServiceClient();
            var employee = client.getAllEmployees();
            foreach (var e  in employee)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(e.Address);
            }
            Console.ReadLine();
        }
    }
}
