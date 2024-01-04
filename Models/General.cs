using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPro.Models
{
    public class General
    {
        public static bool CheckMobileValidation(string MobileNumber)
        {

            if (MobileNumber == null) { return false; }
            if (MobileNumber.Length == 0) { return false; }
            if (!string.IsNullOrEmpty(MobileNumber)) { return false; }
            if ((MobileNumber.Length < 11) || (MobileNumber.Length > 20)) { return false; }
            else { return true; }

        }

        public static bool CheckEmailValidation(string Email)
        {
            return true;
        }
        public static bool CheckValidPhone(string Phone)
        {
            return true;
        }
    }
}
