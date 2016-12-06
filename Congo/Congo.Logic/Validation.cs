using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congo.Logic
{
    public static class Validation
    {
        public static bool ConfirmUserName(AccountDAO account)
        {
            if(account.UserName != null)
            {
                return true;
            }
            return false;
        }
    }
}
