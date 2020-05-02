using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdministrationService.Database.Entities
{
    public sealed class Branch : BaseEntity
    {
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public DateTime OpeningDate { get; set; }
        
        public DateTime ClosingDate { get; set; }
        
        [ForeignKey("ManagerId")]
        public Employee Employee { get; set; }
        public Guid ManagerId { get; set; }
    }
}