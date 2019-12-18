using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Linq;


using System.ComponentModel.DataAnnotations;

namespace FoodLog.Models
{
    public class Posts
    {
        [Key]
        public int postID { get; set; }

        [Required]
        public DateTime posted { get; set; }

        [Required]
        //[StringLength(maximumLength: 120, MinimumLength = 2, ErrorMessage = "* Please Enter a Ingredient. 2 - 40 Letters")]
        public string notes { get; set; }
    }
}
