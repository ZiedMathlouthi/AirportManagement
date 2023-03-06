using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //[Owned]
    public class FullName
    {
     //   [MinLength(3 , ErrorMessage ="doit etre > 3") ,MaxLength(25 , ErrorMessage = "doit etre < 25 ")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
