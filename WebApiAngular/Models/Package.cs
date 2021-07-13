using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAngular.Models
{
    public class Package
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Package Name")]
        [MinLength(6, ErrorMessage = "Must have more than 6 characters")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [MinLength(6, ErrorMessage = "Must have more than 6 characters")]
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        [Required(AllowEmptyStrings = false)]
        public bool InStock { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateReceived { get; set; }
    }
}
