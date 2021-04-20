using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFRestEmployeeDetails
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestEmployeeDetails" in both code and config file together.
    public class RestEmployeeDetails : IRestEmployeeDetails
    {
        public int AddEmployee(Employees employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public bool EditEmployee(Employees employee)
        {
            throw new NotImplementedException();
        }

        public Employees EmployeeDetails(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
