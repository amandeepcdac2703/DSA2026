using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Core.DesignPatterns.CreationDP.PrototypeDP
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Id : {this.Id}, Name: {this.Name}, Email: {this.Email}");
        }

        public Employee Cline()
        {
            //return (Employee)this.MemberwiseClone();
            return new Employee()
            {
                Id = this.Id,
                Name = this.Name,
                Email = this.Email,
            };
        }
    }
}
