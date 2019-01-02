using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
   public class Employee
    {
        string employeeName;
        string password;
        string bloodGroup;
        string gender;

        Data_Access dataAccess = new Data_Access ();

        public string EmployeeName
        {
            set { this.employeeName = value; }
            get { return this.employeeName; }
        }

        public string Password
        {
            set { this.password = value; }
            get { return this.password; }
        }

        public string Blood_Group
        {
            set { this.bloodGroup = value; }
            get { return this.bloodGroup; }
        }

        public string Gender
        {
            set { this.gender = value; }
            get { return this.gender; }
        }

        public List<object> GetEmployeeList( )
        {
            List<object> getEmployeeList = dataAccess.GetEmployeeList ();

            return getEmployeeList.ToList ();
        }

        public object GetEmployee( string n )
        {
            object p = dataAccess.GetEmployee (n);

            return p;
        }

        public void AddEmployee( string name, string password, string bloodGroup, string gender )
        {
            dataAccess.AddEmployee (name,password,bloodGroup,gender);
        }


        public void UpdateEmployee( int i, string name, string password, string bloodGroup, string gender )
        {
            dataAccess.UpdateEmployee(i,name,password,bloodGroup,gender);
        }
        public void DeleteEmployee( int i )
        {
            dataAccess.DeleteEmployee (i);
        }
    }
}
