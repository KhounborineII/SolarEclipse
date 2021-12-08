using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SolarEclipse.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public string TextBody { get; set; }
        [Required]
        public DateTime PostTime { get; set; }

    }
}
