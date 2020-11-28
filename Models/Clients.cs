using System;
using System.ComponentModel.DataAnnotations;

namespace CRMMVC.Models
{
    public class Clients
    {
        public int Id { get; set; }

        [Required] [Display(Name = "Имя")] public string first_name { get; set; }
        [Required] [Display(Name = "Фамилия")] public string second_name { get; set; }
        [Display(Name = "Отчество")] public string middle_name { get; set; }
        [Required] [Phone] [Display(Name = "Номер телефона")] public string phone_number { get; set; }
        [Required] [EmailAddress] [Display(Name = "Email")] public string email { get; set; }
        [MaxLength(7)] [Display(Name = "Пол")] public string gender { get; set; }
        [Display(Name = "Возраст")] public Nullable<int> age { get; set; }
        [Display(Name = "Примечание")] public string note { get; set; }


    }
}
