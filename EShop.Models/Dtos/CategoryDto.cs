using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Models.Dtos
{
    public class CategoryDto
    {
        public int id { get; set; }       
        public string name { get; set; }      
        public string iconcss { get; set; }
    }
}
