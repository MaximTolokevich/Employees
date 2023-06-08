using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Validators
{
    public static class NameValidator
    {
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name)) {return false;}
            foreach (var item in name)
            {
                if (!char.IsLetter(item))
                {
                    return false;
                }             
            }
            return true;
        }
    }
}
