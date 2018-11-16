using System.ComponentModel.DataAnnotations;
using System;

namespace PresentationLayer.Models
{
    public class CreateProductModel
    {
        [Required]
        public Guid Id { get; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
    }
}