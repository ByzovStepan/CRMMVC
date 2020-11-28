using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CRMMVC.Models
{
    public class Users : IdentityUser
    {
        override public string Id { get; set; }

        [Required] [Display(Name = "Имя")] 
        public string first_name { get; set; }
        [Required] [Display(Name = "Фамилия")] 
        public string second_name { get; set; }
        [Display(Name = "Отчество")] 
        public string middle_name { get; set; }
        [Required] [Phone] [Display(Name = "Номер телефона")] 
        public string phone_number { get; set; }
        [Required] [EmailAddress] [Display(Name = "Email")] 
        public string email { get; set; }
        

        [Display(Name = "Должность")] public Posts post { get; set; }
        [Display(Name = "Подразделение")] public Departments department { get; set; }

        [Display(Name = "Пол")] 
        public string gender { get; set; }

        [Display(Name = "Возраст")] 
        public Nullable<int> age { get; set; }

    }
}
