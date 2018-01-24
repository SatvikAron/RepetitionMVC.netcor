using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepetitionclassWebApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MinLength(3, ErrorMessage = "Name cannot be less than 3")]
        public string Name { get; set; }
        [Range(0, 1000000,
       ErrorMessage = "UnitPrice should be less than or equal to 1000000")]
        public int UnitPrice { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
