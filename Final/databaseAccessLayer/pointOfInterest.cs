using System;
using System.ComponentModel.DataAnnotations;


namespace databaseAccessLayer
{
    public class pointOfInterest
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
