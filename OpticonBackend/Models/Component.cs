using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace OpticonBackend.Models
{

    public abstract class Component
    {
        public int Id { get; set; } // Unique identifier
        public string Name { get; set; }
     //   public string Type { get; set; }
       // public string MeasurementUnit { get; set; }

      //  [JsonIgnore]
      //  public ComponentType ComponentType { get; set; } // Navigation property for the many-to-1 relationship
        /*public ICollection<Component> RelatedComponents { get; set; } // For the self-referencing relationship
        public ICollection<Component> ComponentsRelatedTo { get; set; } // Reverse side of the self-referencing relationship
        public ICollection<Component> EnergyFlows { get; set; }
        */

        public Component(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}