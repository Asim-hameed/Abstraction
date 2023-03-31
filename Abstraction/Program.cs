namespace Abstraction
{
    // Show only necessary Details to outer world


    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double GrossTax = 0.1;
        double netSalary;


        public Employee(int id,string name,double gPay) 
        { 
            this.EmpId = id;
            this.EmpName = name;
            this.GrossPay = gPay;
        }
        void calculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (GrossTax * GrossPay);
                Console.WriteLine("Your Salary is {0}",netSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is {0}",GrossPay);
            }
        }
        public void showEmployeeDetails()
        {
            Console.WriteLine("Employee id is {0}",EmpId);
            Console.WriteLine("Employee id is {0}",EmpName);
            this.calculateSalary();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee(365,"Asim",40000);
            employee.showEmployeeDetails();
            Console.WriteLine("Hello, World!");
        }
    }
}