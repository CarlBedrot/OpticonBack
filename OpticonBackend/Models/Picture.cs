using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpticonBackend.Models
{
    public class Picture
    {

        public string Name { get; set; }
        public string Id { get; set; }
        public string Grid { get; set; }
        public List<PictureAccess> PictureAccesses { get; set; }

        // Parameterless constructor for EF Core
        public Picture() { }

        // EF Core will not use this constructor but it's here if needed for your application logic
        public Picture(string name, string grid)
        {
            Name = name;
            Grid = grid;
        }
    }

}