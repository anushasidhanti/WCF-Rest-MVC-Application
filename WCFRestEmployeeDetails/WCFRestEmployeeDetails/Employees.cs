//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFRestEmployeeDetails
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tblEmployees")]
    public partial class Employees
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> Salary { get; set; }
        public string PersonalWebsite { get; set; }
        public string Photo { get; set; }
        public string AlternateText { get; set; }
    }
}
