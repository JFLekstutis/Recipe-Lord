using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipe_Lord
{
    public class Recipe
    {
        [Key]
        public int Recipe_Id { get; set; }
        public string Source_Url { get; set; }
        public string Image_Url { get; set; }
        public string Title { get; set; }
    }
}
