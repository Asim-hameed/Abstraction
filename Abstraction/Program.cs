namespace Abstraction
{
    abstract class person
    {
        // Abstract Methods that do not have body
        //public abstract void show();

        public string fName;
        public string lName;
        public int age;
        public string phoneNo;
        public string _MyProperty;
        public string MyProperty 
        {
            set 
            {
                this._MyProperty = value;
            } 
            get
            {
                return this._MyProperty;
            }
        }
        public abstract void printDetails();
    }
    class student :  person
    {
        public int rollNo;
        public int fees;
        
        public override void printDetails()
        {
            string name = this.fName + " " + this.lName;
            Console.WriteLine("Student Name is {0}",name);
            Console.WriteLine("Studnet age is {0}",this.age);
            Console.WriteLine("Studnet Phone No is {0}", this.phoneNo);
            Console.WriteLine("Studnet Roll No is {0}", this.rollNo);
            Console.WriteLine("Studnet Fees is {0}", this.fees);
            Console.WriteLine(this.MyProperty);
        }
    }
    class teacher : person
    {
        public string qualificationl;
        public int salary;

        public override void printDetails()
        {
            string name = this.fName + " " + this.lName;
            Console.WriteLine("Teacher Name is {0}", name);
            Console.WriteLine("Teacher age is {0}", this.age);
            Console.WriteLine("Teacher Phone No is {0}", this.phoneNo);
            Console.WriteLine("Teacher Qualification No is {0}", this.qualificationl);
            Console.WriteLine("Teacher Salary is {0}", this.salary);
            Console.WriteLine(this.MyProperty);
        }
    }


    // Show only necessary Details to outer world


    //class Employee
    //{
    //    public int EmpId;
    //    public string EmpName;
    //    public double GrossPay;
    //    double GrossTax = 0.1;
    //    double netSalary;


    //    public Employee(int id,string name,double gPay) 
    //    { 
    //        this.EmpId = id;
    //        this.EmpName = name;
    //        this.GrossPay = gPay;
    //    }
    //    void calculateSalary()
    //    {
    //        if (GrossPay >= 30000)
    //        {
    //            netSalary = GrossPay - (GrossTax * GrossPay);
    //            Console.WriteLine("Your Salary is {0}",netSalary);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Your Salary is {0}",GrossPay);
    //        }
    //    }
    //    public void showEmployeeDetails()
    //    {
    //        Console.WriteLine("Employee id is {0}",EmpId);
    //        Console.WriteLine("Employee id is {0}",EmpName);
    //        this.calculateSalary();

    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee=new Employee(365,"Asim",40000);
            //employee.showEmployeeDetails();

            Console.WriteLine("Hello, World!");


            student student = new student();
            student.fName = "Asim";
            student.lName = "Hameed";
            student.rollNo = 0365;
            student.phoneNo = "03335121353";
            student.fees = 155000;
            student.age = 25;
            student.MyProperty = "Property";

            student.printDetails();

            Console.WriteLine("----------------------");

            teacher teacher = new teacher();
            teacher.fName = "Asif";
            teacher.lName = "Ameer";
            teacher.phoneNo = "03001234567";
            teacher.age = 35;
            teacher.salary = 90000;
            teacher.qualificationl = "CS,PhD";
            teacher.MyProperty = "Property";

            teacher.printDetails();

        }
    }
}