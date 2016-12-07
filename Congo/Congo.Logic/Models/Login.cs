using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic.Models
{
    public class Login
    {
        public bool success { get; set; }
        public string message { get; set; }
        public AccountDAO account { get; set; }
    }
}
