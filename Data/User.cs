using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Mail adresi zorunludur.")]
        [StringLength(50, ErrorMessage ="Mail adresi 50 karakterden uzun olamaz")]
        [EmailAddress(ErrorMessage ="Geçerli bir mail adresi girmelisiniz!")]
        public string Mail { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string FullName { get { return Name + " " + SurName; }}

        public string Password { get; set; }


    }
}
