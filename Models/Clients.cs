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
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string middle_name { get; set; }
        [Phone] public string phone_number { get; set; }
        [EmailAddress] public string email { get; set; }
        public string gender { get; set; }
        public Nullable<int> age { get; set; }
        public string note { get; set; }
    }
}
