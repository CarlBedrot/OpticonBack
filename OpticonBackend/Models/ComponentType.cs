using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // This namespace includes KeyAttribute
namespace OpticonBackend.Models
{
    public class ComponentType
    {
        [Key]
        public string Name { get; set; } // Assuming Name is the unique identifier
        public string Image { get; set; }
        public string BasedOn { get; set; }
        public ICollection<Component> Components { get; set; } // Navigation property for the 1-to-many relationship

        public ComponentType()
        {
            Components = new List<Component>();
        }
    }
}