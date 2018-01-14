using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string jobTitle { get; set; }
        public DateTime startDate { get; set; }
    }

    public class Company
    {
        private string name { get; set; }
        private DateTime createdOn { get; set; }
        // Create a property for holding a list of current employees
        private List<Employee> employees = new List<Employee>();


        // Some readonly properties
        public string Name { 
            get
            {
                return name;
            }
        }
        public DateTime CreatedOn { 
            get
            {
                return createdOn;
            }
        }
        public List<Employee> Employees {
            get
            {
                return employees;
            }
        }
        
        // Create a method that allows external code to add an employee
        public void AddEmployee (Employee employeeInfo) {
            employees.Add(employeeInfo);
        }
        
        // Create a method that allows external code to remove an employee
        public void RemoveEmployee (Employee employeeInfo) {
            employees.Remove(employeeInfo);
        }

        // constructor method that accepts two arguments: the name of the company & the date it was created
        public void CreateCompany (string companyName, DateTime dateCreated) {
            // The constructor will set the value of the public properties
            name = companyName;
            createdOn = dateCreated;
        }

        // write the name of each employee to the console
        public void ListEmployees () {
            employees.ForEach(e =>
                Console.WriteLine($@"Employee: {e.firstName} {e.lastName}
                Positon: {e.jobTitle}
                Start Date: {e.startDate}")
            );
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 5");

            // create a company
            Company FiendsForJustice = new Company();


            //create three employees
            Employee matt = new Employee();
            matt.firstName = "Matt";
            matt.lastName = "LaBorde";
            matt.jobTitle = "Founder";
            matt.startDate = new DateTime(2015, 10, 28);

            Employee veronica = new Employee();
            veronica.firstName = "Veronica";
            veronica.lastName = "Dress";
            veronica.jobTitle = "Educator";
            veronica.startDate = new DateTime(2012, 08, 05);

            Employee adam = new Employee();
            adam.firstName = "Adam";
            adam.lastName = "Strizich";
            adam.jobTitle = "Community Organizer";
            adam.startDate = new DateTime(2014, 09, 10);

            // add employees to the company
            FiendsForJustice.AddEmployee(matt);
            FiendsForJustice.AddEmployee(veronica);
            FiendsForJustice.AddEmployee(adam);
            
            // list employees in console
            FiendsForJustice.ListEmployees();

        }
    }
    
}
