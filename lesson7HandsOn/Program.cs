using System;

namespace lesson7HandsOn
{
    public class Employee {
        string name;
        int salary;
        string hireDate;


        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public int Salary {
            get {
                return salary;
            }
            set {
                salary = value;
            }
        }

        public string HireDate {
            get {
                return hireDate;
            }
            set {
                hireDate = value;
            }
        }

        public Employee() {
            name = "";
            salary = 0;
            hireDate = "";
        }

        public Employee(string name, int salary, string hireDate) {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }

        public virtual void getName() {
            Console.WriteLine("Name: " + name);
        }
        public virtual void getSalary() {
            Console.WriteLine("Salary: " + salary);
        }
        public virtual void hiredDate() {
            Console.WriteLine("Hired: " + hireDate);
        }
    }


    public class Engineer: Employee
    {
        string schoolAttended;

        public string SchoolAttended {
            get {
                return schoolAttended;
            }
            set {
                schoolAttended = value;
            }
        }

        public Engineer() {
            schoolAttended = "";
        }

        public Engineer(string name, int salary, string hireDate, string schoolAttended) : base(name, salary, hireDate){
                this.schoolAttended = schoolAttended;
            }
    }

    public class SoftwareEngineer: Engineer
    {
        public SoftwareEngineer() {

        }
        public override void getSalary() {
        
            Console.WriteLine("Salary: Sorry, this employee's salary is private.");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Engineer bob = new Engineer("bob", 42000, "11/22/15", "BSU");

            SoftwareEngineer bryan = new SoftwareEngineer();

            bob.getName();
            bob.getSalary();
            bob.hiredDate();

            bryan.Name = "Bryan";
            bryan.HireDate = "03/05/19";

            Console.WriteLine("-------------------------");

            bryan.getName();
            bryan.getSalary();
            bryan.hiredDate();
        }
    }
}
