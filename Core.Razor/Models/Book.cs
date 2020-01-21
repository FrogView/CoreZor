using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Razor.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Required,StringLength(30,MinimumLength =2)]
        public String Name { get; set; }

        [Required,DataType(DataType.Date)]
        public DateTime PublishTime { get; set; }
        [Required,StringLength(30,MinimumLength =2)]
        public string Author { get; set; }
    }
}
