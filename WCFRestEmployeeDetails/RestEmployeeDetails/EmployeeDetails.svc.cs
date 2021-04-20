using RestEmployeeDetails;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.ModelBinding;

namespace RestEmployeeDetails
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeDetails
    {

        public int AddEmployee(Employees employee)
        {
            try
            {
                EmployeeEntities db = new EmployeeEntities();
                db.tblEmployees.Add(employee);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new System.ServiceModel.Web.WebFaultException<string>(ex.ToString(), System.Net.HttpStatusCode.BadRequest);
            }
            return employee.Id;
        }


        public Employees EmployeeDetails(string id)
        {
            Int32 _id = Convert.ToInt32(id);
            EmployeeEntities db = new EmployeeEntities();
            return db.tblEmployees.SingleOrDefault(p => p.Id == _id);

        }

        //Get All Employees

        public List<Employees> GetEmployees()
        {
            EmployeeEntities db = new EmployeeEntities();
            return db.tblEmployees.ToList();
        }

        public bool EditEmployee(Employees employee)
        {
            EmployeeEntities db = new EmployeeEntities();
            Employees updateEmployee = db.tblEmployees.SingleOrDefault(p => p.Id == employee.Id);
            updateEmployee.FullName = employee.FullName;
            updateEmployee.Gender = employee.Gender;
            updateEmployee.EmailAddress = employee.EmailAddress;
            updateEmployee.Age = employee.Age;
            updateEmployee.AlternateText = employee.AlternateText;
            updateEmployee.PersonalWebsite = employee.PersonalWebsite;
            updateEmployee.Photo = employee.Photo;
            updateEmployee.Salary = employee.Salary;
            db.SaveChanges();
            return true;
        }

        public void DeleteEmployee(string id)
        {
            Int32 _id = Convert.ToInt32(id);
            EmployeeEntities db = new EmployeeEntities();
            Employees DeleteEmployee = db.tblEmployees.SingleOrDefault(p => p.Id == _id);
            db.tblEmployees.Remove(DeleteEmployee);
            db.SaveChanges();
        }

        public void DeleteMultipleEmployee(List<string> multipleEmployeeId)
        {
            foreach(string id in multipleEmployeeId)
            {
                Int32 _id = Convert.ToInt32(id);
                EmployeeEntities db = new EmployeeEntities();
                Employees DeleteEmployee = db.tblEmployees.SingleOrDefault(p => p.Id == _id);
                db.tblEmployees.Remove(DeleteEmployee);
                db.SaveChanges();
            }
        
        }

    }
}
