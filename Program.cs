namespace AssignmentD07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Employee[] EmpArr = new Employee[3]
            {
                new Employee{Id=1,Name="Ali",Gender=Gender.M,Hd = new HireDate() , Salary=5000, Securitylevel = SecurityLevel.DBA},
                new Employee{Id=1,Name="Ali",Gender=Gender.M,Hd = new HireDate() , Salary=5000, Securitylevel = SecurityLevel.guest},
                new Employee{Id=1,Name="Ali",Gender=Gender.M,Hd = new HireDate() , Salary=5000, Securitylevel = SecurityLevel.securityOfficer},
            };

            Employee e1 = new Employee();
            e1.ReedEmployee();


            Array.Sort(EmpArr);

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine(EmpArr[i]);
            }
        }
    }
}
