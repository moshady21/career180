using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentD07
{
    /*
     3.	Employee is identified by an ID,name, security level, salary, hire date and Gender.
     4.	Develop a Structure to represent the HiringDate Data Type consisting of fields to hold the day, month and Years.

     */
    internal class Employee
    {
        int id;
        string name;
        SecurityLevel securitylevel ;
        decimal salary;
        HireDate hd;
        Gender gender;

        public int Id { get; set; }
        public string Name { get; set; }
        public SecurityLevel Securitylevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate Hd { get; set; }
        public Gender Gender { get; set; }
      

        public Employee()
        {
            Id = 1;
            Name = "";
            securitylevel = SecurityLevel.secretary;
            Salary = 1;
            hd = default;
            gender = Gender.M;
        }

        public Employee(int _id, string _name, int _age, decimal _salary, Gender _gen,  HireDate _hd)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
            gender = _gen;
            hd = _hd;
        }

        public Employee ReedEmployee()
        {
            #region One Employee

            Employee e1 = new Employee();
            e1.hd = new HireDate();
            
          
            e1.hd = new HireDate();
            
            Console.WriteLine("enter id");
            e1.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter name");
            e1.Name = Console.ReadLine();

            

            Console.WriteLine("enter salary");
            e1.Salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter gender");
            e1.gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());

            Console.WriteLine("enter hire year");
            e1.hd.Year = int.Parse(Console.ReadLine());

            Console.WriteLine("enter hire month");
            e1.hd.Month = int.Parse(Console.ReadLine());

            Console.WriteLine("enter hire day");
            e1.hd.Day = int.Parse(Console.ReadLine());



            return e1;
            #endregion

        }

        public override string ToString()
        {
            return $"{Id}:{Name}: {Salary.ToString("C")}:{gender}:{hd?.ToString()}";
        }

        public int CompareTo(object obj)
        {
            Employee right = (Employee)obj;
            return this.hd.CompareTo(right.hd);

        }
    }
}
