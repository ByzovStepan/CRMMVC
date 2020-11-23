using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMMVC.Models
{
    public class Clients
    {
        public int Id { get; set; }


        [Required] [Display(Name = "Имя")]              public string first_name { get; set; }
        [Required] [Display(Name = "Фамилия")]          public string second_name { get; set; }
        [Display(Name = "Отчество")]                    public string middle_name { get; set; }
        [Phone] [Display(Name = "Номер телефона")]      public string phone_number { get; set; }
        [EmailAddress] [Display(Name = "Email")]        public string email { get; set; }
        [Display(Name = "Пол")]                         public string gender { get; set; }
        [Display(Name = "Возраст")]                     public Nullable<int> age { get; set; }
        [Display(Name = "Примечание")]                  public string note { get; set; }
    }
}
