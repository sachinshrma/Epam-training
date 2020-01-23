using System;

namespace CommentsExample
{
    class  Employees
    {
        int id;
        string name;
        string address;
        /// <summary>
        /// Employee Object for the Creating a new Employee
        /// </summary>
        /// <example>
        /// It shows how to create the object of Employee
        /// <code>
        /// Employee objEmployee = new Employee(1, "test", "fdssdf");
        /// </code>
        /// </example>
        /// <exception cref="ArgumentNullException">if name or address is null</exception>
        
        /// <param name="id">Must be Unique for each Employee</param>
        /// <param name="name">Name of the Employee</param>
        /// <param name="address">Address of the Employee</param>
        public Employees(int id, string name, string address)
        {
            this.id = id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
        }

        /// <summary>
        /// To Get the Employee Name
        /// </summary>
        /// <returns>return the name of the Employee</returns>
        public String getEmployeeName(){
            return this.name;
        }
        /// <summary>
        /// To Get employee Address
        /// </summary>
        /// 
        /// <returns> return the Employee's Address</returns>
        public String getEmployeeAddress()
        {
            return this.address;
        }
    }
    class Program
    {
        /// <summary>
        /// Main Function
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Employees objEmployee = new Employees(1, "Jitender", "India");
            Console.WriteLine(objEmployee.getEmployeeAddress()); //to print the address of the employee
            Console.WriteLine(objEmployee.getEmployeeName()); //to print the name of the employee
            Console.ReadLine(); //wait for the key press event
        }
    }
}
