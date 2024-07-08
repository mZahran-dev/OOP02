using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    #region 4.Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }

    #endregion

    #region 3.We need to restrict the Gender field to be only M or F [Male or Female] 
    public enum Gender
    {
        m, //male
        f  //female
    }
    #endregion


    #region 1.Design and implement a Class for the employees in a company:
    public class Employee
    {
        #region Attributes
        private int id;
        private string name;
        private SecurityPrivilege securityLevel;
        private decimal salary;
        private HireDate hireDate;
        private Gender gender;
        #endregion

        #region Constructor
        public Employee(int _id, string _name, SecurityPrivilege _securityLevel, decimal _salary, HireDate _hireDate, Gender _gender)
        {
            id = _id;
            name = _name;
            securityLevel = _securityLevel;
            salary = _salary;
            hireDate = _hireDate;
            gender = _gender;
        }
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set
            {
                if (id < 0) throw new ArgumentException("id can''t be negative");
                id = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (salary < 0) throw new ArgumentException("Salary cannot be negative");
                salary = value;
            }
        }

        public SecurityPrivilege SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public HireDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        #endregion

        #region 5.We want to provide the Employee Class to represent Employee data in a string Form(override ToString()), display employee salary in a currency format. [use String.Format Function]
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Security Level: {securityLevel}, Salary: {salary:C}, Hire Date: {hireDate}, Gender: {gender}";
        }
        #endregion

    }

    #endregion

}
