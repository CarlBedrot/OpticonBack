using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OpticonBackend.Models
{
    public class Picture
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public string Grid { get; set; }

        [JsonIgnore]
        public List<PictureAccess> PictureAccesses { get; set; }

        public Picture()
        {
            Random random = new Random();
            Id = random.Next(1000000, 9999999);
            Grid = "blank";
            PictureAccesses = new List<PictureAccess>();
        }

    }

}
