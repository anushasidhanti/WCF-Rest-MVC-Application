using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRestEmployeeDetails
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRestEmployeeDetails" in both code and config file together.
    [ServiceContract]
    public interface IRestEmployeeDetails
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<Employees> GetEmployees();


        [OperationContract]
        [WebGet(UriTemplate = "EmployeeDetails/{id}", ResponseFormat = WebMessageFormat.Json)]
        Employees EmployeeDetails(string id);


        //UpdateEmployee
        [OperationContract]
        [WebInvoke(Method = "PUT",
        UriTemplate = "/EditEmployee", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool EditEmployee(Employees employee);

        //Delete Employee
        [OperationContract]
        [WebInvoke(Method = "DELETE", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/DeleteEmployee/{id}")]
        void DeleteEmployee(string id);



        [OperationContract]
        [WebInvoke(UriTemplate = "CreateEmployee", Method = "POST")]
        int AddEmployee(Employees employee);
    }
}
