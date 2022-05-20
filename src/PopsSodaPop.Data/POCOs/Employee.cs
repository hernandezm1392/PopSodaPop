using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Employee
{
    public Employee(){}
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
