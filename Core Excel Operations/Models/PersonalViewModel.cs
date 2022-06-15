using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Excel_Operations.Models
{
    public class PersonalViewModel
    {
        [Key]
        public int PersonalID { get; set; }
        public string PersonalName { get; set; }
        public string PersonalSurName { get; set; }
        public string PersonalMail { get; set; }
    }
}
