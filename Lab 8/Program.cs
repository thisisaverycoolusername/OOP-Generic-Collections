namespace Lab_8
{
    internal class Program
    {

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public decimal Salary { get; set; }
        }
        static void Main(string[] args)
        {
      
            Employee employee1 = new Employee { Id = 1, Name = "John", Gender = "Male", Salary = 50000 };
            Employee employee2 = new Employee { Id = 2, Name = "Jane", Gender = "Female", Salary = 60000 };
            Employee employee3 = new Employee { Id = 3, Name = "Bob", Gender = "Male", Salary = 55000 };
            Employee employee4 = new Employee { Id = 4, Name = "Alice", Gender = "Female", Salary = 70000 };
            Employee employee5 = new Employee { Id = 5, Name = "Charlie", Gender = "Male", Salary = 80000 };


            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("Printing all objects in the stack:");
            foreach (var employee in employeeStack)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
                Console.WriteLine($"Items left on the stack: {employeeStack.Count}");
            }

            Console.WriteLine("\nGetting all objects using the Pop method:");
            while (employeeStack.Count > 0)
            {
                Employee poppedEmployee = employeeStack.Pop();
                Console.WriteLine($"Id: {poppedEmployee.Id}, Name: {poppedEmployee.Name}, Gender: {poppedEmployee.Gender}, Salary: {poppedEmployee.Salary}");
                Console.WriteLine($"Items left on the stack: {employeeStack.Count}");
            }

  
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

 
            Console.WriteLine("\nRetrieving two objects using the Peek method:");
            for (int i = 0; i < 2; i++)
            {
                Employee peekedEmployee = employeeStack.Peek();
                Console.WriteLine($"Id: {peekedEmployee.Id}, Name: {peekedEmployee.Name}, Gender: {peekedEmployee.Gender}, Salary: {peekedEmployee.Salary}");
                Console.WriteLine($"Items left on the stack: {employeeStack.Count}");
                employeeStack.Pop(); 
            }

       
            Employee searchEmployee = new Employee { Id = 3, Name = "Bob", Gender = "Male", Salary = 55000 };
            bool isEmployeeInStack = employeeStack.Contains(searchEmployee);
            Console.WriteLine($"\nIs item number 3 in the stack? {isEmployeeInStack}");
            Console.WriteLine("");

            List<Employee> employeeList = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Gender = "Male", Salary = 500000 },
            new Employee { Id = 2, Name = "Jane", Gender = "Female", Salary = 600000 },
            new Employee { Id = 3, Name = "Bob", Gender = "Male", Salary = 550000 },
            new Employee { Id = 4, Name = "Alice", Gender = "Female", Salary = 700000 },
            new Employee { Id = 5, Name = "Charlie", Gender = "Male", Salary = 450000 }
        };

          
            Employee employeeToCheck = new Employee { Id = 2, Name = "Jane", Gender = "Female", Salary = 600000 };
            if (employeeList.Contains(employeeToCheck))
            {
                Console.WriteLine("Employee2 object exists in the list");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
                Console.WriteLine("");
            }

            Employee firstMaleEmployee = employeeList.Find(e => e.Gender == "Male");
            Console.WriteLine($"First Male Employee: Id: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary}");
            Console.WriteLine("");
         
            List<Employee> maleEmployees = employeeList.FindAll(e => e.Gender == "Male");
            Console.WriteLine("All Male Employees:");
            foreach (var maleEmployee in maleEmployees)
            {
                Console.WriteLine($"Id: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");
            }
        }
    }
}