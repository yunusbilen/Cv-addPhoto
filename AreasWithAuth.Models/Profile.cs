using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasWithAuth.Models
{
    [Table("Profiles")]
    public class Profile:ModelBase
    {
        public string Name { get; set; }
        public string AboutMe { get; set; }
        public string ProfilePicture { get; set; }
        public string ProfileCoverPicture { get; set; }
        public string Nationality { get; set; }
        public string Marital { get; set; }
        public int YearOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }


    }
}
