using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenHaiDang_2011064530.Models
{
    public class Category
    {
        public byte Id { get; set; } 
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}