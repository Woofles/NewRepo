using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Employee Data
//
namespace Exc_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string employee_nameFirst = "Amanda";
            string employee_nameLast = "Jonson";
            int employee_age = 27;
            char employee_gender = 'f';
            long employee_ID = 8306112507;
            int employee_UEN = 27563571;
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}",employee_nameFirst,employee_nameLast,employee_age,employee_gender,employee_ID,employee_UEN);
        }
    }
}
