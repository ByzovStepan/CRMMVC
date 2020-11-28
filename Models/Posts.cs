using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMMVC.Models
{
    public class Posts
    {
        public int Id { get; set; }

        [Required] [Display(Name = "Наименование должности")] public string name { get; set; }
    }
}
