using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace OpticonBackend.Models
{
    public class PictureAccess
    {
        public int PictureId { get; set; }

        [Key]
        public string UserId { get; set; }

        public List<Picture>? Pictures { get; set; } = new List<Picture>(); // Collection navigation containing dependents

        public PictureAccess(string userId)
        {
            UserId = userId;

        }
    }
}