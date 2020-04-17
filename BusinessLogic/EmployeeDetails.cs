using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class EmployeeDetails
    {

        private string firstName;
        private string lastName;
        private int empID;
        private DateTimeOffset dateOfJoining;
        private string jobDescription;
        private string department;
        private double monthlySalary;
        public string FirstName
        {
            get 
            {
                return firstName;
            }
            set 
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }        

        public EmployeeDetails(string _FirstName, string _LastName)
        {
            FirstName = _FirstName;
            LastName = _LastName;
        }
        public string EmpFullName()
        {
            return firstName + " " + lastName;
        }
        public string EmpFullNameSort()
        {
            return lastName + ", " + firstName;
        }
    }
}
