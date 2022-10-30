
// 6) Create methods for all access modifier in encaptulation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation
{
    internal class Program // Default Access Modifier is internal
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name();

            try
            {
                //employee.Salary();
            }
            catch
            {
                Console.WriteLine("You cannot access a private method.");
            }
            
            
            Administrator administrator = new Administrator();
            administrator.Name();
            administrator.Designation();
            administrator.CurrentProject();

            Console.ReadKey();            
        }
    }

    class Employee
    {
        public void Name()
        {
            Console.WriteLine("Hi folks! Aryan Gupta here...");
        }

        protected internal void CurrentProject()
        {
            Console.WriteLine("No project allocated yet.");
        }

        internal void Designation()
        {
            Console.WriteLine("I'm a Trainee Engineer @Advanced.");
        }

        private void Salary()
        {
            Console.WriteLine("This is a private field.");
        }
    }

    class Administrator : Employee
    {
        Employee employee = new Employee();
        
        public void Display()
        {
            employee.Designation();
            employee.CurrentProject();
        }                
    }
}
