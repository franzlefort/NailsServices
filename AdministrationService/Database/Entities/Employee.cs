using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace AdministrationService.Database.Entities
{
    public sealed class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string PatronymicName { get; set; }
        
        public DateTime EmploymentDate { get; set; }
        
        public DateTime DismissalDate { get; set; }
        
        public decimal Salary { get; set; }
        
        public decimal PercentageOfCost { get; set; }
        
        [ForeignKey("BranchId")]
        public Branch Branch { get; set; }
        public Guid BranchId { get; set; }
        
        [ForeignKey("PostId")]
        public Post Post { get; set; }
        public Guid PostId { get; set; }
        
        public string Login { get; set; }
        
        public string Password { get; set; }
        
        public string Phone { get; set; }
    }
}