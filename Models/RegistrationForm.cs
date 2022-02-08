using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registration.Models
{
    public class RegistrationForm
    {
        [Key]
        public int RegistrationID { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public String  Country { get; set; }

        public DateTime  RegistrationDate { get; set; }

    }
}
