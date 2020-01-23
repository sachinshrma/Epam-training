using System;

namespace CommentsExample
{
    /// <summary>
    /// Employee class for employee creation and utility methods
    /// </summary>
    class  Employee
    {
        private int id;
        private string name;
        private string address;
        /// <summary>
        /// Employee Object for the Creating a new Employee
        /// </summary>
        /// <example>
        /// Create the object of Employee as follows
        /// <code>
        /// Employee employeeObj = new Employee(123, "empName", "empAddress");
        /// </code>
        /// </example>
        /// <exception cref="ArgumentNullException">if any param is null</exception>
        
        /// <param name="id">Unique for every Employee</param>
        /// <param name="name">Name of the Employee</param>
        /// <param name="address">Address of the Employee</param>
        public Employee(int id, string name, string address)
        {
            this.id = id;
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.address = address ?? throw new ArgumentNullException(nameof(address));
        }

        /// <summary>
        /// To Get the Employee Name
        /// </summary>
        /// <returns>return Employee's name</returns>
        public String getEmployeeName(){
            return this.name;
        }
        /// <summary>
        /// To Get employee Address
        /// </summary>
        /// 
        /// <returns> return Employee's address</returns>
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
	    //New employee creation
            Employee employee = new Employee(560238, "Sachin", "Punjab");

	    //prints address of the employee
            Console.WriteLine(objEmployee.getEmployeeAddress()); 

	    //prints name of the employee
            Console.WriteLine(objEmployee.getEmployeeName()); 

            Console.ReadLine();
        }
    }
}