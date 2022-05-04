using System;

namespace Question2
{ 
    public class Program

    {
        static void Main()
        {
            var allemployees = Employee.GetEmployees();

            //Question 3
            var lastD = allemployees.Select(x => x.LastName)
                                    .Where(x => x.StartsWith("D"));
            Console.WriteLine($"Letter D as first letter :");
            foreach (var item in lastD)
            {
                Console.WriteLine(item);
            }

            //Question 4 
            Console.WriteLine($"First Person Older Than 40 In Descending Alphabetical Order By First Name:");
            var age40 = allemployees.Where(x => x.Age > 40)
                                    .OrderByDescending(x => x.FirstName.First());
                                    
            foreach(var item in age40)
            {
                Console.WriteLine($"FirstName:{item.FirstName}   Age: {item.Age}" );
            }



        }
    }
    public  class Employee
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
         public string LastName { get; set; }
        
       


        public static List<Employee> GetEmployees()
       
        {
            return new List<Employee>
            {
                  
       
                new Employee() { FirstName ="Jude", LastName = "Smith", Age = 41},
                new Employee() { FirstName ="Sarah", LastName = "Jones", Age = 22},
                new Employee() { FirstName ="Stacy", LastName = "Baker", Age = 21},
                new Employee() { FirstName ="Samuel", LastName = "Dexter", Age = 17},
                new Employee() { FirstName ="Richy", LastName = "Smith", Age = 49},
                new Employee() { FirstName ="Brett", LastName = "Joy", Age = 51},
                new Employee() { FirstName ="Mark", LastName = "Parker", Age = 116},
                new Employee() { FirstName ="Alice", LastName = "Thompson", Age = 18},
                new Employee() { FirstName ="Evelyn", LastName = "Winsome", Age = 58},
                new Employee() { FirstName ="Mort", LastName = "Martin", Age = 58},
                new Employee() { FirstName ="Eugene", LastName = "deLauter", Age = 84},
                new Employee() { FirstName ="Gail", LastName = "Dude", Age = 34}
            };
          
        }
        
    }

       
}   

