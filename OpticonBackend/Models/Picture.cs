using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OpticonBackend.Models
{
    public class Picture
    {

        public string Name { get; set; }
        public string Id { get; set; }
        public string Grid { get; set; }

        [JsonIgnore]
        public List<PictureAccess> PictureAccesses { get; set; }

        public Picture() 
        {
            PictureAccesses = new List<PictureAccess>();
        }

        // EF Core will not use this constructor but it's here if needed for your application logic
        public Picture(string name, string grid)
        {
            Name = name;
            Grid = grid;
        }

    }

}
