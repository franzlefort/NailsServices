using System.ComponentModel.DataAnnotations;

namespace AdministrationService.Database.Entities
{
    public sealed class Post : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}